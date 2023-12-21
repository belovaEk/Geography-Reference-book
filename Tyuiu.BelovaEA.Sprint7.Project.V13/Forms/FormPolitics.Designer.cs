
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
            this.labelPolitical_BEA = new System.Windows.Forms.Label();
            this.textBoxPolitical_BEA = new System.Windows.Forms.TextBox();
            this.splitContainerPolitical_BEA = new System.Windows.Forms.SplitContainer();
            this.pictureBoxPresident_BEA = new System.Windows.Forms.PictureBox();
            this.labelNamePresident_BEA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPolitical_BEA)).BeginInit();
            this.splitContainerPolitical_BEA.Panel1.SuspendLayout();
            this.splitContainerPolitical_BEA.Panel2.SuspendLayout();
            this.splitContainerPolitical_BEA.SuspendLayout();
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
            this.comboBoxChoosingCountry_BEA.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoosingCountry_BEA_SelectedIndexChanged);
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
            // labelPolitical_BEA
            // 
            this.labelPolitical_BEA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPolitical_BEA.AutoSize = true;
            this.labelPolitical_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolitical_BEA.Location = new System.Drawing.Point(605, 157);
            this.labelPolitical_BEA.Name = "labelPolitical_BEA";
            this.labelPolitical_BEA.Size = new System.Drawing.Size(316, 29);
            this.labelPolitical_BEA.TabIndex = 4;
            this.labelPolitical_BEA.Text = "Политическое устройство";
            // 
            // textBoxPolitical_BEA
            // 
            this.textBoxPolitical_BEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPolitical_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPolitical_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPolitical_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPolitical_BEA.Location = new System.Drawing.Point(0, 0);
            this.textBoxPolitical_BEA.Multiline = true;
            this.textBoxPolitical_BEA.Name = "textBoxPolitical_BEA";
            this.textBoxPolitical_BEA.ReadOnly = true;
            this.textBoxPolitical_BEA.Size = new System.Drawing.Size(500, 424);
            this.textBoxPolitical_BEA.TabIndex = 6;
            // 
            // splitContainerPolitical_BEA
            // 
            this.splitContainerPolitical_BEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerPolitical_BEA.IsSplitterFixed = true;
            this.splitContainerPolitical_BEA.Location = new System.Drawing.Point(41, 232);
            this.splitContainerPolitical_BEA.Name = "splitContainerPolitical_BEA";
            // 
            // splitContainerPolitical_BEA.Panel1
            // 
            this.splitContainerPolitical_BEA.Panel1.Controls.Add(this.pictureBoxPresident_BEA);
            // 
            // splitContainerPolitical_BEA.Panel2
            // 
            this.splitContainerPolitical_BEA.Panel2.Controls.Add(this.textBoxPolitical_BEA);
            this.splitContainerPolitical_BEA.Size = new System.Drawing.Size(1029, 424);
            this.splitContainerPolitical_BEA.SplitterDistance = 379;
            this.splitContainerPolitical_BEA.SplitterWidth = 150;
            this.splitContainerPolitical_BEA.TabIndex = 7;
            // 
            // pictureBoxPresident_BEA
            // 
            this.pictureBoxPresident_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPresident_BEA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPresident_BEA.Name = "pictureBoxPresident_BEA";
            this.pictureBoxPresident_BEA.Size = new System.Drawing.Size(379, 424);
            this.pictureBoxPresident_BEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPresident_BEA.TabIndex = 3;
            this.pictureBoxPresident_BEA.TabStop = false;
            // 
            // labelNamePresident_BEA
            // 
            this.labelNamePresident_BEA.AutoSize = true;
            this.labelNamePresident_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamePresident_BEA.Location = new System.Drawing.Point(36, 186);
            this.labelNamePresident_BEA.Name = "labelNamePresident_BEA";
            this.labelNamePresident_BEA.Size = new System.Drawing.Size(0, 29);
            this.labelNamePresident_BEA.TabIndex = 8;
            // 
            // FormPolitics_BEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.labelNamePresident_BEA);
            this.Controls.Add(this.splitContainerPolitical_BEA);
            this.Controls.Add(this.labelPolitical_BEA);
            this.Controls.Add(this.labelPresident_BEA);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormPolitics_BEA";
            this.Text = "Политика";
            this.splitContainerPolitical_BEA.Panel1.ResumeLayout(false);
            this.splitContainerPolitical_BEA.Panel2.ResumeLayout(false);
            this.splitContainerPolitical_BEA.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPolitical_BEA)).EndInit();
            this.splitContainerPolitical_BEA.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainerPolitical_BEA;
        private System.Windows.Forms.Label labelNamePresident_BEA;
    }
}