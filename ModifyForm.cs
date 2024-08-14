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
    public partial class ModifyForm : Form
    {
        Student modifiedStudent;
        public ModifyForm(Student student)
        {
            InitializeComponent();
            modifiedStudent = student;
            textBox1.Text = student.Id.ToString();
            textBox2.Text = student.Name;
            textBox3.Text = student.Age.ToString();
            textBox4.Text = student.ClassId.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请输入所有信息");
                return;
            }
            else
            {
                modifiedStudent = new Student() { Id = Convert.ToInt32(textBox1.Text), Age = Convert.ToInt32(textBox3.Text), ClassId = Convert.ToInt32(textBox4.Text), Name = textBox2.Text };
                this.Close();
            }
        }
        public Student GetStudent()
        {
            return modifiedStudent;
        }
    }
}
