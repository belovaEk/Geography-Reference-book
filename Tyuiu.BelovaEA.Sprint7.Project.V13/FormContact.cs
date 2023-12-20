using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13
{
    public partial class FormContact_BEA : Form
    {
        public FormContact_BEA()
        {
            InitializeComponent();
        }

        private void buttonSend_BEA_Click(object sender, EventArgs e)
        {
            textBoxEmail_BEA.Visible = false;
            textBoxName_BEA.Visible = false;
            textBoxText_BEA.Visible = false;
            labelConect_BEA.Visible = false;
            labelEmail_BEA.Visible = false;
            labelName_BEA.Visible = false;
            labelText_BEA.Visible = false;
            buttonSend_BEA.Visible = false;

            labelThanks_BEA.Visible = true;
            buttonOk_BEA.Visible = true;
            this.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonOk_BEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
