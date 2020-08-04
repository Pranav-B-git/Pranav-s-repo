namespace DIET_AND_FITNESS_MANAGEMENT_SYSTEM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Diet_log = new System.Windows.Forms.Button();
            this.WORKOUT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Diet_log
            // 
            this.Diet_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.Diet_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diet_log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Diet_log.Location = new System.Drawing.Point(2, 63);
            this.Diet_log.Name = "Diet_log";
            this.Diet_log.Size = new System.Drawing.Size(118, 38);
            this.Diet_log.TabIndex = 0;
            this.Diet_log.Text = "DIET LOG";
            this.Diet_log.UseVisualStyleBackColor = false;
            this.Diet_log.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WORKOUT
            // 
            this.WORKOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.WORKOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WORKOUT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WORKOUT.Location = new System.Drawing.Point(2, 107);
            this.WORKOUT.Name = "WORKOUT";
            this.WORKOUT.Size = new System.Drawing.Size(118, 38);
            this.WORKOUT.TabIndex = 1;
            this.WORKOUT.Text = "WORKOUT";
            this.WORKOUT.UseVisualStyleBackColor = false;
            this.WORKOUT.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(2, 192);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "LOG OUT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.search.Location = new System.Drawing.Point(2, 151);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(118, 38);
            this.search.TabIndex = 3;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button4_Click);
            // 
            // Content_Panel
            // 
            this.Content_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Content_Panel.Location = new System.Drawing.Point(123, 17);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(1025, 549);
            this.Content_Panel.TabIndex = 4;
            this.Content_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 55);
            this.label3.TabIndex = 26;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Content_Panel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WORKOUT);
            this.Controls.Add(this.Diet_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diet_log;
        private System.Windows.Forms.Button WORKOUT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel Content_Panel;
        private System.Windows.Forms.Label label3;
    }
}