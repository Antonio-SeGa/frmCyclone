using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCyclone
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuExploiter_Click(object sender, EventArgs e)
        {
            //Abrir el fromulario
            Form frmExploiter = new frmExploiter();
            //Ocultar el formulario
            frmExploiter.Show();
        }
    }
}
