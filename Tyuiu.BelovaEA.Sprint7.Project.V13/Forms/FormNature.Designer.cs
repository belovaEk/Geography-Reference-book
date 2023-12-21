
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
            this.textBoxAboutNature_BEA = new System.Windows.Forms.TextBox();
            this.pictureBoxNature_BEA = new System.Windows.Forms.PictureBox();
            this.pictureAnimals_BEA = new System.Windows.Forms.PictureBox();
            this.splitContainerNature_BEA = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNature_BEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnimals_BEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNature_BEA)).BeginInit();
            this.splitContainerNature_BEA.Panel1.SuspendLayout();
            this.splitContainerNature_BEA.Panel2.SuspendLayout();
            this.splitContainerNature_BEA.SuspendLayout();
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
            this.comboBoxChoosingCountry_BEA.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoosingCountry_BEA_SelectedIndexChanged);
            // 
            // textBoxAboutNature_BEA
            // 
            this.textBoxAboutNature_BEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAboutNature_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAboutNature_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAboutNature_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAboutNature_BEA.Location = new System.Drawing.Point(52, 138);
            this.textBoxAboutNature_BEA.Multiline = true;
            this.textBoxAboutNature_BEA.Name = "textBoxAboutNature_BEA";
            this.textBoxAboutNature_BEA.ReadOnly = true;
            this.textBoxAboutNature_BEA.Size = new System.Drawing.Size(1013, 193);
            this.textBoxAboutNature_BEA.TabIndex = 6;
            this.textBoxAboutNature_BEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxNature_BEA
            // 
            this.pictureBoxNature_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNature_BEA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNature_BEA.Name = "pictureBoxNature_BEA";
            this.pictureBoxNature_BEA.Size = new System.Drawing.Size(488, 283);
            this.pictureBoxNature_BEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNature_BEA.TabIndex = 5;
            this.pictureBoxNature_BEA.TabStop = false;
            // 
            // pictureAnimals_BEA
            // 
            this.pictureAnimals_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAnimals_BEA.Location = new System.Drawing.Point(0, 0);
            this.pictureAnimals_BEA.Name = "pictureAnimals_BEA";
            this.pictureAnimals_BEA.Size = new System.Drawing.Size(505, 283);
            this.pictureAnimals_BEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnimals_BEA.TabIndex = 4;
            this.pictureAnimals_BEA.TabStop = false;
            // 
            // splitContainerNature_BEA
            // 
            this.splitContainerNature_BEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerNature_BEA.IsSplitterFixed = true;
            this.splitContainerNature_BEA.Location = new System.Drawing.Point(52, 373);
            this.splitContainerNature_BEA.Name = "splitContainerNature_BEA";
            // 
            // splitContainerNature_BEA.Panel1
            // 
            this.splitContainerNature_BEA.Panel1.Controls.Add(this.pictureAnimals_BEA);
            // 
            // splitContainerNature_BEA.Panel2
            // 
            this.splitContainerNature_BEA.Panel2.Controls.Add(this.pictureBoxNature_BEA);
            this.splitContainerNature_BEA.Size = new System.Drawing.Size(1013, 283);
            this.splitContainerNature_BEA.SplitterDistance = 505;
            this.splitContainerNature_BEA.SplitterWidth = 20;
            this.splitContainerNature_BEA.TabIndex = 7;
            // 
            // FormNature_BEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.splitContainerNature_BEA);
            this.Controls.Add(this.textBoxAboutNature_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormNature_BEA";
            this.Text = "Природа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNature_BEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnimals_BEA)).EndInit();
            this.splitContainerNature_BEA.Panel1.ResumeLayout(false);
            this.splitContainerNature_BEA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNature_BEA)).EndInit();
            this.splitContainerNature_BEA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.PictureBox pictureAnimals_BEA;
        private System.Windows.Forms.PictureBox pictureBoxNature_BEA;
        private System.Windows.Forms.TextBox textBoxAboutNature_BEA;
        private System.Windows.Forms.SplitContainer splitContainerNature_BEA;
    }
}