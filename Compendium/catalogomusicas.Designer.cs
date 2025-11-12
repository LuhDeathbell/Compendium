namespace Compendium
{
    partial class catalogomusicas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogomusicas));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_buscar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.bttn_refresh = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nomesMusicasGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_descricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_del = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.RichTextBox();
            this.txt_origem = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_limpar = new System.Windows.Forms.Button();
            this.bttn_copylink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(81, 12);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(534, 27);
            this.txt_nome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // bttn_buscar
            // 
            this.bttn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_buscar.BackgroundImage")));
            this.bttn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_buscar.Location = new System.Drawing.Point(580, 110);
            this.bttn_buscar.Name = "bttn_buscar";
            this.bttn_buscar.Size = new System.Drawing.Size(35, 27);
            this.bttn_buscar.TabIndex = 43;
            this.bttn_buscar.UseVisualStyleBackColor = true;
            this.bttn_buscar.Click += new System.EventHandler(this.bttn_buscar_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro.Location = new System.Drawing.Point(378, 110);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(205, 27);
            this.txt_filtro.TabIndex = 39;
            this.txt_filtro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_filtro_KeyDown);
            // 
            // bttn_refresh
            // 
            this.bttn_refresh.Location = new System.Drawing.Point(536, 71);
            this.bttn_refresh.Name = "bttn_refresh";
            this.bttn_refresh.Size = new System.Drawing.Size(79, 23);
            this.bttn_refresh.TabIndex = 42;
            this.bttn_refresh.Text = "Refresh";
            this.bttn_refresh.UseVisualStyleBackColor = true;
            this.bttn_refresh.Click += new System.EventHandler(this.bttn_refresh_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(373, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 25);
            this.label21.TabIndex = 41;
            this.label21.Text = "Catálogo:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomesMusicasGrid});
            this.dataGridView.Location = new System.Drawing.Point(378, 142);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(237, 404);
            this.dataGridView.TabIndex = 40;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick_1);
            // 
            // nomesMusicasGrid
            // 
            this.nomesMusicasGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomesMusicasGrid.HeaderText = "Músicas catalogadas:";
            this.nomesMusicasGrid.MinimumWidth = 6;
            this.nomesMusicasGrid.Name = "nomesMusicasGrid";
            this.nomesMusicasGrid.ReadOnly = true;
            this.nomesMusicasGrid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_descricao.Location = new System.Drawing.Point(16, 110);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(340, 360);
            this.txt_descricao.TabIndex = 44;
            this.txt_descricao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Descrição:";
            // 
            // bttn_del
            // 
            this.bttn_del.BackColor = System.Drawing.Color.IndianRed;
            this.bttn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_del.Location = new System.Drawing.Point(204, 477);
            this.bttn_del.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_del.Name = "bttn_del";
            this.bttn_del.Size = new System.Drawing.Size(152, 69);
            this.bttn_del.TabIndex = 47;
            this.bttn_del.Text = "Deletar";
            this.bttn_del.UseVisualStyleBackColor = false;
            this.bttn_del.Click += new System.EventHandler(this.bttn_del_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.YellowGreen;
            this.bttn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Location = new System.Drawing.Point(16, 477);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(163, 69);
            this.bttn_save.TabIndex = 46;
            this.bttn_save.Text = "Salvar";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Link:";
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_link.Location = new System.Drawing.Point(17, 596);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(302, 53);
            this.txt_link.TabIndex = 49;
            this.txt_link.Text = "";
            // 
            // txt_origem
            // 
            this.txt_origem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_origem.Location = new System.Drawing.Point(337, 596);
            this.txt_origem.Name = "txt_origem";
            this.txt_origem.Size = new System.Drawing.Size(278, 53);
            this.txt_origem.TabIndex = 51;
            this.txt_origem.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(332, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Origem:";
            // 
            // bttn_limpar
            // 
            this.bttn_limpar.Location = new System.Drawing.Point(500, 665);
            this.bttn_limpar.Name = "bttn_limpar";
            this.bttn_limpar.Size = new System.Drawing.Size(115, 23);
            this.bttn_limpar.TabIndex = 52;
            this.bttn_limpar.Text = "Limpar tudo";
            this.bttn_limpar.UseVisualStyleBackColor = true;
            this.bttn_limpar.Click += new System.EventHandler(this.bttn_limpar_Click);
            // 
            // bttn_copylink
            // 
            this.bttn_copylink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_copylink.BackgroundImage")));
            this.bttn_copylink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_copylink.Location = new System.Drawing.Point(293, 665);
            this.bttn_copylink.Name = "bttn_copylink";
            this.bttn_copylink.Size = new System.Drawing.Size(26, 23);
            this.bttn_copylink.TabIndex = 53;
            this.bttn_copylink.UseVisualStyleBackColor = true;
            this.bttn_copylink.Click += new System.EventHandler(this.bttn_copylink_Click);
            // 
            // catalogomusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(627, 700);
            this.Controls.Add(this.bttn_copylink);
            this.Controls.Add(this.bttn_limpar);
            this.Controls.Add(this.txt_origem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_del);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.bttn_buscar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.bttn_refresh);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "catalogomusicas";
            this.Text = "Músicas";
            this.Load += new System.EventHandler(this.catalogomusicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_buscar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button bttn_refresh;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomesMusicasGrid;
        private System.Windows.Forms.RichTextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_del;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_link;
        private System.Windows.Forms.RichTextBox txt_origem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_limpar;
        private System.Windows.Forms.Button bttn_copylink;
    }
}