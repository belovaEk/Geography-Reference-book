
namespace Tyuiu.BelovaEA.Sprint7.Project.V13.Forms
{
    partial class FormPopulation_BEA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxChoosingCountry_BEA = new System.Windows.Forms.ComboBox();
            this.chartNumber_BEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNationaly_BEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumber_BEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNationaly_BEA)).BeginInit();
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
            // chartNumber_BEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNumber_BEA.ChartAreas.Add(chartArea1);
            this.chartNumber_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend_Population_BEA";
            legend1.Position.Auto = false;
            legend1.Position.Height = 12.9199F;
            legend1.Position.Width = 35.11905F;
            legend1.Position.X = 3F;
            legend1.Position.Y = 3F;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.chartNumber_BEA.Legends.Add(legend1);
            this.chartNumber_BEA.Location = new System.Drawing.Point(0, 0);
            this.chartNumber_BEA.Name = "chartNumber_BEA";
            this.chartNumber_BEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.CadetBlue;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend_Population_BEA";
            series1.Name = "Series1";
            this.chartNumber_BEA.Series.Add(series1);
            this.chartNumber_BEA.Size = new System.Drawing.Size(527, 520);
            this.chartNumber_BEA.TabIndex = 5;
            this.chartNumber_BEA.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "TitleNumber_BEA";
            title1.Text = "Численность населения";
            this.chartNumber_BEA.Titles.Add(title1);
            // 
            // chartNationaly_BEA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNationaly_BEA.ChartAreas.Add(chartArea2);
            this.chartNationaly_BEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartNationaly_BEA.Legends.Add(legend2);
            this.chartNationaly_BEA.Location = new System.Drawing.Point(0, 0);
            this.chartNationaly_BEA.Name = "chartNationaly_BEA";
            this.chartNationaly_BEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartNationaly_BEA.Series.Add(series2);
            this.chartNationaly_BEA.Size = new System.Drawing.Size(516, 520);
            this.chartNationaly_BEA.TabIndex = 6;
            this.chartNationaly_BEA.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "TitleNationality_BEA";
            title2.Text = "Национальный фонд";
            this.chartNationaly_BEA.Titles.Add(title2);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 118);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartNumber_BEA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartNationaly_BEA);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 520);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.SplitterWidth = 40;
            this.splitContainer1.TabIndex = 7;
            // 
            // FormPopulation_BEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.comboBoxChoosingCountry_BEA);
            this.Name = "FormPopulation_BEA";
            this.Text = "Население";
            ((System.ComponentModel.ISupportInitialize)(this.chartNumber_BEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNationaly_BEA)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoosingCountry_BEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumber_BEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNationaly_BEA;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}