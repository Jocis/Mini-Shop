using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Parduotuve pridetiForma = new Parduotuve();
            pridetiForma.KeistiLanga += KeistiForma;
            pridetiForma.TopLevel = false;
            mainFormP.Controls.Add(pridetiForma);
            pridetiForma.Show();
        }

        public void KeistiForma(Form form)
        {
            form.TopLevel = false;
            mainFormP.Controls.Clear();
            mainFormP.Controls.Add(form);
            form.Show();
        }
    }
}
