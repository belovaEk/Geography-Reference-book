
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormFact
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
            this.pictureBoxCountry_BEA = new System.Windows.Forms.PictureBox();
            this.textBoxFacts_BEA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry_BEA)).BeginInit();
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
            // pictureBoxCountry_BEA
            // 
            this.pictureBoxCountry_BEA.Location = new System.Drawing.Point(533, 128);
            this.pictureBoxCountry_BEA.Name = "pictureBoxCountry_BEA";
            this.pictureBoxCountry_BEA.Size = new System.Drawing.Size(552, 486);
            this.pictureBoxCountry_BEA.TabIndex = 4;
            this.pictureBoxCountry_BEA.TabStop = false;
            // 
            // textBoxFacts_BEA
            // 
            this.textBoxFacts_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFacts_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFacts_BEA.Location = new System.Drawing.Point(32, 128);
            this.textBoxFacts_BEA.Multiline = true;
            this.textBoxFacts_BEA.Name = "textBoxFacts_BEA";
            this.textBoxFacts_BEA.Size = new System.Drawing.Size(466, 486);
            this.textBoxFacts_BEA.TabIndex = 6;
            // 
            // FormFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.textBoxFacts_BEA);
            this.Controls.Add(this.pictureBoxCountry_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormFact";
            this.Text = "Факты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry_BEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.PictureBox pictureBoxCountry_BEA;
        private System.Windows.Forms.TextBox textBoxFacts_BEA;
    }
}