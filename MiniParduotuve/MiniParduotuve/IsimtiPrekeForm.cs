using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve
{
    public partial class IsimtiPrekeForm : Form
    {
        public Action<Form> KeistiLanga;
        static SqlConnection sql;

        public IsimtiPrekeForm(Action<Form> kl)
        {
            InitializeComponent();
            KeistiLanga = kl;
        }

        private void IsimtiPrekeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lentelesDataSet.Prekes' table. You can move, or remove it, as needed.
            this.prekesTableAdapter.Fill(this.lentelesDataSet.Prekes);
        }

        private void IsimtiPrekeBt_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\C#\\Pamokos\\10_22 atsiskaitymas\\MiniParduotuve\\MiniParduotuve\\Lenteles.mdf\";Integrated Security = True";
            sql = new SqlConnection(connectionString);

            string querry = "DELETE FROM Prekes WHERE Id = @Id";
            SqlCommand command = new SqlCommand(querry, sql);
            //Prekes ivedimas i duomenu baze.
            command.Parameters.AddWithValue("@Id", PrekesIdTB.Text);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();

            KeistiLanga(new Parduotuve());
        }
    }
}
