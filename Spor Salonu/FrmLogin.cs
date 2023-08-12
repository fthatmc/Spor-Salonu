using DALayer.Migrations;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_Salonu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        BLUsers BLUsers = new BLUsers();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (BLUsers.login(TxtName.Text, TxtPassword.Text)) 
            {
                MessageBox.Show("Hoş Geldiniz");
                FrmUserMainPage frm = new FrmUserMainPage();
                frm.Show();
            }
            else MessageBox.Show("Hatalı Kullanıcı && Parola");
        }
    }
}
