using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaeasytech3
{
    public partial class IN_configuracionandroid : Form
    {
        public IN_configuracionandroid()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            elegirappandroid ventana = new elegirappandroid();
            ventana.Show();
            this.Hide();
        }

        private void IN_configuracionandroid_Load(object sender, EventArgs e)
        {

        }
    }
}
