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
            dateTimePickerRelease_KKA.CustomFormat = "DD MM YYYY";
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
                if (textBoxManufacturer_KKA.Text == "" || textBoxTypeCPU_KKA.Text == "" || numericUpDownCountCore_KKA.Text == "" ||
                    textBoxClockFrequency_KKA.Text == "" || numericUpDownCountMemory_KKA.Text == "" || textBoxCountDisk_KKA.Text == "" ||
                    dateTimePickerRelease_KKA.Text == "" || textBoxPrice_KKA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string[] row = new string[] { $"{textBoxManufacturer_KKA.Text}", $"{textBoxTypeCPU_KKA.Text}",
                    $"{numericUpDownCountCore_KKA.Text}", $"{textBoxClockFrequency_KKA.Text}",
                    $"{numericUpDownCountMemory_KKA.Text}", $"{textBoxCountDisk_KKA.Text}",
                    $"{dateTimePickerRelease_KKA.Text}", $"{textBoxPrice_KKA.Text}" };
                    dataGridViewPC_KKA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathPersonalComputer, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    textBoxManufacturer_KKA.Clear();
                    textBoxTypeCPU_KKA.Clear();
                    numericUpDownCountCore_KKA.Text = "0";
                    textBoxClockFrequency_KKA.Clear();
                    numericUpDownCountMemory_KKA.Text = "0";
                    textBoxCountDisk_KKA.Clear();
                    dateTimePickerRelease_KKA.Text = $"{DateTime.Now}";
                    textBoxPrice_KKA.Clear();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPC_KKA_Click(object sender, EventArgs e)
        {
            dataGridViewPC_KKA.Visible = true;
            dataGridViewSeller_KKA.Visible = false;

            labelSearch_KKA.Visible = true;
            textBoxSearch_KKA.Visible = true;
            buttonSearchPC_KKA.Visible = true;
            buttonSearchSeller_KKA.Visible = false;

            textBoxManufacturer_KKA.Visible = true;
            textBoxClockFrequency_KKA.Visible = true;
            textBoxCountDisk_KKA.Visible = true;
            textBoxTypeCPU_KKA.Visible = true;
            textBoxPrice_KKA.Visible = true;
            numericUpDownCountCore_KKA.Visible = true;
            numericUpDownCountMemory_KKA.Visible = true;
            dateTimePickerRelease_KKA.Visible = true;
            buttonAddNewPC_KKA.Visible = true;
            buttonSavePC_KKA.Visible = true;
            buttonStatistic_KKA.Visible = true;
            labelClockFrequency_KKA.Visible = true;
            labelCountCore_KKA.Visible = true;
            labelCountDisk_KKA.Visible = true;
            labelCountMemory_KKA.Visible = true;
            labelManufacturer_KKA.Visible = true;
            labelPrice_KKA.Visible = true;
            labelTypeCPU_KKA.Visible = true;
            labelRelease_KKA.Visible = true;

            dataGridViewSeller_KKA.Visible = false;
            textBoxNameSeller_KKA.Visible = false;
            textBoxPhoneNumber_KKA.Visible = false;
            textBoxURL_KKA.Visible = false;
            textBoxAddress_KKA.Visible = false;
            buttonAddNewSeller_KKA.Visible = false;
            buttonSaveSeller_KKA.Visible = false;
            labelAddress_KKA.Visible = false;
            labelNameSeller_KKA.Visible = false;
            labelPhoneNumber_KKA.Visible = false;
            labelURL_KKA.Visible = false;


            textBoxTitle_KKA.Text = "Электронно-вычислительные машины";
            try
            {

                string[,] DataMatrix = ds.GetData(pathPersonalComputer);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewPC_KKA.RowCount = rows + 1;
                dataGridViewPC_KKA.ColumnCount = columns;

                dataGridViewPC_KKA.Columns[0].HeaderText = "Производитель";
                dataGridViewPC_KKA.Columns[1].HeaderText = "Тип процессора";
                dataGridViewPC_KKA.Columns[2].HeaderText = "Кол-во ядер";
                dataGridViewPC_KKA.Columns[3].HeaderText = "Тактовая частота";
                dataGridViewPC_KKA.Columns[4].HeaderText = "Объем ОЗУ";
                dataGridViewPC_KKA.Columns[5].HeaderText = "Объем ЖД";
                dataGridViewPC_KKA.Columns[6].HeaderText = "Дата выпуска";
                dataGridViewPC_KKA.Columns[7].HeaderText = "Цена";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewPC_KKA.Columns[i].Width = 150;
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
            dataGridViewPC_KKA.Visible = false;
            dataGridViewSeller_KKA.Visible = true;

            labelSearch_KKA.Visible = true;
            textBoxSearch_KKA.Visible = true;
            buttonSearchPC_KKA.Visible = false;
            buttonSearchSeller_KKA.Visible = true;

            textBoxManufacturer_KKA.Visible = false;
            textBoxClockFrequency_KKA.Visible = false;
            textBoxCountDisk_KKA.Visible = false;
            textBoxTypeCPU_KKA.Visible = false;
            textBoxPrice_KKA.Visible = false;
            numericUpDownCountCore_KKA.Visible = false;
            numericUpDownCountMemory_KKA.Visible = false;
            dateTimePickerRelease_KKA.Visible = false;
            buttonAddNewPC_KKA.Visible = false;
            buttonSavePC_KKA.Visible = false;
            buttonStatistic_KKA.Visible = false;
            labelClockFrequency_KKA.Visible = false;
            labelCountCore_KKA.Visible = false;
            labelCountDisk_KKA.Visible = false;
            labelCountMemory_KKA.Visible = false;
            labelManufacturer_KKA.Visible = false;
            labelPrice_KKA.Visible = false;
            labelTypeCPU_KKA.Visible = false;
            labelRelease_KKA.Visible = false;

            dataGridViewSeller_KKA.Visible = true;
            textBoxNameSeller_KKA.Visible = true;
            textBoxPhoneNumber_KKA.Visible = true;
            textBoxURL_KKA.Visible = true;
            textBoxAddress_KKA.Visible = true;
            buttonAddNewSeller_KKA.Visible = true;
            buttonSaveSeller_KKA.Visible = true;
            labelAddress_KKA.Visible = true;
            labelNameSeller_KKA.Visible = true;
            labelPhoneNumber_KKA.Visible = true;
            labelURL_KKA.Visible = true;

            textBoxTitle_KKA.Text = "Фирмы-реализаторы";
            try
            {

                string[,] DataMatrix = ds.GetData(pathSeller);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewSeller_KKA.RowCount = rows + 1;
                dataGridViewSeller_KKA.ColumnCount = columns;

                dataGridViewSeller_KKA.Columns[0].HeaderText = "Наименование";
                dataGridViewSeller_KKA.Columns[1].HeaderText = "Адрес";
                dataGridViewSeller_KKA.Columns[2].HeaderText = "Номер телефона";
                dataGridViewSeller_KKA.Columns[3].HeaderText = "Ссылка на сайт";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewSeller_KKA.Columns[i].Width = 150;
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

        private void buttonSearchPC_KKA_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewSeller_KKA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxURL_KKA.Text == "" || textBoxPhoneNumber_KKA.Text == "" || textBoxNameSeller_KKA.Text == "" || textBoxAddress_KKA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string[] row = new string[] { $"{textBoxNameSeller_KKA.Text}", $"{textBoxAddress_KKA.Text}",
                    $"{textBoxPhoneNumber_KKA.Text}", $"{textBoxURL_KKA.Text}" };
                    dataGridViewSeller_KKA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathSeller, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxNameSeller_KKA.Clear();
                    textBoxAddress_KKA.Clear();
                    textBoxPhoneNumber_KKA.Clear();
                    textBoxURL_KKA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatistic_KKA_Click(object sender, EventArgs e)
        {
            FormStatistic statistic = new FormStatistic();
            statistic.Show();
        }

        private void buttonSaveSeller_KKA_Click(object sender, EventArgs e)
        {

        }

        private void buttonSavePC_KKA_Click(object sender, EventArgs e)
        {

        }
    }
}
