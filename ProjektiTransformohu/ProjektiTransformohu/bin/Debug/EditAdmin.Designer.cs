namespace ProjektiTransformohu
{
    partial class EditAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKerko = new Bunifu.Framework.UI.BunifuFlatButton();
            this.editTable = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.load = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mobile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.idE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.txtbSearch);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnKerko);
            this.panel4.Controls.Add(this.editTable);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.load);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.mobile);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.username);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.idE);
            this.panel4.Controls.Add(this.btn_Edit);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1118, 686);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtbSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.ForeColor = System.Drawing.Color.White;
            this.txtbSearch.Location = new System.Drawing.Point(834, 77);
            this.txtbSearch.Multiline = true;
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(120, 36);
            this.txtbSearch.TabIndex = 48;
            this.txtbSearch.TextChanged += new System.EventHandler(this.TxtbSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(762, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Kerko";
            // 
            // btnKerko
            // 
            this.btnKerko.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKerko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKerko.BorderRadius = 7;
            this.btnKerko.ButtonText = "  Kerko";
            this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKerko.DisabledColor = System.Drawing.Color.Gray;
            this.btnKerko.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKerko.Iconimage = global::ProjektiTransformohu.Properties.Resources.kerko;
            this.btnKerko.Iconimage_right = null;
            this.btnKerko.Iconimage_right_Selected = null;
            this.btnKerko.Iconimage_Selected = null;
            this.btnKerko.IconMarginLeft = 0;
            this.btnKerko.IconMarginRight = 0;
            this.btnKerko.IconRightVisible = true;
            this.btnKerko.IconRightZoom = 0D;
            this.btnKerko.IconVisible = true;
            this.btnKerko.IconZoom = 65D;
            this.btnKerko.IsTab = false;
            this.btnKerko.Location = new System.Drawing.Point(973, 67);
            this.btnKerko.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKerko.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKerko.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKerko.selected = false;
            this.btnKerko.Size = new System.Drawing.Size(119, 46);
            this.btnKerko.TabIndex = 46;
            this.btnKerko.Text = "  Kerko";
            this.btnKerko.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Textcolor = System.Drawing.Color.White;
            this.btnKerko.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // editTable
            // 
            this.editTable.AllowUserToAddRows = false;
            this.editTable.AllowUserToDeleteRows = false;
            this.editTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.editTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editTable.ColumnHeadersHeight = 30;
            this.editTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.editTable.EnableHeadersVisualStyles = false;
            this.editTable.GridColor = System.Drawing.Color.SteelBlue;
            this.editTable.Location = new System.Drawing.Point(450, 144);
            this.editTable.Name = "editTable";
            this.editTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.editTable.Size = new System.Drawing.Size(642, 448);
            this.editTable.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "user",
            "admin",
            "super admin"});
            this.comboBox1.Location = new System.Drawing.Point(152, 473);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 27);
            this.comboBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "UserType";
            // 
            // load
            // 
            this.load.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load.BorderRadius = 7;
            this.load.ButtonText = "  Load";
            this.load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load.DisabledColor = System.Drawing.Color.Gray;
            this.load.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Iconcolor = System.Drawing.Color.Transparent;
            this.load.Iconimage = global::ProjektiTransformohu.Properties.Resources.load;
            this.load.Iconimage_right = null;
            this.load.Iconimage_right_Selected = null;
            this.load.Iconimage_Selected = null;
            this.load.IconMarginLeft = 0;
            this.load.IconMarginRight = 0;
            this.load.IconRightVisible = true;
            this.load.IconRightZoom = 0D;
            this.load.IconVisible = true;
            this.load.IconZoom = 56D;
            this.load.IsTab = false;
            this.load.Location = new System.Drawing.Point(344, 144);
            this.load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.load.Name = "load";
            this.load.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.load.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.load.OnHoverTextColor = System.Drawing.Color.White;
            this.load.selected = false;
            this.load.Size = new System.Drawing.Size(100, 40);
            this.load.TabIndex = 24;
            this.load.Text = "  Load";
            this.load.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load.Textcolor = System.Drawing.Color.White;
            this.load.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(12, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mobile";
            // 
            // mobile
            // 
            this.mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.ForeColor = System.Drawing.Color.White;
            this.mobile.HintForeColor = System.Drawing.Color.SeaGreen;
            this.mobile.HintText = "";
            this.mobile.isPassword = false;
            this.mobile.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.mobile.LineIdleColor = System.Drawing.Color.Gray;
            this.mobile.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.mobile.LineThickness = 4;
            this.mobile.Location = new System.Drawing.Point(134, 391);
            this.mobile.Margin = new System.Windows.Forms.Padding(4);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(174, 45);
            this.mobile.TabIndex = 19;
            this.mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.HintForeColor = System.Drawing.Color.SeaGreen;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.name.LineThickness = 4;
            this.name.Location = new System.Drawing.Point(134, 318);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(174, 45);
            this.name.TabIndex = 17;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HintForeColor = System.Drawing.Color.SeaGreen;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.password.LineThickness = 4;
            this.password.Location = new System.Drawing.Point(134, 246);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(174, 45);
            this.password.TabIndex = 15;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.HintForeColor = System.Drawing.Color.SeaGreen;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.username.LineThickness = 4;
            this.username.Location = new System.Drawing.Point(134, 180);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 45);
            this.username.TabIndex = 13;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // idE
            // 
            this.idE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idE.ForeColor = System.Drawing.Color.White;
            this.idE.HintForeColor = System.Drawing.Color.SeaGreen;
            this.idE.HintText = "";
            this.idE.isPassword = false;
            this.idE.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.idE.LineIdleColor = System.Drawing.Color.Gray;
            this.idE.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.idE.LineThickness = 4;
            this.idE.Location = new System.Drawing.Point(134, 117);
            this.idE.Margin = new System.Windows.Forms.Padding(4);
            this.idE.Name = "idE";
            this.idE.Size = new System.Drawing.Size(174, 45);
            this.idE.TabIndex = 6;
            this.idE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Edit.BorderRadius = 7;
            this.btn_Edit.ButtonText = "  Perditso Adminin";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Edit.Iconimage = global::ProjektiTransformohu.Properties.Resources.edit;
            this.btn_Edit.Iconimage_right = null;
            this.btn_Edit.Iconimage_right_Selected = null;
            this.btn_Edit.Iconimage_Selected = null;
            this.btn_Edit.IconMarginLeft = 0;
            this.btn_Edit.IconMarginRight = 0;
            this.btn_Edit.IconRightVisible = true;
            this.btn_Edit.IconRightZoom = 0D;
            this.btn_Edit.IconVisible = true;
            this.btn_Edit.IconZoom = 60D;
            this.btn_Edit.IsTab = false;
            this.btn_Edit.Location = new System.Drawing.Point(99, 528);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Edit.selected = false;
            this.btn_Edit.Size = new System.Drawing.Size(209, 64);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "  Perditso Adminin";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Textcolor = System.Drawing.Color.White;
            this.btn_Edit.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjektiTransformohu.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(431, -17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 647);
            this.Controls.Add(this.panel4);
            this.Name = "EditAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perditso Perdorusin";
            this.Load += new System.EventHandler(this.EditAdmin_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Edit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mobile;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuFlatButton load;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView editTable;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnKerko;
    }
}