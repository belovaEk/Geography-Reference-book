
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormPolitics_BEA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxChoosingCountry_BEA = new System.Windows.Forms.ComboBox();
            this.labelPresident_BEA = new System.Windows.Forms.Label();
            this.pictureBoxPresident_BEA = new System.Windows.Forms.PictureBox();
            this.labelPolitical_BEA = new System.Windows.Forms.Label();
            this.textBoxPolitical_BEA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresident_BEA)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChoosingCountry_BEA
            // 
            this.comboBoxChoosingCountry_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoosingCountry_BEA.FormattingEnabled = true;
            this.comboBoxChoosingCountry_BEA.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Франция",
            "Китай",
            "Япония"});
            this.comboBoxChoosingCountry_BEA.Location = new System.Drawing.Point(41, 46);
            this.comboBoxChoosingCountry_BEA.Name = "comboBoxChoosingCountry_BEA";
            this.comboBoxChoosingCountry_BEA.Size = new System.Drawing.Size(251, 34);
            this.comboBoxChoosingCountry_BEA.TabIndex = 1;
            this.comboBoxChoosingCountry_BEA.Text = "Выберите страну";
            // 
            // labelPresident_BEA
            // 
            this.labelPresident_BEA.AutoSize = true;
            this.labelPresident_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPresident_BEA.Location = new System.Drawing.Point(36, 157);
            this.labelPresident_BEA.Name = "labelPresident_BEA";
            this.labelPresident_BEA.Size = new System.Drawing.Size(322, 29);
            this.labelPresident_BEA.TabIndex = 2;
            this.labelPresident_BEA.Text = "Действующий президент: ";
            // 
            // pictureBoxPresident_BEA
            // 
            this.pictureBoxPresident_BEA.Location = new System.Drawing.Point(41, 211);
            this.pictureBoxPresident_BEA.Name = "pictureBoxPresident_BEA";
            this.pictureBoxPresident_BEA.Size = new System.Drawing.Size(471, 411);
            this.pictureBoxPresident_BEA.TabIndex = 3;
            this.pictureBoxPresident_BEA.TabStop = false;
            // 
            // labelPolitical_BEA
            // 
            this.labelPolitical_BEA.AutoSize = true;
            this.labelPolitical_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolitical_BEA.Location = new System.Drawing.Point(614, 157);
            this.labelPolitical_BEA.Name = "labelPolitical_BEA";
            this.labelPolitical_BEA.Size = new System.Drawing.Size(323, 29);
            this.labelPolitical_BEA.TabIndex = 4;
            this.labelPolitical_BEA.Text = "Политическое устройство:";
            // 
            // textBoxPolitical_BEA
            // 
            this.textBoxPolitical_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPolitical_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPolitical_BEA.Location = new System.Drawing.Point(619, 211);
            this.textBoxPolitical_BEA.Multiline = true;
            this.textBoxPolitical_BEA.Name = "textBoxPolitical_BEA";
            this.textBoxPolitical_BEA.Size = new System.Drawing.Size(448, 411);
            this.textBoxPolitical_BEA.TabIndex = 6;
            // 
            // FormPolitics_BEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.textBoxPolitical_BEA);
            this.Controls.Add(this.labelPolitical_BEA);
            this.Controls.Add(this.pictureBoxPresident_BEA);
            this.Controls.Add(this.labelPresident_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormPolitics_BEA";
            this.Text = "Политика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresident_BEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.Label labelPresident_BEA;
        private System.Windows.Forms.PictureBox pictureBoxPresident_BEA;
        private System.Windows.Forms.Label labelPolitical_BEA;
        private System.Windows.Forms.TextBox textBoxPolitical_BEA;
    }
}