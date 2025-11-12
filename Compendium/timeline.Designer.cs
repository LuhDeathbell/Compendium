namespace Compendium
{
    partial class timeline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timeline));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txt_descricao = new System.Windows.Forms.RichTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.MaskedTextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_evento5 = new System.Windows.Forms.Label();
            this.lbl_evento6 = new System.Windows.Forms.Label();
            this.lbl_evento4 = new System.Windows.Forms.Label();
            this.lbl_evento3 = new System.Windows.Forms.Label();
            this.lbl_evento2 = new System.Windows.Forms.Label();
            this.lbl_evento1 = new System.Windows.Forms.Label();
            this.lbl_evento7 = new System.Windows.Forms.Label();
            this.lbl_evento8 = new System.Windows.Forms.Label();
            this.lbl_evento9 = new System.Windows.Forms.Label();
            this.bttn_buscar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnEvento});
            this.dataGridView1.Location = new System.Drawing.Point(80, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 126);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnEvento
            // 
            this.columnEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEvento.HeaderText = "Eventos:";
            this.columnEvento.MinimumWidth = 6;
            this.columnEvento.Name = "columnEvento";
            this.columnEvento.ReadOnly = true;
            this.columnEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.InitialImage = global::Compendium.Properties.Resources.placeholder_image_icon_19;
            this.pictureBox.Location = new System.Drawing.Point(80, 196);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 152);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_descricao.Location = new System.Drawing.Point(327, 64);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(701, 284);
            this.txt_descricao.TabIndex = 2;
            this.txt_descricao.Text = "";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(327, 40);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(591, 22);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(924, 39);
            this.txt_data.Mask = "0000/00/00";
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(104, 22);
            this.txt_data.TabIndex = 4;
            this.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Lime;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(1034, 324);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(27, 23);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "+";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Red;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(1034, 295);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(27, 23);
            this.btn_remover.TabIndex = 5;
            this.btn_remover.Text = "-";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(80, 40);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(207, 22);
            this.txt_filtro.TabIndex = 3;
            this.txt_filtro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_filtro_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_evento5
            // 
            this.lbl_evento5.AutoSize = true;
            this.lbl_evento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento5.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento5.Location = new System.Drawing.Point(527, 408);
            this.lbl_evento5.Name = "lbl_evento5";
            this.lbl_evento5.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento5.TabIndex = 6;
            this.lbl_evento5.Text = "-";
            this.lbl_evento5.TextChanged += new System.EventHandler(this.lbl_evento5_TextChanged);
            // 
            // lbl_evento6
            // 
            this.lbl_evento6.AutoSize = true;
            this.lbl_evento6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento6.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento6.Location = new System.Drawing.Point(609, 408);
            this.lbl_evento6.Name = "lbl_evento6";
            this.lbl_evento6.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento6.TabIndex = 6;
            this.lbl_evento6.Text = "-";
            this.lbl_evento6.TextChanged += new System.EventHandler(this.lbl_evento6_TextChanged);
            this.lbl_evento6.Click += new System.EventHandler(this.lbl_evento6_Click);
            this.lbl_evento6.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento6.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento4
            // 
            this.lbl_evento4.AutoSize = true;
            this.lbl_evento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento4.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento4.Location = new System.Drawing.Point(367, 408);
            this.lbl_evento4.Name = "lbl_evento4";
            this.lbl_evento4.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento4.TabIndex = 6;
            this.lbl_evento4.Text = "-";
            this.lbl_evento4.TextChanged += new System.EventHandler(this.lbl_evento4_TextChanged);
            this.lbl_evento4.Click += new System.EventHandler(this.lbl_evento4_Click);
            this.lbl_evento4.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento4.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento3
            // 
            this.lbl_evento3.AutoSize = true;
            this.lbl_evento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento3.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento3.Location = new System.Drawing.Point(308, 408);
            this.lbl_evento3.Name = "lbl_evento3";
            this.lbl_evento3.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento3.TabIndex = 6;
            this.lbl_evento3.Text = "-";
            this.lbl_evento3.TextChanged += new System.EventHandler(this.lbl_evento3_TextChanged);
            this.lbl_evento3.Click += new System.EventHandler(this.lbl_evento3_Click);
            this.lbl_evento3.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento3.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento2
            // 
            this.lbl_evento2.AutoSize = true;
            this.lbl_evento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento2.Location = new System.Drawing.Point(242, 408);
            this.lbl_evento2.Name = "lbl_evento2";
            this.lbl_evento2.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento2.TabIndex = 6;
            this.lbl_evento2.Text = "-";
            this.lbl_evento2.TextChanged += new System.EventHandler(this.lbl_evento2_TextChanged);
            this.lbl_evento2.Click += new System.EventHandler(this.lbl_evento2_Click);
            this.lbl_evento2.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento2.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento1
            // 
            this.lbl_evento1.AutoSize = true;
            this.lbl_evento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento1.Location = new System.Drawing.Point(185, 408);
            this.lbl_evento1.Name = "lbl_evento1";
            this.lbl_evento1.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento1.TabIndex = 6;
            this.lbl_evento1.Text = "-";
            this.lbl_evento1.TextChanged += new System.EventHandler(this.lbl_evento1_TextChanged);
            this.lbl_evento1.Click += new System.EventHandler(this.lbl_evento1_Click);
            this.lbl_evento1.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento1.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento7
            // 
            this.lbl_evento7.AutoSize = true;
            this.lbl_evento7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento7.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento7.Location = new System.Drawing.Point(671, 408);
            this.lbl_evento7.Name = "lbl_evento7";
            this.lbl_evento7.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento7.TabIndex = 6;
            this.lbl_evento7.Text = "-";
            this.lbl_evento7.TextChanged += new System.EventHandler(this.lbl_evento7_TextChanged);
            this.lbl_evento7.Click += new System.EventHandler(this.lbl_evento7_Click);
            this.lbl_evento7.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento7.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento8
            // 
            this.lbl_evento8.AutoSize = true;
            this.lbl_evento8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento8.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento8.Location = new System.Drawing.Point(742, 408);
            this.lbl_evento8.Name = "lbl_evento8";
            this.lbl_evento8.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento8.TabIndex = 6;
            this.lbl_evento8.Text = "-";
            this.lbl_evento8.TextChanged += new System.EventHandler(this.lbl_evento8_TextChanged);
            this.lbl_evento8.Click += new System.EventHandler(this.lbl_evento8_Click);
            this.lbl_evento8.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento8.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // lbl_evento9
            // 
            this.lbl_evento9.AutoSize = true;
            this.lbl_evento9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento9.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_evento9.Location = new System.Drawing.Point(800, 408);
            this.lbl_evento9.Name = "lbl_evento9";
            this.lbl_evento9.Size = new System.Drawing.Size(10, 13);
            this.lbl_evento9.TabIndex = 6;
            this.lbl_evento9.Text = "-";
            this.lbl_evento9.TextChanged += new System.EventHandler(this.lbl_evento9_TextChanged);
            this.lbl_evento9.Click += new System.EventHandler(this.lbl_evento9_Click);
            this.lbl_evento9.MouseLeave += new System.EventHandler(this.lbl_evento1_MouseLeave);
            this.lbl_evento9.MouseHover += new System.EventHandler(this.lbl_evento1_MouseHover);
            // 
            // bttn_buscar
            // 
            this.bttn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_buscar.BackgroundImage")));
            this.bttn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_buscar.Location = new System.Drawing.Point(293, 40);
            this.bttn_buscar.Name = "bttn_buscar";
            this.bttn_buscar.Size = new System.Drawing.Size(27, 22);
            this.bttn_buscar.TabIndex = 44;
            this.bttn_buscar.UseVisualStyleBackColor = true;
            this.bttn_buscar.Click += new System.EventHandler(this.bttn_buscar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(965, 354);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(96, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar tudo";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1092, 516);
            this.Controls.Add(this.bttn_buscar);
            this.Controls.Add(this.lbl_evento1);
            this.Controls.Add(this.lbl_evento2);
            this.Controls.Add(this.lbl_evento3);
            this.Controls.Add(this.lbl_evento4);
            this.Controls.Add(this.lbl_evento9);
            this.Controls.Add(this.lbl_evento8);
            this.Controls.Add(this.lbl_evento7);
            this.Controls.Add(this.lbl_evento6);
            this.Controls.Add(this.lbl_evento5);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timeline";
            this.Text = "Linha do Tempo";
            this.Load += new System.EventHandler(this.timeline_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.timeline_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_data;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEvento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_evento5;
        private System.Windows.Forms.Label lbl_evento6;
        private System.Windows.Forms.Label lbl_evento4;
        private System.Windows.Forms.Label lbl_evento3;
        private System.Windows.Forms.Label lbl_evento2;
        private System.Windows.Forms.Label lbl_evento1;
        private System.Windows.Forms.Label lbl_evento7;
        private System.Windows.Forms.Label lbl_evento8;
        private System.Windows.Forms.Label lbl_evento9;
        private System.Windows.Forms.Button bttn_buscar;
        private System.Windows.Forms.Button btn_limpar;
    }
}