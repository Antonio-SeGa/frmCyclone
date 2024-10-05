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
    public partial class frmLogin : Form
    {
        private CapaNegocio.FN_Login objFNLogin = new CapaNegocio.FN_Login();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            try 
            {
                //Mandar parametros recibidos por las cajas de texto
               objFNLogin.parLogueo(txtUser.Text, txtPass.Text);
                
                if (objFNLogin.log() == true)
                {
                    //Cerrar el fromulario de login
                    //abrir el fromulario de login
                    frmMenu openFrmMenu = new frmMenu();                  
                    openFrmMenu.Show();                    
                    this.Hide();
                }
                else {
                    clearBtns();
                }
                
                
            }
            //Cachear un error presentado
            catch (Exception ex) {
                MessageBox.Show(ex.Message,
                                "Login Suceso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }         
        }

        public void clearBtns() 
        {
            txtPass.Clear();
            txtUser.Clear();
        }
    }
}
