
namespace Alkalmazas
{
    partial class UCVarosMoziNap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVaros = new System.Windows.Forms.ComboBox();
            this.városBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxNap = new System.Windows.Forms.ComboBox();
            this.napBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMozi = new System.Windows.Forms.ComboBox();
            this.moziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonVarosMoziNap = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.városBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moziBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Melyik városban szeretne moziba menni?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(104, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Melyik moziba szeretne menni?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(104, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Melyik nap szeretne moziba menni?";
            // 
            // comboBoxVaros
            // 
            this.comboBoxVaros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxVaros.DataSource = this.városBindingSource;
            this.comboBoxVaros.DisplayMember = "NEV";
            this.comboBoxVaros.Location = new System.Drawing.Point(108, 146);
            this.comboBoxVaros.Name = "comboBoxVaros";
            this.comboBoxVaros.Size = new System.Drawing.Size(366, 21);
            this.comboBoxVaros.TabIndex = 3;
            this.comboBoxVaros.SelectedIndexChanged += new System.EventHandler(this.comboBoxVaros_SelectedIndexChanged);
            // 
            // városBindingSource
            // 
            this.városBindingSource.DataSource = typeof(Alkalmazas.Város);
            // 
            // comboBoxNap
            // 
            this.comboBoxNap.DataSource = this.napBindingSource;
            this.comboBoxNap.DisplayMember = "NAPOK";
            this.comboBoxNap.FormattingEnabled = true;
            this.comboBoxNap.Location = new System.Drawing.Point(107, 371);
            this.comboBoxNap.Name = "comboBoxNap";
            this.comboBoxNap.Size = new System.Drawing.Size(366, 21);
            this.comboBoxNap.TabIndex = 4;
            // 
            // napBindingSource
            // 
            this.napBindingSource.DataSource = typeof(Alkalmazas.Nap);
            // 
            // comboBoxMozi
            // 
            this.comboBoxMozi.DataSource = this.moziBindingSource;
            this.comboBoxMozi.DisplayMember = "NEV";
            this.comboBoxMozi.FormattingEnabled = true;
            this.comboBoxMozi.Location = new System.Drawing.Point(107, 251);
            this.comboBoxMozi.Name = "comboBoxMozi";
            this.comboBoxMozi.Size = new System.Drawing.Size(366, 21);
            this.comboBoxMozi.TabIndex = 5;
            // 
            // moziBindingSource
            // 
            this.moziBindingSource.DataSource = typeof(Alkalmazas.Mozi);
            // 
            // buttonVarosMoziNap
            // 
            this.buttonVarosMoziNap.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonVarosMoziNap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVarosMoziNap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonVarosMoziNap.FlatAppearance.BorderSize = 2;
            this.buttonVarosMoziNap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonVarosMoziNap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarosMoziNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVarosMoziNap.Location = new System.Drawing.Point(375, 486);
            this.buttonVarosMoziNap.Name = "buttonVarosMoziNap";
            this.buttonVarosMoziNap.Size = new System.Drawing.Size(123, 40);
            this.buttonVarosMoziNap.TabIndex = 6;
            this.buttonVarosMoziNap.Text = "Tovább";
            this.buttonVarosMoziNap.UseVisualStyleBackColor = false;
            this.buttonVarosMoziNap.Click += new System.EventHandler(this.buttonVarosMoziNap_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(54, 486);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moziBindingSource, "MOZI_PK", true));
            this.label4.Location = new System.Drawing.Point(438, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.napBindingSource, "NAP_PK", true));
            this.label5.Location = new System.Drawing.Point(142, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // UCVarosMoziNap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonVarosMoziNap);
            this.Controls.Add(this.comboBoxMozi);
            this.Controls.Add(this.comboBoxNap);
            this.Controls.Add(this.comboBoxVaros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "UCVarosMoziNap";
            this.Size = new System.Drawing.Size(554, 707);
            ((System.ComponentModel.ISupportInitialize)(this.városBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moziBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNap;
        private System.Windows.Forms.BindingSource városBindingSource;
        private System.Windows.Forms.BindingSource napBindingSource;
        private System.Windows.Forms.BindingSource moziBindingSource;
        private System.Windows.Forms.Button buttonVarosMoziNap;
        public System.Windows.Forms.ComboBox comboBoxMozi;
        public System.Windows.Forms.ComboBox comboBoxVaros;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
