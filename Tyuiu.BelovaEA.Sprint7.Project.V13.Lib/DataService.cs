using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public string[] Georaphy(int index, string path)
        {
            string[] res = new string[2];

            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            res[0] = arrayValues[index, 1];
            res[1] = arrayValues[index, 2];
            return res;
        }
        
        public int[,] Population_Number(int index, string path)
        { 
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int[,] res = new int[2, columns];
            for (int i = 0; i<2; i++)
            {
                for (int c = 0; c < columns; c++)
                {
                    res[0, c] = arrayValues[0, c];
                    res[1, c] = arrayValues[index+1, c]/1000;
                }
            }

            return res;    
        }

        public string[,] Population_Nationaly(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }

            return arrayValues;
        }

        public double[,] Economy(int index, string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            double[,] arrayValues = new double[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToDouble(line_r[c]);
                }
            }

            double[,] res = new double[2, columns];
            for (int i = 0; i < 2; i++)
            {
                for (int c = 0; c < columns; c++)
                {
                    res[0, c] = arrayValues[0, c];
                    res[1, c] = arrayValues[index + 1, c];
                }
            }

            return res;
        }
    }
}
