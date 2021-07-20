using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkalmazas
{

    public partial class UCVarosMoziNap : UserControl
    {
        Database1Entities context = new Database1Entities();
        public int MoziID;
        public int NapID;
        public UCVarosMoziNap()
        {
            InitializeComponent();

            context.Város.Load();
            context.Mozi.Load();
            context.Nap.Load();
            városBindingSource.DataSource = context.Város.Local;
            moziBindingSource.DataSource = context.Mozi.Local;
            napBindingSource.DataSource = context.Nap.Local;
            comboBoxVaros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNap.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMozi.DropDownStyle = ComboBoxStyle.DropDownList;

            


        }

       public void comboBoxVaros_SelectedIndexChanged(object sender, EventArgs e)
       {
            if (comboBoxMozi.SelectedItem == null) return;

            Város kiválasztottmozi = (Város)comboBoxVaros.SelectedItem;

            var mozik = from x in context.Mozi
                        where x.VAROS_FK == kiválasztottmozi.VÁROS_PK
                        select x;
            moziBindingSource.DataSource = mozik.ToList();
            
        }

        public void buttonVarosMoziNap_Click(object sender, EventArgs e)
        {
            
            UCVetitesek uc2 = new UCVetitesek(comboBoxMozi.Text, int.Parse(label4.Text),int.Parse(label5.Text));
            this.Controls.Add(uc2);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            comboBoxMozi.Visible = false;
            comboBoxNap.Visible = false;
            comboBoxVaros.Visible = false;
            buttonVarosMoziNap.Visible = false;
            buttonCancel.Visible = false;
            uc2.Combobox = comboBoxNap.Text;
            MoziID = int.Parse(label4.Text);
            Console.WriteLine(MoziID);
            NapID = int.Parse(label5.Text);
            Console.WriteLine(NapID);
            label4.Visible = false;
            label5.Visible = false;
            }
        public string Combobox1
        {
            get { return comboBoxNap.Text; }
        }




        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ((Form1)this.TopLevelControl).Close();
        }

        
    }
}
