namespace MultiRoblox
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            Logo = new PictureBox();
            NameLabel = new Label();
            VersionLabel = new Label();
            DescriptionLabel = new Label();
            GithubLink = new LinkLabel();
            listBox1 = new ListBox();
            ContributorsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(144, 134);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(12, 149);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(142, 32);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "MultiRoblox";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            VersionLabel.ForeColor = Color.White;
            VersionLabel.Location = new Point(12, 181);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(35, 17);
            VersionLabel.TabIndex = 1;
            VersionLabel.Text = "1.0.0";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = Color.White;
            DescriptionLabel.Location = new Point(12, 207);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(286, 21);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Open multiple Roblox instances at once.";
            // 
            // GithubLink
            // 
            GithubLink.ActiveLinkColor = Color.RoyalBlue;
            GithubLink.AutoSize = true;
            GithubLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GithubLink.LinkColor = Color.White;
            GithubLink.Location = new Point(12, 228);
            GithubLink.Name = "GithubLink";
            GithubLink.Size = new Size(59, 21);
            GithubLink.TabIndex = 3;
            GithubLink.TabStop = true;
            GithubLink.Text = "GitHub";
            GithubLink.VisitedLinkColor = Color.White;
            GithubLink.LinkClicked += GithubLinkClicked;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(22, 22, 22);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "Dlunhappy226 - Programming" });
            listBox1.Location = new Point(162, 40);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(230, 136);
            listBox1.TabIndex = 4;
            // 
            // ContributorsLabel
            // 
            ContributorsLabel.AutoSize = true;
            ContributorsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ContributorsLabel.ForeColor = Color.White;
            ContributorsLabel.Location = new Point(162, 12);
            ContributorsLabel.Name = "ContributorsLabel";
            ContributorsLabel.Size = new Size(118, 25);
            ContributorsLabel.TabIndex = 5;
            ContributorsLabel.Text = "Contributors";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(404, 261);
            Controls.Add(ContributorsLabel);
            Controls.Add(listBox1);
            Controls.Add(GithubLink);
            Controls.Add(DescriptionLabel);
            Controls.Add(VersionLabel);
            Controls.Add(NameLabel);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About MultiRoblox";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label NameLabel;
        private Label VersionLabel;
        private Label DescriptionLabel;
        private LinkLabel GithubLink;
        private ListBox listBox1;
        private Label ContributorsLabel;
    }
}