using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.BelovaEA.Sprint7.Project.V13.Lib;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Tyuiu.BelovaEA.Sprint7.Project.V13\bin\Debug\population.csv";

            FileInfo info = new FileInfo(path);
            bool tyta = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }

        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = $@"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Tyuiu.BelovaEA.Sprint7.Project.V13\bin\Debug\population.csv";
            DataService ds = new DataService();
            int[,] res = ds.Population_Number(0, path);
            int[,] wait = { { 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 }, { 143347, 143666, 146267, 146544, 146804, 146880, 146780, 146748, 147182 } };
        }
    }
}
