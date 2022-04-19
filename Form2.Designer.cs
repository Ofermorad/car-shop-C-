namespace proj2
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_wheels = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_del_se = new System.Windows.Forms.Button();
            this.txt_wheels_se = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_type_se = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_sql = new System.Windows.Forms.Button();
            this.che_sql = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(252, 259);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wheels";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // txt_wheels
            // 
            this.txt_wheels.Location = new System.Drawing.Point(191, 120);
            this.txt_wheels.Name = "txt_wheels";
            this.txt_wheels.Size = new System.Drawing.Size(150, 31);
            this.txt_wheels.TabIndex = 4;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(191, 180);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(150, 31);
            this.txt_type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(117, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add new car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 111);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(533, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delete c car";
            // 
            // btn_del_se
            // 
            this.btn_del_se.Location = new System.Drawing.Point(668, 259);
            this.btn_del_se.Name = "btn_del_se";
            this.btn_del_se.Size = new System.Drawing.Size(112, 34);
            this.btn_del_se.TabIndex = 10;
            this.btn_del_se.Text = "delete";
            this.btn_del_se.UseVisualStyleBackColor = true;
            this.btn_del_se.Click += new System.EventHandler(this.btn_del_se_Click);
            // 
            // txt_wheels_se
            // 
            this.txt_wheels_se.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_wheels_se.Location = new System.Drawing.Point(630, 183);
            this.txt_wheels_se.Name = "txt_wheels_se";
            this.txt_wheels_se.Size = new System.Drawing.Size(150, 31);
            this.txt_wheels_se.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wheels";
            // 
            // txt_type_se
            // 
            this.txt_type_se.Location = new System.Drawing.Point(630, 120);
            this.txt_type_se.Name = "txt_type_se";
            this.txt_type_se.Size = new System.Drawing.Size(150, 31);
            this.txt_type_se.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type";
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(117, 259);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(112, 34);
            this.btn_add2.TabIndex = 16;
            this.btn_add2.Text = "add";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(533, 259);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 34);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 490);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_sql
            // 
            this.btn_sql.Location = new System.Drawing.Point(594, 442);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(112, 34);
            this.btn_sql.TabIndex = 19;
            this.btn_sql.Text = "Sql";
            this.btn_sql.UseVisualStyleBackColor = true;
            this.btn_sql.Click += new System.EventHandler(this.btn_sql_Click);
            // 
            // che_sql
            // 
            this.che_sql.AutoSize = true;
            this.che_sql.Location = new System.Drawing.Point(594, 407);
            this.che_sql.Name = "che_sql";
            this.che_sql.Size = new System.Drawing.Size(79, 29);
            this.che_sql.TabIndex = 20;
            this.che_sql.Text = "sure?";
            this.che_sql.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(578, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 43);
            this.label7.TabIndex = 21;
            this.label7.Text = "Go SQL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.che_sql);
            this.Controls.Add(this.btn_sql);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_type_se);
            this.Controls.Add(this.txt_wheels_se);
            this.Controls.Add(this.btn_del_se);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_wheels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_clear;
        private Label label1;
        private Label label2;
        private TextBox txt_wheels;
        private TextBox txt_type;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btn_del_se;
        private TextBox txt_wheels_se;
        private Label label6;
        private TextBox txt_type_se;
        private Label label5;
        private Button btn_add2;
        private Button btn_search;
        private DateTimePicker dateTimePicker1;
        private Button btn_sql;
        private CheckBox che_sql;
        private Label label7;
    }
}