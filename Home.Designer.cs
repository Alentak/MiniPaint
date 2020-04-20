namespace MiniPaint
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.cbCouleurs = new System.Windows.Forms.ComboBox();
            this.numCotes = new System.Windows.Forms.NumericUpDown();
            this.numEpaisseur = new System.Windows.Forms.NumericUpDown();
            this.btnRempli = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormes = new System.Windows.Forms.Panel();
            this.Triangle = new System.Windows.Forms.Button();
            this.Polygone = new System.Windows.Forms.Button();
            this.Ligne = new System.Windows.Forms.Button();
            this.Cercle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.lbCotes = new System.Windows.Forms.Label();
            this.lbEpaisseur = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnCouleur = new System.Windows.Forms.Button();
            this.cpForme = new System.Windows.Forms.ColorDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpaisseur)).BeginInit();
            this.pnlFormes.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.LightGray;
            this.pnlControl.Controls.Add(this.cbCouleurs);
            this.pnlControl.Controls.Add(this.numCotes);
            this.pnlControl.Controls.Add(this.numEpaisseur);
            this.pnlControl.Controls.Add(this.btnRempli);
            this.pnlControl.Controls.Add(this.btnSelection);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.pnlFormes);
            this.pnlControl.Controls.Add(this.btnEffacer);
            this.pnlControl.Controls.Add(this.lbCotes);
            this.pnlControl.Controls.Add(this.lbEpaisseur);
            this.pnlControl.Controls.Add(this.btnSuivant);
            this.pnlControl.Controls.Add(this.btnPrecedent);
            this.pnlControl.Controls.Add(this.btnCouleur);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 28);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1222, 100);
            this.pnlControl.TabIndex = 1;
            // 
            // cbCouleurs
            // 
            this.cbCouleurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCouleurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCouleurs.FormattingEnabled = true;
            this.cbCouleurs.Items.AddRange(new object[] {
            "Une couleur",
            "Toutes les couleurs"});
            this.cbCouleurs.Location = new System.Drawing.Point(1018, 37);
            this.cbCouleurs.Name = "cbCouleurs";
            this.cbCouleurs.Size = new System.Drawing.Size(155, 32);
            this.cbCouleurs.TabIndex = 18;
            // 
            // numCotes
            // 
            this.numCotes.Location = new System.Drawing.Point(842, 52);
            this.numCotes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCotes.Name = "numCotes";
            this.numCotes.Size = new System.Drawing.Size(54, 32);
            this.numCotes.TabIndex = 17;
            this.numCotes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCotes.Visible = false;
            // 
            // numEpaisseur
            // 
            this.numEpaisseur.Location = new System.Drawing.Point(842, 14);
            this.numEpaisseur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEpaisseur.Name = "numEpaisseur";
            this.numEpaisseur.Size = new System.Drawing.Size(54, 32);
            this.numEpaisseur.TabIndex = 3;
            this.numEpaisseur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEpaisseur.ValueChanged += new System.EventHandler(this.numEpaisseur_ValueChanged);
            // 
            // btnRempli
            // 
            this.btnRempli.BackColor = System.Drawing.Color.White;
            this.btnRempli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRempli.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRempli.Location = new System.Drawing.Point(494, 34);
            this.btnRempli.Name = "btnRempli";
            this.btnRempli.Size = new System.Drawing.Size(117, 50);
            this.btnRempli.TabIndex = 13;
            this.btnRempli.Text = "Contour";
            this.btnRempli.UseVisualStyleBackColor = false;
            this.btnRempli.Click += new System.EventHandler(this.btnRempli_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.White;
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.Location = new System.Drawing.Point(12, 33);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(151, 50);
            this.btnSelection.TabIndex = 16;
            this.btnSelection.Text = "Mode Création";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Formes :";
            // 
            // pnlFormes
            // 
            this.pnlFormes.BackColor = System.Drawing.Color.Silver;
            this.pnlFormes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormes.Controls.Add(this.Triangle);
            this.pnlFormes.Controls.Add(this.Polygone);
            this.pnlFormes.Controls.Add(this.Ligne);
            this.pnlFormes.Controls.Add(this.Cercle);
            this.pnlFormes.Controls.Add(this.Rectangle);
            this.pnlFormes.Location = new System.Drawing.Point(177, 33);
            this.pnlFormes.Name = "pnlFormes";
            this.pnlFormes.Size = new System.Drawing.Size(283, 58);
            this.pnlFormes.TabIndex = 12;
            // 
            // Triangle
            // 
            this.Triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Triangle.BackgroundImage")));
            this.Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Triangle.Location = new System.Drawing.Point(227, 3);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(50, 50);
            this.Triangle.TabIndex = 4;
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.btnForme_Click);
            // 
            // Polygone
            // 
            this.Polygone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Polygone.BackgroundImage")));
            this.Polygone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polygone.Location = new System.Drawing.Point(171, 3);
            this.Polygone.Name = "Polygone";
            this.Polygone.Size = new System.Drawing.Size(50, 50);
            this.Polygone.TabIndex = 3;
            this.Polygone.UseVisualStyleBackColor = true;
            this.Polygone.Click += new System.EventHandler(this.btnForme_Click);
            // 
            // Ligne
            // 
            this.Ligne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ligne.BackgroundImage")));
            this.Ligne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ligne.Location = new System.Drawing.Point(115, 3);
            this.Ligne.Name = "Ligne";
            this.Ligne.Size = new System.Drawing.Size(50, 50);
            this.Ligne.TabIndex = 2;
            this.Ligne.UseVisualStyleBackColor = true;
            this.Ligne.Click += new System.EventHandler(this.btnForme_Click);
            // 
            // Cercle
            // 
            this.Cercle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cercle.BackgroundImage")));
            this.Cercle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cercle.Location = new System.Drawing.Point(59, 3);
            this.Cercle.Name = "Cercle";
            this.Cercle.Size = new System.Drawing.Size(50, 50);
            this.Cercle.TabIndex = 1;
            this.Cercle.UseVisualStyleBackColor = true;
            this.Cercle.Click += new System.EventHandler(this.btnForme_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rectangle.BackgroundImage")));
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle.Location = new System.Drawing.Point(3, 3);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(50, 50);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.btnForme_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.White;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Location = new System.Drawing.Point(1320, 29);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(88, 43);
            this.btnEffacer.TabIndex = 11;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // lbCotes
            // 
            this.lbCotes.AutoSize = true;
            this.lbCotes.Location = new System.Drawing.Point(676, 52);
            this.lbCotes.Name = "lbCotes";
            this.lbCotes.Size = new System.Drawing.Size(160, 24);
            this.lbCotes.TabIndex = 10;
            this.lbCotes.Text = "Nombre de côtés :";
            this.lbCotes.Visible = false;
            // 
            // lbEpaisseur
            // 
            this.lbEpaisseur.AutoSize = true;
            this.lbEpaisseur.Location = new System.Drawing.Point(739, 21);
            this.lbEpaisseur.Name = "lbEpaisseur";
            this.lbEpaisseur.Size = new System.Drawing.Size(97, 24);
            this.lbEpaisseur.TabIndex = 8;
            this.lbEpaisseur.Text = "Épaisseur :";
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.White;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(1244, 17);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(50, 50);
            this.btnSuivant.TabIndex = 7;
            this.btnSuivant.Text = "→";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.White;
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(1188, 17);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(50, 50);
            this.btnPrecedent.TabIndex = 6;
            this.btnPrecedent.Text = "←";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnCouleur
            // 
            this.btnCouleur.BackColor = System.Drawing.Color.Black;
            this.btnCouleur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCouleur.FlatAppearance.BorderSize = 2;
            this.btnCouleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouleur.Location = new System.Drawing.Point(932, 14);
            this.btnCouleur.Name = "btnCouleur";
            this.btnCouleur.Size = new System.Drawing.Size(63, 63);
            this.btnCouleur.TabIndex = 1;
            this.btnCouleur.UseVisualStyleBackColor = false;
            this.btnCouleur.Click += new System.EventHandler(this.btnCouleur_Click);
            // 
            // cpForme
            // 
            this.cpForme.AnyColor = true;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1222, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 768);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mini Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Home_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpaisseur)).EndInit();
            this.pnlFormes.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnCouleur;
        private System.Windows.Forms.ColorDialog cpForme;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Label lbEpaisseur;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label lbCotes;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Panel pnlFormes;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Polygone;
        private System.Windows.Forms.Button Ligne;
        private System.Windows.Forms.Button Cercle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRempli;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.NumericUpDown numEpaisseur;
        private System.Windows.Forms.NumericUpDown numCotes;
        private System.Windows.Forms.ComboBox cbCouleurs;
    }
}

