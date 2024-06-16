using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeNamespace
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string dept = textBox3.Text;
            string jTitle = textBox4.Text;
           

            PartTimeEmployee PTE = new PartTimeEmployee(fName, lName, dept, jTitle);

            PTE.computeSalary(Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox6.Text));

            label10.Text = fName.ToString();
            label11.Text = lName.ToString();
            label12.Text = PTE.BasicSalary.ToString();         

        }
    }
}
