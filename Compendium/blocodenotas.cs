using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compendium
{
    public partial class blocodenotas : Form
    {
        public blocodenotas()
        {
            InitializeComponent();
        }

        public void novo()
        {
            if(DialogResult.Yes == MessageBox.Show("Compendium","Deseja salvar primeiro?",MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                salvar();
            }
            richTextBox.Text = string.Empty;
        }

        public void salvar()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo RTF (*.rtf)|*.rtf|Texto Simples (*.txt)|*.txt";
            saveFileDialog1.Title = "Salvar documento";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = saveFileDialog1.FileName;

                if (Path.GetExtension(caminho).ToLower() == ".rtf")
                {
                    richTextBox.SaveFile(caminho, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.SaveFile(caminho, RichTextBoxStreamType.PlainText);
                }

                MessageBox.Show("Compendium", "Arquivo salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void abrir()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivo RTF (*.rtf)|*.rtf|Texto Simples (*.txt)|*.txt";
            openFileDialog1.Title = "Abrir documento";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFileDialog1.FileName;

                // Decide se carrega como RTF ou texto simples baseado na extensão
                if (Path.GetExtension(caminho).ToLower() == ".rtf")
                {
                    richTextBox.LoadFile(caminho, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.LoadFile(caminho, RichTextBoxStreamType.PlainText);
                }
            }

        }

        public void copiar()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }

        public void recortar()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();
            }
        }

        public void colar()
        {
            richTextBox.Paste();
        }

        public void negrito()
        {
            string nomeFonte = richTextBox.SelectionFont.Name;
            float tamanhoFonte = richTextBox.SelectionFont.Size;
            bool resp;
            resp = richTextBox.SelectionFont.Bold;
            if (resp == false)
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Bold);
            }
            else
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        public void italico()
        {
            string nomeFonte = richTextBox.SelectionFont.Name;
            float tamanhoFonte = richTextBox.SelectionFont.Size;
            bool resp;
            resp = richTextBox.SelectionFont.Bold;
            if (resp == false)
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Italic);
            }
            else
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        public void sublinhado()
        {
            string nomeFonte = richTextBox.SelectionFont.Name;
            float tamanhoFonte = richTextBox.SelectionFont.Size;
            bool resp;
            resp = richTextBox.SelectionFont.Bold;
            if (resp == false)
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Underline);
            }
            else
            {
                richTextBox.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        public void fontes()
        {
            FontDialog fonte = new FontDialog();
            if (fonte.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fonte.Font;
            }
        }

        public void esquerda()
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        public void centro()
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void direita()
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void toolStripCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void toolStripColar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recortar();
        }

        private void toolStripRecortar_Click(object sender, EventArgs e)
        {
            recortar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void toolStripFontes_Click(object sender, EventArgs e)
        {
            fontes();
        }

        private void opçõesDeFontesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontes();
        }

        private void toolStripEsquerda_Click(object sender, EventArgs e)
        {
            esquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esquerda();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            centro();
        }

        private void toolStripCentro_Click(object sender, EventArgs e)
        {
            centro();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direita();
        }

        private void toolStripDireita_Click(object sender, EventArgs e)
        {
            direita();
        }
    }
}
