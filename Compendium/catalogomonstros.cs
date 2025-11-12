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
using Newtonsoft.Json;

namespace Compendium
{
    public partial class catalogomonstros : Form
    {
        public catalogomonstros()
        {
            InitializeComponent();
        }

        List<monstros> catalogoMonstros;
        string nomePerfil;
        string path = string.Empty;
        string archive = string.Empty;
        string json;
        string jsonAtualizado;

        private void catalogomonstros_Load(object sender, EventArgs e)
        {
            nomePerfil = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            nomePerfil = new DirectoryInfo(nomePerfil).Name;

            if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documentos")){path = @"C:\Users\" + nomePerfil + @"\Documentos\Compendium";}
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documents")){path = @"C:\Users\" + nomePerfil + @"\Documents\Compendium";}
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documentos")){path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documentos\Compendium";}
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documents")){path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documents\Compendium";}
            else
            {
                MessageBox.Show("Não foi possível encontrar a pasta Documentos", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            archive = path;
            archive += @"\monstros.json";

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
            catalogoMonstros = JsonConvert.DeserializeObject<List<monstros>>(json) ?? new List<monstros>();

            monstros Monstros = new monstros
            {
                Nome = txt_nome.Text,
                Ataques = txt_ataques.Text,
                Deslocamento = txt_deslocamento.Text,
                Imunidades = txt_imunidades.Text,
                Fraquezas = txt_fraquezas.Text,
                Defesa = txt_defesa.Text,
                Esquiva = txt_esquiva.Text,
                Descricao = txt_descricao.Text,
                Habitat = txt_habitat.Text,
                Forca = txt_forca.Text,
                Destreza = txt_destreza.Text,
                Constituicao = txt_constituicao.Text,
                Magia = txt_magia.Text,
                Ciencia = txt_ciencia.Text,
                Sabedoria = txt_sabedoria.Text,
                Carisma = txt_carisma.Text,
                Saude = txt_saude.Text,
                Sanidade = txt_sanidade.Text,
                Mana = txt_mana.Text,
                Fadiga = txt_fadiga.Text
            };

            monstros monstroExiste = catalogoMonstros.FirstOrDefault(f => f.Nome == Monstros.Nome);

            if(monstroExiste != null)
            {
                if(DialogResult.Yes == MessageBox.Show("Esse monstro já foi catalogado, deseja sobrescrevê-lo?","Compendium",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    catalogoMonstros.Remove(monstroExiste);
                    catalogoMonstros.Add(Monstros);
                    jsonAtualizado = JsonConvert.SerializeObject(catalogoMonstros, Formatting.Indented);
                    File.WriteAllText(archive, jsonAtualizado);
                    atualizar();
                    limpar();
                    MessageBox.Show("Monstro sobrescrito com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Altere o nome para catalogar um novo monstro", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nome.Focus();
                    txt_nome.SelectAll();
                }
            }
            else
            {
                catalogoMonstros.Add(Monstros);
                jsonAtualizado = JsonConvert.SerializeObject(catalogoMonstros, Formatting.Indented);
                File.WriteAllText(archive, jsonAtualizado);
                atualizar();
                limpar();
                MessageBox.Show("Monstro catalogado com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void atualizar()
        {
            if(File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                catalogoMonstros = JsonConvert.DeserializeObject<List<monstros>>(json) ?? new List<monstros>();

            }
            else
            {
                MessageBox.Show("Não existem monstros catalogados", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dataGridView.Rows.Clear();

            var monstrosFiltrados = catalogoMonstros.AsEnumerable();

            if (!string.IsNullOrEmpty(txt_filtro.Text))
            {
                monstrosFiltrados = monstrosFiltrados.Where(f => f.Nome == txt_filtro.Text);
            }

            monstrosFiltrados = monstrosFiltrados.OrderBy(f => f.Nome);

            foreach (var monstro in monstrosFiltrados)
            {
                dataGridView.Rows.Add(monstro.Nome);
            }
        }

        public void limpar()
        {
            txt_nome.Clear();
            txt_ataques.Clear();
            txt_deslocamento.Clear();
            txt_imunidades.Clear();
            txt_fraquezas.Clear();
            txt_defesa.Clear();
            txt_esquiva.Clear();
            txt_descricao.Clear();
            txt_habitat.Clear();
            txt_forca.Clear();
            txt_destreza.Clear();
            txt_constituicao.Clear();
            txt_magia.Clear();
            txt_ciencia.Clear();
            txt_sabedoria.Clear();
            txt_carisma.Clear();
            txt_saude.Clear();
            txt_sanidade.Clear();
            txt_mana.Clear();
            txt_fadiga.Clear();
            txt_filtro.Clear();
            atualizar();
        }

        public void deletar()
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza de que deseja excluir esse monstro?","Compendium",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                if (File.Exists(archive))
                {
                    json = File.ReadAllText(archive);
                    List<monstros> catalogoMonstros = JsonConvert.DeserializeObject<List<monstros>>(json);

                    monstros monstroExiste = catalogoMonstros.FirstOrDefault(f => f.Nome == txt_nome.Text);
                    if (monstroExiste != null)
                    {
                        catalogoMonstros.Remove(monstroExiste);
                        json = JsonConvert.SerializeObject(catalogoMonstros, Formatting.Indented);
                        File.WriteAllText(archive, json);

                        MessageBox.Show("Monstro excluído com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_filtro.Clear();
                        atualizar();
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Esse monstro ainda não foi catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Não há nenhum monstro catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Selected = true;
            if(File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<monstros> catalogoMonstros = JsonConvert.DeserializeObject<List<monstros>>(json);

                monstros monstroFound = catalogoMonstros.FirstOrDefault(f => f.Nome == dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                if(monstroFound != null)
                {
                    txt_nome.Text = monstroFound.Nome;
                    txt_ataques.Text = monstroFound.Ataques;
                    txt_deslocamento.Text = monstroFound.Deslocamento;
                    txt_imunidades.Text = monstroFound.Imunidades;
                    txt_fraquezas.Text = monstroFound.Fraquezas;
                    txt_defesa.Text = monstroFound.Defesa;
                    txt_esquiva.Text = monstroFound.Esquiva;
                    txt_descricao.Text = monstroFound.Descricao;
                    txt_habitat.Text = monstroFound.Habitat;
                    txt_forca.Text = monstroFound.Forca;
                    txt_destreza.Text = monstroFound.Destreza;
                    txt_constituicao.Text = monstroFound.Constituicao;
                    txt_magia.Text = monstroFound.Magia;
                    txt_ciencia.Text = monstroFound.Ciencia;
                    txt_sabedoria.Text = monstroFound.Sabedoria;
                    txt_carisma.Text = monstroFound.Carisma;
                    txt_saude.Text = monstroFound.Saude;
                    txt_sanidade.Text = monstroFound.Sanidade;
                    txt_mana.Text = monstroFound.Mana;
                    txt_fadiga.Text = monstroFound.Fadiga;
                }
            }
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty)
            {
                MessageBox.Show("É obrigatório completar o campo 'nome'", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_ataques.Text == String.Empty || txt_deslocamento.Text == String.Empty || txt_imunidades.Text == String.Empty || txt_fraquezas.Text == String.Empty
                    || txt_defesa.Text == String.Empty || txt_esquiva.Text == String.Empty || txt_descricao.Text == String.Empty || txt_habitat.Text == String.Empty
                    || txt_forca.Text == String.Empty || txt_destreza.Text == String.Empty || txt_constituicao.Text == String.Empty || txt_magia.Text == String.Empty
                    || txt_ciencia.Text == String.Empty || txt_sabedoria.Text == String.Empty || txt_carisma.Text == String.Empty || txt_saude.Text == String.Empty
                    || txt_sanidade.Text == String.Empty || txt_mana.Text == String.Empty || txt_fadiga.Text == String.Empty)
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

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bttn_refresh_Click(object sender, EventArgs e)
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
    }
    public class monstros
    {
        public string Nome { get; set; }
        public string Ataques { get; set; }
        public string Deslocamento { get; set; }
        public string Imunidades { get; set; }
        public string Fraquezas { get; set; }
        public string Defesa { get; set; }
        public string Esquiva { get; set; }
        public string Descricao { get; set; }
        public string Habitat {  get; set; }
        public string Forca {  get; set; }
        public string Destreza { get; set; }
        public string Constituicao { get; set; }
        public string Magia { get; set; }
        public string Ciencia { get; set; }
        public string Sabedoria { get; set; }
        public string Carisma { get; set; }
        public string Saude { get; set;}
        public string Sanidade { get; set; }
        public string Mana {  get; set; }
        public string Fadiga { get; set; }


    }
}
