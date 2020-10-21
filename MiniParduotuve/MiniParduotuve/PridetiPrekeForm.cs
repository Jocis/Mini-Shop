using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve
{
    public partial class PridetiPrekeForm : Form
    {
        public Action<Form> KeistiLanga;
        static SqlConnection sql;

        public PridetiPrekeForm(Action<Form> kl)
        {
            InitializeComponent();
            KeistiLanga = kl;
        }

        private void PatvirtintiNaujaPrekeBt_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\C#\\Pamokos\\10_22 atsiskaitymas\\MiniParduotuve\\MiniParduotuve\\Lenteles.mdf\";Integrated Security = True";
            sql = new SqlConnection(connectionString);

            string querry = "INSERT INTO Prekes(Pavadinimas, Kaina, Svoris, Nuotrauka) VALUES(@Pavadinimas, @Kaina, @Svoris, @Nuotrauka)";
            SqlCommand command = new SqlCommand(querry, sql);
            //Prekes ivedimas i duomenu baze.
            command.Parameters.AddWithValue("@Pavadinimas", PrekesPavadinimasTB.Text);
            command.Parameters.AddWithValue("@Kaina", PrekesKainaTB.Text);
            command.Parameters.AddWithValue("@Svoris", PrekesSvorisTB.Text);
            command.Parameters.AddWithValue("@Nuotrauka", NuotraukosPathTB.Text);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();

            KeistiLanga(new Parduotuve());
        }

        private void PridetiNuotraukaBt_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg)|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                PridetiPrekePB.Image = new Bitmap(open.FileName);
                // image file path  
                NuotraukosPathTB.Text = open.FileName;
            }
        }
    }
}
