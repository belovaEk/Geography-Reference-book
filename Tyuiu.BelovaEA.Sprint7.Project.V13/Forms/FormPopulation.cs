using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BelovaEA.Sprint7.Project.V13.Lib;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    public partial class FormPopulation_BEA : Form
    {
        public FormPopulation_BEA()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        string path = @"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\population.csv";
        private void comboBoxChoosingCountry_BEA_SelectedIndexChanged(object sender, EventArgs e)
        {

            // заполняем численность

            int[,] matrixNumber = new int[2, 5];
            int index = comboBoxChoosingCountry_BEA.SelectedIndex;
            matrixNumber = ds.Population_Number(index, path);

            chartNumber_BEA.ChartAreas[0].AxisX.Title = "Годы";
            chartNumber_BEA.ChartAreas[0].AxisY.Title = "Кол-во человек, тыс";
            
            chartNumber_BEA.Series[0].Points.Clear();
            for (int r = 0; r < matrixNumber.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrixNumber.GetLongLength(1); c++)
                {
                    chartNumber_BEA.Series[0].Points.AddXY(matrixNumber[0, c], matrixNumber[1, c]);
                }
            }

            string[,] matrixNationaly;
            
            // заполняем пирог и настраиваем масштаб для численности
            switch (index)
            {
                case 0:
                    chartNationaly_BEA.Series[0].Points.Clear();
                    matrixNationaly = ds.Population_Nationaly(@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\National_Russia.csv");
                    for (int r = 0; r < matrixNationaly.GetLongLength(0); r++)
                    {
                        chartNationaly_BEA.Series[0].Points.AddXY(matrixNationaly[r, 0], matrixNationaly[r, 1]);
                    }

                    chartNumber_BEA.ChartAreas[0].AxisY.Minimum = 144000;
                    chartNumber_BEA.ChartAreas[0].AxisY.Maximum = 148000;
                    break;


                case 1:
                    chartNationaly_BEA.Series[0].Points.Clear();
                    matrixNationaly = ds.Population_Nationaly(@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\National_USA.csv");
                    for (int r = 0; r < matrixNationaly.GetLongLength(0); r++)
                    {
                        chartNationaly_BEA.Series[0].Points.AddXY(matrixNationaly[r, 0], matrixNationaly[r, 1]);
                    }
                    chartNumber_BEA.ChartAreas[0].AxisY.Minimum = 300000;
                    chartNumber_BEA.ChartAreas[0].AxisY.Maximum = 340000;
                    break;

                case 2:
                    chartNationaly_BEA.Series[0].Points.Clear();
                    matrixNationaly = ds.Population_Nationaly(@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\National_France.csv");
                    for (int r = 0; r < matrixNationaly.GetLongLength(0); r++)
                    {
                        chartNationaly_BEA.Series[0].Points.AddXY(matrixNationaly[r, 0], matrixNationaly[r, 1]);
                    }

                    chartNumber_BEA.ChartAreas[0].AxisY.Minimum = 62000;
                    chartNumber_BEA.ChartAreas[0].AxisY.Maximum = 66000;
                    break;

                case 3:
                    chartNationaly_BEA.Series[0].Points.Clear();
                    matrixNationaly = ds.Population_Nationaly(@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\National_China.csv");
                    for (int r = 0; r < matrixNationaly.GetLongLength(0); r++)
                    {
                        chartNationaly_BEA.Series[0].Points.AddXY(matrixNationaly[r, 0], matrixNationaly[r, 1]);
                    }

                    chartNumber_BEA.ChartAreas[0].AxisY.Minimum = 1300000;
                    chartNumber_BEA.ChartAreas[0].AxisY.Maximum = 1425000;
                    break;
                case 4:
                    chartNationaly_BEA.Series[0].Points.Clear();
                    matrixNationaly = ds.Population_Nationaly(@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\National_Japan.csv");
                    for (int r = 0; r < matrixNationaly.GetLongLength(0); r++)
                    {
                        chartNationaly_BEA.Series[0].Points.AddXY(matrixNationaly[r, 0], matrixNationaly[r, 1]);
                    }

                    chartNumber_BEA.ChartAreas[0].AxisY.Minimum = 120000;
                    chartNumber_BEA.ChartAreas[0].AxisY.Maximum = 129000;
                    break;
                
            }
   
        }
        
    }
}
