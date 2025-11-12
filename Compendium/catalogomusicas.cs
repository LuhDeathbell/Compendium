using Newtonsoft.Json;
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
    public partial class catalogomusicas : Form
    {
        public catalogomusicas()
        {
            InitializeComponent();
        }

        List<musicas> catalogoMusicas;
        string nomePerfil;
        string path = string.Empty;
        string archive = string.Empty;
        string json;
        string jsonAtualizado;

        private void catalogomusicas_Load(object sender, EventArgs e)
        {
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
            archive += @"\musicas.json";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(archive))
            {
                File.Create(archive).Dispose();
            }

            atualizar();
        }

        public void salvar()
        {
            json = File.ReadAllText(archive);
            catalogoMusicas = JsonConvert.DeserializeObject<List<musicas>>(json) ?? new List<musicas>();

            musicas Musicas = new musicas
            {
                Nome = txt_nome.Text,
                Descricao = txt_descricao.Text,
                Link = txt_link.Text,
                Origem = txt_origem.Text
            };

            musicas musicaExiste = catalogoMusicas.FirstOrDefault(f => f.Nome == Musicas.Nome);

            if(musicaExiste != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Essa música já foi catalogada, deseja sobrescrevê-la?","Compendium",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
                {
                    catalogoMusicas.Remove(musicaExiste);
                    catalogoMusicas.Add(Musicas);
                    jsonAtualizado = JsonConvert.SerializeObject(catalogoMusicas, Formatting.Indented);
                    File.WriteAllText(archive,jsonAtualizado);
                    atualizar();
                    limpar();
                    MessageBox.Show("Música sobrescrita com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Altere o nome para catalogar uma nova música", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nome.Focus();
                    txt_nome.SelectAll();
                }
            }
            else
            {
                catalogoMusicas.Add(Musicas);
                jsonAtualizado = JsonConvert.SerializeObject(catalogoMusicas, Formatting.Indented);
                File.WriteAllText (archive,jsonAtualizado);
                atualizar();
                limpar();
                MessageBox.Show("Música catalogada com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void atualizar()
        {
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                catalogoMusicas = JsonConvert.DeserializeObject<List<musicas>>(json) ?? new List<musicas>();

            }
            else
            {
                MessageBox.Show("Não existem músicas catalogados", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridView.Rows.Clear();

            var musicasFiltrados = catalogoMusicas.AsEnumerable();

            if (!string.IsNullOrEmpty(txt_filtro.Text))
            {
                musicasFiltrados = musicasFiltrados.Where(f => f.Nome == txt_filtro.Text);
            }

            musicasFiltrados = musicasFiltrados.OrderBy(f => f.Nome);

            foreach (var musica in musicasFiltrados)
            {
                dataGridView.Rows.Add(musica.Nome);
            }
        }

        public void limpar()
        {
            txt_descricao.Clear();
            txt_nome.Clear();
            txt_filtro.Clear();
            txt_link.Clear();
            txt_origem.Clear();
        }

        public void deletar()
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza de que deseja excluir essa música?", "Compendium", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (File.Exists(archive))
                {
                    json = File.ReadAllText(archive);
                    List<musicas> catalogoMusicas = JsonConvert.DeserializeObject<List<musicas>>(json);

                    musicas musicaExiste = catalogoMusicas.FirstOrDefault(f => f.Nome == txt_nome.Text);
                    if (musicaExiste != null)
                    {
                        catalogoMusicas.Remove(musicaExiste);
                        json = JsonConvert.SerializeObject(catalogoMusicas, Formatting.Indented);
                        File.WriteAllText(archive, json);

                        MessageBox.Show("Música excluída com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_filtro.Clear();
                        atualizar();
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Esse música ainda não foi catalogada", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Não há nenhuma música catalogada", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_filtro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                atualizar();
            }
        }

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bttn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty)
            {
                MessageBox.Show("É obrigatório completar o campo 'nome'", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_link.Text == String.Empty || txt_origem.Text == String.Empty || txt_descricao.Text == String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Existem campos em branco, deseja salvar mesmo assim?", "Compendium", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        salvar();
                    }
                }
                else
                {
                    salvar();
                }
            }
        }

        private void bttn_del_Click(object sender, EventArgs e)
        {
            deletar();
        }

        private void bttn_copylink_Click(object sender, EventArgs e)
        {
            txt_link.SelectAll();
            txt_link.Copy();
        }

        private void dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Selected = true;
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<musicas> catalogoMusicas = JsonConvert.DeserializeObject<List<musicas>>(json);

                musicas musicaFound = catalogoMusicas.FirstOrDefault(f => f.Nome == dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                if (musicaFound != null)
                {
                    txt_nome.Text = musicaFound.Nome;
                    txt_descricao.Text = musicaFound.Descricao;
                    txt_origem.Text = musicaFound.Origem;
                    txt_link.Text = musicaFound.Link;
                }
            }
        }
    }

    public class musicas
    {
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Link { get; set; }
        public string Descricao { get; set; }
    }
}
