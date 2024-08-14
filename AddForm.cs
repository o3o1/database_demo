using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_demo
{
    public partial class AddForm : Form
    {
        Student new_student = new();
        public AddForm()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请输入所有信息");
                return;
            }
            else 
            {
                new_student = new Student() { Id = Convert.ToInt32(textBox1.Text), Age = Convert.ToInt32(textBox4.Text), ClassId = Convert.ToInt32(textBox3.Text), Name = textBox2.Text };
                this.Close();
            }
        }
        public Student GetStudent()
        {
            return new_student;
        }
    }
}
