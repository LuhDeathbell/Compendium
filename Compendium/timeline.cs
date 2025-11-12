using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Compendium
{
    public partial class timeline : Form
    {
        public timeline()
        {
            InitializeComponent();
        }

        List<evento> catalogoTimeline;
        string nomePerfil;
        string path = string.Empty;
        string archive = string.Empty;
        string imagens = string.Empty;
        string json;
        string jsonAtualizado;

        private void timeline_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(timeline_Paint);

            nomePerfil = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            nomePerfil = new DirectoryInfo(nomePerfil).Name;

            if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documentos")) { path = @"C:\Users\" + nomePerfil + @"\Documentos\Compendium"; }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documents")) { path = @"C:\Users\" + nomePerfil + @"\Documents\Compendium"; }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documentos")) { path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documentos\Compendium"; }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documents")) { path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documents\Compendium"; }
            else
            {
                MessageBox.Show("Não foi possível encontrar a pasta Documentos", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            archive = path;
            imagens = path;
            archive += @"\timeline.json";
            imagens += @"\imagens";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(archive))
            {
                File.Create(archive).Dispose();
            }
            if (!Directory.Exists(imagens))
            {
                Directory.CreateDirectory(imagens);
            }

            atualizar();

            lbl_evento1.Location = new Point(80 - (lbl_evento1.Width / 2), this.Height - 80);
            lbl_evento2.Location = new Point(160 - (lbl_evento1.Width / 2), this.Height - 105);
            lbl_evento3.Location = new Point(240 - (lbl_evento1.Width / 2), this.Height - 80);
            lbl_evento4.Location = new Point(320 - (lbl_evento1.Width / 2), this.Height - 105);
            lbl_evento5.Location = new Point(400 - (lbl_evento1.Width / 2), this.Height - 80);
            lbl_evento6.Location = new Point(480 - (lbl_evento1.Width / 2), this.Height - 105);
            lbl_evento7.Location = new Point(560 - (lbl_evento1.Width / 2), this.Height - 80);
            lbl_evento8.Location = new Point(640 - (lbl_evento1.Width / 2), this.Height - 105);
            lbl_evento9.Location = new Point(720 - (lbl_evento1.Width / 2), this.Height - 80);
        }

        private void timeline_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                e.Graphics.DrawLine(pen, 80, this.Height-150, 720, this.Height-150);

                e.Graphics.DrawLine(pen, 80, this.Height - 150, 80, this.Height - 100);
                e.Graphics.DrawLine(pen, 160, this.Height - 150, 160, this.Height - 125);

                e.Graphics.DrawLine(pen, 240, this.Height - 150, 240, this.Height - 100);
                e.Graphics.DrawLine(pen, 320, this.Height - 150, 320, this.Height - 125);

                e.Graphics.DrawLine(pen, 400, this.Height - 150, 400, this.Height - 90);
                e.Graphics.DrawLine(pen, 480, this.Height - 150, 480, this.Height - 125);

                e.Graphics.DrawLine(pen, 560, this.Height - 150, 560, this.Height - 100);
                e.Graphics.DrawLine(pen, 640, this.Height - 150, 640, this.Height - 125);

                e.Graphics.DrawLine(pen, 720, this.Height - 150, 720, this.Height - 100);

                e.Graphics.DrawLine(pen, 380, this.Height - 110, 400, this.Height - 90);
                e.Graphics.DrawLine(pen, 420, this.Height - 110, 400, this.Height - 90);

            }
        }

        

        public void atualizar()
        {
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                catalogoTimeline = JsonConvert.DeserializeObject<List<evento>>(json) ?? new List<evento>();
            }
            else
            {
                MessageBox.Show("Não existem eventos catalogados", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.Rows.Clear();

            var eventosFiltrados = catalogoTimeline.AsEnumerable();

            eventosFiltrados = eventosFiltrados.OrderBy(f => f.Data);

            foreach (var evento in eventosFiltrados)
            {
                dataGridView1.Rows.Add(evento.Nome);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            json = File.ReadAllText(archive);
            catalogoTimeline = JsonConvert.DeserializeObject<List<evento>>(json) ?? new List<evento>();

            if (pictureBox.Image != null)
            {
                using (System.Drawing.Image img = (System.Drawing.Image)pictureBox.Image.Clone())
                {
                    if (File.Exists(imagens + "\\" + txt_nome.Text.Replace(" ", String.Empty) + ".png"))
                    {
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null;
                        File.Delete(imagens + "\\" + txt_nome.Text.Replace(" ", String.Empty) + ".png");
                    }
                    img.Save(imagens + "\\" + txt_nome.Text.Replace(" ", String.Empty) + ".png");
                }
            }

            evento Evento = new evento
            {
                Nome = txt_nome.Text,
                Data = txt_data.Text,
                Descricao = txt_descricao.Text,
                Imagem = imagens + "\\" + txt_nome.Text.Replace(" ", String.Empty) + ".png"
            };

            evento eventoExiste = catalogoTimeline.FirstOrDefault(f => f.Nome == Evento.Nome);

            if (eventoExiste != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja salvar as alterações feitas?","Compendium", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    catalogoTimeline.Remove(eventoExiste);
                    catalogoTimeline.Add(Evento);
                    jsonAtualizado = JsonConvert.SerializeObject(catalogoTimeline, Formatting.Indented);
                    File.WriteAllText(archive, jsonAtualizado);
                    atualizar();
                    limpar();
                    MessageBox.Show("Alterações salvas com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                catalogoTimeline.Add(Evento);
                jsonAtualizado = JsonConvert.SerializeObject(catalogoTimeline, Formatting.Indented);
                File.WriteAllText (archive, jsonAtualizado);
                atualizar();
                limpar();
                MessageBox.Show("Evento salvo com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void limpar()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            txt_filtro.Clear();
            txt_data.Clear();
            txt_descricao.Clear();
            txt_nome.Clear();
            lbl_evento1.Text = "-";
            lbl_evento2.Text = "-";
            lbl_evento3.Text = "-";
            lbl_evento4.Text = "-";
            lbl_evento5.Text = "-";
            lbl_evento6.Text = "-";
            lbl_evento7.Text = "-";
            lbl_evento8.Text = "-";
            lbl_evento9.Text = "-";
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar este evento?", "Compedium", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (File.Exists(archive))
                {
                    json = File.ReadAllText(archive);
                    List<evento> catalogoTimeline = JsonConvert.DeserializeObject<List<evento>>(json);

                    evento eventoExiste = catalogoTimeline.FirstOrDefault(f => f.Nome == txt_nome.Text);
                    if (eventoExiste != null)
                    {
                        catalogoTimeline.Remove(eventoExiste);
                        json = JsonConvert.SerializeObject(catalogoTimeline, Formatting.Indented);
                        File.WriteAllText(archive, json);

                        pictureBox.Image = null;
                        File.Delete(imagens + "\\" + txt_nome.Text.Replace(" ", String.Empty) + ".png");

                        MessageBox.Show("Evento excluído com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizar();
                        limpar();
                        
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Selected = true;
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<evento> catalogoTimeline = JsonConvert.DeserializeObject<List<evento>>(json);

                evento eventoExiste = catalogoTimeline.FirstOrDefault(f => f.Nome == dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (eventoExiste != null)
                {
                    txt_nome.Text = eventoExiste.Nome;
                    txt_descricao.Text = eventoExiste.Descricao;
                    txt_data.Text = eventoExiste.Data;
                    if (pictureBox.Image != null)
                        pictureBox.Image.Dispose();
                    if (File.Exists(eventoExiste.Imagem))
                        using (var stream = new MemoryStream(File.ReadAllBytes(eventoExiste.Imagem)))
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }
                    
                    else
                        pictureBox.Image = null;
                    reorganizar();
                }
            }
            

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = new MemoryStream(File.ReadAllBytes(openFileDialog1.FileName)))
                    {
                        pictureBox.Image = Image.FromStream(stream);
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        public void reorganizar()
        {
            lbl_evento5.Text = txt_nome.Text;
            if (dataGridView1.SelectedCells[0].RowIndex > 0)
                lbl_evento4.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 1].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex > 1)
                lbl_evento3.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 2].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex > 2)
                lbl_evento2.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 3].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex > 3)
                lbl_evento1.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex - 4].Cells[0].Value.ToString();

            if (dataGridView1.SelectedCells[0].RowIndex < dataGridView1.Rows.Count - 1)
                lbl_evento6.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex + 1].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex < dataGridView1.Rows.Count - 2 && !(dataGridView1.SelectedCells[0].RowIndex + 2 > dataGridView1.Rows.Count - 1))
                lbl_evento7.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex + 2].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex < dataGridView1.Rows.Count - 3 && !(dataGridView1.SelectedCells[0].RowIndex + 3 > dataGridView1.Rows.Count - 1))
                lbl_evento8.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex + 3].Cells[0].Value.ToString();
            if (dataGridView1.SelectedCells[0].RowIndex < dataGridView1.Rows.Count - 4 && !(dataGridView1.SelectedCells[0].RowIndex + 4 > dataGridView1.Rows.Count - 1))
                lbl_evento9.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex + 4].Cells[0].Value.ToString();

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int rowsCount = dataGridView1.Rows.Count;

            if (rowIndex == 0)
            {
                lbl_evento1.Text = "-";
                lbl_evento2.Text = "-";
                lbl_evento3.Text = "-";
                lbl_evento4.Text = "-";
            }
            else if (rowIndex == 1)
            {
                lbl_evento1.Text = "-";
                lbl_evento2.Text = "-";
                lbl_evento3.Text = "-";
            }
            else if (rowIndex == 2)
            {
                lbl_evento1.Text = "-";
                lbl_evento2.Text = "-";
            }
            else if (rowIndex == 3)
            {
                lbl_evento1.Text = "-";
            }
            if (rowIndex == rowsCount - 1)
            {
                lbl_evento9.Text = "-";
                lbl_evento8.Text = "-";
                lbl_evento7.Text = "-";
                lbl_evento6.Text = "-";
            }
            else if (rowIndex == rowsCount - 2)
            {
                lbl_evento9.Text = "-";
                lbl_evento8.Text = "-";
                lbl_evento7.Text = "-";
            }
            else if (rowIndex == rowsCount - 3)
            {
                lbl_evento9.Text = "-";
                lbl_evento8.Text = "-";
            }
            else if (rowIndex == rowsCount - 4)
            {
                lbl_evento9.Text = "-";
            }
            
        }

        public void recentralizar(Label lbl)
        {
            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF textSize = graphics.MeasureString(lbl.Text, lbl.Font);
                int pixelWidth = (int)textSize.Width;
                lbl.Width = pixelWidth;
                char lblnumberC = lbl.Name[lbl.Name.Length - 1];
                int lblnumber = lblnumberC - '0';
                if (lblnumber%2 != 0)
                    lbl.Location = new Point((80*lblnumber) - (lbl.Width / 2), this.Height - 80);
                else
                    lbl.Location = new Point((80 * lblnumber) - (lbl.Width / 2), this.Height - 105);
            }

        }

        private void lbl_evento5_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento5 as Label);
        }

        private void lbl_evento1_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento1 as Label);
        }

        private void lbl_evento2_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento2 as Label);
        }

        private void lbl_evento3_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento3 as Label);
        }

        private void lbl_evento4_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento4 as Label);
        }

        private void lbl_evento6_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento6 as Label);
        }

        private void lbl_evento7_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento7 as Label);
        }

        private void lbl_evento8_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento8 as Label);
        }

        private void lbl_evento9_TextChanged(object sender, EventArgs e)
        {
            recentralizar(lbl_evento9 as Label);
        }

        public void buscar(string filtro)
        {
            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell cell = row.Cells["columnEvento"];

                    if (cell.Value != null && cell.Value.ToString().StartsWith(filtro, StringComparison.OrdinalIgnoreCase))
                    {
                        cell.Selected = true;
                        dataGridView1.CurrentCell = cell;
                        break;
                    }
                }
            }
            dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Selected = true;
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<evento> catalogoTimeline = JsonConvert.DeserializeObject<List<evento>>(json);

                evento eventoExiste = catalogoTimeline.FirstOrDefault(f => f.Nome == dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (eventoExiste != null)
                {
                    txt_nome.Text = eventoExiste.Nome;
                    txt_descricao.Text = eventoExiste.Descricao;
                    txt_data.Text = eventoExiste.Data;
                    if (pictureBox.Image != null)
                        pictureBox.Image.Dispose();
                    if (File.Exists(eventoExiste.Imagem))
                        using (var stream = new MemoryStream(File.ReadAllBytes(eventoExiste.Imagem)))
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }

                    else
                        pictureBox.Image = null;
                    reorganizar();
                }
            }
        }

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            buscar(txt_filtro.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void txt_filtro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                buscar(txt_filtro.Text);
        }

        public void labelClick(Label lbl)
        {
            if (lbl.Text != "-")
            {
                buscar(lbl.Text);
            }
        }

        private void lbl_evento1_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento1 as Label);
        }

        private void lbl_evento2_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento2 as Label);
        }

        private void lbl_evento3_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento3 as Label);
        }

        private void lbl_evento4_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento4 as Label);
        }

        private void lbl_evento6_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento6 as Label);
        }

        private void lbl_evento7_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento7 as Label);
        }

        private void lbl_evento8_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento8 as Label);
        }

        private void lbl_evento9_Click(object sender, EventArgs e)
        {
            labelClick(lbl_evento9 as Label);
        }

        private void lbl_evento1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lbl_evento1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }

    public class evento
    {
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

    }
}
