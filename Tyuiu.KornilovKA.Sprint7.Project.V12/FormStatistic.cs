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
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }
        string path = @"..\Back-end\personal_computer.csv";
        DataService ds = new DataService();
        private void FormStatistic_Load(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetData(path);

            double[] pricePC = ds.GetPrice(DataMatrix);

            double minPrice = ds.MinValue(pricePC);

            double maxPrice = ds.MaxValue(pricePC);

            double avgPrice = ds.AverageValue(pricePC);

            textBoxMinPrice_KKA.Text = minPrice.ToString();
            textBoxMaxPrice_KKA.Text = maxPrice.ToString();
            textBoxAvgPrice_KKA.Text = avgPrice.ToString();
        }
    }
}
