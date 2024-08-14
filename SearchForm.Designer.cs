
namespace database_demo
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "学号", "姓名", "年龄", "班级" });
            comboBox1.Location = new Point(76, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 2;
            label1.Text = "条件1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 5;
            label2.Text = "条件2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "学号", "姓名", "年龄", "班级" });
            comboBox2.Location = new Point(76, 175);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "与", "或" });
            comboBox4.Location = new Point(23, 110);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 25);
            comboBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 41);
            label4.Name = "label4";
            label4.Size = new Size(17, 17);
            label4.TabIndex = 11;
            label4.Text = "=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 178);
            label5.Name = "label5";
            label5.Size = new Size(17, 17);
            label5.TabIndex = 12;
            label5.Text = "=";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(55, 246);
            button1.Name = "button1";
            button1.Size = new Size(89, 45);
            button1.TabIndex = 14;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(220, 246);
            button2.Name = "button2";
            button2.Size = new Size(89, 45);
            button2.TabIndex = 15;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 317);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "SearchForm";
            Text = "筛选";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}