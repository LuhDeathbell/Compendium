using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Compendium
{
    
    public partial class catalogofeiticos : Form
    {
        public catalogofeiticos()
        {
            InitializeComponent();
        }

        List<feitico> catalogoFeiticos;
        List<string> export;
        string nomePerfil;
        string path = string.Empty;
        string archive = string.Empty;
        string json;
        string jsonAtualizado;

        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void salvar()
        {
            json = File.ReadAllText(archive);
            catalogoFeiticos = JsonConvert.DeserializeObject<List<feitico>>(json) ?? new List<feitico>();

            feitico feiticos = new feitico
            {
                Nome = txt_name.Text,
                Categoria = box_category.Text,
                Dano = txt_damage.Text,
                Alcance = txt_range.Text,
                Formato = txt_format.Text,
                Nivel = box_level.Text,
                Mental = txt_mental.Text,
                Verbal = txt_verbal.Text,
                Somatico = txt_somatic.Text,
                Material = txt_material.Text,
                Descricao = txt_description.Text,
                Afinidade = txt_afinity.Text,
                Assinatura = txt_signature.Text
            };

            feitico feiticoExiste = catalogoFeiticos.FirstOrDefault(f => f.Nome == feiticos.Nome);

            if (feiticoExiste != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Este feitiço já existe, deseja sobrescrevê-lo?", "Compendium",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    catalogoFeiticos.Remove(feiticoExiste);
                    catalogoFeiticos.Add(feiticos);
                    jsonAtualizado = JsonConvert.SerializeObject(catalogoFeiticos, Formatting.Indented);
                    File.WriteAllText(archive, jsonAtualizado);
                    atualizar();
                    limpar();
                    MessageBox.Show("Feitiço sobrescrito com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Altere o nome para adicionar um novo feitiço", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_name.Focus();
                    txt_name.SelectAll();
                }
            }
            else
            {
                catalogoFeiticos.Add(feiticos);
                jsonAtualizado = JsonConvert.SerializeObject(catalogoFeiticos, Formatting.Indented);
                File.WriteAllText(archive, jsonAtualizado);
                atualizar();
                limpar();
                MessageBox.Show("Feitiço registrado com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void atualizar()
        {
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                catalogoFeiticos = JsonConvert.DeserializeObject<List<feitico>>(json) ?? new List<feitico>();                
            }
            else
            {
                MessageBox.Show("Não existem feitiços catalogados", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.Rows.Clear();

            var feiticosFiltrados = catalogoFeiticos.AsEnumerable();

            if (!string.IsNullOrEmpty(box_filter.Text) && box_filter.Text != "Todos")
            {
                feiticosFiltrados = feiticosFiltrados.Where(f => f.Categoria == box_filter.Text);
            }

            if (!string.IsNullOrEmpty(box_filterLevel.Text) && box_filterLevel.Text != "Todos")
            {
                feiticosFiltrados = feiticosFiltrados.Where(f => f.Nivel == box_filterLevel.Text);
            }

            List<string> ordemNiveis = new List<string> { "Iniciante", "Aprendiz", "Adepto", "Especialista", "Mestre" };

            feiticosFiltrados = feiticosFiltrados.OrderBy(f => f.Categoria).ThenBy(f => ordemNiveis.IndexOf(f.Nivel)).ThenBy(f => f.Nome).ToList();

            foreach (var feitico in feiticosFiltrados)
            {
                dataGridView.Rows.Add(feitico.Nome);
            }
        }

        public void limpar()
        {
            txt_name.Clear();
            box_category.Text = null;
            box_level.Text = null;
            txt_range.Clear();
            txt_format.Clear();
            txt_description.Clear();
            txt_damage.Clear();
            txt_afinity.Clear();
            txt_signature.Clear();
            txt_mental.Clear();
            txt_verbal.Clear();
            txt_somatic.Clear();
            txt_material.Clear();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == string.Empty)
            {
                MessageBox.Show("É obrigatório completar o campo 'nome'", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (box_category.Text == string.Empty || txt_damage.Text == string.Empty || txt_range.Text == string.Empty
                || txt_format.Text == string.Empty || box_level.Text == string.Empty || txt_mental.Text == string.Empty || txt_verbal.Text == string.Empty
                || txt_somatic.Text == string.Empty || txt_material.Text == string.Empty || txt_description.Text == string.Empty
                || txt_afinity.Text == string.Empty || txt_signature.Text == string.Empty)
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

        private void catalogofeiticos_Load(object sender, EventArgs e)
        {
            
            nomePerfil = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            nomePerfil = new DirectoryInfo(nomePerfil).Name;

            if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documentos"))
            {
                path = @"C:\Users\" + nomePerfil + @"\Documentos\Compendium";

            }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\Documents"))
            {
                path = @"C:\Users\" + nomePerfil + @"\Documents\Compendium";
                
            }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documentos"))
            {
                path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documentos\Compendium";

            }
            else if (Directory.Exists(@"C:\Users\" + nomePerfil + @"\OneDrive\Documents"))
            {
                path = @"C:\Users\" + nomePerfil + @"\OneDrive\Documents\Compendium";

            }
            else
            {
                MessageBox.Show("Não foi possível encontrar a pasta Documentos","Compendium",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }


            archive = path;
            archive += @"\feiticos.json";

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

        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            atualizar();
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Selected = true;            
            if (File.Exists(archive))
            {
                json = File.ReadAllText(archive);
                List<feitico> catalogoFeiticos = JsonConvert.DeserializeObject<List<feitico>>(json);

                feitico feiticoFound = catalogoFeiticos.FirstOrDefault(f => f.Nome == dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                if (feiticoFound != null)
                {
                    txt_name.Text = feiticoFound.Nome;
                    box_category.Text = feiticoFound.Categoria;
                    txt_damage.Text = feiticoFound.Dano;
                    txt_range.Text = feiticoFound.Alcance;
                    txt_format.Text = feiticoFound.Formato;
                    box_level.Text = feiticoFound.Nivel;
                    txt_mental.Text = feiticoFound.Mental;
                    txt_verbal.Text = feiticoFound.Verbal;
                    txt_somatic.Text = feiticoFound.Somatico;
                    txt_material.Text = feiticoFound.Material;
                    txt_description.Text = feiticoFound.Descricao;
                    txt_afinity.Text = feiticoFound.Afinidade;
                    txt_signature.Text = feiticoFound.Assinatura;
                }
            }
        }

        private void bttn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bttn_del_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza de que deseja excluir esse feitiço?","Compendium",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (File.Exists(archive))
                {
                    json = File.ReadAllText(archive);
                    List<feitico> catalogoFeiticos = JsonConvert.DeserializeObject<List<feitico>>(json);

                    feitico feiticoExiste = catalogoFeiticos.FirstOrDefault(f => f.Nome == txt_name.Text);
                    if (feiticoExiste != null)
                    {
                        catalogoFeiticos.Remove(feiticoExiste);
                        json = JsonConvert.SerializeObject(catalogoFeiticos, Formatting.Indented);
                        File.WriteAllText(archive, json);

                        MessageBox.Show("Feitiço excluído com sucesso", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        box_filter.Text = null;
                        box_filterLevel.Text = null;
                        atualizar();
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Esse feitiço ainda não foi catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não há nenhum feitiço catalogado", "Compendium", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void bttn_export_Click(object sender, EventArgs e)
        {
            StringBuilder textoExportado = new StringBuilder();

            if (DialogResult.Yes == MessageBox.Show("Exportar apenas os itens selecionados?","Compendium",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question))
            {

                foreach (DataGridViewRow row in dataGridView.SelectedRows.Cast<DataGridViewRow>().Reverse())
                {
                    string nomeFeitico = row.Cells[0].Value.ToString();

                    feitico feiticoEncontrado = catalogoFeiticos.FirstOrDefault(f => f.Nome == nomeFeitico);

                    if (feiticoEncontrado != null)
                    {
                        textoExportado.AppendLine($"Nome: {feiticoEncontrado.Nome}");
                        textoExportado.AppendLine($"Categoria: {feiticoEncontrado.Categoria}");
                        textoExportado.AppendLine($"Dano: {feiticoEncontrado.Dano}");
                        textoExportado.AppendLine($"Alcance: {feiticoEncontrado.Alcance}");
                        textoExportado.AppendLine($"Formato: {feiticoEncontrado.Formato}");
                        textoExportado.AppendLine($"Nível: {feiticoEncontrado.Nivel}");
                        textoExportado.AppendLine($"Mental: {feiticoEncontrado.Mental}");
                        textoExportado.AppendLine($"Verbal: {feiticoEncontrado.Verbal}");
                        textoExportado.AppendLine($"Somático: {feiticoEncontrado.Somatico}");
                        textoExportado.AppendLine($"Material: {feiticoEncontrado.Material}");
                        textoExportado.AppendLine($"Descrição: {feiticoEncontrado.Descricao}");
                        textoExportado.AppendLine($"Afinidade: {feiticoEncontrado.Afinidade}");
                        textoExportado.AppendLine($"Assinatura: {feiticoEncontrado.Assinatura}");
                        textoExportado.AppendLine("----------------------------------------------");

                        
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Arquivo de Texto (*.txt)|*.txt",
                    Title = "Salvar Feitiços",
                    FileName = "FeiticosExportados.txt"
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textoExportado.ToString());
                    MessageBox.Show("Feitiços exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView.Rows.Cast<DataGridViewRow>().Reverse())
                {
                    string nomeFeitico = row.Cells[0].Value.ToString();

                    feitico feiticoEncontrado = catalogoFeiticos.FirstOrDefault(f => f.Nome == nomeFeitico);

                    if (feiticoEncontrado != null)
                    {
                        textoExportado.AppendLine($"Nome: {feiticoEncontrado.Nome}");
                        textoExportado.AppendLine($"Categoria: {feiticoEncontrado.Categoria}");
                        textoExportado.AppendLine($"Dano: {feiticoEncontrado.Dano}");
                        textoExportado.AppendLine($"Alcance: {feiticoEncontrado.Alcance}");
                        textoExportado.AppendLine($"Formato: {feiticoEncontrado.Formato}");
                        textoExportado.AppendLine($"Nível: {feiticoEncontrado.Nivel}");
                        textoExportado.AppendLine($"Mental: {feiticoEncontrado.Mental}");
                        textoExportado.AppendLine($"Verbal: {feiticoEncontrado.Verbal}");
                        textoExportado.AppendLine($"Somático: {feiticoEncontrado.Somatico}");
                        textoExportado.AppendLine($"Material: {feiticoEncontrado.Material}");
                        textoExportado.AppendLine($"Descrição: {feiticoEncontrado.Descricao}");
                        textoExportado.AppendLine($"Afinidade: {feiticoEncontrado.Afinidade}");
                        textoExportado.AppendLine($"Assinatura: {feiticoEncontrado.Assinatura}");
                        textoExportado.AppendLine("----------------------------------------------");
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Arquivo de Texto (*.txt)|*.txt",
                    Title = "Salvar Feitiços",
                    FileName = "FeiticosExportados.txt"
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textoExportado.ToString());
                    MessageBox.Show("Feitiços exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void bttn_copy_Click(object sender, EventArgs e)
        {
            StringBuilder textoExportado = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                string nomeFeitico = row.Cells[0].Value.ToString();

                feitico feiticoEncontrado = catalogoFeiticos.FirstOrDefault(f => f.Nome == nomeFeitico);

                if (feiticoEncontrado != null)
                {
                    textoExportado.AppendLine($"Nome: {feiticoEncontrado.Nome}");
                    textoExportado.AppendLine($"Categoria: {feiticoEncontrado.Categoria}");
                    textoExportado.AppendLine($"Dano: {feiticoEncontrado.Dano}");
                    textoExportado.AppendLine($"Alcance: {feiticoEncontrado.Alcance}");
                    textoExportado.AppendLine($"Formato: {feiticoEncontrado.Formato}");
                    textoExportado.AppendLine($"Nível: {feiticoEncontrado.Nivel}");
                    textoExportado.AppendLine($"Mental: {feiticoEncontrado.Mental}");
                    textoExportado.AppendLine($"Verbal: {feiticoEncontrado.Verbal}");
                    textoExportado.AppendLine($"Somático: {feiticoEncontrado.Somatico}");
                    textoExportado.AppendLine($"Material: {feiticoEncontrado.Material}");
                    textoExportado.AppendLine($"Descrição: {feiticoEncontrado.Descricao}");
                    textoExportado.AppendLine($"Afinidade: {feiticoEncontrado.Afinidade}");
                    textoExportado.AppendLine($"Assinatura: {feiticoEncontrado.Assinatura}");
                    textoExportado.AppendLine("----------------------------------------------");
                }
                
            }
            
            Clipboard.SetText(textoExportado.ToString());
        }

        private void box_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void box_filterLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bttn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Importar arquivo"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(archive))
                {
                    File.Delete(archive);
                    File.Move(openFileDialog1.FileName, archive);
                    atualizar();
                    MessageBox.Show("Feitiços importados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    File.Move(openFileDialog1.FileName, archive);
                    atualizar();
                    MessageBox.Show("Feitiços importados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
    public class feitico
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Dano { get; set; }
        public string Alcance { get; set; }
        public string Formato { get; set; }
        public string Nivel { get; set; }
        public string Mental { get; set; }
        public string Verbal { get; set; }
        public string Somatico { get; set; }
        public string Material { get; set; }
        public string Descricao { get; set; }
        public string Afinidade { get; set; }
        public string Assinatura { get; set; }
    }
}
