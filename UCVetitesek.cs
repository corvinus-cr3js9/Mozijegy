using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alkalmazas
{
    public partial class UCVetitesek : UserControl
    {
        Database1Entities context = new Database1Entities();
        private int AktuálisMozi;
        private int AktuálisNap;
        public  UCVetitesek(string moziszöveg, int MoziID, int NapID)
        {
            InitializeComponent();

            context.Műfaj.Load();
            context.Film.Load();
            context.Vetítés.Load();
            műfajBindingSource.DataSource = context.Műfaj.Local;
            filmBindingSource.DataSource = context.Film.Local;
            vetítésBindingSource.DataSource = context.Vetítés.Local;
            this.labelMozi.Text = moziszöveg;
            AktuálisMozi = MoziID;
            AktuálisNap = NapID;
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            Műfaj műfajok = (Műfaj)comboBox1.SelectedItem;
            
            var kiválasztottműfaj = from x in context.Film
                                    where x.MUFAJ_FK == műfajok.MUFAJ_PK 
                                    select x;
            filmBindingSource.DataSource = kiválasztottműfaj.ToList();

        }
        
        private void listBoxFilmek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilmek.SelectedItem == null) return;
            
            Film kiválasztottFilm = (Film)listBoxFilmek.SelectedItem;
            

            var vetitesek = from x in context.Vetítés
                            where x.FILM_FK == kiválasztottFilm.FILM_PK && x.MOZI_FK == AktuálisMozi && x.NAP_FK == AktuálisNap
                            orderby x.IDOPONTOK_FK
                            select new Idopontok {
                                VETITES_ID = x.VETITES_PK,
                                IDOPONTOK = x.Időpont.IDOPONTOK
                            };
            IDOPONTOKbindingSource.DataSource = vetitesek.ToList();
              
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (listBoxIdopontok.SelectedItem == null)
            {
                MessageBox.Show("Kérem válasszon ki egy időpontot.");
                return;
            }
            FormAdatok f2 = new FormAdatok(int.Parse(labelVetítésID.Text));
           
            f2.ShowDialog();
            
            if (f2.buttonOKWasClicked == true)
            {
                
                Jegy j = new Jegy();
                j.VETITES_FK = int.Parse(labelVetítésID.Text);
                j.VENDEG_NEV = f2.textBoxNev.Text;
                j.KATEGORIA_FK = int.Parse(f2.labelKategoriaID.Text);
                context.Jegy.Add(j);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                context.SaveChanges();
                JegyekLista();

            }
            

        }
        
        private void JegyekLista()
        {
            if (listBoxIdopontok.SelectedItem == null) return;

            var jegyek = from x in context.Jegy
                         select new JegyVasarlas
                         {
                             JEGY_PK = x.JEGY_PK,
                             VETITES_FK = x.Vetítés.VETITES_PK,
                             CIM = x.Vetítés.Film.CIM,
                             IDOPONTOK= x.Vetítés.Időpont.IDOPONTOK,
                             VENDEG_NEV = x.VENDEG_NEV,
                             KATEGORIA_NEV = x.Kategória.NEV,
                             AR = x.Kategória.AR
                         };
            
            
            jegyvasarlasBindingSource.DataSource = jegyek.ToList();
            if (dataGridView1.Rows.Count<2)
            {
                return;
            }
            else
            {
                var összérték = (from x in jegyek select x.AR).Sum();

                textBoxFizetendo.Text = összérték.ToString();
            }


        }


        public string Combobox
        {
            set { labelNap.Text = value; }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                return;
            }
            else
            {
                var jegy_pk = ((JegyVasarlas)jegyvasarlasBindingSource.Current).JEGY_PK;

                var törlendő = (from x in context.Jegy
                                where x.JEGY_PK == jegy_pk
                                select x).FirstOrDefault();

                context.Jegy.Remove(törlendő);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                JegyekLista();
                
                
            }
            
        }
    }

    
}
