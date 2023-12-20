
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormEconomy
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
            this.textBoxEconomy_BEA = new System.Windows.Forms.TextBox();
            this.pictureBoxMap_BEA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap_BEA)).BeginInit();
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
            // textBoxEconomy_BEA
            // 
            this.textBoxEconomy_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEconomy_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEconomy_BEA.Location = new System.Drawing.Point(41, 135);
            this.textBoxEconomy_BEA.Multiline = true;
            this.textBoxEconomy_BEA.Name = "textBoxEconomy_BEA";
            this.textBoxEconomy_BEA.Size = new System.Drawing.Size(506, 508);
            this.textBoxEconomy_BEA.TabIndex = 6;
            // 
            // pictureBoxMap_BEA
            // 
            this.pictureBoxMap_BEA.Location = new System.Drawing.Point(573, 135);
            this.pictureBoxMap_BEA.Name = "pictureBoxMap_BEA";
            this.pictureBoxMap_BEA.Size = new System.Drawing.Size(522, 508);
            this.pictureBoxMap_BEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap_BEA.TabIndex = 7;
            this.pictureBoxMap_BEA.TabStop = false;
            // 
            // FormEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.pictureBoxMap_BEA);
            this.Controls.Add(this.textBoxEconomy_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormEconomy";
            this.Text = "Экономика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap_BEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.TextBox textBoxEconomy_BEA;
        private System.Windows.Forms.PictureBox pictureBoxMap_BEA;
    }
}