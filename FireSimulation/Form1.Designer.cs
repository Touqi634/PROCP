namespace FireSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.bttnHistory = new System.Windows.Forms.Button();
            this.bttnAboutUs = new System.Windows.Forms.Button();
            this.bttnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aboutUsControl11 = new FireSimulation.AboutUsControl1();
            this.historyControl11 = new FireSimulation.HistoryControl1();
            this.homePageControl1 = new FireSimulation.HomePageControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bttnFront = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.bttnHistory);
            this.panel1.Controls.Add(this.bttnAboutUs);
            this.panel1.Controls.Add(this.bttnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 541);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 49);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 100);
            this.SidePanel.TabIndex = 3;
            // 
            // bttnHistory
            // 
            this.bttnHistory.FlatAppearance.BorderSize = 0;
            this.bttnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHistory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHistory.ForeColor = System.Drawing.Color.White;
            this.bttnHistory.Image = ((System.Drawing.Image)(resources.GetObject("bttnHistory.Image")));
            this.bttnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnHistory.Location = new System.Drawing.Point(22, 187);
            this.bttnHistory.Name = "bttnHistory";
            this.bttnHistory.Size = new System.Drawing.Size(169, 100);
            this.bttnHistory.TabIndex = 5;
            this.bttnHistory.Text = "       History";
            this.bttnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnHistory.UseVisualStyleBackColor = true;
            this.bttnHistory.Click += new System.EventHandler(this.BttnHistory_Click);
            // 
            // bttnAboutUs
            // 
            this.bttnAboutUs.FlatAppearance.BorderSize = 0;
            this.bttnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAboutUs.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAboutUs.ForeColor = System.Drawing.Color.White;
            this.bttnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("bttnAboutUs.Image")));
            this.bttnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAboutUs.Location = new System.Drawing.Point(22, 336);
            this.bttnAboutUs.Name = "bttnAboutUs";
            this.bttnAboutUs.Size = new System.Drawing.Size(169, 100);
            this.bttnAboutUs.TabIndex = 4;
            this.bttnAboutUs.Text = "       About us";
            this.bttnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnAboutUs.UseVisualStyleBackColor = true;
            this.bttnAboutUs.Click += new System.EventHandler(this.BttnAboutUs_Click);
            // 
            // bttnHome
            // 
            this.bttnHome.FlatAppearance.BorderSize = 0;
            this.bttnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.ForeColor = System.Drawing.Color.White;
            this.bttnHome.Image = ((System.Drawing.Image)(resources.GetObject("bttnHome.Image")));
            this.bttnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnHome.Location = new System.Drawing.Point(19, 49);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(169, 100);
            this.bttnHome.TabIndex = 3;
            this.bttnHome.Text = "       Home";
            this.bttnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.BttnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(275, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 150);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simulations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "DevOps";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(960, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 6;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.aboutUsControl11);
            this.panel5.Controls.Add(this.historyControl11);
            this.panel5.Controls.Add(this.homePageControl1);
            this.panel5.Location = new System.Drawing.Point(191, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(851, 395);
            this.panel5.TabIndex = 8;
            // 
            // aboutUsControl11
            // 
            this.aboutUsControl11.Location = new System.Drawing.Point(3, -13);
            this.aboutUsControl11.Name = "aboutUsControl11";
            this.aboutUsControl11.Size = new System.Drawing.Size(851, 399);
            this.aboutUsControl11.TabIndex = 2;
            // 
            // historyControl11
            // 
            this.historyControl11.Location = new System.Drawing.Point(0, 0);
            this.historyControl11.Name = "historyControl11";
            this.historyControl11.Size = new System.Drawing.Size(851, 386);
            this.historyControl11.TabIndex = 1;
            // homePageControl1
            // 
            this.homePageControl1.Location = new System.Drawing.Point(0, 3);
            this.homePageControl1.Name = "homePageControl1";
            this.homePageControl1.Size = new System.Drawing.Size(851, 371);
            this.homePageControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(902, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 9;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(902, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 10;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bttnFront
            // 
            this.bttnFront.FlatAppearance.BorderSize = 0;
            this.bttnFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFront.ForeColor = System.Drawing.Color.White;
            this.bttnFront.Image = ((System.Drawing.Image)(resources.GetObject("bttnFront.Image")));
            this.bttnFront.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnFront.Location = new System.Drawing.Point(835, 27);
            this.bttnFront.Name = "bttnFront";
            this.bttnFront.Size = new System.Drawing.Size(61, 42);
            this.bttnFront.TabIndex = 11;
            this.bttnFront.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnFront.UseVisualStyleBackColor = true;
            this.bttnFront.Click += new System.EventHandler(this.BttnFront_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 541);
            this.Controls.Add(this.bttnFront);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button bttnHistory;
        private System.Windows.Forms.Button bttnAboutUs;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private HomePageControl homePageControl1;
        private AboutUsControl1 aboutUsControl11;
        private HistoryControl1 historyControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttnFront;
    }
}

