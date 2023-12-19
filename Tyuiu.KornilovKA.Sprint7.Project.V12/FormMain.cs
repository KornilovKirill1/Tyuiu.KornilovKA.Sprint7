using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KornilovKA.Sprint7.Project.V12.Lib;

namespace Tyuiu.KornilovKA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //openFileDialogTable_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            //saveFileDialogNewData_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            //dateTimePickerRelease_KKA.CustomFormat = "DD MM YYYY";
        }
        DataService ds = new DataService();
        string pathPersonalComputer = @"..\Back-end\personal_computer.csv";
        string pathSeller = @"..\Back-end\selling_company.csv";
        private void toolStripButtonInfoProgram_KKA_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void buttonAddNewPC_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                string[] row = new string[] { $"{textBoxManufacturer_KKA.Text}", $"{textBoxTypeCPU_KKA.Text}",
                $"{numericUpDownCountCore_KKA.Text}", $"{textBoxClockFrequency_KKA.Text}",
                $"{numericUpDownCountMemory_KKA.Text}", $"{textBoxCountDisk_KKA.Text}",
                $"{dateTimePickerRelease_KKA.Text}", $"{textBoxPrice_KKA.Text}", };
                dataGridViewPC_KKA.Rows.Add(row);
                bool completed = ds.AddNewData(pathPersonalComputer, row);
                if (completed)
                {
                    MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPC_KKA_Click(object sender, EventArgs e)
        {
            //panelPC_KKA.Visible = true;
            //panelSeller_KKA.Visible = false;
            dataGridViewPC_KKA.Visible = true;
            dataGridViewSeller_KKA.Visible = false;
            groupBoxDataPC_KKA.Visible = true;
            groupBoxDataSeller_KKA.Visible = false;
            textBoxTitle_KKA.Text = "Электронно-вычислительные машины";
            try
            {

                string[,] DataMatrix = ds.GetData(pathPersonalComputer);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewPC_KKA.RowCount = rows + 1;
                dataGridViewPC_KKA.ColumnCount = columns;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewPC_KKA.Columns[i].Width = 100;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewPC_KKA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSeller_KKA_Click(object sender, EventArgs e)
        {
            //panelPC_KKA.Visible = true;
            //panelSeller_KKA.Visible = false;
            dataGridViewPC_KKA.Visible = false;
            dataGridViewSeller_KKA.Visible = true;
            groupBoxDataPC_KKA.Visible = false;
            groupBoxDataSeller_KKA.Visible = true;
            textBoxTitle_KKA.Text = "Фирмы-реализаторы";
            try
            {

                string[,] DataMatrix = ds.GetData(pathSeller);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewSeller_KKA.RowCount = rows + 1;
                dataGridViewSeller_KKA.ColumnCount = columns;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewSeller_KKA.Columns[i].Width = 100;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewSeller_KKA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonManual_KKA_Click(object sender, EventArgs e)
        {
            FormManual manual = new FormManual();
            manual.Show();
        }

        private void buttonAbout_KKA_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }
    }
}
