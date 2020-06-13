using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal_lotniczy
{
    public partial class FormTerminal : Form
    {
        bool wyjscie = false;
        public FormTerminal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            wyjscie = true;
            FormLoty o2 = new FormLoty();
            o2.Show();
            this.Close();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            wyjscie = true;
            FormRejestracja o3 = new FormRejestracja();
            o3.Show();
            this.Close();

        }

        private void FormTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!wyjscie)
            {
                Application.Exit();
            }
            else
            {
                wyjscie = false;
            }
        }

        private void FormTerminal_Load(object sender, EventArgs e)
        {
            if (Lot.ListaLotów.Count > 0)
            {
                int min = 10000;
                foreach (Lot lo in Lot.ListaLotów)
                {
                    if (lo.Cena<=min)
                    {
                        min = lo.Cena;
                    }
                }
                
                labelPromocja.Text = "U nas możesz latać już od: ";
                labelNajniższa.Text = min.ToString() + "zł";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

                
        }

        private void labelNajniższa_Click(object sender, EventArgs e)
        {

        }
    }
}
