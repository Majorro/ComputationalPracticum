
namespace ComputationalPracticum
{
    partial class ODECalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.solutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.y0Label = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.x0Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.solutionChart);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.y0TextBox);
            this.splitContainer1.Panel2.Controls.Add(this.y0Label);
            this.splitContainer1.Panel2.Controls.Add(this.plotButton);
            this.splitContainer1.Panel2.Controls.Add(this.nTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.nLabel);
            this.splitContainer1.Panel2.Controls.Add(this.xTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.xLabel);
            this.splitContainer1.Panel2.Controls.Add(this.x0TextBox);
            this.splitContainer1.Panel2.Controls.Add(this.x0Label);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 582);
            this.splitContainer1.SplitterDistance = 963;
            this.splitContainer1.TabIndex = 1;
            // 
            // solutionChart
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "Solutions";
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.Title = "X";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.Title = "Error";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "LocalErrors";
            chartArea3.AxisX.Title = "Steps";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.Title = "Max error";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.Name = "MaxErrors";
            this.solutionChart.ChartAreas.Add(chartArea1);
            this.solutionChart.ChartAreas.Add(chartArea2);
            this.solutionChart.ChartAreas.Add(chartArea3);
            this.solutionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "solutionApproximationLegend";
            this.solutionChart.Legends.Add(legend1);
            this.solutionChart.Location = new System.Drawing.Point(0, 0);
            this.solutionChart.Name = "solutionChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "Solutions";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "solutionApproximationLegend";
            series1.Name = "Exact solution";
            series2.BorderWidth = 3;
            series2.ChartArea = "Solutions";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "solutionApproximationLegend";
            series2.Name = "Euler\'s method";
            series3.BorderWidth = 3;
            series3.ChartArea = "Solutions";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "solutionApproximationLegend";
            series3.Name = "Improved Euler\'s method";
            series4.BorderWidth = 3;
            series4.ChartArea = "Solutions";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.Legend = "solutionApproximationLegend";
            series4.Name = "Runge-Kutta method";
            series5.BorderWidth = 3;
            series5.ChartArea = "LocalErrors";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.IsVisibleInLegend = false;
            series5.Legend = "solutionApproximationLegend";
            series5.Name = "Euler\'s method local errors";
            series6.BorderWidth = 3;
            series6.ChartArea = "LocalErrors";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Lime;
            series6.IsVisibleInLegend = false;
            series6.Legend = "solutionApproximationLegend";
            series6.Name = "Improved Euler\'s method local errors";
            series7.BorderWidth = 3;
            series7.ChartArea = "LocalErrors";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series7.IsVisibleInLegend = false;
            series7.Legend = "solutionApproximationLegend";
            series7.Name = "Runge-Kutta method local errors";
            series8.BorderWidth = 3;
            series8.ChartArea = "MaxErrors";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.IsVisibleInLegend = false;
            series8.Legend = "solutionApproximationLegend";
            series8.Name = "Euler\'s method total errors";
            series9.BorderWidth = 3;
            series9.ChartArea = "MaxErrors";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Lime;
            series9.IsVisibleInLegend = false;
            series9.Legend = "solutionApproximationLegend";
            series9.Name = "Improved Euler\'s method total errors";
            series10.BorderWidth = 3;
            series10.ChartArea = "MaxErrors";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series10.IsVisibleInLegend = false;
            series10.Legend = "solutionApproximationLegend";
            series10.Name = "Runge-Kutta method total errors";
            this.solutionChart.Series.Add(series1);
            this.solutionChart.Series.Add(series2);
            this.solutionChart.Series.Add(series3);
            this.solutionChart.Series.Add(series4);
            this.solutionChart.Series.Add(series5);
            this.solutionChart.Series.Add(series6);
            this.solutionChart.Series.Add(series7);
            this.solutionChart.Series.Add(series8);
            this.solutionChart.Series.Add(series9);
            this.solutionChart.Series.Add(series10);
            this.solutionChart.Size = new System.Drawing.Size(963, 582);
            this.solutionChart.TabIndex = 0;
            this.solutionChart.Text = "solutionChart";
            title1.DockedToChartArea = "Solutions";
            title1.DockingOffset = -5;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "SolutionsTitle";
            title1.Text = "Approximating solutions";
            title2.DockedToChartArea = "LocalErrors";
            title2.DockingOffset = -5;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "LocalErrorsTitle";
            title2.Text = "Local errors";
            title3.DockedToChartArea = "MaxErrors";
            title3.DockingOffset = -5;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "MaxErrorsTitle";
            title3.Text = "Total approximation error";
            this.solutionChart.Titles.Add(title1);
            this.solutionChart.Titles.Add(title2);
            this.solutionChart.Titles.Add(title3);
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(6, 74);
            this.y0TextBox.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(86, 20);
            this.y0TextBox.TabIndex = 8;
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y0Label.Location = new System.Drawing.Point(6, 51);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(23, 18);
            this.y0Label.TabIndex = 7;
            this.y0Label.Text = "y0";
            // 
            // plotButton
            // 
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.plotButton.Location = new System.Drawing.Point(6, 204);
            this.plotButton.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(86, 35);
            this.plotButton.TabIndex = 6;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(6, 159);
            this.nTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(86, 20);
            this.nTextBox.TabIndex = 5;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.Location = new System.Drawing.Point(6, 139);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(19, 18);
            this.nLabel.TabIndex = 4;
            this.nLabel.Text = "N";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(6, 119);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(86, 20);
            this.xTextBox.TabIndex = 3;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(6, 99);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(18, 18);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X";
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(6, 29);
            this.x0TextBox.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(86, 20);
            this.x0TextBox.TabIndex = 1;
            // 
            // x0Label
            // 
            this.x0Label.AutoSize = true;
            this.x0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0Label.Location = new System.Drawing.Point(6, 6);
            this.x0Label.Name = "x0Label";
            this.x0Label.Size = new System.Drawing.Size(23, 18);
            this.x0Label.TabIndex = 0;
            this.x0Label.Text = "x0";
            // 
            // ODECalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ODECalculator";
            this.Text = "ODE calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solutionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart solutionChart;
        private System.Windows.Forms.Label x0Label;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.Label y0Label;
    }
}

