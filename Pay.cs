using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_OOP.Parking
{
    public partial class Pay : Form

    {
        public Pay()
        {
            InitializeComponent();
        }
        Codepay coupon = new Codepay();
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string totalcoupon = this.textBox1.Text;
            double Coupon = Convert.ToDouble(totalcoupon);
            coupon.create(Coupon);

            double totalCoupon = coupon.getCoupon();
            textBox2.Text = totalCoupon.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pay = this.textBox2.Text;
            string money = this.textBox3.Text;
            double Pay = Convert.ToDouble(pay);
            double getMoney = Convert.ToDouble(money);
           if(getMoney>=Pay)
           {
                double chang = getMoney-Pay;
                MessageBox.Show("ชำระเงินสำเร็จ"); 
                textBox4.Text = chang.ToString();
           }
            else
            {
                Exception ex;
                MessageBox.Show("จำนวนเงินไม่เพียงพอไม่สามารถชำระเงินได้");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.price = textBox4.Text;
            m.money= textBox1.Text;
            m.code = textBox2.Text;
            m.ShowDialog();
           
      
            
        }
    }
}
