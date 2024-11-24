namespace PresentationProject
{
    partial class Registration
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.facultydl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lnametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.fnametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.registerb = new Guna.UI2.WinForms.Guna2Button();
            this.exit = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordtb1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernametb1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.facultydl);
            this.guna2ShadowPanel1.Controls.Add(this.lnametb);
            this.guna2ShadowPanel1.Controls.Add(this.fnametb);
            this.guna2ShadowPanel1.Controls.Add(this.registerb);
            this.guna2ShadowPanel1.Controls.Add(this.exit);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.passwordtb1);
            this.guna2ShadowPanel1.Controls.Add(this.usernametb1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(334, 418);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(103, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose faculty";
            // 
            // facultydl
            // 
            this.facultydl.BackColor = System.Drawing.Color.Transparent;
            this.facultydl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.facultydl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultydl.FocusedColor = System.Drawing.Color.Empty;
            this.facultydl.FocusedState.Parent = this.facultydl;
            this.facultydl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.facultydl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.facultydl.FormattingEnabled = true;
            this.facultydl.HoverState.Parent = this.facultydl;
            this.facultydl.ItemHeight = 30;
            this.facultydl.Items.AddRange(new object[] {
            "Computer Science",
            "Engineering",
            "Medicine",
            "Law",
            "Arts",
            "Business Administration",
            "Education",
            "Social Sciences",
            "Natural Sciences",
            "Pharmacy",
            "Architecture",
            "Economics",
            "Psychology",
            "Agricultural Sciences",
            "Mathematics",
            "Linguistics",
            "History",
            "Chemistry",
            "Environmental Studies"});
            this.facultydl.ItemsAppearance.Parent = this.facultydl;
            this.facultydl.Location = new System.Drawing.Point(39, 297);
            this.facultydl.Name = "facultydl";
            this.facultydl.ShadowDecoration.Parent = this.facultydl;
            this.facultydl.Size = new System.Drawing.Size(250, 36);
            this.facultydl.TabIndex = 9;
            // 
            // lnametb
            // 
            this.lnametb.AutoRoundedCorners = true;
            this.lnametb.BackColor = System.Drawing.Color.Transparent;
            this.lnametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lnametb.BorderRadius = 16;
            this.lnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnametb.DefaultText = "";
            this.lnametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnametb.DisabledState.Parent = this.lnametb;
            this.lnametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnametb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lnametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnametb.FocusedState.Parent = this.lnametb;
            this.lnametb.ForeColor = System.Drawing.Color.Black;
            this.lnametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnametb.HoverState.Parent = this.lnametb;
            this.lnametb.Location = new System.Drawing.Point(39, 229);
            this.lnametb.Name = "lnametb";
            this.lnametb.PasswordChar = '\0';
            this.lnametb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.lnametb.PlaceholderText = "👤 Last name";
            this.lnametb.SelectedText = "";
            this.lnametb.ShadowDecoration.BorderRadius = 16;
            this.lnametb.ShadowDecoration.Enabled = true;
            this.lnametb.ShadowDecoration.Parent = this.lnametb;
            this.lnametb.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lnametb.Size = new System.Drawing.Size(250, 35);
            this.lnametb.TabIndex = 8;
            // 
            // fnametb
            // 
            this.fnametb.AutoRoundedCorners = true;
            this.fnametb.BackColor = System.Drawing.Color.Transparent;
            this.fnametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.fnametb.BorderRadius = 16;
            this.fnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnametb.DefaultText = "";
            this.fnametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnametb.DisabledState.Parent = this.fnametb;
            this.fnametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnametb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.fnametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnametb.FocusedState.Parent = this.fnametb;
            this.fnametb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametb.ForeColor = System.Drawing.Color.Black;
            this.fnametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnametb.HoverState.Parent = this.fnametb;
            this.fnametb.Location = new System.Drawing.Point(39, 178);
            this.fnametb.Margin = new System.Windows.Forms.Padding(4);
            this.fnametb.Name = "fnametb";
            this.fnametb.PasswordChar = '\0';
            this.fnametb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.fnametb.PlaceholderText = "👤 First name";
            this.fnametb.SelectedText = "";
            this.fnametb.ShadowDecoration.BorderRadius = 16;
            this.fnametb.ShadowDecoration.Enabled = true;
            this.fnametb.ShadowDecoration.Parent = this.fnametb;
            this.fnametb.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.fnametb.Size = new System.Drawing.Size(250, 35);
            this.fnametb.TabIndex = 7;
            // 
            // registerb
            // 
            this.registerb.AutoRoundedCorners = true;
            this.registerb.BackColor = System.Drawing.Color.Transparent;
            this.registerb.BorderColor = System.Drawing.Color.RoyalBlue;
            this.registerb.BorderRadius = 21;
            this.registerb.CheckedState.Parent = this.registerb;
            this.registerb.CustomImages.Parent = this.registerb;
            this.registerb.FillColor = System.Drawing.Color.CornflowerBlue;
            this.registerb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerb.ForeColor = System.Drawing.Color.White;
            this.registerb.HoverState.Parent = this.registerb;
            this.registerb.Location = new System.Drawing.Point(61, 348);
            this.registerb.Name = "registerb";
            this.registerb.ShadowDecoration.BorderRadius = 25;
            this.registerb.ShadowDecoration.Depth = 25;
            this.registerb.ShadowDecoration.Enabled = true;
            this.registerb.ShadowDecoration.Parent = this.registerb;
            this.registerb.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.registerb.Size = new System.Drawing.Size(200, 45);
            this.registerb.TabIndex = 6;
            this.registerb.Text = "Sign Up";
            this.registerb.Click += new System.EventHandler(this.registerb_Click);
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.FillColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.exit.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Location = new System.Drawing.Point(281, 4);
            this.exit.Name = "exit";
            this.exit.PressedColor = System.Drawing.Color.Transparent;
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(51, 37);
            this.exit.TabIndex = 2;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION";
            // 
            // passwordtb1
            // 
            this.passwordtb1.AutoRoundedCorners = true;
            this.passwordtb1.BackColor = System.Drawing.Color.Transparent;
            this.passwordtb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.passwordtb1.BorderRadius = 16;
            this.passwordtb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtb1.DefaultText = "";
            this.passwordtb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtb1.DisabledState.Parent = this.passwordtb1;
            this.passwordtb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtb1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.passwordtb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtb1.FocusedState.Parent = this.passwordtb1;
            this.passwordtb1.ForeColor = System.Drawing.Color.Black;
            this.passwordtb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtb1.HoverState.Parent = this.passwordtb1;
            this.passwordtb1.Location = new System.Drawing.Point(39, 130);
            this.passwordtb1.Name = "passwordtb1";
            this.passwordtb1.PasswordChar = '\0';
            this.passwordtb1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordtb1.PlaceholderText = "🔑 Password";
            this.passwordtb1.SelectedText = "";
            this.passwordtb1.ShadowDecoration.BorderRadius = 16;
            this.passwordtb1.ShadowDecoration.Enabled = true;
            this.passwordtb1.ShadowDecoration.Parent = this.passwordtb1;
            this.passwordtb1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.passwordtb1.Size = new System.Drawing.Size(250, 35);
            this.passwordtb1.TabIndex = 3;
            // 
            // usernametb1
            // 
            this.usernametb1.AutoRoundedCorners = true;
            this.usernametb1.BackColor = System.Drawing.Color.Transparent;
            this.usernametb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.usernametb1.BorderRadius = 16;
            this.usernametb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametb1.DefaultText = "";
            this.usernametb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametb1.DisabledState.Parent = this.usernametb1;
            this.usernametb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametb1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.usernametb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametb1.FocusedState.Parent = this.usernametb1;
            this.usernametb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb1.ForeColor = System.Drawing.Color.Black;
            this.usernametb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametb1.HoverState.Parent = this.usernametb1;
            this.usernametb1.Location = new System.Drawing.Point(39, 79);
            this.usernametb1.Margin = new System.Windows.Forms.Padding(4);
            this.usernametb1.Name = "usernametb1";
            this.usernametb1.PasswordChar = '\0';
            this.usernametb1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernametb1.PlaceholderText = "👤 Username";
            this.usernametb1.SelectedText = "";
            this.usernametb1.ShadowDecoration.BorderRadius = 16;
            this.usernametb1.ShadowDecoration.Enabled = true;
            this.usernametb1.ShadowDecoration.Parent = this.usernametb1;
            this.usernametb1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.usernametb1.Size = new System.Drawing.Size(250, 35);
            this.usernametb1.TabIndex = 2;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TileButton exit;
        private Guna.UI2.WinForms.Guna2Button registerb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordtb1;
        private Guna.UI2.WinForms.Guna2TextBox usernametb1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox facultydl;
        private Guna.UI2.WinForms.Guna2TextBox lnametb;
        private Guna.UI2.WinForms.Guna2TextBox fnametb;
        private System.Windows.Forms.Label label2;
    }
}