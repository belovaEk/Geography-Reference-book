
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
            this.textBoxFacts_BEA = new System.Windows.Forms.TextBox();
            this.splitContainerFact = new System.Windows.Forms.SplitContainer();
            this.pictureBoxCountry_BEA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFact)).BeginInit();
            this.splitContainerFact.Panel1.SuspendLayout();
            this.splitContainerFact.Panel2.SuspendLayout();
            this.splitContainerFact.SuspendLayout();
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
            this.comboBoxChoosingCountry_BEA.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoosingCountry_BEA_SelectedIndexChanged);
            // 
            // textBoxFacts_BEA
            // 
            this.textBoxFacts_BEA.BackColor = System.Drawing.Color.White;
            this.textBoxFacts_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFacts_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFacts_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFacts_BEA.Location = new System.Drawing.Point(0, 0);
            this.textBoxFacts_BEA.Multiline = true;
            this.textBoxFacts_BEA.Name = "textBoxFacts_BEA";
            this.textBoxFacts_BEA.ReadOnly = true;
            this.textBoxFacts_BEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFacts_BEA.Size = new System.Drawing.Size(445, 551);
            this.textBoxFacts_BEA.TabIndex = 6;
            // 
            // splitContainerFact
            // 
            this.splitContainerFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerFact.IsSplitterFixed = true;
            this.splitContainerFact.Location = new System.Drawing.Point(24, 105);
            this.splitContainerFact.Name = "splitContainerFact";
            // 
            // splitContainerFact.Panel1
            // 
            this.splitContainerFact.Panel1.Controls.Add(this.textBoxFacts_BEA);
            // 
            // splitContainerFact.Panel2
            // 
            this.splitContainerFact.Panel2.Controls.Add(this.pictureBoxCountry_BEA);
            this.splitContainerFact.Size = new System.Drawing.Size(1057, 551);
            this.splitContainerFact.SplitterDistance = 445;
            this.splitContainerFact.SplitterWidth = 40;
            this.splitContainerFact.TabIndex = 7;
            // 
            // pictureBoxCountry_BEA
            // 
            this.pictureBoxCountry_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCountry_BEA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCountry_BEA.Name = "pictureBoxCountry_BEA";
            this.pictureBoxCountry_BEA.Size = new System.Drawing.Size(572, 551);
            this.pictureBoxCountry_BEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCountry_BEA.TabIndex = 4;
            this.pictureBoxCountry_BEA.TabStop = false;
            // 
            // FormFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.splitContainerFact);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormFact";
            this.Text = "Факты";
            this.splitContainerFact.Panel1.ResumeLayout(false);
            this.splitContainerFact.Panel1.PerformLayout();
            this.splitContainerFact.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFact)).EndInit();
            this.splitContainerFact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry_BEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.PictureBox pictureBoxCountry_BEA;
        private System.Windows.Forms.TextBox textBoxFacts_BEA;
        private System.Windows.Forms.SplitContainer splitContainerFact;
    }
}