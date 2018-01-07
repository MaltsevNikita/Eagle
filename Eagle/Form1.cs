using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eagle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uSERPASSWORDTableAdapter.Update(this.eagle202DataSet.USERPASSWORD);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.uSERPASSWORDTableAdapter.Fill(this.eagle202DataSet.USERPASSWORD);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Int32 s = Convert.ToInt32(dataGridView1[1, 2].Value);

            //Вытаскиваем из ячейки dataGridView значение и помещаем его в label
            //label1.Text = Convert.ToString(dataGridView1[1, 2].Value);
            //MessageBox.Show(Convert.ToString(s + 1));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaseFind_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(ToFind_textBox.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.uSERPASSWORDTableAdapter.Fill(this.eagle202DataSet.USERPASSWORD);
        }

        private void LoadData_button_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eagle202DataSet.USERPASSWORD". При необходимости она может быть перемещена или удалена.
            this.uSERPASSWORDTableAdapter.Fill(this.eagle202DataSet.USERPASSWORD);
            //=========================================================================================================
            dataGridView1.Rows[1].Cells[1].Style.BackColor = Color.Green;
            //=========================================================================================================
        }
    }
}
