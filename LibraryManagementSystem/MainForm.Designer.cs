
namespace LibraryManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.greet_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.issueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.dashboard2 = new LibraryManagementSystem.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 53);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System | Main Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1623, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.issueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 870);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 817);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log out";
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(62, 202);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(190, 29);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard2);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(329, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1321, 870);
            this.panel3.TabIndex = 2;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1320, 869);
            this.addBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(1320, 869);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1320, 869);
            this.returnBooks1.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.logout_btn.Location = new System.Drawing.Point(12, 803);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(52, 54);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(12, 520);
            this.returnBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.returnBooks_btn.TabIndex = 5;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.UseVisualStyleBackColor = true;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // issueBooks_btn
            // 
            this.issueBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issueBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.issueBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.issueBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBooks_btn.Location = new System.Drawing.Point(12, 442);
            this.issueBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issueBooks_btn.Name = "issueBooks_btn";
            this.issueBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.issueBooks_btn.TabIndex = 4;
            this.issueBooks_btn.Text = "ISSUE BOOKS";
            this.issueBooks_btn.UseVisualStyleBackColor = true;
            this.issueBooks_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(12, 363);
            this.addBooks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(300, 69);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "ADD BOOKS";
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 285);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(300, 69);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.sddefault_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(52, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(21, 30);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1320, 869);
            this.dashboard1.TabIndex = 3;
            // 
            // dashboard2
            // 
            this.dashboard2.Location = new System.Drawing.Point(0, 0);
            this.dashboard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(1320, 869);
            this.dashboard2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 923);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnBooks_btn;
        private System.Windows.Forms.Button issueBooks_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private ReturnBooks returnBooks1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private Dashboard dashboard1;
        private Dashboard dashboard2;
    }
}