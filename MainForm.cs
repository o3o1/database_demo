using System.Data;
using System.Data.SQLite;

namespace database_demo
{
    public partial class MainForm : Form
    {
        //set the correct values for your database file path
        private readonly string myConnectionString = "Data Source=database.db";
        private Student selectedStudent = new()
        {
            Id = 0,
            Name = "",
            Age = 0,
            ClassId = 0
        };

        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine(Environment.CurrentDirectory);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshStudentData();
        }

        private void AddStudent(Student student)
        {
            using SQLiteConnection conn = new(myConnectionString);
            conn.Open();
            SQLiteCommand cmd = new();

            string addStr = $"INSERT INTO students VALUES({student.Id}, '{student.Name}', {student.Age}, {student.ClassId});";
            cmd = new SQLiteCommand(addStr, conn);
            try { cmd.ExecuteNonQuery(); }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ModifyStudent(Student oldStudent, Student newStudent)
        {
            using SQLiteConnection conn = new(myConnectionString);
            conn.Open();
            SQLiteCommand cmd = new();

            string modStr = $"UPDATE students SET Id={newStudent.Id}, StudentName='{newStudent.Name}', Age={newStudent.Age}, ClassID={newStudent.ClassId} WHERE Id={oldStudent.Id} AND StudentName='{oldStudent.Name}' AND Age={oldStudent.Age} AND ClassID={oldStudent.ClassId};";
            cmd = new SQLiteCommand(modStr, conn);
            try { cmd.ExecuteNonQuery(); }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshStudentData()
        {
            using SQLiteConnection conn = new(myConnectionString);
            conn.Open();
            SQLiteCommand cmd = new();

            string queryStr = "SELECT * FROM students;";
            cmd = new SQLiteCommand(queryStr, conn);
            SQLiteDataAdapter adapter = new(cmd);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            dgStudent.DataSource = dataTable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.ShowDialog();
            Student new_student = addForm.GetStudent();
            if (new_student.Id != 0 || new_student.Name != null || new_student.Age != 0 || new_student.ClassId != 0)
            { AddStudent(new_student); }
            RefreshStudentData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgStudent.SelectedRows.Count > 1 || (dgStudent.SelectedRows.Count == 1 && dgStudent.SelectedRows[0].Cells[0].Value != null))
            {
                using SQLiteConnection conn = new(myConnectionString);
                conn.Open();
                SQLiteCommand cmd = new();

                DataGridViewRow selectedRow;
                int Id = -1;
                for (int i = 0; i < dgStudent.SelectedRows.Count; i++)
                {
                    selectedRow = dgStudent.SelectedRows[i];
                    Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string delStr = $"DELETE FROM students where Id={Id};";
                    cmd = new SQLiteCommand(delStr, conn);
                    cmd.ExecuteNonQuery();
                }
                RefreshStudentData();
            }
            else { MessageBox.Show("请选择需要删除的行"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new();
            searchForm.ShowDialog();
            bool exitflag = searchForm.GetExitFlag();
            try
            {
                if (exitflag)
                {
                    string seaStr;
                    List<string> conType = searchForm.GetConType();
                    List<string> cons = searchForm.GetCons();
                    string logic = searchForm.GetLogic();
                    if (conType.Count == 1)
                    {
                        switch (conType[0])
                        {
                            case "学号":
                                conType[0] = "Id";
                                break;
                            case "姓名":
                                conType[0] = "StudentName";
                                break;
                            case "年龄":
                                conType[0] = "Age";
                                break;
                            case "班级":
                                conType[0] = "ClassId";
                                break;
                            default:
                                break;
                        }
                        seaStr = $"SELECT * FROM students WHERE {conType[0]} = '{cons[0]}';";
                    }
                    else
                    {
                        switch (conType[0])
                        {
                            case "学号":
                                conType[0] = "Id";
                                break;
                            case "姓名":
                                conType[0] = "StudentName";
                                break;
                            case "年龄":
                                conType[0] = "Age";
                                break;
                            case "班级":
                                conType[0] = "ClassId";
                                break;
                            default:
                                break;
                        }
                        switch (conType[1])
                        {
                            case "学号":
                                conType[1] = "Id";
                                break;
                            case "姓名":
                                conType[1] = "StudentName";
                                break;
                            case "年龄":
                                conType[1] = "Age";
                                break;
                            case "班级":
                                conType[1] = "ClassId";
                                break;
                            default:
                                break;
                        }
                        switch (logic)
                        {
                            case "与":
                                logic = "AND";
                                break;
                            case "或":
                                logic = "OR";
                                break;
                            default:
                                break;
                        }
                        seaStr = $"SELECT * FROM students WHERE {conType[0]} = '{cons[0]}' {logic} {conType[1]} = '{cons[1]}';";
                    }
                    using SQLiteConnection conn = new(myConnectionString);
                    conn.Open();
                    SQLiteCommand cmd = new();
                    cmd = new SQLiteCommand(seaStr, conn);
                    SQLiteDataAdapter adapter = new(cmd);
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);
                    dgStudent.DataSource = dataTable;
                }
                else
                {
                    RefreshStudentData();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgStudent.SelectedRows.Count > 1)
            {
                MessageBox.Show("请选择一行进行修改");
                return;
            }
            else if (dgStudent.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("请选择有效的一行");
                return;
            }
            else 
            {
                DataGridViewRow selectedRow = dgStudent.SelectedRows[0];
                selectedStudent = new()
                {
                    Id = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Name = selectedRow.Cells[1].Value.ToString(),
                    Age = Convert.ToInt32(selectedRow.Cells[2].Value),
                    ClassId = Convert.ToInt32(selectedRow.Cells[3].Value)
                };
                ModifyForm modifyForm = new(selectedStudent);
                modifyForm.ShowDialog();
                Student modifiedStudent = modifyForm.GetStudent();
                ModifyStudent(selectedStudent, modifiedStudent);
                RefreshStudentData();
            }  
        }
    }
}
