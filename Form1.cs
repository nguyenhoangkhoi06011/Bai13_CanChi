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

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstKq.Items.Add("Năm 2000 - Canh Thìn");
            lstKq.Items.Add("Năm 2001 - Tân Tỵ");
            lstKq.Items.Add("Năm 2002 - Nhâm Ngọ");
            lstKq.Items.Add("Năm 2003 - Quý Mùi");
            lstKq.Items.Add("Năm 2004 - Giáp Thân");
            lstKq.Items.Add("Năm 2005 - Ất Dậu");
            lstKq.Items.Add("Năm 2006 - Bính Tuất");
            lstKq.Items.Add("Năm 2007 - Đinh Hợi");
            lstKq.Items.Add("Năm 2008 - Mậu Tý");
            lstKq.Items.Add("Năm 2009 - Kỷ Sửu");
            lstKq.Items.Add("Năm 2010 - Canh Dần");
            lstKq.Items.Add("Năm 2011 - Tân Mão");
            lstKq.Items.Add("Năm 2012 - Nhâm Thìn");
            lstKq.Items.Add("Năm 2013 - Quý Tỵ");
            lstKq.Items.Add("Năm 2014 - Giáp Ngọ");
            lstKq.Items.Add("Năm 2015 - Ất Mùi");
            lstKq.Items.Add("Năm 2016 - Bính Thân");
            lstKq.Items.Add("Năm 2017 - Đinh Dậu");
            lstKq.Items.Add("Năm 2018 - Mậu Tuất");
            lstKq.Items.Add("Năm 2019 - Kỷ Hợi");
            lstKq.Items.Add("Năm 2020 - Canh Tý");
            lstKq.Items.Add("Năm 2021 - Tân Sửu");
            lstKq.Items.Add("Năm 2022 - Nhâm Dần");
            lstKq.Items.Add("Năm 2023 - Quý Mão");
            lstKq.Items.Add("Năm 2024 - Giáp Thìn");
            lstKq.Items.Add("Năm 2025 - Ất Tỵ");
            lstKq.Items.Add("Năm 2026 - Bính Ngọ");
            lstKq.Items.Add("Năm 2027 - Đinh Mùi");
            lstKq.Items.Add("Năm 2028 - Mậu Thân");
            lstKq.Items.Add("Năm 2029 - Kỷ Dậu");
            lstKq.Items.Add("Năm 2030 - Canh Tuất");
            lstKq.Items.Add("Năm 2031 - Tân Hợi");
            lstKq.Items.Add("Năm 2032 - Nhâm Tý");
            lstKq.Items.Add("Năm 2033 - Quý Sửu");
            lstKq.Items.Add("Năm 2034 - Giáp Dần");
            lstKq.Items.Add("Năm 2035 - Ất Mão");
            lstKq.Items.Add("Năm 2036 - Bính Thìn");
            lstKq.Items.Add("Năm 2037 - Đinh Tỵ");
            lstKq.Items.Add("Năm 2038 - Mậu Ngọ");
            lstKq.Items.Add("Năm 2039 - Kỷ Mùi");
            lstKq.Items.Add("Năm 2040 - Canh Thân");
            lstKq.Items.Add("Năm 2041 - Tân Dậu");
            lstKq.Items.Add("Năm 2042 - Nhâm Tuất");
            lstKq.Items.Add("Năm 2043 - Quý Hợi");
            lstKq.Items.Add("Năm 2044 - Giáp Tý");
            lstKq.Items.Add("Năm 2045 - Ất Sửu");
            lstKq.Items.Add("Năm 2046 - Bính Dần");
            lstKq.Items.Add("Năm 2047 - Đinh Mão");
            lstKq.Items.Add("Năm 2048 - Mậu Thìn");
            lstKq.Items.Add("Năm 2049 - Kỷ Tỵ");
            lstKq.Items.Add("Năm 2050 - Canh Ngọ");


        }
    }
}
