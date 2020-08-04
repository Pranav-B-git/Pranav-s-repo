namespace DIET_AND_FITNESS_MANAGEMENT_SYSTEM
{
    partial class SearchBarUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBarUc));
            this.Search_Bar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WOradioButton1 = new System.Windows.Forms.RadioButton();
            this.NUradioButton2 = new System.Windows.Forms.RadioButton();
            this.labelfib = new System.Windows.Forms.Label();
            this.labelpro = new System.Windows.Forms.Label();
            this.labelcal = new System.Windows.Forms.Label();
            this.labelfood = new System.Windows.Forms.Label();
            this.labelfat = new System.Windows.Forms.Label();
            this.labelvit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Bar
            // 
            this.Search_Bar.AllowDrop = true;
            this.Search_Bar.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple",
            "Almonds",
            "Bananna"});
            this.Search_Bar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search_Bar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_Bar.Location = new System.Drawing.Point(96, 45);
            this.Search_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.Size = new System.Drawing.Size(684, 22);
            this.Search_Bar.TabIndex = 2;
            this.Search_Bar.TextChanged += new System.EventHandler(this.Search_Bar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(788, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 127);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WOradioButton1
            // 
            this.WOradioButton1.AutoSize = true;
            this.WOradioButton1.BackColor = System.Drawing.Color.Transparent;
            this.WOradioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOradioButton1.ForeColor = System.Drawing.Color.White;
            this.WOradioButton1.Location = new System.Drawing.Point(832, 31);
            this.WOradioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.WOradioButton1.Name = "WOradioButton1";
            this.WOradioButton1.Size = new System.Drawing.Size(120, 20);
            this.WOradioButton1.TabIndex = 5;
            this.WOradioButton1.TabStop = true;
            this.WOradioButton1.Text = "Workout Data";
            this.WOradioButton1.UseVisualStyleBackColor = false;
            this.WOradioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NUradioButton2
            // 
            this.NUradioButton2.AutoSize = true;
            this.NUradioButton2.BackColor = System.Drawing.Color.Transparent;
            this.NUradioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUradioButton2.ForeColor = System.Drawing.Color.White;
            this.NUradioButton2.Location = new System.Drawing.Point(832, 59);
            this.NUradioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.NUradioButton2.Name = "NUradioButton2";
            this.NUradioButton2.Size = new System.Drawing.Size(120, 20);
            this.NUradioButton2.TabIndex = 6;
            this.NUradioButton2.TabStop = true;
            this.NUradioButton2.Text = "Nutrition Data";
            this.NUradioButton2.UseVisualStyleBackColor = false;
            this.NUradioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelfib
            // 
            this.labelfib.AutoSize = true;
            this.labelfib.BackColor = System.Drawing.Color.Transparent;
            this.labelfib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfib.ForeColor = System.Drawing.Color.White;
            this.labelfib.Location = new System.Drawing.Point(418, 198);
            this.labelfib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfib.Name = "labelfib";
            this.labelfib.Size = new System.Drawing.Size(93, 15);
            this.labelfib.TabIndex = 15;
            this.labelfib.Text = "FIBER ( in g )";
            this.labelfib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelfib.Visible = false;
            this.labelfib.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelpro
            // 
            this.labelpro.AutoSize = true;
            this.labelpro.BackColor = System.Drawing.Color.Transparent;
            this.labelpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpro.ForeColor = System.Drawing.Color.White;
            this.labelpro.Location = new System.Drawing.Point(550, 198);
            this.labelpro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpro.Name = "labelpro";
            this.labelpro.Size = new System.Drawing.Size(101, 15);
            this.labelpro.TabIndex = 16;
            this.labelpro.Text = "PROTEIN(in g)";
            this.labelpro.Visible = false;
            this.labelpro.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelcal
            // 
            this.labelcal.AutoSize = true;
            this.labelcal.BackColor = System.Drawing.Color.Transparent;
            this.labelcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcal.ForeColor = System.Drawing.Color.White;
            this.labelcal.Location = new System.Drawing.Point(233, 198);
            this.labelcal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcal.Name = "labelcal";
            this.labelcal.Size = new System.Drawing.Size(142, 15);
            this.labelcal.TabIndex = 14;
            this.labelcal.Text = "CALORIES(Per 100g)";
            this.labelcal.Visible = false;
            this.labelcal.Click += new System.EventHandler(this.labelcal_Click);
            // 
            // labelfood
            // 
            this.labelfood.AutoSize = true;
            this.labelfood.BackColor = System.Drawing.Color.Transparent;
            this.labelfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfood.ForeColor = System.Drawing.Color.White;
            this.labelfood.Location = new System.Drawing.Point(104, 198);
            this.labelfood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfood.Name = "labelfood";
            this.labelfood.Size = new System.Drawing.Size(88, 15);
            this.labelfood.TabIndex = 13;
            this.labelfood.Text = "FOOD NAME";
            this.labelfood.Visible = false;
            this.labelfood.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelfat
            // 
            this.labelfat.AutoSize = true;
            this.labelfat.BackColor = System.Drawing.Color.Transparent;
            this.labelfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfat.ForeColor = System.Drawing.Color.White;
            this.labelfat.Location = new System.Drawing.Point(802, 198);
            this.labelfat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfat.Name = "labelfat";
            this.labelfat.Size = new System.Drawing.Size(65, 15);
            this.labelfat.TabIndex = 18;
            this.labelfat.Text = "FAT(in g)";
            this.labelfat.Visible = false;
            this.labelfat.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelvit
            // 
            this.labelvit.AutoSize = true;
            this.labelvit.BackColor = System.Drawing.Color.Transparent;
            this.labelvit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvit.ForeColor = System.Drawing.Color.White;
            this.labelvit.Location = new System.Drawing.Point(701, 198);
            this.labelvit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelvit.Name = "labelvit";
            this.labelvit.Size = new System.Drawing.Size(70, 15);
            this.labelvit.TabIndex = 17;
            this.labelvit.Text = "VITAMINS";
            this.labelvit.Visible = false;
            this.labelvit.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(701, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "VITAMINS";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(802, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "FAT ( in g )";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "FOOD NAME";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "CALORIES(Per 100g)";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(550, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "PROTEIN ( in g )";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "FIBER ( in g )";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // SearchBarUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelvit);
            this.Controls.Add(this.labelfat);
            this.Controls.Add(this.labelfood);
            this.Controls.Add(this.NUradioButton2);
            this.Controls.Add(this.labelcal);
            this.Controls.Add(this.WOradioButton1);
            this.Controls.Add(this.labelpro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelfib);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search_Bar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchBarUc";
            this.Size = new System.Drawing.Size(1025, 549);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_Bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton WOradioButton1;
        private System.Windows.Forms.RadioButton NUradioButton2;
        private System.Windows.Forms.Label labelfib;
        private System.Windows.Forms.Label labelpro;
        private System.Windows.Forms.Label labelcal;
        private System.Windows.Forms.Label labelfood;
        private System.Windows.Forms.Label labelfat;
        private System.Windows.Forms.Label labelvit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
