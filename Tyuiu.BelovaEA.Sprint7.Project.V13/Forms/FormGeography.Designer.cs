
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormGeography
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
            this.labelCapital_BEA = new System.Windows.Forms.Label();
            this.labelSquare_BEA = new System.Windows.Forms.Label();
            this.pictureBoxMap_BEA = new System.Windows.Forms.PictureBox();
            this.labelNeighbor_BEA = new System.Windows.Forms.Label();
            this.textBoxNeigbor_BEA = new System.Windows.Forms.TextBox();
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
            this.comboBoxChoosingCountry_BEA.TabIndex = 0;
            this.comboBoxChoosingCountry_BEA.Text = "Выберите страну";
            // 
            // labelCapital_BEA
            // 
            this.labelCapital_BEA.AutoSize = true;
            this.labelCapital_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapital_BEA.Location = new System.Drawing.Point(36, 149);
            this.labelCapital_BEA.Name = "labelCapital_BEA";
            this.labelCapital_BEA.Size = new System.Drawing.Size(126, 29);
            this.labelCapital_BEA.TabIndex = 1;
            this.labelCapital_BEA.Text = "Столица: ";
            // 
            // labelSquare_BEA
            // 
            this.labelSquare_BEA.AutoSize = true;
            this.labelSquare_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare_BEA.Location = new System.Drawing.Point(36, 226);
            this.labelSquare_BEA.Name = "labelSquare_BEA";
            this.labelSquare_BEA.Size = new System.Drawing.Size(136, 29);
            this.labelSquare_BEA.TabIndex = 2;
            this.labelSquare_BEA.Text = "Площадь: ";
            // 
            // pictureBoxMap_BEA
            // 
            this.pictureBoxMap_BEA.Location = new System.Drawing.Point(461, 137);
            this.pictureBoxMap_BEA.Name = "pictureBoxMap_BEA";
            this.pictureBoxMap_BEA.Size = new System.Drawing.Size(608, 470);
            this.pictureBoxMap_BEA.TabIndex = 3;
            this.pictureBoxMap_BEA.TabStop = false;
            // 
            // labelNeighbor_BEA
            // 
            this.labelNeighbor_BEA.AutoSize = true;
            this.labelNeighbor_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNeighbor_BEA.Location = new System.Drawing.Point(36, 307);
            this.labelNeighbor_BEA.Name = "labelNeighbor_BEA";
            this.labelNeighbor_BEA.Size = new System.Drawing.Size(115, 29);
            this.labelNeighbor_BEA.TabIndex = 4;
            this.labelNeighbor_BEA.Text = "Соседи: ";
            // 
            // textBoxNeigbor_BEA
            // 
            this.textBoxNeigbor_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNeigbor_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNeigbor_BEA.Location = new System.Drawing.Point(41, 357);
            this.textBoxNeigbor_BEA.Multiline = true;
            this.textBoxNeigbor_BEA.Name = "textBoxNeigbor_BEA";
            this.textBoxNeigbor_BEA.Size = new System.Drawing.Size(332, 250);
            this.textBoxNeigbor_BEA.TabIndex = 5;
            // 
            // FormGeography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.textBoxNeigbor_BEA);
            this.Controls.Add(this.labelNeighbor_BEA);
            this.Controls.Add(this.pictureBoxMap_BEA);
            this.Controls.Add(this.labelSquare_BEA);
            this.Controls.Add(this.labelCapital_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormGeography";
            this.Text = "География";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap_BEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.Label labelCapital_BEA;
        private System.Windows.Forms.Label labelSquare_BEA;
        private System.Windows.Forms.PictureBox pictureBoxMap_BEA;
        private System.Windows.Forms.Label labelNeighbor_BEA;
        private System.Windows.Forms.TextBox textBoxNeigbor_BEA;
    }
}