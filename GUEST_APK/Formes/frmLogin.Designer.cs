namespace GUEST_APK
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeConnecter = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsername = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatut = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 147);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Animated = true;
            this.btnQuitter.AnimatedGIF = true;
            this.btnQuitter.AutoRoundedCorners = true;
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BorderRadius = 16;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuitter.Location = new System.Drawing.Point(113, 427);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(133, 35);
            this.btnQuitter.TabIndex = 27;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Animated = true;
            this.btnSeConnecter.AnimatedGIF = true;
            this.btnSeConnecter.AutoRoundedCorners = true;
            this.btnSeConnecter.BackColor = System.Drawing.Color.Transparent;
            this.btnSeConnecter.BorderRadius = 16;
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeConnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeConnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeConnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeConnecter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSeConnecter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(113, 386);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(133, 35);
            this.btnSeConnecter.TabIndex = 25;
            this.btnSeConnecter.Text = "Se Connecter";
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.Location = new System.Drawing.Point(76, 335);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.Location = new System.Drawing.Point(76, 210);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 36);
            this.txtUsername.TabIndex = 23;
            this.txtUsername.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "LOGIN";
            // 
            // cbUsername
            // 
            this.cbUsername.BackColor = System.Drawing.Color.Transparent;
            this.cbUsername.BorderRadius = 10;
            this.cbUsername.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsername.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUsername.ForeColor = System.Drawing.Color.Black;
            this.cbUsername.ItemHeight = 30;
            this.cbUsername.Location = new System.Drawing.Point(76, 238);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(200, 36);
            this.cbUsername.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 52);
            this.label2.TabIndex = 30;
            this.label2.Text = "Société NGUVU";
            // 
            // cbStatut
            // 
            this.cbStatut.BackColor = System.Drawing.Color.Transparent;
            this.cbStatut.BorderRadius = 10;
            this.cbStatut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatut.ForeColor = System.Drawing.Color.Black;
            this.cbStatut.ItemHeight = 30;
            this.cbStatut.Items.AddRange(new object[] {
            "Administrateur",
            "Utilisateur"});
            this.cbStatut.Location = new System.Drawing.Point(76, 293);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(200, 36);
            this.cbStatut.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Connecté entant que:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnQuitter;
        private Guna.UI2.WinForms.Guna2Button btnSeConnecter;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox cbUsername;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox cbStatut;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}