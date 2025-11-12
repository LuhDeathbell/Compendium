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

namespace Compendium
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFeiticos_Click(object sender, EventArgs e)
        {

            catalogofeiticos catalogofeiticos = new catalogofeiticos();
            catalogofeiticos.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMonstros_Click(object sender, EventArgs e)
        {
            catalogomonstros catalogomonstros = new catalogomonstros();
            catalogomonstros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catalogopersonagens catalogopersonagens = new catalogopersonagens();
            catalogopersonagens.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            blocodenotas blocodenotas = new blocodenotas();
            blocodenotas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            catalogomusicas catalogomusicas = new catalogomusicas();
            catalogomusicas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dados dados = new dados();
            dados.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Essa função pode causar lentidão e ocasionalmente crashes, você deseja prosseguir?","Compendium",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    leitordepdf leitordepdf = new leitordepdf(filePath);

                    leitordepdf.Show();
                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timeline timeline = new timeline();
            timeline.Show();
        }
    }
}
