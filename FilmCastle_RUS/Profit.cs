using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilmCastle
{
    public partial class Profit : Form
    {

        public Profit(int data, int saled)
        {
            InitializeComponent();
            this.data = data;
            this.saled = saled;
        }
        int data { get; set; }
        int saled { get; set; }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Profit_Load(object sender, EventArgs e)
        {
            int expenseall=data;
            int saledall=saled;
            

            StreamReader sr = new StreamReader("Expense.txt");
            expenseall += Convert.ToInt32(sr.ReadLine());
            sr.Close();

            StreamReader srt = new StreamReader("Profit.txt");
            saledall += Convert.ToInt32(srt.ReadLine());
            srt.Close();
            int profit = saledall - expenseall;
            ProfitBox.Text = Convert.ToString(profit);
            EarnedBox.Text = Convert.ToString(saledall);
            SpendedBox.Text = Convert.ToString(expenseall);
            this.chart.Series["Profit"].Points.AddXY("",profit);
            this.chart.Series["Spended money"].Points.AddXY("", expenseall);
            this.chart.Series["Earnings"].Points.AddXY("", saledall);
            StreamWriter sw = new StreamWriter("Expense.txt");
            sw.WriteLine(expenseall);
            sw.Close();
            
            StreamWriter swt = new StreamWriter("Profit.txt");
            swt.WriteLine(saledall);
            swt.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Expense.txt");
            sw.WriteLine("0");
            sw.Close();

            StreamWriter swt = new StreamWriter("Profit.txt");
            swt.WriteLine("0");
            swt.Close();
            Close();
        }
    }
}
