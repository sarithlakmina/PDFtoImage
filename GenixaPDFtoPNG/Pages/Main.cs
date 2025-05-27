using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenixaPDFtoPNG.Pages
{
    public partial class Main : Form
    {
        private string pdfFilePath;
        private string outputFolder;
        private const int DefaultDpi = 150;  // fixed DPI
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                progressBar1.Value = 0;
                lblProgress.Text = "";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pdfFilePath = ofd.FileName;
                    txtPdfPath.Text = pdfFilePath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pdfFilePath) || !File.Exists(pdfFilePath))
            {
                MessageBox.Show("Please select a valid PDF file first.");
                return;
            }

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = fbd.SelectedPath;
                    progressBar1.Value = 0;    // Reset progress bar
                    lblProgress.Text = "0%";   // Reset progress label

                    ConvertPdfToPng(pdfFilePath, outputFolder);

                    // Update label after full conversion
                    lblProgress.Text = "100%";

                    // Show message box only after progress shows 100%
                    MessageBox.Show("Conversion completed!");
                }
            }
        }


        private void ConvertPdfToPng(string pdfPath, string outputDir)
        {
            using (var document = PdfDocument.Load(pdfPath))
            {
                int pageCount = document.PageCount;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = pageCount;
                progressBar1.Step = 1;

                for (int i = 0; i < pageCount; i++)
                {
                    using (var image = document.Render(i, DefaultDpi, DefaultDpi, PdfRenderFlags.Annotations))
                    {
                        string outputPath = Path.Combine(outputDir, $"page_{i + 1}.png");
                        image.Save(outputPath, ImageFormat.Png);
                    }

                    progressBar1.PerformStep();
                    int percent = (int)(((i + 1) / (float)pageCount) * 100);
                    lblProgress.Text = percent + "%";
                    lblProgress.Refresh(); // Update label immediately
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
