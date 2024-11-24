namespace PresentationProject
{
    partial class TestForm
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.option1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.option2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.option3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.option4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.questionlb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lQuestion = new System.Windows.Forms.ListBox();
            this.eQuestion = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.completed = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.finishb = new Guna.UI2.WinForms.Guna2Button();
            this.timerlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.eQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(252)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(252)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Pink;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Quality = 250;
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(700, 600);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.eQuestion);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(700, 600);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(9, 139);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(263, 100);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "<p style=\"font-size: 22px\";>\r\n&#128075 Welcome back, <strong>admin</strong>!\r\n</p" +
    ">\r\n";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.questionlb);
            this.guna2GroupBox1.Controls.Add(this.option4);
            this.guna2GroupBox1.Controls.Add(this.option3);
            this.guna2GroupBox1.Controls.Add(this.option2);
            this.guna2GroupBox1.Controls.Add(this.option1);
            this.guna2GroupBox1.Controls.Add(this.Save);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(278, 14);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(370, 363);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Question #";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Save
            // 
            this.Save.AutoRoundedCorners = true;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Save.BorderRadius = 21;
            this.Save.CheckedState.Parent = this.Save;
            this.Save.CustomImages.Parent = this.Save;
            this.Save.FillColor = System.Drawing.Color.CornflowerBlue;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.HoverState.Parent = this.Save;
            this.Save.Location = new System.Drawing.Point(85, 290);
            this.Save.Name = "Save";
            this.Save.ShadowDecoration.BorderRadius = 25;
            this.Save.ShadowDecoration.Depth = 25;
            this.Save.ShadowDecoration.Enabled = true;
            this.Save.ShadowDecoration.Parent = this.Save;
            this.Save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Save.Size = new System.Drawing.Size(200, 45);
            this.Save.TabIndex = 7;
            this.Save.Text = "Sumbit";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option1.CheckedState.BorderThickness = 0;
            this.option1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.option1.CheckedState.InnerOffset = -4;
            this.option1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option1.Location = new System.Drawing.Point(27, 110);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(103, 29);
            this.option1.TabIndex = 8;
            this.option1.TabStop = true;
            this.option1.Text = " Option 1";
            this.option1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.option1.UncheckedState.BorderThickness = 2;
            this.option1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.option1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.option1.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option2.CheckedState.BorderThickness = 0;
            this.option2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.option2.CheckedState.InnerOffset = -4;
            this.option2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option2.Location = new System.Drawing.Point(27, 152);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(106, 29);
            this.option2.TabIndex = 8;
            this.option2.TabStop = true;
            this.option2.Text = " Option 2";
            this.option2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.option2.UncheckedState.BorderThickness = 2;
            this.option2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.option2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option3.CheckedState.BorderThickness = 0;
            this.option3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.option3.CheckedState.InnerOffset = -4;
            this.option3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option3.Location = new System.Drawing.Point(27, 194);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(106, 29);
            this.option3.TabIndex = 8;
            this.option3.TabStop = true;
            this.option3.Text = " Option 3";
            this.option3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.option3.UncheckedState.BorderThickness = 2;
            this.option3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.option3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option4.CheckedState.BorderThickness = 0;
            this.option4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.option4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.option4.CheckedState.InnerOffset = -4;
            this.option4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option4.Location = new System.Drawing.Point(27, 236);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(106, 29);
            this.option4.TabIndex = 8;
            this.option4.TabStop = true;
            this.option4.Text = " Option 4";
            this.option4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.option4.UncheckedState.BorderThickness = 2;
            this.option4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.option4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.option4.UseVisualStyleBackColor = true;
            // 
            // questionlb
            // 
            this.questionlb.AutoRoundedCorners = true;
            this.questionlb.BackColor = System.Drawing.Color.Transparent;
            this.questionlb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.questionlb.BorderRadius = 16;
            this.questionlb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questionlb.DefaultText = "";
            this.questionlb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.questionlb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.questionlb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.questionlb.DisabledState.Parent = this.questionlb;
            this.questionlb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.questionlb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.questionlb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.questionlb.FocusedState.Parent = this.questionlb;
            this.questionlb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlb.ForeColor = System.Drawing.Color.Black;
            this.questionlb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.questionlb.HoverState.Parent = this.questionlb;
            this.questionlb.Location = new System.Drawing.Point(17, 61);
            this.questionlb.Margin = new System.Windows.Forms.Padding(4);
            this.questionlb.Name = "questionlb";
            this.questionlb.PasswordChar = '\0';
            this.questionlb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.questionlb.PlaceholderText = "Question name";
            this.questionlb.ReadOnly = true;
            this.questionlb.SelectedText = "";
            this.questionlb.ShadowDecoration.BorderRadius = 16;
            this.questionlb.ShadowDecoration.Enabled = true;
            this.questionlb.ShadowDecoration.Parent = this.questionlb;
            this.questionlb.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.questionlb.Size = new System.Drawing.Size(336, 35);
            this.questionlb.TabIndex = 10;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.lQuestion);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(15, 13);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(247, 489);
            this.guna2GroupBox2.TabIndex = 9;
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lQuestion
            // 
            this.lQuestion.BackColor = System.Drawing.Color.White;
            this.lQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lQuestion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestion.ForeColor = System.Drawing.Color.Black;
            this.lQuestion.FormattingEnabled = true;
            this.lQuestion.ItemHeight = 30;
            this.lQuestion.Location = new System.Drawing.Point(8, 17);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lQuestion.Size = new System.Drawing.Size(231, 420);
            this.lQuestion.TabIndex = 10;
            this.lQuestion.SelectedIndexChanged += new System.EventHandler(this.lQuestion_SelectedIndexChanged);
            // 
            // eQuestion
            // 
            this.eQuestion.BackColor = System.Drawing.Color.Transparent;
            this.eQuestion.Controls.Add(this.finishb);
            this.eQuestion.Controls.Add(this.timerlb);
            this.eQuestion.Controls.Add(this.completed);
            this.eQuestion.Controls.Add(this.guna2GroupBox2);
            this.eQuestion.Controls.Add(this.guna2GroupBox1);
            this.eQuestion.FillColor = System.Drawing.Color.White;
            this.eQuestion.Location = new System.Drawing.Point(12, 42);
            this.eQuestion.Name = "eQuestion";
            this.eQuestion.Radius = 10;
            this.eQuestion.ShadowColor = System.Drawing.Color.Black;
            this.eQuestion.Size = new System.Drawing.Size(666, 518);
            this.eQuestion.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // completed
            // 
            this.completed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.completed.Location = new System.Drawing.Point(23, 459);
            this.completed.Name = "completed";
            this.completed.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.completed.ShadowDecoration.Parent = this.completed;
            this.completed.ShowPercentage = true;
            this.completed.Size = new System.Drawing.Size(231, 34);
            this.completed.TabIndex = 11;
            this.completed.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // finishb
            // 
            this.finishb.AutoRoundedCorners = true;
            this.finishb.BackColor = System.Drawing.Color.Transparent;
            this.finishb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.finishb.BorderRadius = 21;
            this.finishb.BorderThickness = 3;
            this.finishb.CheckedState.Parent = this.finishb;
            this.finishb.CustomImages.Parent = this.finishb;
            this.finishb.Enabled = false;
            this.finishb.FillColor = System.Drawing.Color.White;
            this.finishb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.finishb.HoverState.Parent = this.finishb;
            this.finishb.Location = new System.Drawing.Point(363, 445);
            this.finishb.Name = "finishb";
            this.finishb.ShadowDecoration.BorderRadius = 25;
            this.finishb.ShadowDecoration.Depth = 25;
            this.finishb.ShadowDecoration.Enabled = true;
            this.finishb.ShadowDecoration.Parent = this.finishb;
            this.finishb.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.finishb.Size = new System.Drawing.Size(200, 45);
            this.finishb.TabIndex = 7;
            this.finishb.Text = "Finish";
            this.finishb.Click += new System.EventHandler(this.finishb_Click);
            // 
            // timerlb
            // 
            this.timerlb.BackColor = System.Drawing.Color.Transparent;
            this.timerlb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerlb.Location = new System.Drawing.Point(384, 382);
            this.timerlb.Name = "timerlb";
            this.timerlb.Size = new System.Drawing.Size(160, 34);
            this.timerlb.TabIndex = 12;
            this.timerlb.Text = "<p style=\'font-size: 24px; margin: auto;\'>Time left: 360 </p>";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.eQuestion.ResumeLayout(false);
            this.eQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel eQuestion;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ListBox lQuestion;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox questionlb;
        private Guna.UI2.WinForms.Guna2RadioButton option4;
        private Guna.UI2.WinForms.Guna2RadioButton option3;
        private Guna.UI2.WinForms.Guna2RadioButton option2;
        private Guna.UI2.WinForms.Guna2RadioButton option1;
        private Guna.UI2.WinForms.Guna2Button Save;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar completed;
        private Guna.UI2.WinForms.Guna2Button finishb;
        private Guna.UI2.WinForms.Guna2HtmlLabel timerlb;
    }
}