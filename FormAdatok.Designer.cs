
namespace Alkalmazas
{
    partial class FormAdatok
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdatok));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.comboBoxJegyTipus = new System.Windows.Forms.ComboBox();
            this.kategóriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelVetitesID = new System.Windows.Forms.Label();
            this.labelKategoriaID = new System.Windows.Forms.Label();
            this.jegyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kategóriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxNev
            // 
            resources.ApplyResources(this.textBoxNev, "textBoxNev");
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNev_Validating);
            this.textBoxNev.Validated += new System.EventHandler(this.textBoxNev_Validated);
            // 
            // comboBoxJegyTipus
            // 
            this.comboBoxJegyTipus.CausesValidation = false;
            this.comboBoxJegyTipus.DataSource = this.kategóriaBindingSource;
            this.comboBoxJegyTipus.DisplayMember = "NEV";
            this.comboBoxJegyTipus.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxJegyTipus, "comboBoxJegyTipus");
            this.comboBoxJegyTipus.Name = "comboBoxJegyTipus";
            // 
            // kategóriaBindingSource
            // 
            this.kategóriaBindingSource.DataSource = typeof(Alkalmazas.Kategória);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxAr
            // 
            this.textBoxAr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategóriaBindingSource, "AR", true));
            resources.ApplyResources(this.textBoxAr, "textBoxAr");
            this.textBoxAr.Name = "textBoxAr";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.LightPink;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightPink;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelVetitesID
            // 
            resources.ApplyResources(this.labelVetitesID, "labelVetitesID");
            this.labelVetitesID.Name = "labelVetitesID";
            // 
            // labelKategoriaID
            // 
            resources.ApplyResources(this.labelKategoriaID, "labelKategoriaID");
            this.labelKategoriaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategóriaBindingSource, "KATEGORIA_PK", true));
            this.labelKategoriaID.Name = "labelKategoriaID";
            // 
            // jegyBindingSource
            // 
            this.jegyBindingSource.DataSource = typeof(Alkalmazas.Jegy);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdatok
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxJegyTipus);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVetitesID);
            this.Controls.Add(this.labelKategoriaID);
            this.KeyPreview = true;
            this.Name = "FormAdatok";
            ((System.ComponentModel.ISupportInitialize)(this.kategóriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxJegyTipus;
        private System.Windows.Forms.BindingSource kategóriaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelVetitesID;
        private System.Windows.Forms.BindingSource jegyBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBoxNev;
        public System.Windows.Forms.Label labelKategoriaID;
    }
}