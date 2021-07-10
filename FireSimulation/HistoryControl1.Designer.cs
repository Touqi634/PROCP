namespace FireSimulation
{
    partial class HistoryControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.People = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Survived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fire_Intensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Stamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblSurvived = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.srv = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.Label();
            this.fir = new System.Windows.Forms.Label();
            this.inte = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.exi = new System.Windows.Forms.Label();
            this.ppl = new System.Windows.Forms.Label();
            this.bttnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.People,
            this.Survived,
            this.Time,
            this.Fire,
            this.Fire_Intensity,
            this.Floor_Plan,
            this.Time_Stamp});
            this.dgvHistory.Location = new System.Drawing.Point(70, 59);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(739, 229);
            this.dgvHistory.TabIndex = 1;
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistory_CellClick);
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistory_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // People
            // 
            this.People.HeaderText = "People";
            this.People.MinimumWidth = 6;
            this.People.Name = "People";
            this.People.ReadOnly = true;
            this.People.Visible = false;
            this.People.Width = 125;
            // 
            // Survived
            // 
            this.Survived.HeaderText = "Survived";
            this.Survived.MinimumWidth = 6;
            this.Survived.Name = "Survived";
            this.Survived.ReadOnly = true;
            this.Survived.Visible = false;
            this.Survived.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Visible = false;
            this.Time.Width = 125;
            // 
            // Fire
            // 
            this.Fire.HeaderText = "Fire";
            this.Fire.MinimumWidth = 6;
            this.Fire.Name = "Fire";
            this.Fire.ReadOnly = true;
            this.Fire.Visible = false;
            this.Fire.Width = 125;
            // 
            // Fire_Intensity
            // 
            this.Fire_Intensity.HeaderText = "Fire_Intensity";
            this.Fire_Intensity.MinimumWidth = 6;
            this.Fire_Intensity.Name = "Fire_Intensity";
            this.Fire_Intensity.ReadOnly = true;
            this.Fire_Intensity.Visible = false;
            this.Fire_Intensity.Width = 125;
            // 
            // Floor_Plan
            // 
            this.Floor_Plan.HeaderText = "Floor Plan";
            this.Floor_Plan.MinimumWidth = 6;
            this.Floor_Plan.Name = "Floor_Plan";
            this.Floor_Plan.ReadOnly = true;
            this.Floor_Plan.Width = 125;
            // 
            // Time_Stamp
            // 
            this.Time_Stamp.HeaderText = "Time Stamp";
            this.Time_Stamp.MinimumWidth = 6;
            this.Time_Stamp.Name = "Time_Stamp";
            this.Time_Stamp.ReadOnly = true;
            this.Time_Stamp.Width = 125;
            // 
            // lblPeople
            // 
            this.lblPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeople.Location = new System.Drawing.Point(66, 303);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(173, 33);
            this.lblPeople.TabIndex = 5;
            this.lblPeople.Text = "No. People: ";
            // 
            // lblFire
            // 
            this.lblFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFire.Location = new System.Drawing.Point(245, 336);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(177, 45);
            this.lblFire.TabIndex = 6;
            this.lblFire.Text = "No. Fire: ";
            // 
            // lblSurvived
            // 
            this.lblSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurvived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurvived.Location = new System.Drawing.Point(66, 329);
            this.lblSurvived.Name = "lblSurvived";
            this.lblSurvived.Size = new System.Drawing.Size(173, 45);
            this.lblSurvived.TabIndex = 7;
            this.lblSurvived.Text = "Survival: ";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(245, 303);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(123, 33);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time: ";
            // 
            // lblIntensity
            // 
            this.lblIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntensity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIntensity.Location = new System.Drawing.Point(428, 303);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(156, 45);
            this.lblIntensity.TabIndex = 9;
            this.lblIntensity.Text = "Intensity: ";
            // 
            // srv
            // 
            this.srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.srv.Location = new System.Drawing.Point(170, 336);
            this.srv.Name = "srv";
            this.srv.Size = new System.Drawing.Size(54, 24);
            this.srv.TabIndex = 11;
            // 
            // tim
            // 
            this.tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tim.Location = new System.Drawing.Point(320, 303);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(102, 24);
            this.tim.TabIndex = 12;
            // 
            // fir
            // 
            this.fir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fir.Location = new System.Drawing.Point(339, 336);
            this.fir.Name = "fir";
            this.fir.Size = new System.Drawing.Size(62, 24);
            this.fir.TabIndex = 13;
            this.fir.Click += new System.EventHandler(this.Fir_Click);
            // 
            // inte
            // 
            this.inte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inte.Location = new System.Drawing.Point(521, 303);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(63, 24);
            this.inte.TabIndex = 14;
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExit.Location = new System.Drawing.Point(428, 336);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(156, 45);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "Exits:";
            // 
            // exi
            // 
            this.exi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exi.Location = new System.Drawing.Point(488, 339);
            this.exi.Name = "exi";
            this.exi.Size = new System.Drawing.Size(63, 24);
            this.exi.TabIndex = 16;
            // 
            // ppl
            // 
            this.ppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ppl.Location = new System.Drawing.Point(184, 301);
            this.ppl.Name = "ppl";
            this.ppl.Size = new System.Drawing.Size(55, 33);
            this.ppl.TabIndex = 10;
            // 
            // bttnOpen
            // 
            this.bttnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.bttnOpen.BackgroundImage = global::FireSimulation.Properties.Resources.pill;
            this.bttnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnOpen.FlatAppearance.BorderSize = 0;
            this.bttnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnOpen.Location = new System.Drawing.Point(612, 294);
            this.bttnOpen.Name = "bttnOpen";
            this.bttnOpen.Size = new System.Drawing.Size(161, 59);
            this.bttnOpen.TabIndex = 4;
            this.bttnOpen.Text = "Open";
            this.bttnOpen.UseVisualStyleBackColor = false;
            this.bttnOpen.Click += new System.EventHandler(this.BttnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(3, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 66);
            this.panel1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(597, -3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 56);
            this.button4.TabIndex = 18;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // HistoryControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exi);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.inte);
            this.Controls.Add(this.fir);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.srv);
            this.Controls.Add(this.ppl);
            this.Controls.Add(this.lblIntensity);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSurvived);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.bttnOpen);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.label1);
            this.Name = "HistoryControl1";
            this.Size = new System.Drawing.Size(885, 511);
            this.Load += new System.EventHandler(this.HistoryControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button bttnOpen;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label lblSurvived;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.Label srv;
        private System.Windows.Forms.Label tim;
        private System.Windows.Forms.Label fir;
        private System.Windows.Forms.Label inte;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label exi;
        private System.Windows.Forms.Label ppl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn People;
        private System.Windows.Forms.DataGridViewTextBoxColumn Survived;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fire_Intensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor_Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Stamp;
        private System.Windows.Forms.Button button4;
    }
}
