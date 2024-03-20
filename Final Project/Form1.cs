using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CSV csv = new CSV();
        int hour;
        int result;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculation_Click(object sender, EventArgs e)
        {
            Calculation Natty = new Calculation();
            hour = int.Parse(doinghour.Text);
            result = Natty.calculator(hour);
            ResultCalculating.Text = result.ToString();


        }
        private void CSV_Click(object sender, EventArgs e)
        {
            string name = EmployeeName.Text;
            bool canWrite = csv.SavetoFile(name, hour, result);
            if (canWrite)
            {
                MessageBox.Show("เขียนไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("เขียนไฟล์ไม่สำเร็จ");
            }
        }

    }
}
    


