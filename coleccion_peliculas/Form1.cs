using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coleccion_peliculas
{
    public partial class Form1 : Form
    {
        UserControl1 a = new UserControl1();
        UserControl2 b = new UserControl2();
        int c1 = 0, c2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Add(a);
            a.Show();
        }

        private void cambiopanel()
        {
            
        }

    }
}
