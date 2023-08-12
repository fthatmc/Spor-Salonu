using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALayer;
using EntityLayer;
using LogicLayer;
using Context = DALayer.Context;


namespace Spor_Salonu
{
    public partial class FrmUserSavePage : Form
    {
        ResponsModel<Users> response = new ResponsModel<Users>();
        public FrmUserSavePage()
        {
            InitializeComponent();
        }
        BLUsers us = new BLUsers();

        //public FrmUserSavePage(int id, string adı, string soyadı, string sifre, int departmantid)
        //{
        //    InitializeComponent();

        //    Txtid.Text = id.ToString();
        //    TxtName.Text = adı;
        //    TxtSurName.Text = soyadı;
        //    TxtPassword.Text = sifre;
        //    TxtDepartmanid.Text = departmantid.ToString();
        //    this.Text = "Kullanıcı Güncelle";
        //    button1.Text = "Güncelle";

        //}
        private void button1_Click(object sender, EventArgs e)//btnEKLE
        {
            
            if (Txtid.Text == "-1")
            {
                Kaydet();
            }
            else
            {
                Güncelle();
            }
        }

        public int SelectedValue;//buraya bak bu form da comboxı getir.
        private void Kaydet()
        {
            Users user = new Users();
            user.Name = TxtName.Text;
            user.SurName = TxtSurName.Text;
            user.Password = TxtPassword.Text;
            user.DepartmentId = Convert.ToInt32(TxtDepartmanid.Text);
            //user.Department = TxtDepartmanAdi.Text;
            response = us.Add(user);

            if (!response.IsSuccess) MessageBox.Show(response.ErrorMessage, "HATA");
            else
            {
                MessageBox.Show("Yeni Kullanıcı Eklendi.", "KAYIT");
                var Form = (FrmUserMainPage)Application.OpenForms["FrmUserMainPage"];
                if (Form != null)
                {
                    Form.ListeGetir();
                }
               
            }         

            
        }
        private void Güncelle()
        {
            //Users userg = new Users();
            //userg.id = Convert.ToInt32(Txtid.Text);
            //userg.Name = TxtName.Text;
            //userg.SurName = TxtSurName.Text;
            //userg.Password = TxtPassword.Text;
            //userg.DepartmentId = Convert.ToInt32(TxtDepartmanid.Text);
            //us.Update(userg);
            //var Form = (FrmUserMainPage)Application.OpenForms["FrmUserMainPage"];
            //if (Form != null)
            //{
            //    Form.ListeGetir();
            //}
        }


    }
}
