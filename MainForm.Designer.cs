namespace database_demo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgStudent = new DataGridView();
            panel1 = new Panel();
            btnModify = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgStudent
            // 
            dgStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgStudent.Location = new Point(12, 12);
            dgStudent.Name = "dgStudent";
            dgStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudent.Size = new Size(776, 333);
            dgStudent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(12, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 87);
            panel1.TabIndex = 1;
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnModify.Location = new Point(603, 23);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(117, 44);
            btnModify.TabIndex = 8;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(428, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 44);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "筛选";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(258, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 44);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(79, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "增加";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "学号（数字）";
            Column1.Name = "Column1";
            Column1.ToolTipText = "数字";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "StudentName";
            Column2.HeaderText = "姓名（字符串）";
            Column2.Name = "Column2";
            Column2.ToolTipText = "字符串";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.HeaderText = "年龄（数字）";
            Column3.Name = "Column3";
            Column3.ToolTipText = "数字";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ClassID";
            Column4.HeaderText = "班级（数字）";
            Column4.Name = "Column4";
            Column4.ToolTipText = "数字";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgStudent);
            Name = "MainForm";
            Text = "学生信息管理系统";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dgStudent;
        private Panel panel1;
        private Button btnModify;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
