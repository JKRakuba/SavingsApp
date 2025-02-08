using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Windows.Forms;

using System.IO;
namespace Savings
{
    public partial class Savings : Form
    {
        Button buttonCalculate;
        TextBox textBoxAmount;
        TextBox textBoxDate;
        TextBox textBoxInterestRate;

        Label labelAmount;
        Label labelDate;
        Label labelInterest;

        public Savings()
        {
            textBoxAmount = new TextBox();
            textBoxAmount.Location = new Point(10, 90);
            textBoxAmount.Size = new Size(150, 10);
            textBoxAmount.Text = "100000.00";
            this.Controls.Add(textBoxAmount);
           

            textBoxDate = new TextBox();
            textBoxDate.Location = new Point(10, 60);
            textBoxDate.Size = new Size(150, 10);
            textBoxDate.Text = "20.06.2022";
            this.Controls.Add(textBoxAmount);

            textBoxInterestRate = new TextBox();
            textBoxInterestRate.Location = new Point(10, 60);
            textBoxInterestRate.Size = new Size(150, 10);
            textBoxInterestRate.Text = "0.15";
            this.Controls.Add(textBoxInterestRate);

            //Create interest label

            labelAmount = new Label();
            labelAmount.Location = new Point(10, 5);
            labelAmount.Size = new Size(144, 15);
            labelAmount.Text = "Amount";
            this.Controls.Add(labelAmount);

            //Create interest label

            labelDate = new Label();
            labelDate.Location = new Point(10, 5);
            labelDate.Size = new Size(144, 15);
            labelDate.Text = "Date";
            this.Controls.Add(labelAmount);

            //Create interest label

            labelInterest = new Label();
            labelInterest.Location = new Point(10, 135);
            labelInterest.Size = new Size(144, 15);
            labelInterest.Text = "Interest";
            this.Controls.Add(labelInterest);

        }

        //Event handler for calculate button

        private void buttonCalculate_Click(object sender, System.EventArgs e)
        {

            double prin = Convert.ToDouble(textBoxAmount.Text);
            double rate = Convert.ToDouble(textBoxInterestRate.Text);

            double amt = prin * rate;
            string ans = amt.ToString();
            textBoxInterestRate.Text = ans;
        }

        public static void Main(string[] args)
        {
            Application.Run(new Savings());



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_1Keydown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}