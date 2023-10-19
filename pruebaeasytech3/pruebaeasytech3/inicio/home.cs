using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_TIC_3RO
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btncomenzar_Click(object sender, EventArgs e)
        {
            welcome ventana = new welcome();
            ventana.Show();
            this.Hide();
        }
    }
}
