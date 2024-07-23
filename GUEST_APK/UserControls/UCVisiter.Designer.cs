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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnImprinerCarte = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkAgent = new System.Windows.Forms.CheckBox();
            this.cbAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnRapportDateAgent = new Guna.UI2.WinForms.Guna2Button();
            this.lblGetId = new System.Windows.Forms.Label();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisiter)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1460, 94);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPACE DES VISITES";
            // 
            // dgVisiter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgVisiter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVisiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisiter.BackgroundColor = System.Drawing.Color.White;
            this.dgVisiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVisiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVisiter.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgVisiter.EnableHeadersVisualStyles = false;
            this.dgVisiter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgVisiter.Location = new System.Drawing.Point(4, 188);
            this.dgVisiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVisiter.Name = "dgVisiter";
            this.dgVisiter.RowHeadersVisible = false;
            this.dgVisiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisiter.Size = new System.Drawing.Size(1450, 320);
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
            this.dgVisiter.Click += new System.EventHandler(this.dgVisiter_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.txtSearch.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(1161, 126);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Rechercher ici";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(294, 52);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Animated = true;
            this.btnImprimer.AnimatedGIF = true;
            this.btnImprimer.AutoRoundedCorners = true;
            this.btnImprimer.BorderRadius = 25;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImprimer.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimer.Image")));
            this.btnImprimer.Location = new System.Drawing.Point(998, 126);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(154, 52);
            this.btnImprimer.TabIndex = 13;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimatedGIF = true;
            this.btnAjouter.AutoRoundedCorners = true;
            this.btnAjouter.BorderRadius = 25;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(4, 126);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(154, 52);
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
            this.guna2GroupBox1.Controls.Add(this.btnImprinerCarte);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(4, 534);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(430, 226);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Actions";
            // 
            // btnImprinerCarte
            // 
            this.btnImprinerCarte.Animated = true;
            this.btnImprinerCarte.AnimatedGIF = true;
            this.btnImprinerCarte.AutoRoundedCorners = true;
            this.btnImprinerCarte.BackColor = System.Drawing.Color.White;
            this.btnImprinerCarte.BorderRadius = 25;
            this.btnImprinerCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprinerCarte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImprinerCarte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImprinerCarte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImprinerCarte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImprinerCarte.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprinerCarte.ForeColor = System.Drawing.Color.White;
            this.btnImprinerCarte.Image = ((System.Drawing.Image)(resources.GetObject("btnImprinerCarte.Image")));
            this.btnImprinerCarte.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImprinerCarte.Location = new System.Drawing.Point(34, 109);
            this.btnImprinerCarte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprinerCarte.Name = "btnImprinerCarte";
            this.btnImprinerCarte.Size = new System.Drawing.Size(357, 52);
            this.btnImprinerCarte.TabIndex = 15;
            this.btnImprinerCarte.Text = "Imprimer la carte de visite";
            this.btnImprinerCarte.Click += new System.EventHandler(this.btnImprinerCarte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Controls.Add(this.lblGetId);
            this.panel1.Controls.Add(this.dgVisiter);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnImprimer);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 885);
            this.panel1.TabIndex = 16;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.chkAgent);
            this.guna2GroupBox2.Controls.Add(this.cbAgent);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.DateFin);
            this.guna2GroupBox2.Controls.Add(this.DateDebut);
            this.guna2GroupBox2.Controls.Add(this.btnRapportDateAgent);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(682, 534);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(772, 346);
            this.guna2GroupBox2.TabIndex = 17;
            this.guna2GroupBox2.Text = "Rapport par Date et Agent";
            // 
            // chkAgent
            // 
            this.chkAgent.AutoSize = true;
            this.chkAgent.BackColor = System.Drawing.Color.Transparent;
            this.chkAgent.ForeColor = System.Drawing.Color.Black;
            this.chkAgent.Location = new System.Drawing.Point(422, 102);
            this.chkAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAgent.Name = "chkAgent";
            this.chkAgent.Size = new System.Drawing.Size(209, 34);
            this.chkAgent.TabIndex = 21;
            this.chkAgent.Text = "Inclure Agent";
            this.chkAgent.UseVisualStyleBackColor = false;
            this.chkAgent.CheckedChanged += new System.EventHandler(this.chkAgent_CheckedChanged);
            // 
            // cbAgent
            // 
            this.cbAgent.BackColor = System.Drawing.Color.Transparent;
            this.cbAgent.BorderRadius = 15;
            this.cbAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgent.FillColor = System.Drawing.Color.SteelBlue;
            this.cbAgent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAgent.ForeColor = System.Drawing.Color.White;
            this.cbAgent.ItemHeight = 30;
            this.cbAgent.Location = new System.Drawing.Point(422, 146);
            this.cbAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(331, 36);
            this.cbAgent.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Au";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Du";
            // 
            // DateFin
            // 
            this.DateFin.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Location = new System.Drawing.Point(57, 191);
            this.DateFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(328, 31);
            this.DateFin.TabIndex = 17;
            // 
            // DateDebut
            // 
            this.DateDebut.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Location = new System.Drawing.Point(57, 102);
            this.DateDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(328, 31);
            this.DateDebut.TabIndex = 16;
            // 
            // btnRapportDateAgent
            // 
            this.btnRapportDateAgent.Animated = true;
            this.btnRapportDateAgent.AnimatedGIF = true;
            this.btnRapportDateAgent.AutoRoundedCorners = true;
            this.btnRapportDateAgent.BackColor = System.Drawing.Color.White;
            this.btnRapportDateAgent.BorderRadius = 25;
            this.btnRapportDateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapportDateAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRapportDateAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRapportDateAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRapportDateAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRapportDateAgent.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapportDateAgent.ForeColor = System.Drawing.Color.White;
            this.btnRapportDateAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnRapportDateAgent.Image")));
            this.btnRapportDateAgent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRapportDateAgent.Location = new System.Drawing.Point(136, 272);
            this.btnRapportDateAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRapportDateAgent.Name = "btnRapportDateAgent";
            this.btnRapportDateAgent.Size = new System.Drawing.Size(189, 52);
            this.btnRapportDateAgent.TabIndex = 15;
            this.btnRapportDateAgent.Text = "Imprimer";
            this.btnRapportDateAgent.Click += new System.EventHandler(this.btnRapportDateAgent_Click);
            // 
            // lblGetId
            // 
            this.lblGetId.AutoSize = true;
            this.lblGetId.Location = new System.Drawing.Point(182, 143);
            this.lblGetId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetId.Name = "lblGetId";
            this.lblGetId.Size = new System.Drawing.Size(0, 20);
            this.lblGetId.TabIndex = 16;
            this.lblGetId.Visible = false;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // UCVisiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCVisiter";
            this.Size = new System.Drawing.Size(1468, 894);
            this.Load += new System.EventHandler(this.UCVisiter_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisiter)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button btnImprinerCarte;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Label lblGetId;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private Guna.UI2.WinForms.Guna2Button btnRapportDateAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbAgent;
        private System.Windows.Forms.CheckBox chkAgent;
    }
}
