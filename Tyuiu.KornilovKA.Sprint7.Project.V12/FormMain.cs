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
            openFileDialogTable_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogNewData_KKA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            dateTimePickerRelease_KKA.CustomFormat = "DD MM YYYY";
        }
        DataService ds = new DataService();
        string pathPersonalComputer = @"C:\Users\KILIAN\source\repos\Tyuiu.KornilovKA.Sprint7\Back-end\personal_computer.csv";
        private void toolStripButtonInfoProgram_KKA_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void ToolStripMenuItemOpen_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogTable_KKA.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogTable_KKA.FileName;

                    string[,] DataMatrix = ds.GetData(FileName);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    dataGridViewTable_KKA.RowCount = rows + 1;
                    dataGridViewTable_KKA.ColumnCount = columns;
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewTable_KKA.Columns[i].Width = 100;
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewTable_KKA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                } else
                {
                    throw new Exception("Файл не выбран!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChangedMainOnManufacturer_KKA_Click(object sender, EventArgs e)
        {
            panelDataGrid_KKA.Visible = false;
        }

        private void buttonAddNewPC_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                string[] row = new string[] { $"{textBoxManufacturer_KKA.Text}", $"{textBoxTypeCPU_KKA.Text}",
                $"{numericUpDownCountCore_KKA.Text}", $"{textBoxClockFrequency_KKA.Text}",
                $"{numericUpDownCountMemory_KKA.Text}", $"{textBoxCountDisk_KKA.Text}",
                $"{dateTimePickerRelease_KKA.Text}", $"{textBoxPrice_KKA.Text}", };
                dataGridViewTable_KKA.Rows.Add(row);
                bool completed = ds.AddNewData(pathPersonalComputer, row);
                if (completed)
                {
                    MessageBox.Show("Данные добавлены!","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
