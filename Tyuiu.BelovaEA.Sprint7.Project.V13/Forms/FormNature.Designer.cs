
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormNature_BEA
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
            this.pictureAnimals_BEA = new System.Windows.Forms.PictureBox();
            this.pictureBoxNature_BEA = new System.Windows.Forms.PictureBox();
            this.textBoxAboutNature_BEA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnimals_BEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNature_BEA)).BeginInit();
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
            // pictureAnimals_BEA
            // 
            this.pictureAnimals_BEA.Location = new System.Drawing.Point(52, 380);
            this.pictureAnimals_BEA.Name = "pictureAnimals_BEA";
            this.pictureAnimals_BEA.Size = new System.Drawing.Size(469, 259);
            this.pictureAnimals_BEA.TabIndex = 4;
            this.pictureAnimals_BEA.TabStop = false;
            // 
            // pictureBoxNature_BEA
            // 
            this.pictureBoxNature_BEA.Location = new System.Drawing.Point(585, 380);
            this.pictureBoxNature_BEA.Name = "pictureBoxNature_BEA";
            this.pictureBoxNature_BEA.Size = new System.Drawing.Size(469, 259);
            this.pictureBoxNature_BEA.TabIndex = 5;
            this.pictureBoxNature_BEA.TabStop = false;
            // 
            // textBoxAboutNature_BEA
            // 
            this.textBoxAboutNature_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAboutNature_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAboutNature_BEA.Location = new System.Drawing.Point(52, 130);
            this.textBoxAboutNature_BEA.Multiline = true;
            this.textBoxAboutNature_BEA.Name = "textBoxAboutNature_BEA";
            this.textBoxAboutNature_BEA.Size = new System.Drawing.Size(1002, 193);
            this.textBoxAboutNature_BEA.TabIndex = 6;
            // 
            // FormNature_BEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.textBoxAboutNature_BEA);
            this.Controls.Add(this.pictureBoxNature_BEA);
            this.Controls.Add(this.pictureAnimals_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormNature_BEA";
            this.Text = "Природа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnimals_BEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNature_BEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.PictureBox pictureAnimals_BEA;
        private System.Windows.Forms.PictureBox pictureBoxNature_BEA;
        private System.Windows.Forms.TextBox textBoxAboutNature_BEA;
    }
}