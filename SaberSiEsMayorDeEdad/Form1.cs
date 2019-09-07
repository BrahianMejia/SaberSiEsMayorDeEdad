using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberSiEsMayorDeEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmayorono.Visible = false;
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            string edad = txtedad.Text;
            int saber = Convert.ToInt32(edad);

            if (saber >= 18)
            {
                lblmayorono.Text = "Eres mayor de edad.";
            }
            else
            {
                lblmayorono.Text = "No eres mayor de edad";
            }

            lblmayorono.Visible = true;
        }
    }
}
