namespace database_demo
{
    partial class ModifyForm
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
            Cancel = new Button();
            Confirm = new Button();
            ClassId = new Label();
            textBox4 = new TextBox();
            Age = new Label();
            textBox3 = new TextBox();
            StudentName = new Label();
            textBox2 = new TextBox();
            Id = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancel.Location = new Point(189, 235);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 42);
            Cancel.TabIndex = 19;
            Cancel.Text = "取消";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Confirm
            // 
            Confirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Confirm.Location = new Point(58, 235);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(75, 42);
            Confirm.TabIndex = 18;
            Confirm.Text = "确认";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // ClassId
            // 
            ClassId.AutoSize = true;
            ClassId.Location = new Point(32, 179);
            ClassId.Name = "ClassId";
            ClassId.Size = new Size(32, 17);
            ClassId.TabIndex = 17;
            ClassId.Text = "班级";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 16;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(32, 134);
            Age.Name = "Age";
            Age.Size = new Size(32, 17);
            Age.TabIndex = 15;
            Age.Text = "年龄";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 14;
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(32, 87);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(32, 17);
            StudentName.TabIndex = 13;
            StudentName.Text = "姓名";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 12;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(32, 42);
            Id.Name = "Id";
            Id.Size = new Size(32, 17);
            Id.TabIndex = 11;
            Id.Text = "学号";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 10;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 317);
            Controls.Add(Cancel);
            Controls.Add(Confirm);
            Controls.Add(ClassId);
            Controls.Add(textBox4);
            Controls.Add(Age);
            Controls.Add(textBox3);
            Controls.Add(StudentName);
            Controls.Add(textBox2);
            Controls.Add(Id);
            Controls.Add(textBox1);
            Name = "ModifyForm";
            Text = "修改";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button Confirm;
        private Label ClassId;
        private TextBox textBox4;
        private Label Age;
        private TextBox textBox3;
        private Label StudentName;
        private TextBox textBox2;
        private Label Id;
        private TextBox textBox1;
    }
}