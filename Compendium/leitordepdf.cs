using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace Compendium
{
    public partial class leitordepdf : Form
    {
        private PdfViewer pdfViewer;
        private PdfDocument pdfDocument;
        public leitordepdf(string pdfPath)
        {
            InitializeComponent();

            if (File.Exists(pdfPath))
            {
                pdfDocument = PdfDocument.Load(pdfPath);

                pdfViewer = new PdfViewer();
                pdfViewer.Dock = DockStyle.Fill;
                pdfViewer.Document = pdfDocument;

                this.Controls.Add(pdfViewer);

                this.FormClosed += leitordepdf_FormClosed;
            }
            else
            {
                MessageBox.Show("Arquivo PDF não encontrado.","Compendium",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void leitordepdf_Load(object sender, EventArgs e)
        {
            
        }

        private void leitordepdf_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void leitordepdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pdfViewer != null)
            {
                pdfViewer.Dispose();
                pdfViewer = null;
            }

            if (pdfDocument != null)
            {
                pdfDocument.Dispose();
                pdfDocument = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
