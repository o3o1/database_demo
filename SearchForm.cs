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
    public partial class SearchForm : Form
    {
        List<string> conType = [];
        List<string> cons = [];
        string logic = "";
        bool exitflag = false;
        public SearchForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "" || textBox1.Text == "") && (comboBox2.Text == "" || textBox2.Text == ""))
            {
                exitflag = false;
                this.Close();
            }
            else if (comboBox1.Text != "" && textBox1.Text != "")
            {
                if (comboBox2.Text != "" && textBox2.Text != "")
                {
                    conType.Add(comboBox1.Text);
                    cons.Add(textBox1.Text);
                    conType.Add(comboBox2.Text);
                    cons.Add(textBox2.Text);
                    logic = comboBox4.Text;
                    exitflag = true;
                    this.Close();
                }
                else
                {
                    conType.Add(comboBox1.Text);
                    cons.Add(textBox1.Text);
                    exitflag = true;
                    this.Close();
                }
            }
            else 
            {
                conType.Add(comboBox2.Text);
                cons.Add(textBox2.Text);
                exitflag = true;
                this.Close();
            }
        }
        public List<string> GetConType()
        {
            return conType;
        }
        public List<string> GetCons()
        {
            return cons;
        }
        public string GetLogic()
        {
            return logic;
        }
        public bool GetExitFlag()
        {
            return exitflag;
        }
    }
}
