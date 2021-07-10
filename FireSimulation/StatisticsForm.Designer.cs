namespace FireSimulation
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button8 = new System.Windows.Forms.Button();
            this.lblSurvivalRate = new System.Windows.Forms.Label();
            this.lblSurvived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGradeResult = new System.Windows.Forms.Label();
            this.chartExitEscapees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            this.labelExitDetails = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExitEscapees)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 14);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "People";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(945, 436);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1291, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 46);
            this.button8.TabIndex = 42;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // lblSurvivalRate
            // 
            this.lblSurvivalRate.AutoSize = true;
            this.lblSurvivalRate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurvivalRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurvivalRate.Location = new System.Drawing.Point(964, 98);
            this.lblSurvivalRate.Name = "lblSurvivalRate";
            this.lblSurvivalRate.Size = new System.Drawing.Size(204, 34);
            this.lblSurvivalRate.TabIndex = 43;
            this.lblSurvivalRate.Text = "Survival Rate: ";
            // 
            // lblSurvived
            // 
            this.lblSurvived.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurvived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurvived.Location = new System.Drawing.Point(965, 196);
            this.lblSurvived.Name = "lblSurvived";
            this.lblSurvived.Size = new System.Drawing.Size(224, 80);
            this.lblSurvived.TabIndex = 44;
            this.lblSurvived.Text = "__ out of __ survived in under __ seconds.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(964, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 45;
            this.label2.Text = "Grade:";
            // 
            // lblGradeResult
            // 
            this.lblGradeResult.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGradeResult.Location = new System.Drawing.Point(1080, 150);
            this.lblGradeResult.Name = "lblGradeResult";
            this.lblGradeResult.Size = new System.Drawing.Size(244, 34);
            this.lblGradeResult.TabIndex = 46;
            // 
            // chartExitEscapees
            // 
            chartArea2.Name = "ChartArea1";
            this.chartExitEscapees.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartExitEscapees.Legends.Add(legend2);
            this.chartExitEscapees.Location = new System.Drawing.Point(16, 455);
            this.chartExitEscapees.Margin = new System.Windows.Forms.Padding(4);
            this.chartExitEscapees.Name = "chartExitEscapees";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Escapees";
            this.chartExitEscapees.Series.Add(series2);
            this.chartExitEscapees.Size = new System.Drawing.Size(541, 361);
            this.chartExitEscapees.TabIndex = 48;
            this.chartExitEscapees.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(565, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Assigned Fire exit:";
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExit.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelExit.Location = new System.Drawing.Point(565, 535);
            this.LabelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(78, 24);
            this.LabelExit.TabIndex = 50;
            this.LabelExit.Text = "Exit???";
            // 
            // labelExitDetails
            // 
            this.labelExitDetails.AutoSize = true;
            this.labelExitDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitDetails.ForeColor = System.Drawing.Color.Black;
            this.labelExitDetails.Location = new System.Drawing.Point(565, 578);
            this.labelExitDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExitDetails.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelExitDetails.Name = "labelExitDetails";
            this.labelExitDetails.Size = new System.Drawing.Size(396, 40);
            this.labelExitDetails.TabIndex = 51;
            this.labelExitDetails.Text = "ppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp" +
    "pp";
            // 
            // bttnBack
            // 
            this.bttnBack.FlatAppearance.BorderSize = 0;
            this.bttnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBack.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.ForeColor = System.Drawing.Color.White;
            this.bttnBack.Image = ((System.Drawing.Image)(resources.GetObject("bttnBack.Image")));
            this.bttnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBack.Location = new System.Drawing.Point(1224, 0);
            this.bttnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(61, 46);
            this.bttnBack.TabIndex = 52;
            this.bttnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.BttnBack_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 831);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.labelExitDetails);
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartExitEscapees);
            this.Controls.Add(this.lblGradeResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSurvived);
            this.Controls.Add(this.lblSurvivalRate);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExitEscapees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblSurvivalRate;
        private System.Windows.Forms.Label lblSurvived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGradeResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExitEscapees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Label labelExitDetails;
        private System.Windows.Forms.Button bttnBack;
    }
}