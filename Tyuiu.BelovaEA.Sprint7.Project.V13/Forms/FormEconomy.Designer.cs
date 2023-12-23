
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxChoosingCountry_BEA = new System.Windows.Forms.ComboBox();
            this.textBoxEconomy_BEA = new System.Windows.Forms.TextBox();
            this.chartVVP_BEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chartVVP_BEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // textBoxEconomy_BEA
            // 
            this.textBoxEconomy_BEA.BackColor = System.Drawing.Color.White;
            this.textBoxEconomy_BEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEconomy_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEconomy_BEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEconomy_BEA.Location = new System.Drawing.Point(0, 0);
            this.textBoxEconomy_BEA.Multiline = true;
            this.textBoxEconomy_BEA.Name = "textBoxEconomy_BEA";
            this.textBoxEconomy_BEA.ReadOnly = true;
            this.textBoxEconomy_BEA.Size = new System.Drawing.Size(409, 547);
            this.textBoxEconomy_BEA.TabIndex = 6;
            this.textBoxEconomy_BEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chartVVP_BEA
            // 
            chartArea6.Name = "ChartArea1";
            this.chartVVP_BEA.ChartAreas.Add(chartArea6);
            this.chartVVP_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend_Population_BEA";
            legend6.Position.Auto = false;
            legend6.Position.Height = 12.9199F;
            legend6.Position.Width = 35.11905F;
            legend6.Position.X = 3F;
            legend6.Position.Y = 3F;
            legend6.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.chartVVP_BEA.Legends.Add(legend6);
            this.chartVVP_BEA.Location = new System.Drawing.Point(0, 0);
            this.chartVVP_BEA.Name = "chartVVP_BEA";
            this.chartVVP_BEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Color = System.Drawing.Color.CadetBlue;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend_Population_BEA";
            series6.Name = "Series1";
            this.chartVVP_BEA.Series.Add(series6);
            this.chartVVP_BEA.Size = new System.Drawing.Size(654, 547);
            this.chartVVP_BEA.TabIndex = 7;
            this.chartVVP_BEA.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title6.Name = "TitleVVP_BEA";
            title6.Text = "ВВП на душу населения (в млрд долл. США)";
            this.chartVVP_BEA.Titles.Add(title6);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(25, 109);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartVVP_BEA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEconomy_BEA);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 547);
            this.splitContainer1.SplitterDistance = 654;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 8;
            // 
            // FormEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormEconomy";
            this.Text = "Экономика";
            ((System.ComponentModel.ISupportInitialize)(this.chartVVP_BEA)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.TextBox textBoxEconomy_BEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVVP_BEA;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}