using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCastle
{


    public partial class Form1 : Form
    {
            public static int PR;
            public static int Spends;
            public static int Investions;
        public Form1()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, EventArgs e)
        {
            PR = Convert.ToInt32(Logo.Text)+Convert.ToInt32(Ad.Text)+Convert.ToInt32(Web.Text)+Convert.ToInt32(App.Text)+Convert.ToInt32(Data.Text);
            Spends = Convert.ToInt32(Material.Text) + Convert.ToInt32(Staff.Text) + Convert.ToInt32(License.Text) + Convert.ToInt32(Equip.Text);
            Investions = Convert.ToInt32(Invest.Text)+Convert.ToInt32(Recruit.Text);

            Profit newForm = new Profit(PR+Spends,Investions);
            newForm.Show();
            //this.tabControl1.TabPages
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eqip_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_TextChanged(object sender, EventArgs e)
        {

        }

        private void License_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Eqip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Staff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void License_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Invest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Recruit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Logo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Web_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void App_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Invest_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recruit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void App_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Invest_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class Calculations
    {
        int Earnings;
        int Spends;
        int Profit;

    }
}
