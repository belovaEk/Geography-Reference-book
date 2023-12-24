using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Tyuiu.BelovaEA.Sprint7.Project.V13
{
    public partial class FormMainMenu_BEA : Form
    {
        private Button currentButton;
        private Form activeForm;
        public FormMainMenu_BEA()
        {
            InitializeComponent();
            buttonCloseChildForm_BEA.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu_BEA.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel_BEA.Controls.Add(childForm);
            this.panelDesktopPanel_BEA.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle_BEA.Text = childForm.Text;
        }

        private void buttonGeography_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormGeography());
        }

        private void buttonNature_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormNature_BEA());
        }

        private void buttonPopulation_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormPopulation_BEA());
        }

        private void buttonEconomy_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormEconomy());
        }

        private void buttonPolitics_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormPolitics_BEA());
        }

        private void buttonFact_BEA_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar_BEA.BackColor = color;
                    panelLogo_BEA.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_BEA.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormFact());
        }
        private void Reset()
        {
            DisableButton();
            labelTitle_BEA.Text = "Меню";
            panelTitleBar_BEA.BackColor = Color.FromArgb(95, 158, 160);
            panelLogo_BEA.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonCloseChildForm_BEA.Visible = false;
        }

        private void buttonCloseChildForm_BEA_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelTitleBar_BEA_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_BEA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMax_BEA_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMin_BEA_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormContact_BEA formContact = new FormContact_BEA();
            formContact.ShowDialog();
        }

        private void buttonGuide_BEA_Click(object sender, EventArgs e)
        {
            
            string path = $@"{Directory.GetCurrentDirectory()}\User's_guide.docx";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "WINWORD.EXE";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonAbout_BEA_Click(object sender, EventArgs e)
        {
            FormAbout_BEA formAbout = new FormAbout_BEA();
            formAbout.ShowDialog();
        }
    }
}
