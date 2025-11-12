namespace Compendium
{
    partial class catalogofeiticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogofeiticos));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_level = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_format = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_range = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_damage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_verbal = new System.Windows.Forms.RichTextBox();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mental = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_afinity = new System.Windows.Forms.RichTextBox();
            this.txt_signature = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_del = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nomesFeiticosGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.box_filter = new System.Windows.Forms.ComboBox();
            this.bttn_refresh = new System.Windows.Forms.Button();
            this.box_filterLevel = new System.Windows.Forms.ComboBox();
            this.bttn_limpar = new System.Windows.Forms.Button();
            this.bttn_import = new System.Windows.Forms.Button();
            this.bttn_export = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttn_copy = new System.Windows.Forms.Button();
            this.txt_somatic = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(128, 25);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(401, 30);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_level);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_format);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_range);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_damage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.box_category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(19, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(237, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // box_level
            // 
            this.box_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_level.FormattingEnabled = true;
            this.box_level.Items.AddRange(new object[] {
            "Iniciante",
            "Aprendiz",
            "Adepto",
            "Especialista",
            "Mestre"});
            this.box_level.Location = new System.Drawing.Point(5, 318);
            this.box_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_level.Name = "box_level";
            this.box_level.Size = new System.Drawing.Size(225, 28);
            this.box_level.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(5, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nível:";
            // 
            // txt_format
            // 
            this.txt_format.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_format.Location = new System.Drawing.Point(5, 244);
            this.txt_format.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_format.Name = "txt_format";
            this.txt_format.Size = new System.Drawing.Size(225, 30);
            this.txt_format.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(5, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Formato:";
            // 
            // txt_range
            // 
            this.txt_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_range.Location = new System.Drawing.Point(5, 176);
            this.txt_range.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_range.Name = "txt_range";
            this.txt_range.Size = new System.Drawing.Size(225, 30);
            this.txt_range.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(5, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alcance:";
            // 
            // txt_damage
            // 
            this.txt_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_damage.Location = new System.Drawing.Point(5, 114);
            this.txt_damage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_damage.Name = "txt_damage";
            this.txt_damage.Size = new System.Drawing.Size(225, 30);
            this.txt_damage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dano:";
            // 
            // box_category
            // 
            this.box_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_category.FormattingEnabled = true;
            this.box_category.Items.AddRange(new object[] {
            "Angelomancia",
            "Druidismo",
            "Evocação",
            "Ilusão",
            "Invocação",
            "Misticismo",
            "Necromancia"});
            this.box_category.Location = new System.Drawing.Point(5, 49);
            this.box_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_category.Name = "box_category";
            this.box_category.Size = new System.Drawing.Size(225, 28);
            this.box_category.TabIndex = 4;
            this.box_category.SelectedIndexChanged += new System.EventHandler(this.categoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_verbal);
            this.groupBox2.Controls.Add(this.txt_material);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_mental);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(288, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(243, 289);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restrições";
            // 
            // txt_verbal
            // 
            this.txt_verbal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_verbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verbal.Location = new System.Drawing.Point(8, 114);
            this.txt_verbal.Name = "txt_verbal";
            this.txt_verbal.Size = new System.Drawing.Size(224, 100);
            this.txt_verbal.TabIndex = 21;
            this.txt_verbal.Text = "";
            // 
            // txt_material
            // 
            this.txt_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_material.Location = new System.Drawing.Point(8, 244);
            this.txt_material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(225, 30);
            this.txt_material.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(8, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Material:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(9, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Verbal:";
            // 
            // txt_mental
            // 
            this.txt_mental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mental.Location = new System.Drawing.Point(7, 49);
            this.txt_mental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mental.Name = "txt_mental";
            this.txt_mental.Size = new System.Drawing.Size(225, 30);
            this.txt_mental.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mental:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(547, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Somático:";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Location = new System.Drawing.Point(552, 53);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(241, 224);
            this.txt_description.TabIndex = 4;
            this.txt_description.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(547, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descrição:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(820, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Afinidade:";
            // 
            // txt_afinity
            // 
            this.txt_afinity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_afinity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_afinity.Location = new System.Drawing.Point(825, 57);
            this.txt_afinity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_afinity.Name = "txt_afinity";
            this.txt_afinity.Size = new System.Drawing.Size(241, 166);
            this.txt_afinity.TabIndex = 23;
            this.txt_afinity.Text = "";
            // 
            // txt_signature
            // 
            this.txt_signature.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_signature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_signature.Location = new System.Drawing.Point(825, 259);
            this.txt_signature.Margin = new System.Windows.Forms.Padding(4);
            this.txt_signature.Name = "txt_signature";
            this.txt_signature.Size = new System.Drawing.Size(241, 160);
            this.txt_signature.TabIndex = 25;
            this.txt_signature.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(820, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Assinatura:";
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.YellowGreen;
            this.bttn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Location = new System.Drawing.Point(288, 369);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(112, 69);
            this.bttn_save.TabIndex = 26;
            this.bttn_save.Text = "Salvar";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_del
            // 
            this.bttn_del.BackColor = System.Drawing.Color.IndianRed;
            this.bttn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_del.Location = new System.Drawing.Point(419, 370);
            this.bttn_del.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_del.Name = "bttn_del";
            this.bttn_del.Size = new System.Drawing.Size(112, 69);
            this.bttn_del.TabIndex = 27;
            this.bttn_del.Text = "Deletar";
            this.bttn_del.UseVisualStyleBackColor = false;
            this.bttn_del.Click += new System.EventHandler(this.bttn_del_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomesFeiticosGrid});
            this.dataGridView.Location = new System.Drawing.Point(1089, 53);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(237, 292);
            this.dataGridView.TabIndex = 28;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // nomesFeiticosGrid
            // 
            this.nomesFeiticosGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomesFeiticosGrid.HeaderText = "Feitiços catalogados:";
            this.nomesFeiticosGrid.MinimumWidth = 6;
            this.nomesFeiticosGrid.Name = "nomesFeiticosGrid";
            this.nomesFeiticosGrid.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(1084, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Catálogo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1084, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Filtros:";
            // 
            // box_filter
            // 
            this.box_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_filter.FormattingEnabled = true;
            this.box_filter.Items.AddRange(new object[] {
            "Todos",
            "Angelomancia",
            "Druidismo",
            "Evocação",
            "Ilusão",
            "Invocação",
            "Misticismo",
            "Necromancia"});
            this.box_filter.Location = new System.Drawing.Point(1089, 376);
            this.box_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_filter.Name = "box_filter";
            this.box_filter.Size = new System.Drawing.Size(236, 24);
            this.box_filter.TabIndex = 13;
            this.box_filter.SelectedIndexChanged += new System.EventHandler(this.box_filter_SelectedIndexChanged);
            // 
            // bttn_refresh
            // 
            this.bttn_refresh.Location = new System.Drawing.Point(1247, 26);
            this.bttn_refresh.Name = "bttn_refresh";
            this.bttn_refresh.Size = new System.Drawing.Size(79, 23);
            this.bttn_refresh.TabIndex = 31;
            this.bttn_refresh.Text = "Refresh";
            this.bttn_refresh.UseVisualStyleBackColor = true;
            this.bttn_refresh.Click += new System.EventHandler(this.bttn_refresh_Click);
            // 
            // box_filterLevel
            // 
            this.box_filterLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_filterLevel.FormattingEnabled = true;
            this.box_filterLevel.Items.AddRange(new object[] {
            "Todos",
            "Iniciante",
            "Aprendiz",
            "Adepto",
            "Especialista",
            "Mestre"});
            this.box_filterLevel.Location = new System.Drawing.Point(1089, 404);
            this.box_filterLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_filterLevel.Name = "box_filterLevel";
            this.box_filterLevel.Size = new System.Drawing.Size(236, 24);
            this.box_filterLevel.TabIndex = 32;
            this.box_filterLevel.SelectedIndexChanged += new System.EventHandler(this.box_filterLevel_SelectedIndexChanged);
            // 
            // bttn_limpar
            // 
            this.bttn_limpar.Location = new System.Drawing.Point(951, 426);
            this.bttn_limpar.Name = "bttn_limpar";
            this.bttn_limpar.Size = new System.Drawing.Size(115, 23);
            this.bttn_limpar.TabIndex = 33;
            this.bttn_limpar.Text = "Limpar tudo";
            this.bttn_limpar.UseVisualStyleBackColor = true;
            this.bttn_limpar.Click += new System.EventHandler(this.bttn_limpar_Click);
            // 
            // bttn_import
            // 
            this.bttn_import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_import.BackgroundImage")));
            this.bttn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_import.Location = new System.Drawing.Point(755, 409);
            this.bttn_import.Name = "bttn_import";
            this.bttn_import.Size = new System.Drawing.Size(38, 33);
            this.bttn_import.TabIndex = 34;
            this.bttn_import.UseVisualStyleBackColor = true;
            this.bttn_import.Click += new System.EventHandler(this.bttn_import_Click);
            // 
            // bttn_export
            // 
            this.bttn_export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_export.BackgroundImage")));
            this.bttn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_export.Location = new System.Drawing.Point(711, 409);
            this.bttn_export.Name = "bttn_export";
            this.bttn_export.Size = new System.Drawing.Size(38, 33);
            this.bttn_export.TabIndex = 35;
            this.bttn_export.UseVisualStyleBackColor = true;
            this.bttn_export.Click += new System.EventHandler(this.bttn_export_Click);
            // 
            // bttn_copy
            // 
            this.bttn_copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_copy.BackgroundImage")));
            this.bttn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_copy.Location = new System.Drawing.Point(552, 409);
            this.bttn_copy.Name = "bttn_copy";
            this.bttn_copy.Size = new System.Drawing.Size(38, 33);
            this.bttn_copy.TabIndex = 36;
            this.bttn_copy.UseVisualStyleBackColor = true;
            this.bttn_copy.Click += new System.EventHandler(this.bttn_copy_Click);
            // 
            // txt_somatic
            // 
            this.txt_somatic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_somatic.Location = new System.Drawing.Point(552, 315);
            this.txt_somatic.Name = "txt_somatic";
            this.txt_somatic.Size = new System.Drawing.Size(241, 85);
            this.txt_somatic.TabIndex = 37;
            this.txt_somatic.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // catalogofeiticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1343, 458);
            this.Controls.Add(this.txt_somatic);
            this.Controls.Add(this.bttn_copy);
            this.Controls.Add(this.bttn_export);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bttn_import);
            this.Controls.Add(this.bttn_limpar);
            this.Controls.Add(this.box_filterLevel);
            this.Controls.Add(this.bttn_refresh);
            this.Controls.Add(this.box_filter);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bttn_del);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txt_signature);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_afinity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "catalogofeiticos";
            this.Text = "Compendium";
            this.Load += new System.EventHandler(this.catalogofeiticos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_category;
        private System.Windows.Forms.TextBox txt_format;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_range;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_damage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_level;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mental;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txt_afinity;
        private System.Windows.Forms.RichTextBox txt_signature;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_del;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox box_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomesFeiticosGrid;
        private System.Windows.Forms.Button bttn_refresh;
        private System.Windows.Forms.ComboBox box_filterLevel;
        private System.Windows.Forms.Button bttn_limpar;
        private System.Windows.Forms.Button bttn_import;
        private System.Windows.Forms.Button bttn_export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bttn_copy;
        private System.Windows.Forms.RichTextBox txt_verbal;
        private System.Windows.Forms.RichTextBox txt_somatic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}