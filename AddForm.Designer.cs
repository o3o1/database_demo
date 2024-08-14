
namespace database_demo
{
    partial class AddForm
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
            textBox1 = new TextBox();
            Id = new Label();
            StudentName = new Label();
            textBox2 = new TextBox();
            ClassId = new Label();
            textBox3 = new TextBox();
            Age = new Label();
            textBox4 = new TextBox();
            Confirm = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(32, 42);
            Id.Name = "Id";
            Id.Size = new Size(32, 17);
            Id.TabIndex = 1;
            Id.Text = "学号";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(32, 87);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(32, 17);
            StudentName.TabIndex = 3;
            StudentName.Text = "姓名";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 2;
            // 
            // ClassId
            // 
            ClassId.AutoSize = true;
            ClassId.Location = new Point(32, 179);
            ClassId.Name = "ClassId";
            ClassId.Size = new Size(32, 17);
            ClassId.TabIndex = 7;
            ClassId.Text = "班级";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 6;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(32, 134);
            Age.Name = "Age";
            Age.Size = new Size(32, 17);
            Age.TabIndex = 5;
            Age.Text = "年龄";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 4;
            // 
            // Confirm
            // 
            Confirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Confirm.Location = new Point(58, 235);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(75, 42);
            Confirm.TabIndex = 8;
            Confirm.Text = "确认";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // Cancel
            // 
            Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancel.Location = new Point(189, 235);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 42);
            Cancel.TabIndex = 9;
            Cancel.Text = "取消";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 317);
            Controls.Add(Cancel);
            Controls.Add(Confirm);
            Controls.Add(ClassId);
            Controls.Add(textBox3);
            Controls.Add(Age);
            Controls.Add(textBox4);
            Controls.Add(StudentName);
            Controls.Add(textBox2);
            Controls.Add(Id);
            Controls.Add(textBox1);
            Name = "AddForm";
            Text = "添加";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Id;
        private Label StudentName;
        private TextBox textBox2;
        private Label ClassId;
        private TextBox textBox3;
        private Label Age;
        private TextBox textBox4;
        private Button Confirm;
        private Button Cancel;
    }
}