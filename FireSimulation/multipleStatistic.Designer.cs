namespace FireSimulation
{
    partial class multipleStatistic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.chartMultipleExits = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartInjured = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBestExitDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAssignedExit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAvgUsage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPaintExtinquisher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMultipleExits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInjured)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 32;
            // 
            // chartMultipleExits
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMultipleExits.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMultipleExits.Legends.Add(legend3);
            this.chartMultipleExits.Location = new System.Drawing.Point(12, 64);
            this.chartMultipleExits.Name = "chartMultipleExits";
            this.chartMultipleExits.Padding = new System.Windows.Forms.Padding(3);
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Exits";
            this.chartMultipleExits.Series.Add(series5);
            this.chartMultipleExits.Size = new System.Drawing.Size(457, 247);
            this.chartMultipleExits.TabIndex = 3;
            this.chartMultipleExits.Text = "chart1";
            this.chartMultipleExits.Click += new System.EventHandler(this.chartMultipleExits_Click);
            // 
            // chartInjured
            // 
            this.chartInjured.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.Title = "Simualtion Nr";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Interval = 50D;
            chartArea4.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.Title = "Number of ppl";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.Name = "ChartArea1";
            this.chartInjured.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartInjured.Legends.Add(legend4);
            this.chartInjured.Location = new System.Drawing.Point(12, 362);
            this.chartInjured.Name = "chartInjured";
            this.chartInjured.Padding = new System.Windows.Forms.Padding(3);
            series6.BorderColor = System.Drawing.Color.Silver;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Color = System.Drawing.Color.OrangeRed;
            series6.Legend = "Legend1";
            series6.Name = "Injured";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "Survived";
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Dead";
            this.chartInjured.Series.Add(series6);
            this.chartInjured.Series.Add(series7);
            this.chartInjured.Series.Add(series8);
            this.chartInjured.Size = new System.Drawing.Size(632, 247);
            this.chartInjured.TabIndex = 4;
            this.chartInjured.Text = "chart1";
            this.chartInjured.Click += new System.EventHandler(this.chartInjured_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multiple Sim Results";
            // 
            // labelBestExitDescription
            // 
            this.labelBestExitDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBestExitDescription.AutoSize = true;
            this.labelBestExitDescription.ForeColor = System.Drawing.Color.Black;
            this.labelBestExitDescription.Location = new System.Drawing.Point(9, 182);
            this.labelBestExitDescription.Name = "labelBestExitDescription";
            this.labelBestExitDescription.Size = new System.Drawing.Size(505, 13);
            this.labelBestExitDescription.TabIndex = 6;
            this.labelBestExitDescription.Text = "ppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp" +
    "pp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assigned fire exit";
            // 
            // labelAssignedExit
            // 
            this.labelAssignedExit.AutoSize = true;
            this.labelAssignedExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignedExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelAssignedExit.Location = new System.Drawing.Point(6, 62);
            this.labelAssignedExit.Name = "labelAssignedExit";
            this.labelAssignedExit.Size = new System.Drawing.Size(136, 33);
            this.labelAssignedExit.TabIndex = 8;
            this.labelAssignedExit.Text = "Exit????";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAvgUsage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelBestExitDescription);
            this.groupBox1.Controls.Add(this.labelAssignedExit);
            this.groupBox1.Location = new System.Drawing.Point(479, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelAvgUsage
            // 
            this.labelAvgUsage.AutoSize = true;
            this.labelAvgUsage.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgUsage.ForeColor = System.Drawing.Color.Blue;
            this.labelAvgUsage.Location = new System.Drawing.Point(7, 119);
            this.labelAvgUsage.Name = "labelAvgUsage";
            this.labelAvgUsage.Size = new System.Drawing.Size(121, 36);
            this.labelAvgUsage.TabIndex = 9;
            this.labelAvgUsage.Text = "AVG????";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPaintExtinquisher);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(824, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 247);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buttonPaintExtinquisher
            // 
            this.buttonPaintExtinquisher.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPaintExtinquisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPaintExtinquisher.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaintExtinquisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPaintExtinquisher.Location = new System.Drawing.Point(186, 203);
            this.buttonPaintExtinquisher.Name = "buttonPaintExtinquisher";
            this.buttonPaintExtinquisher.Size = new System.Drawing.Size(122, 38);
            this.buttonPaintExtinquisher.TabIndex = 3;
            this.buttonPaintExtinquisher.Text = "Display";
            this.buttonPaintExtinquisher.UseVisualStyleBackColor = false;
            this.buttonPaintExtinquisher.Click += new System.EventHandler(this.buttonPaintExtinquisher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.MaximumSize = new System.Drawing.Size(300, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 72);
            this.label4.TabIndex = 2;
            this.label4.Text = "Our simulation has calculated the best positions to place fire extinguishers to e" +
    "nshure that the best possible scenario is given in real life situations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Extinguishers";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Tomato;
            this.buttonClose.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(992, 559);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(158, 70);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // multipleStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1162, 641);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartInjured);
            this.Controls.Add(this.chartMultipleExits);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "multipleStatistic";
            this.Text = "multipleStatistic";
            this.Load += new System.EventHandler(this.multipleStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMultipleExits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInjured)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMultipleExits;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInjured;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBestExitDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAssignedExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAvgUsage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPaintExtinquisher;
        private System.Windows.Forms.Button buttonClose;
    }
}