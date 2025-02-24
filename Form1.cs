using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_CanChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chiArr = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            string giatritrave= canArr[Convert.ToInt32(txtNam.Text)%10]+ " " + chiArr[Convert.ToInt32(txtNam.Text) % 12];
            txtCanChi.Text=giatritrave;
            for (int i = 2000; i <= 2050; i++)
            {
                lstKq.Items.Add(i + "-" + canArr[i % 10] + "" + chiArr[i % 12]);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        } 
        
        
        
    }
}
