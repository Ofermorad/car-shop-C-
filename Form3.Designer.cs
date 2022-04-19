namespace proj2
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_show_users = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.del_pass_txt = new System.Windows.Forms.TextBox();
            this.name_del_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(525, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(421, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_show_users
            // 
            this.btn_show_users.Location = new System.Drawing.Point(666, 491);
            this.btn_show_users.Name = "btn_show_users";
            this.btn_show_users.Size = new System.Drawing.Size(112, 34);
            this.btn_show_users.TabIndex = 1;
            this.btn_show_users.Text = "show_users";
            this.btn_show_users.UseVisualStyleBackColor = true;
            this.btn_show_users.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(84, 170);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(112, 34);
            this.btn_add_user.TabIndex = 2;
            this.btn_add_user.Text = "add user";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "pass";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(179, 65);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(150, 31);
            this.name_txt.TabIndex = 5;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(180, 112);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(150, 31);
            this.pass_txt.TabIndex = 6;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(218, 170);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(298, 357);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 34);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "delete";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // del_pass_txt
            // 
            this.del_pass_txt.Location = new System.Drawing.Point(260, 299);
            this.del_pass_txt.Name = "del_pass_txt";
            this.del_pass_txt.Size = new System.Drawing.Size(150, 31);
            this.del_pass_txt.TabIndex = 12;
            // 
            // name_del_txt
            // 
            this.name_del_txt.Location = new System.Drawing.Point(259, 252);
            this.name_del_txt.Name = "name_del_txt";
            this.name_del_txt.Size = new System.Drawing.Size(150, 31);
            this.name_del_txt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "name";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(164, 357);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(112, 34);
            this.btn_find.TabIndex = 8;
            this.btn_find.Text = "find user";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.del_pass_txt);
            this.Controls.Add(this.name_del_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.btn_show_users);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_show_users;
        private Button btn_add_user;
        private Label label1;
        private Label label2;
        private TextBox name_txt;
        private TextBox pass_txt;
        private Button btn_clear;
        private Button btn_del;
        private TextBox del_pass_txt;
        private TextBox name_del_txt;
        private Label label3;
        private Label label4;
        private Button btn_find;
    }
}