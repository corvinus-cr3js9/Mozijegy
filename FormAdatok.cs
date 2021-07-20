using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkalmazas
{
    public partial class FormAdatok : Form
    {
        Database1Entities context = new Database1Entities();
        private int aktualVetID;
        public FormAdatok(int AktualisVetitesID)
        {
            InitializeComponent();

            context.Kategória.Load();
            kategóriaBindingSource.DataSource = context.Kategória.Local;

            aktualVetID = AktualisVetitesID;
            labelVetitesID.Text = aktualVetID.ToString();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool buttonOKWasClicked = false;
        private void buttonOK_Click(object sender, EventArgs e)
        {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dominik\4. félév\Szoftver-technológia II\Alkalmazas\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Jegy (VETITES_FK, VENDEG_NEV, KATEGORIA_FK) VALUES (@VETITES, @NEV, @KATEGORIA)", con);
                cmd.Parameters.Add("@VETITES", int.Parse(labelVetitesID.Text));
                cmd.Parameters.Add("@NEV", textBoxNev.Text);
                cmd.Parameters.Add("@KATEGORIA", int.Parse(labelKategoriaID.Text));
                cmd.ExecuteNonQuery();
            buttonOKWasClicked = true;
               

        }
        
        private void textBoxNev_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNev, "Írja be a vendég nevét.");
            }
        }

        private void textBoxNev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNev, "");
        }
    }
}
