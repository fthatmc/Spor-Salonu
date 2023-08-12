using DALayer;
using EntityLayer;
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
    public partial class FrmUserMainPage : Form
    {
        public FrmUserMainPage()
        {
            InitializeComponent();
        }
        BLUsers BLus = new BLUsers();
        BLDepertment BLDep = new BLDepertment();

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }
        
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            FrmUserSavePage frm = new FrmUserSavePage();
            frm.SelectedValue = int.Parse(CmbDepartman.SelectedValue.ToString());
            frm.Show();
        }

        public void ListeGetir()
        {
            //dataGridView1.DataSource =BLus.GetAll();

            ResponsModel<Users> response = BLus.GetAll();
            if (!response.IsSuccess) MessageBox.Show(response.ErrorMessage, "HATA");
            else dataGridView1.DataSource = response.ResponseList;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = MessageBox.Show("Kullanıcıyı Güncellemek İstediğinize Emin Misiniz ?", "Kullanıcı Güncelleme", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Users usg = new Users();
                    usg.id = int.Parse(TxtKullanıcıid.Text);
                    usg.Name = TxtAdi.Text;
                    usg.SurName = TxtSoyadi.Text;
                    usg.Password = TxtSifre.Text;
                    usg.DepartmentId = int.Parse(CmbDepartman.SelectedValue.ToString());
                    BLus.Update(usg);

                    MessageBox.Show("Kayıt Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeGetir();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA");
            }


            


            //FrmUserSavePage frm = new FrmUserSavePage(Convert.ToInt32(TxtKullanıcıid.Text), TxtAdi.Text, TxtSoyadi.Text, TxtSifre.Text, Convert.ToInt32(TxtDepartmanID.Text));
            //frm.Show();
        }
        
        private void FrmUserMainPage_Load(object sender, EventArgs e)
        {
            ListeGetir();
            
            CmbDepartman.DisplayMember = "Name"; // DisplayMember görünen üye
            CmbDepartman.ValueMember = "id"; //Arka plandaki üye değeri
            ResponsModel<Departmans> respons = BLDep.GetAll();
            if (!respons.IsSuccess) MessageBox.Show(respons.ErrorMessage, "HATA");
            else CmbDepartman.DataSource = respons.ResponseList;

            //Users user = new Users();
            //CmbDepartman.SelectedValue = user.Department;

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKullanıcıid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtDeparrtmanid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
         

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = MessageBox.Show("Kullanıcıyı Silmek İstediğinize Emin Misiniz ?", "Kullanıcı Silme", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    BLus.Delete(int.Parse(TxtKullanıcıid.Text));
                    MessageBox.Show("Kayıt Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeGetir();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA");
            }
 
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
  
            dataGridView1.DataSource = BLus.GetAll(int.Parse(TxtAra.Text));
        }
    }
}
