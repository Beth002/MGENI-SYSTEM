namespace GUEST_APK.UserControls
{
    partial class UCVisiter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVisiter));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVisiter = new Guna.UI.WinForms.GunaDataGridView();
            this.Id_Visite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Badge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonction_Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnImprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisiter)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 61);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPACE DES VISITES";
            // 
            // dgVisiter
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgVisiter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgVisiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisiter.BackgroundColor = System.Drawing.Color.White;
            this.dgVisiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVisiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgVisiter.ColumnHeadersHeight = 21;
            this.dgVisiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Visite,
            this.Visiteur,
            this.Motif,
            this.Badge,
            this.Agent,
            this.Fonction_Agent,
            this.Departement,
            this.Date_Heure,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVisiter.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgVisiter.EnableHeadersVisualStyles = false;
            this.dgVisiter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVisiter.Location = new System.Drawing.Point(4, 121);
            this.dgVisiter.Name = "dgVisiter";
            this.dgVisiter.RowHeadersVisible = false;
            this.dgVisiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisiter.Size = new System.Drawing.Size(971, 208);
            this.dgVisiter.TabIndex = 14;
            this.dgVisiter.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgVisiter.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgVisiter.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgVisiter.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgVisiter.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgVisiter.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgVisiter.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgVisiter.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVisiter.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgVisiter.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVisiter.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgVisiter.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgVisiter.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgVisiter.ThemeStyle.HeaderStyle.Height = 21;
            this.dgVisiter.ThemeStyle.ReadOnly = false;
            this.dgVisiter.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgVisiter.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisiter.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgVisiter.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgVisiter.ThemeStyle.RowsStyle.Height = 22;
            this.dgVisiter.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVisiter.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgVisiter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVisiter_CellContentClick);
            this.dgVisiter.DoubleClick += new System.EventHandler(this.dgVisiter_DoubleClick);
            // 
            // Id_Visite
            // 
            this.Id_Visite.DataPropertyName = "Id_Visite";
            this.Id_Visite.HeaderText = "Identifiant";
            this.Id_Visite.Name = "Id_Visite";
            // 
            // Visiteur
            // 
            this.Visiteur.DataPropertyName = "Visiteur";
            this.Visiteur.HeaderText = "Visiteur";
            this.Visiteur.Name = "Visiteur";
            // 
            // Motif
            // 
            this.Motif.DataPropertyName = "Motif";
            this.Motif.HeaderText = "Motif";
            this.Motif.Name = "Motif";
            // 
            // Badge
            // 
            this.Badge.DataPropertyName = "Badge";
            this.Badge.HeaderText = "Badge";
            this.Badge.Name = "Badge";
            // 
            // Agent
            // 
            this.Agent.DataPropertyName = "Agent";
            this.Agent.HeaderText = "Agent";
            this.Agent.Name = "Agent";
            // 
            // Fonction_Agent
            // 
            this.Fonction_Agent.DataPropertyName = "Fonction_Agent";
            this.Fonction_Agent.HeaderText = "Fonction";
            this.Fonction_Agent.Name = "Fonction_Agent";
            // 
            // Departement
            // 
            this.Departement.DataPropertyName = "Departement";
            this.Departement.HeaderText = "Département";
            this.Departement.Name = "Departement";
            // 
            // Date_Heure
            // 
            this.Date_Heure.DataPropertyName = "Date_Heure";
            this.Date_Heure.HeaderText = "Date";
            this.Date_Heure.Name = "Date_Heure";
            // 
            // Column2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Text = "Modifier";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(775, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Rechercher ici";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 34);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Animated = true;
            this.btnImprimer.AnimatedGIF = true;
            this.btnImprimer.AutoRoundedCorners = true;
            this.btnImprimer.BorderRadius = 16;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimer.Image")));
            this.btnImprimer.Location = new System.Drawing.Point(666, 81);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(103, 34);
            this.btnImprimer.TabIndex = 13;
            this.btnImprimer.Text = "Imprimer";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimatedGIF = true;
            this.btnAjouter.AutoRoundedCorners = true;
            this.btnAjouter.BorderRadius = 16;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(4, 81);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 34);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.dgVisiter;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.guna2Button2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(4, 378);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(287, 147);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Actions";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AnimatedGIF = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(23, 56);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(238, 34);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Générer une carte de visite";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AnimatedGIF = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 16;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(23, 96);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(238, 34);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Imprimer la carte de visite";
            // 
            // UCVisiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgVisiter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.panel2);
            this.Name = "UCVisiter";
            this.Size = new System.Drawing.Size(979, 581);
            this.Load += new System.EventHandler(this.UCVisiter_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisiter)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgVisiter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnImprimer;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Visite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Badge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction_Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Heure;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
