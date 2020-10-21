using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve
{
    public partial class Parduotuve : Form
    {
        public Action<Form> KeistiLanga;
        static SqlConnection sql;


        public Parduotuve()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\C#\\Pamokos\\10_22 atsiskaitymas\\MiniParduotuve\\MiniParduotuve\\Lenteles.mdf\";Integrated Security = True";
            sql = new SqlConnection(connectionString);
            InitializeComponent();
            double krepselioSvoris = 0;
            int kasDesimtasKg = 0;
            double kurjerioMokestis = 0;
            string kurjerioMokestisText = null;
            string svorioTekstas = null;
            string kainosTekstas = null;
            double suma = 0;


            // Pirmos prekes irasymas i panel.
            IrasymasIPirmosPrekesLabeliusIrPictureBoxus(1, PavadinimasL, SvorisL, KainaL, PrekesNuotraukaPB1);

            int vienetaiPrekiu1 = 1;
            PrekesVntTB.Text = $"{vienetaiPrekiu1}vnt.";

            string query1 = "SELECT Svoris, Kaina FROM Prekes WHERE Id = 1";
            SqlCommand command1 = new SqlCommand(query1, sql);
            sql.Open();
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                double pirmosPrekesKaina = Convert.ToDouble(reader1["Kaina"]);
                double prekiuSvoris = Convert.ToDouble(reader1["Svoris"]);
                string pirmosPrekesSvorisText = $"{reader1["Svoris"]}";
                string pirmosPrekesKainaText = $"{reader1["Kaina"]}";

                PridetiBt.Click += (s, e) => {
                    vienetaiPrekiu1++;
                    PrekesVntTB.Text = $"{vienetaiPrekiu1}vnt.";
                };

                AtimtiBt.Click += (s, e) => {
                    if (vienetaiPrekiu1 > 0)
                    {
                        vienetaiPrekiu1--;
                    }
                    PrekesVntTB.Text = $"{vienetaiPrekiu1}vnt.";
                };


                IKrepseliBt.Click += (s, e) => {

                    suma += vienetaiPrekiu1 * pirmosPrekesKaina;
                    GalutineKrepselioKainaTB.Text = suma.ToString();

                    krepselioSvoris += (vienetaiPrekiu1 * prekiuSvoris);
                    GalutinisKrepselioSvorisTB.Text = krepselioSvoris.ToString();

                    svorioTekstas = TextBoxSuSudetimiGeneravimasMetodas(svorioTekstas, vienetaiPrekiu1, pirmosPrekesSvorisText);
                    KrepselioSvorisTB.Text = svorioTekstas;

                    kainosTekstas = TextBoxSuSudetimiGeneravimasMetodas(kainosTekstas, vienetaiPrekiu1, pirmosPrekesKainaText);
                    KrepselioKainaTB.Text = kainosTekstas;

                    CheckBoxDisableMetodas(krepselioSvoris, PastasCB, KurjerisCB, PastomatasCB, TarptautinisKurjerisCB);
                };

                
            }
            sql.Close();



            // Visu prekiu isvedimas i panel.
            string query = "SELECT Pavadinimas, Svoris, Kaina, Nuotrauka FROM Prekes WHERE Id is not NULL AND Id != 1";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            int prekiuObjektuAtstumas = 270;

            while (reader.Read())
            {
                int vienetaiPrekiu = 1;
                // STATIC INFO-------------------------------------------------
                string outputString1 = $"{reader["Pavadinimas"]}";
                string outputString2 = $"Svoris: {reader["Svoris"]}";
                string outputString3 = $"Kaina: {reader["Kaina"]}€";
                string outputString4 = $"{reader["Nuotrauka"]}";
                double PasikartojanciosprekesKaina = Convert.ToDouble(reader["Kaina"]);
                double prekiuSvoris = Convert.ToDouble(reader["Svoris"]);
                string pasikartojanciosPrekesSvorisText = $"{reader["Svoris"]}";
                string pasikartojanciosPrekesKainaText = $"{reader["Kaina"]}";

                NaujuLabelAtkartojimoMetodas(PavadinimasL, PrekiuSarasasP, outputString1, prekiuObjektuAtstumas);
                NaujuLabelAtkartojimoMetodas(SvorisL, PrekiuSarasasP, outputString2, prekiuObjektuAtstumas);
                NaujuLabelAtkartojimoMetodas(KainaL, PrekiuSarasasP, outputString3, prekiuObjektuAtstumas);

                PictureBox naujasPictureBox = new PictureBox();
                naujasPictureBox.BackgroundImage = Image.FromFile(outputString4);
                naujasPictureBox.Size = PrekesNuotraukaPB1.Size;
                naujasPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                naujasPictureBox.Location = new Point(naujasPictureBox.Location.X + 200, naujasPictureBox.Location.Y + prekiuObjektuAtstumas);
                PrekiuSarasasP.Controls.Add(naujasPictureBox);

                // INTERACTION TOOLS---------------------------------------------------
                TextBox naujasTextBox = new TextBox();
                naujasTextBox.Text = $"{vienetaiPrekiu}vnt.";
                naujasTextBox.Size = PrekesVntTB.Size;
                naujasTextBox.Location = new Point(PrekesVntTB.Location.X, PrekesVntTB.Location.Y + prekiuObjektuAtstumas);
                PrekiuSarasasP.Controls.Add(naujasTextBox);

                Button naujasButton1 = new Button();
                MygtukuGeneravivasMetodas(naujasButton1, "+", PridetiBt, prekiuObjektuAtstumas, PrekiuSarasasP);
                naujasButton1.Click += (s, e) => {
                    vienetaiPrekiu++;
                    naujasTextBox.Text = $"{vienetaiPrekiu}vnt.";
                };

                Button naujasButton2 = new Button();
                MygtukuGeneravivasMetodas(naujasButton2, "-", AtimtiBt, prekiuObjektuAtstumas, PrekiuSarasasP);
                naujasButton2.Click += (s, e) => {
                    if (vienetaiPrekiu > 0)
                    {
                        vienetaiPrekiu--;
                    }
                    naujasTextBox.Text = $"{vienetaiPrekiu}vnt.";
                };

                Button naujasButton3 = new Button();
                MygtukuGeneravivasMetodas(naujasButton3, "I krepseli", IKrepseliBt, prekiuObjektuAtstumas, PrekiuSarasasP);
                naujasButton3.Click += (s, e) => {
                    suma += vienetaiPrekiu * PasikartojanciosprekesKaina;
                    GalutineKrepselioKainaTB.Text = suma.ToString();

                    krepselioSvoris += vienetaiPrekiu * prekiuSvoris;
                    GalutinisKrepselioSvorisTB.Text = krepselioSvoris.ToString();

                    svorioTekstas = TextBoxSuSudetimiGeneravimasMetodas(svorioTekstas, vienetaiPrekiu, pasikartojanciosPrekesSvorisText);
                    KrepselioSvorisTB.Text = svorioTekstas;

                    kainosTekstas = TextBoxSuSudetimiGeneravimasMetodas(kainosTekstas, vienetaiPrekiu, pasikartojanciosPrekesKainaText);
                    KrepselioKainaTB.Text = kainosTekstas;

                    CheckBoxDisableMetodas(krepselioSvoris, PastasCB, KurjerisCB, PastomatasCB, TarptautinisKurjerisCB);
                };

                prekiuObjektuAtstumas += 270;
            }
            
            sql.Close();

            OkCheckBoxBt.Click += (s, e) => {
                if (KurjerisCB.Checked == true)
                {
                    kurjerioMokestisText = KurjerioMokestiscountTextMetodas(kasDesimtasKg, krepselioSvoris, suma, kurjerioMokestis, kurjerioMokestisText, 0.03);
                    KurjerioMokestisTB.Text = kurjerioMokestisText;
                }
                else if (TarptautinisKurjerisCB.Checked == true)
                {
                    kurjerioMokestisText = KurjerioMokestiscountTextMetodas(kasDesimtasKg, krepselioSvoris, suma, kurjerioMokestis, kurjerioMokestisText, 0.05);
                    KurjerioMokestisTB.Text = kurjerioMokestisText;
                }
            };

            string pilnaKaina = null;
            SkaiciuotiBt.Click += (s, e) => {
                pilnaKaina = $"{Convert.ToDouble(kurjerioMokestisText) + suma}";
                PilnaKainaTB.Text = pilnaKaina;
            };

            MoketiBt.Click += (s, e) => {
                if (KurjerisCB.Checked == true || TarptautinisKurjerisCB.Checked == true)
                {
                    if (pilnaKaina != null && kurjerioMokestisText != null)
                    {
                        PabaigosMessageBoxMetodas(KeistiLanga);
                    }
                }
                else if (PastasCB.Checked == true || PastomatasCB.Checked == true)
                {
                    if (pilnaKaina != null)
                    {
                        PabaigosMessageBoxMetodas(KeistiLanga);
                    }
                }
                
            };
        }

        //----------------------------------------------------------
        public static void MygtukuGeneravivasMetodas(Button buttonName, string mygtukoText, Button atkartojamasMygtukas, int prekiuObjektuAtstumas, Panel panel)
        {
            buttonName.Text = mygtukoText;
            buttonName.Size = atkartojamasMygtukas.Size;
            buttonName.Location = new Point(atkartojamasMygtukas.Location.X, atkartojamasMygtukas.Location.Y + prekiuObjektuAtstumas);
            buttonName.UseVisualStyleBackColor = true;
            panel.Controls.Add(buttonName);
        }

        //----------------------------------------------------------
        public static string TextBoxSuSudetimiGeneravimasMetodas(string generuojamasTekstas, int vienetaiPrekiu, string dauginamaReiksme)
        {
            if (generuojamasTekstas == null)
            {
                return generuojamasTekstas += $"{vienetaiPrekiu} * {dauginamaReiksme}";
            }
            else
            {
                return generuojamasTekstas += $" + {vienetaiPrekiu} * {dauginamaReiksme}";
            }
        }

        //----------------------------------------------------------
        public static string KurjerioMokestiscountTextMetodas(double kasDesimtasKg, double krepselioSvoris, double suma,
            double kurjerioMokestis, string kurjerioMokestisText, double procentaiNuoKainos)
        {
            kasDesimtasKg = krepselioSvoris / 10;
            double procentaiNuoKrepselioKainos = suma * procentaiNuoKainos;
            kurjerioMokestis = procentaiNuoKrepselioKainos * kasDesimtasKg;
            return kurjerioMokestisText = kurjerioMokestis.ToString();
        }

        //----------------------------------------------------------
        public static void PabaigosMessageBoxMetodas(Action<Form> KeistiLanga)
        {
            string message = "Aciu, kad pirkote!";
            string title = "Mokejimas sekmingas";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(title, message, button);
            if (result == DialogResult.OK)
            {
                Parduotuve form = new Parduotuve();
                form.KeistiLanga = KeistiLanga;
                KeistiLanga(form);
            }
        }

        //----------------------------------------------------------
        private void PridetiPrekeBt_Click(object sender, EventArgs e)
        {
            KeistiLanga(new PridetiPrekeForm(KeistiLanga));
        }
        private void IsimtiPrekeBt_Click(object sender, EventArgs e)
        {
            KeistiLanga(new IsimtiPrekeForm(KeistiLanga));
        }

        //PIRMAI prekei metodai.--------------------------------------------------------------------------------------
        // Informacijos surasymas PIRMAI prekei metodas.
        public static void IrasymasIPirmosPrekesLabeliusIrPictureBoxus(int id, Label label1, Label label2, Label label3, PictureBox pictureBox)
        {

            string query = "SELECT Pavadinimas, Svoris, Kaina, Nuotrauka FROM Prekes WHERE Id = @a";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            command.Parameters.AddWithValue("@a", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string outputString1 = $"{reader["Pavadinimas"]}";
                string outputString2 = $"Svoris: {reader["Svoris"]}";
                string outputString3 = $"Kaina: {reader["Kaina"]}";
                string outputString4 = $"{reader["Nuotrauka"]}";
                label1.Text = outputString1;
                label2.Text = outputString2;
                label3.Text = outputString3;
                pictureBox.BackgroundImage = Image.FromFile(outputString4);
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            }
            sql.Close();
        }

        //LIKUSIOMS prekems metodai.---------------------------------------------------------------------------------
        // Informacijos surasymas LIKUSIOMS prekems metodas.
        public static void NaujuLabelAtkartojimoMetodas(Label atkartojamasLabel, Panel panel, string labelText, int atstumas)
        {
            Label naujasLabel = new Label();
            naujasLabel.Text = labelText;
            naujasLabel.Size = atkartojamasLabel.Size;
            naujasLabel.Location = new Point(atkartojamasLabel.Location.X, atkartojamasLabel.Location.Y + atstumas);
            panel.Controls.Add(naujasLabel);
        }

        // CHECK BOX.
        public static void CheckBoxDisableMetodas(double krepselioSvoris, CheckBox PastasCB, CheckBox KurjerisCB, CheckBox PastomatasCB, CheckBox TarptautinisSiuntimasCB)
        {
            if (krepselioSvoris < 5)
            {
                PastasCB.Enabled = true;
                KurjerisCB.Enabled = true;
                PastomatasCB.Enabled = true;
                TarptautinisSiuntimasCB.Enabled = true;
            }
            else if (krepselioSvoris < 10)
            {
                PastasCB.Enabled = true;
                KurjerisCB.Enabled = true;
                PastomatasCB.Enabled = false;
                TarptautinisSiuntimasCB.Enabled = true;
            }
            else
            {
                PastasCB.Enabled = false;
                KurjerisCB.Enabled = true;
                PastomatasCB.Enabled = false;
                TarptautinisSiuntimasCB.Enabled = true;
            }
        }
    }
}
