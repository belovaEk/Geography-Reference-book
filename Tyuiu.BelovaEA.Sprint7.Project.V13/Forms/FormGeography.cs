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
    public partial class FormGeography : Form
    {
        public FormGeography()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\belov\source\repos\Tyuiu.BelovaEA.Sprint7\Based\Info.csv";

        private void comboBoxChoosingCountry_BEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Country = comboBoxChoosingCountry_BEA.SelectedIndex;
            labelCapital_BEA.Text = $"Столица: {ds.Georaphy(Country, path)[0]}";
            labelSquare_BEA.Text = $"Площадь: {ds.Georaphy(Country, path)[1]}";

            switch (Country)
            {
                case 0:
                    pictureBoxMap_BEA.Image = Properties.Resources.Russia_map;
                    textBoxNeigbor_BEA.Text = "По суше Россия граничит: на северо-западе с Норвегией и Финляндией; на западе с Польшей и Литвой (Калининградская область), Эстонией, Латвией, Беларусью и Украиной; на Кавказе с Грузией (часть границы — с Абхазией и Южной Осетией) и Азербайджаном; Европейская часть России и Сибирь граничат с Казахстаном; Восточная Сибирь — с Китаем и Монголией; на Дальнем Востоке Россия имеет сухопутные границы с Китаем и Северной Кореей, морские границы с Японией и США (на крайнем северо-востоке Азии).";
                    break;

                case 1:
                    pictureBoxMap_BEA.Image = Properties.Resources.America_Map;
                    textBoxNeigbor_BEA.Text = "На юге США граничат с Мексикой, на севере — с Канадой. США также имеют морскую границу с Российской Федерацией. С запада территория США омывается Тихим океаном, с востока — Атлантическим, на юго-востоке США находится Мексиканский залив, полуостров Аляска с севера омывается Северным Ледовитым океаном.";
                    break;

                case 2:
                    pictureBoxMap_BEA.Image = Properties.Resources.France_map;
                    textBoxNeigbor_BEA.Text = "Ближайшие соседи Франции — Бельгия, Люксембург, Германия, Швейцария, Италия, Испания и Андорра. По проливам Ла-Манш (под которым в настоящее время прорыт туннель) и Па-де-Кале проходит граница с Великобританией. На юге страны расположено карликовое княжество Монако.";
                    break;

                case 3:
                    pictureBoxMap_BEA.Image = Properties.Resources.China_map;
                    textBoxNeigbor_BEA.Text = "На северо-востоке Китай граничит с КНДР и Россией, на севере — с Монголией, на северо-западе — с Россией и Казахстаном, на западе — с Киргизией, Таджикистаном и Афганистаном, на юго-западе — с контролируемым Пакистаном Гилгит-Балтистаном, Индией, Непалом и Бутаном, на юге — с Мьянмой, Лаосом, Вьетнамом.";
                    break;

                case 4:
                    pictureBoxMap_BEA.Image = Properties.Resources.Japan_map;
                    textBoxNeigbor_BEA.Text = "Япония не имеет сухопутных границ. По морю Япония граничит с Россией, Китаем и республикой Корея. Со всеми этими странами у Японии есть нерешенные территориальные вопросы, но наиболее известный из них — претензия Японии на южную часть российских Курил — острова Кунашир, Итуруп, Шикотан и Хабомаи.";
                    break;

            }


        }

    }
}
