using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentsMarks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsMarksDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsMarksDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            //this.студентыTableAdapter.Fill(this.studentsMarksDataSet.Студенты);
            /*
             SqlDataAdapter dA = new SqlDataAdapter(WindowsFormsApplication108.Program.SQLstr, WindowsFormsApplication108.Program.ConnectionString);
            dA.Fill(this.aC_InventoryDataSet,"РабМесто");
            this.рабМестоDataGridView.DataSource = this.aC_InventoryDataSet.Tables["РабМесто"].DefaultView;
             */
            SqlDataAdapter dA = new SqlDataAdapter(StudentsMarks.Program.SQLstr, StudentsMarks.Program.ConnectionString);
            dA.Fill(this.studentsMarksDataSet, "Студенты");
            this.dataGridView1.DataSource = this.studentsMarksDataSet.Tables["Студенты"].DefaultView;
            this.студентыGridControl.DataSource = this.studentsMarksDataSet.Tables["Студенты"].DefaultView;

        }
    }
}
