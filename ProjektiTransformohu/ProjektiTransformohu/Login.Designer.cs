namespace ProjektiTransformohu
{
    partial class Login
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
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comoboxType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSignOut = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.Info;
            this.username.Location = new System.Drawing.Point(179, 288);
            this.username.Name = "username";
            this.username.ShortcutsEnabled = false;
            this.username.Size = new System.Drawing.Size(154, 24);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.UseWaitCursor = true;
            this.username.Click += new System.EventHandler(this.Username_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(133, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.Info;
            this.password.Location = new System.Drawing.Point(179, 368);
            this.password.Name = "password";
            this.password.ShortcutsEnabled = false;
            this.password.Size = new System.Drawing.Size(154, 24);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.Password_Click);
            this.password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(133, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 5;
            // 
            // comoboxType
            // 
            this.comoboxType.AutoCompleteCustomSource.AddRange(new string[] {
            "user",
            "admin"});
            this.comoboxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comoboxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comoboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comoboxType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comoboxType.FormattingEnabled = true;
            this.comoboxType.ItemHeight = 22;
            this.comoboxType.Items.AddRange(new object[] {
            "user",
            "admin",
            "super admin"});
            this.comoboxType.Location = new System.Drawing.Point(212, 433);
            this.comoboxType.Name = "comoboxType";
            this.comoboxType.Size = new System.Drawing.Size(121, 30);
            this.comoboxType.TabIndex = 7;
            this.comoboxType.Click += new System.EventHandler(this.ComboBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(133, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Image = global::ProjektiTransformohu.Properties.Resources.power;
            this.btnSignOut.ImageActive = null;
            this.btnSignOut.Location = new System.Drawing.Point(426, 20);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(30, 31);
            this.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Zoom = 10;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjektiTransformohu.Properties.Resources.role;
            this.pictureBox4.Location = new System.Drawing.Point(167, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // picpass
            // 
            this.picpass.Image = global::ProjektiTransformohu.Properties.Resources.pss;
            this.picpass.Location = new System.Drawing.Point(133, 358);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(34, 33);
            this.picpass.TabIndex = 2;
            this.picpass.TabStop = false;
            // 
            // picuser
            // 
            this.picuser.Image = global::ProjektiTransformohu.Properties.Resources.uss;
            this.picuser.Location = new System.Drawing.Point(133, 280);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(34, 33);
            this.picuser.TabIndex = 1;
            this.picuser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjektiTransformohu.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(42, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(474, 658);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comoboxType);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comoboxType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Bunifu.Framework.UI.BunifuImageButton btnSignOut;
    }
}