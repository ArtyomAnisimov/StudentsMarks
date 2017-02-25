using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsMarksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsMarksDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.studentsMarksDataSet.Группы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Data Source=DESKTOP-GSM02UG\BDMSSQLSERVER12;Initial Catalog=StudentsMarks;Integrated Security=True
            StudentsMarks.Program.ConnectionString = "Data Source=DESKTOP-GSM02UG\\BDMSSQLSERVER12;Initial Catalog=StudentsMarks;Integrated Security=True";

            StudentsMarks.Program.str2 =
                this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            StudentsMarks.Program.SQLstr =
                "SELECT * FROM dbo.Студенты where (dbo.Студенты.[ID Группы]=" + StudentsMarks.Program.str2 +")";
            Form2 Students = new Form2();
            Students.Show();
            /*
             WindowsFormsApplication108.Program.str2 = this.подразделенияDataGridView.Rows[this.подразделенияDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            WindowsFormsApplication108.Program.SQLstr = "SELECT ID, ПодразделениеID, Наименование, СотрудникID, СетевоеИмя, IPАдрес, Домен, ПО FROM dbo.РабМесто where (ПодразделениеID=" +
                WindowsFormsApplication108.Program.str2 +")";
             */
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            StudentsMarks.Program.ConnectionString = "Data Source=DESKTOP-GSM02UG\\BDMSSQLSERVER12;Initial Catalog=StudentsMarks;Integrated Security=True";

            StudentsMarks.Program.str2 =
                this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            this.группыGridControl.FocusedView.GetRow(0).ToString();
            StudentsMarks.Program.SQLstr =
                "SELECT * FROM dbo.Студенты where (dbo.Студенты.[ID Группы]=" + StudentsMarks.Program.str2 + ")";
            Form2 Students = new Form2();
            Students.Show();

        }
    }
}
