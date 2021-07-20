
namespace Alkalmazas
{
    partial class UCVetitesek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxFilmek = new System.Windows.Forms.ListBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.műfajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetítésekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.időpontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetítésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJatekido = new System.Windows.Forms.TextBox();
            this.textBoxSzinkron = new System.Windows.Forms.TextBox();
            this.labelMozi = new System.Windows.Forms.Label();
            this.labelNap = new System.Windows.Forms.Label();
            this.listBoxIdopontok = new System.Windows.Forms.ListBox();
            this.IDOPONTOKbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFizetendo = new System.Windows.Forms.TextBox();
            this.teremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelVetítésID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jegyvasarlasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOPONTOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDEGNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kATEGORIANEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.műfajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetítésekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.időpontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetítésBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDOPONTOKbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teremBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegyvasarlasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFilmek
            // 
            this.listBoxFilmek.DataSource = this.filmBindingSource;
            this.listBoxFilmek.DisplayMember = "CIM";
            this.listBoxFilmek.FormattingEnabled = true;
            this.listBoxFilmek.Location = new System.Drawing.Point(23, 70);
            this.listBoxFilmek.Name = "listBoxFilmek";
            this.listBoxFilmek.Size = new System.Drawing.Size(237, 277);
            this.listBoxFilmek.TabIndex = 0;
            this.listBoxFilmek.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmek_SelectedIndexChanged);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(Alkalmazas.Film);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Műfaj";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.műfajBindingSource;
            this.comboBox1.DisplayMember = "NEV";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // műfajBindingSource
            // 
            this.műfajBindingSource.DataSource = typeof(Alkalmazas.Műfaj);
            // 
            // időpontBindingSource
            // 
            this.időpontBindingSource.DataSource = typeof(Alkalmazas.Időpont);
            // 
            // vetítésBindingSource
            // 
            this.vetítésBindingSource.DataSource = typeof(Alkalmazas.Vetítés);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Játékidő";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szinkron";
            // 
            // textBoxJatekido
            // 
            this.textBoxJatekido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "JATEKIDO", true));
            this.textBoxJatekido.Enabled = false;
            this.textBoxJatekido.Location = new System.Drawing.Point(71, 390);
            this.textBoxJatekido.Name = "textBoxJatekido";
            this.textBoxJatekido.Size = new System.Drawing.Size(100, 20);
            this.textBoxJatekido.TabIndex = 7;
            // 
            // textBoxSzinkron
            // 
            this.textBoxSzinkron.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "SZINKRON", true));
            this.textBoxSzinkron.Enabled = false;
            this.textBoxSzinkron.Location = new System.Drawing.Point(71, 427);
            this.textBoxSzinkron.Name = "textBoxSzinkron";
            this.textBoxSzinkron.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzinkron.TabIndex = 8;
            // 
            // labelMozi
            // 
            this.labelMozi.AutoSize = true;
            this.labelMozi.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMozi.Location = new System.Drawing.Point(17, 25);
            this.labelMozi.Name = "labelMozi";
            this.labelMozi.Size = new System.Drawing.Size(113, 31);
            this.labelMozi.TabIndex = 9;
            this.labelMozi.Text = "labelMozi";
            // 
            // labelNap
            // 
            this.labelNap.AutoSize = true;
            this.labelNap.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNap.Location = new System.Drawing.Point(424, 25);
            this.labelNap.Name = "labelNap";
            this.labelNap.Size = new System.Drawing.Size(106, 31);
            this.labelNap.TabIndex = 10;
            this.labelNap.Text = "labelNap";
            // 
            // listBoxIdopontok
            // 
            this.listBoxIdopontok.DataSource = this.IDOPONTOKbindingSource;
            this.listBoxIdopontok.DisplayMember = "IDOPONTOK";
            this.listBoxIdopontok.FormattingEnabled = true;
            this.listBoxIdopontok.Location = new System.Drawing.Point(430, 70);
            this.listBoxIdopontok.Name = "listBoxIdopontok";
            this.listBoxIdopontok.Size = new System.Drawing.Size(73, 277);
            this.listBoxIdopontok.TabIndex = 11;
            // 
            // IDOPONTOKbindingSource
            // 
            this.IDOPONTOKbindingSource.DataSource = typeof(Alkalmazas.Idopontok);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kosár";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Marlett", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(538, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 53);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Marlett", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(538, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 53);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(948, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Összesen fizetendő:";
            // 
            // textBoxFizetendo
            // 
            this.textBoxFizetendo.Enabled = false;
            this.textBoxFizetendo.Location = new System.Drawing.Point(1145, 384);
            this.textBoxFizetendo.Name = "textBoxFizetendo";
            this.textBoxFizetendo.Size = new System.Drawing.Size(71, 20);
            this.textBoxFizetendo.TabIndex = 16;
            // 
            // teremBindingSource
            // 
            this.teremBindingSource.DataSource = typeof(Alkalmazas.Terem);
            // 
            // labelVetítésID
            // 
            this.labelVetítésID.AutoSize = true;
            this.labelVetítésID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IDOPONTOKbindingSource, "VETITES_ID", true));
            this.labelVetítésID.Location = new System.Drawing.Point(474, 296);
            this.labelVetítésID.Name = "labelVetítésID";
            this.labelVetítésID.Size = new System.Drawing.Size(29, 13);
            this.labelVetítésID.TabIndex = 17;
            this.labelVetítésID.Text = "teszt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIMDataGridViewTextBoxColumn,
            this.iDOPONTOKDataGridViewTextBoxColumn,
            this.vENDEGNEVDataGridViewTextBoxColumn,
            this.kATEGORIANEVDataGridViewTextBoxColumn,
            this.aRDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jegyvasarlasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(622, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 277);
            this.dataGridView1.TabIndex = 18;
            // 
            // jegyvasarlasBindingSource
            // 
            this.jegyvasarlasBindingSource.DataSource = typeof(Alkalmazas.JegyVasarlas);
            // 
            // cIMDataGridViewTextBoxColumn
            // 
            this.cIMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cIMDataGridViewTextBoxColumn.DataPropertyName = "CIM";
            this.cIMDataGridViewTextBoxColumn.HeaderText = "Cím";
            this.cIMDataGridViewTextBoxColumn.Name = "cIMDataGridViewTextBoxColumn";
            this.cIMDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // iDOPONTOKDataGridViewTextBoxColumn
            // 
            this.iDOPONTOKDataGridViewTextBoxColumn.DataPropertyName = "IDOPONTOK";
            this.iDOPONTOKDataGridViewTextBoxColumn.HeaderText = "Időpont";
            this.iDOPONTOKDataGridViewTextBoxColumn.Name = "iDOPONTOKDataGridViewTextBoxColumn";
            this.iDOPONTOKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vENDEGNEVDataGridViewTextBoxColumn
            // 
            this.vENDEGNEVDataGridViewTextBoxColumn.DataPropertyName = "VENDEG_NEV";
            this.vENDEGNEVDataGridViewTextBoxColumn.HeaderText = "Vendég neve";
            this.vENDEGNEVDataGridViewTextBoxColumn.Name = "vENDEGNEVDataGridViewTextBoxColumn";
            this.vENDEGNEVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kATEGORIANEVDataGridViewTextBoxColumn
            // 
            this.kATEGORIANEVDataGridViewTextBoxColumn.DataPropertyName = "KATEGORIA_NEV";
            this.kATEGORIANEVDataGridViewTextBoxColumn.HeaderText = "Jegy típus";
            this.kATEGORIANEVDataGridViewTextBoxColumn.Name = "kATEGORIANEVDataGridViewTextBoxColumn";
            this.kATEGORIANEVDataGridViewTextBoxColumn.ReadOnly = true;
            this.kATEGORIANEVDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // aRDataGridViewTextBoxColumn
            // 
            this.aRDataGridViewTextBoxColumn.DataPropertyName = "AR";
            this.aRDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.aRDataGridViewTextBoxColumn.Name = "aRDataGridViewTextBoxColumn";
            this.aRDataGridViewTextBoxColumn.ReadOnly = true;
            this.aRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aRDataGridViewTextBoxColumn.Width = 50;
            // 
            // UCVetitesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxFizetendo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNap);
            this.Controls.Add(this.labelMozi);
            this.Controls.Add(this.textBoxSzinkron);
            this.Controls.Add(this.textBoxJatekido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFilmek);
            this.Controls.Add(this.listBoxIdopontok);
            this.Controls.Add(this.labelVetítésID);
            this.Name = "UCVetitesek";
            this.Size = new System.Drawing.Size(1277, 719);
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.műfajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetítésekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.időpontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetítésBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDOPONTOKbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teremBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegyvasarlasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFilmek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource műfajBindingSource;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.BindingSource vetítésBindingSource;
        private System.Windows.Forms.BindingSource időpontBindingSource;
        private System.Windows.Forms.BindingSource vetítésekBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJatekido;
        private System.Windows.Forms.TextBox textBoxSzinkron;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFizetendo;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label labelMozi;
        public System.Windows.Forms.Label labelNap;
        private System.Windows.Forms.BindingSource teremBindingSource;
        private System.Windows.Forms.Label labelVetítésID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jegyvasarlasBindingSource;
        public System.Windows.Forms.ListBox listBoxIdopontok;
        private System.Windows.Forms.BindingSource IDOPONTOKbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vETITESPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOPONTOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDEGNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kATEGORIANEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRDataGridViewTextBoxColumn;
    }
}
