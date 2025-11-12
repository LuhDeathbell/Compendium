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
    public partial class catalogopersonagens : Form
    {
        public catalogopersonagens()
        {
            InitializeComponent();
        }

        List<personagens> catalogoPersonagens;
        string nomePerfil;
        string path = string.Empty;
        string archive = string.Empty;
        string json;
        string jsonAtualizado;

        private void catalogopersonagens_Load(object sender, EventArgs e)
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
            archive += @"\personagens.json";

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
            catalogoPersonagens = JsonConvert.DeserializeObject<List<personagens>>(json) ?? new List<personagens>();

            personagens Personagens = new personagens
            {
                Nome = txt_nome.Text,
                Raca = txt_raca.Text,
                Classe = txt_classe.Text,
                Profissao = txt_profissao.Text,
                Localizacao = txt_localizacao.Text,
                Descricao = txt_descricao.Text,
                Conexoes = txt_conexoes.Text,
                Extras = txt_extras.Text
            };

            personagens personagemExiste = catalogoPersonagens.FirstOrDefault(f => f.Nome == Personagens.Nome);

            if (personagemExiste != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Esse personagem já foi catalogado, deseja sobrescrevê-lo?", "Compendium", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    catalogoPersonagens.Remove(personagemExiste);
                    catalogoPersonagens.Add(Personagens);
                    jsonAtualizado = JsonConvert.SerializeObject(catalogoPersonagens, Formatting.Indented);
                    File.WriteAllText(archive, jsonAtualizado);
                    atualizar();
                    limpar();
                    MessageBox.Show("Personagem sobrescrito com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Altere o nome para catalogar um novo personagem", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nome.Focus();
                    txt_nome.SelectAll();
                }
            }
            else
            {
                catalogoPersonagens.Add(Personagens);
                jsonAtualizado = JsonConvert.SerializeObject(catalogoPersonagens, Formatting.Indented);
                File.WriteAllText(archive, jsonAtualizado);
                atualizar();
                limpar();
                MessageBox.Show("Personagem catalogado com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void deletar()
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza de que deseja excluir esse personagem?", "Compendium", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (File.Exists(archive))
                {
                    json = File.ReadAllText(archive);
                    catalogoPersonagens = JsonConvert.DeserializeObject<List<personagens>>(json) ?? new List<personagens>();
                    personagens personagemExiste = catalogoPersonagens.FirstOrDefault(f => f.Nome == txt_nome.Text);

                    if (personagemExiste != null)
                    {
                        catalogoPersonagens.Remove(personagemExiste);
                        jsonAtualizado = JsonConvert.SerializeObject(catalogoPersonagens, Formatting.Indented);
                        File.WriteAllText(archive, jsonAtualizado);
                        atualizar();
                        limpar();
                        MessageBox.Show("Personagem deletado com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Esse personagem ainda não foi catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não há nenhum personagem catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                
            }
            
        }

        public void atualizar()
        {
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                catalogoPersonagens = JsonConvert.DeserializeObject<List<personagens>>(json) ?? new List<personagens>();

            }
            else
            {
                MessageBox.Show("Não existem personagens catalogados", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridView.Rows.Clear();

            var personagensFiltrados = catalogoPersonagens.AsEnumerable();

            if (!string.IsNullOrEmpty(txt_filtro.Text))
            {
                personagensFiltrados = personagensFiltrados.Where(f => f.Nome == txt_filtro.Text);
            }

            foreach (var personagem in personagensFiltrados)
            {
                dataGridView.Rows.Add(personagem.Nome);
            }
        }

        public void limpar()
        {
            txt_nome.Clear();
            txt_raca.Clear();
            txt_classe.Clear();
            txt_profissao.Clear();
            txt_localizacao.Clear();
            txt_descricao.Clear();
            txt_conexoes.Clear();
            txt_extras.Clear();
            txt_filtro.Clear();
            atualizar();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text == String.Empty)
            {
                MessageBox.Show("É obrigatório completar o campo 'nome'", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txt_raca.Text == String.Empty || txt_classe.Text == String.Empty || txt_profissao.Text == String.Empty || txt_localizacao.Text == String.Empty 
                    || txt_descricao.Text == String.Empty || txt_conexoes.Text == String.Empty || txt_extras.Text == String.Empty)
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

        private void bttn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void txt_filtro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                atualizar();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Selected = true;
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<personagens> catalogoPersonagens = JsonConvert.DeserializeObject<List<personagens>>(json);

                personagens personagemFound = catalogoPersonagens.FirstOrDefault(f => f.Nome == dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                if (personagemFound != null)
                {
                    txt_nome.Text = personagemFound.Nome;
                    txt_raca.Text = personagemFound.Raca;
                    txt_classe.Text = personagemFound.Classe;
                    txt_profissao.Text = personagemFound.Profissao;
                    txt_localizacao.Text = personagemFound.Localizacao;
                    txt_descricao.Text = personagemFound.Descricao;
                    txt_conexoes.Text = personagemFound.Conexoes;
                    txt_extras.Text = personagemFound.Extras;
                }
            }
        }
    }

    public class personagens
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public string Profissao { get; set; }
        public string Localizacao { get; set; }
        public string Descricao { get; set; }
        public string Conexoes { get; set; }
        public string Extras { get; set; }
    }
}
