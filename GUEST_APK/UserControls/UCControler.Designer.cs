namespace GUEST_APK.UserControls
{
    partial class UCControler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCControler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgControler = new Guna.UI.WinForms.GunaDataGridView();
            this.Id_Controler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnImprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgControler);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnImprimer);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 581);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 61);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPACE DE CONTROLE";
            // 
            // dgControler
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgControler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgControler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgControler.BackgroundColor = System.Drawing.Color.White;
            this.dgControler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgControler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgControler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgControler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgControler.ColumnHeadersHeight = 21;
            this.dgControler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Controler,
            this.Visiteur,
            this.Agent,
            this.Date_Heure,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgControler.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgControler.EnableHeadersVisualStyles = false;
            this.dgControler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgControler.Location = new System.Drawing.Point(3, 118);
            this.dgControler.Name = "dgControler";
            this.dgControler.RowHeadersVisible = false;
            this.dgControler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgControler.Size = new System.Drawing.Size(971, 456);
            this.dgControler.TabIndex = 8;
            this.dgControler.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgControler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgControler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgControler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgControler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgControler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgControler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgControler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgControler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgControler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgControler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgControler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgControler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgControler.ThemeStyle.HeaderStyle.Height = 21;
            this.dgControler.ThemeStyle.ReadOnly = false;
            this.dgControler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgControler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgControler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgControler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgControler.ThemeStyle.RowsStyle.Height = 22;
            this.dgControler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgControler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgControler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControler_CellContentClick);
            this.dgControler.DoubleClick += new System.EventHandler(this.dgControler_DoubleClick);
            // 
            // Id_Controler
            // 
            this.Id_Controler.DataPropertyName = "Id_Controler";
            this.Id_Controler.HeaderText = "Identifiant";
            this.Id_Controler.Name = "Id_Controler";
            // 
            // Visiteur
            // 
            this.Visiteur.DataPropertyName = "Visiteur";
            this.Visiteur.HeaderText = "Visiteur";
            this.Visiteur.Name = "Visiteur";
            // 
            // Agent
            // 
            this.Agent.DataPropertyName = "Agent";
            this.Agent.HeaderText = "Agent";
            this.Agent.Name = "Agent";
            // 
            // Date_Heure
            // 
            this.Date_Heure.DataPropertyName = "Date_Heure";
            this.Date_Heure.HeaderText = "Date";
            this.Date_Heure.Name = "Date_Heure";
            // 
            // Column2
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
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
            this.txtSearch.Location = new System.Drawing.Point(774, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Rechercher ici";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 34);
            this.txtSearch.TabIndex = 5;
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
            this.btnImprimer.Location = new System.Drawing.Point(665, 78);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(103, 34);
            this.btnImprimer.TabIndex = 7;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
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
            this.btnAjouter.Location = new System.Drawing.Point(3, 78);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 34);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.dgControler;
            // 
            // UCControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCControler";
            this.Size = new System.Drawing.Size(979, 581);
            this.Load += new System.EventHandler(this.UCControler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgControler;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnImprimer;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Controler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Heure;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}
