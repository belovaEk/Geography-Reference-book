using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    public partial class FormNature_BEA : Form
    {
        public FormNature_BEA()
        {
            InitializeComponent();
        }

        private void comboBoxChoosingCountry_BEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoosingCountry_BEA.SelectedIndex)
            {
                case 0:
                    pictureAnimals_BEA.Image = Properties.Resources.animal_Russia;
                    pictureBoxNature_BEA.Image = Properties.Resources.nature_Russia;
                    textBoxAboutNature_BEA.Text = "Для нашей страны характерно большое число природных зон (арктические пустыни, тундра, тайга и т.д.), что дает широкий спектр климатических условий и порождает разнообразие флоры и фауны. В одно и то же время температура в разных местах может существенно различаться: когда зимой в Сочи будет +15°С, в Якутии морозы могут доходить до -50°С.";
                    break;

                case 1:
                    pictureAnimals_BEA.Image = Properties.Resources.animal_USA;
                    pictureBoxNature_BEA.Image = Properties.Resources.nature_USA;
                    textBoxAboutNature_BEA.Text = "Огромная территориальная протяженность США обуславливает большое климатическое разнообразие этой страны, где климат колеблется от засушливого пустынного до климата жарких и влажных тропических лесов и холодной Арктики на Аляске. Несмотря на это, большая часть территорий всё же имеет умеренно-континентальный климат, который характеризуется средней температурой воздуха летом +22+28°C и достаточно тёплой зимой со средней температурой +2+8°C.";
                    break;

                case 2:
                    pictureAnimals_BEA.Image = Properties.Resources.animal_France;
                    pictureBoxNature_BEA.Image = Properties.Resources.nature_France;
                    textBoxAboutNature_BEA.Text = "С севера на юг на территории страны располагаются различные климатические зоны, причем разница между ними значительна.  Вся территория страны относится к умеренному климатическому поясу, за исключением южных субтропиков.Ареал распространения животных во Франции зависит от рельефа местности и климатических условий.";
                    break;

                case 3:
                    pictureAnimals_BEA.Image = Properties.Resources.animal_China;
                    pictureBoxNature_BEA.Image = Properties.Resources.nature_China;
                    textBoxAboutNature_BEA.Text = "Особенности флоры и фауны различаются в зависимости от типа климата, который формирует природу. В северо-западной части страны установился умеренный климат, пройдя на юго-восток, можно наткнуться на выраженные признаки субтропиков, ещё южнее расположились тропики. Южное побережье одолевают муссоны, образуемые воздушными массами океана и суши. От движения муссонов зависит распределение осадков.";
                    break;

                case 4:
                    pictureAnimals_BEA.Image = Properties.Resources.animal_Japan;
                    pictureBoxNature_BEA.Image = Properties.Resources.nature_Japan;
                    textBoxAboutNature_BEA.Text = "Флора и фауна Японии разнообразна, что обусловлено благоприятным климатом и большим количеством влаги, а также имеет свои особенности, что связано с островной изоляцией территории. Здесь распространены эндемики – растения и животные, обитающие только в данной местности. В Японии насчитывается 2750 видов растений, множество животных и птиц, реки, озера и моря богаты рыбой. Леса покрывают около 60% всей территории.";
                    break;

            }
        }
    }
}
