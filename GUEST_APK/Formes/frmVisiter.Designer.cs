namespace GUEST_APK.Formes
{
    partial class frmVisiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisiter));
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMotif = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBadge = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateVisite = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbVisiteur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Animated = true;
            this.btnModifier.AnimatedGIF = true;
            this.btnModifier.AutoRoundedCorners = true;
            this.btnModifier.BorderRadius = 18;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(5)))), ((int)(((byte)(200)))));
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(221, 369);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 39);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cbMotif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbBadge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DateVisite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbAgent);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cbVisiteur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 321);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // cbMotif
            // 
            this.cbMotif.BackColor = System.Drawing.Color.Transparent;
            this.cbMotif.BorderRadius = 10;
            this.cbMotif.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMotif.ForeColor = System.Drawing.Color.Black;
            this.cbMotif.ItemHeight = 30;
            this.cbMotif.Items.AddRange(new object[] {
            "ENTRETIENT EMBAUCHE",
            "CONVOCATION",
            "INSPECTION DES LOCAUX",
            "EVACUATION DES IMMONDICES",
            "PROMENADE"});
            this.cbMotif.Location = new System.Drawing.Point(101, 268);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(216, 36);
            this.cbMotif.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Motif";
            // 
            // cbBadge
            // 
            this.cbBadge.BackColor = System.Drawing.Color.Transparent;
            this.cbBadge.BorderRadius = 10;
            this.cbBadge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBadge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBadge.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBadge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBadge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBadge.ForeColor = System.Drawing.Color.Black;
            this.cbBadge.ItemHeight = 30;
            this.cbBadge.Location = new System.Drawing.Point(101, 186);
            this.cbBadge.Name = "cbBadge";
            this.cbBadge.Size = new System.Drawing.Size(216, 36);
            this.cbBadge.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Badge";
            // 
            // DateVisite
            // 
            this.DateVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateVisite.Location = new System.Drawing.Point(101, 237);
            this.DateVisite.Name = "DateVisite";
            this.DateVisite.Size = new System.Drawing.Size(216, 22);
            this.DateVisite.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date";
            // 
            // cbAgent
            // 
            this.cbAgent.BackColor = System.Drawing.Color.Transparent;
            this.cbAgent.BorderRadius = 10;
            this.cbAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAgent.ForeColor = System.Drawing.Color.Black;
            this.cbAgent.ItemHeight = 30;
            this.cbAgent.Location = new System.Drawing.Point(101, 144);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(216, 36);
            this.cbAgent.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 10;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.Enabled = false;
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(101, 56);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 14;
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.cbVisiteur.BorderRadius = 10;
            this.cbVisiteur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisiteur.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVisiteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVisiteur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVisiteur.ForeColor = System.Drawing.Color.Black;
            this.cbVisiteur.ItemHeight = 30;
            this.cbVisiteur.Location = new System.Drawing.Point(101, 98);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(216, 36);
            this.cbVisiteur.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visiteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimatedGIF = true;
            this.btnAjouter.AutoRoundedCorners = true;
            this.btnAjouter.BorderRadius = 18;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(43, 369);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 39);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.groupBox1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(345, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 31);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "   ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVisiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 420);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAjouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisiter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISITE";
            this.Load += new System.EventHandler(this.frmVisiter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker DateVisite;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox cbAgent;
        public Guna.UI2.WinForms.Guna2TextBox txtId;
        public Guna.UI2.WinForms.Guna2ComboBox cbVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnAjouter;
        public Guna.UI2.WinForms.Guna2ComboBox cbMotif;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2ComboBox cbBadge;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label btnExit;
    }
}