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
    public partial class stickers : Form
    {
        public stickers()
        {
            InitializeComponent();
        }

        private void btnstickers_Click(object sender, EventArgs e)
        {
            lolograste ventana = new lolograste();
            ventana.Show();
            this.Hide();
        }
    }
}
