namespace FireSimulation
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurvived = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(288, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulation Done!";
            // 
            // lblSurvived
            // 
            this.lblSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurvived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurvived.Location = new System.Drawing.Point(190, 142);
            this.lblSurvived.Name = "lblSurvived";
            this.lblSurvived.Size = new System.Drawing.Size(250, 35);
            this.lblSurvived.TabIndex = 3;
            this.lblSurvived.Text = "People Survived: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::FireSimulation.Properties.Resources.pill;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(325, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(190, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(250, 35);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time: ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::FireSimulation.Properties.Resources.pill;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(325, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Statistics";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(750, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 45);
            this.button4.TabIndex = 7;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.FlatAppearance.BorderSize = 0;
            this.bttnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.ForeColor = System.Drawing.Color.White;
            this.bttnBack.Image = ((System.Drawing.Image)(resources.GetObject("bttnBack.Image")));
            this.bttnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBack.Location = new System.Drawing.Point(616, 23);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(61, 45);
            this.bttnBack.TabIndex = 8;
            this.bttnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.BttnBack_Click);
            // 
            // bttnFront
            // 
            this.bttnFront.FlatAppearance.BorderSize = 0;
            this.bttnFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFront.ForeColor = System.Drawing.Color.White;
            this.bttnFront.Image = ((System.Drawing.Image)(resources.GetObject("bttnFront.Image")));
            this.bttnFront.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnFront.Location = new System.Drawing.Point(683, 23);
            this.bttnFront.Name = "bttnFront";
            this.bttnFront.Size = new System.Drawing.Size(61, 45);
            this.bttnFront.TabIndex = 9;
            this.bttnFront.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnFront.UseVisualStyleBackColor = true;
            this.bttnFront.Click += new System.EventHandler(this.BttnFront_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 496);
            this.Controls.Add(this.bttnFront);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSurvived);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurvived;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnFront;
    }
}