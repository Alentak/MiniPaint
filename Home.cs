using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPaint
{
    public partial class Home : Form
    {
        Point debut;
        Point fin;

        Color couleur = Color.Black;
        int epaisseur = 1;

        bool rempli = false;
        bool dessine = false;
        bool creation = true;

        Stack<Forme> formes = new Stack<Forme>();

        Graphics g;
        //Pour les boutons précédent et suivant
        Forme derniere;
        Forme formeSelected;

        NomForme nomForme = NomForme.Rectangle;

        delegate void Couleur(Color couleur);

        Couleur delegChangeCouleur;

        Dictionary<string, NomForme> dicoFormes = new Dictionary<string, NomForme> { 
            { "Cercle", NomForme.Cercle }, 
            { "Ligne", NomForme.Ligne }, 
            { "Polygone", NomForme.Polygone },
            { "Rectangle", NomForme.Rectangle },
            { "Triangle", NomForme.Triangle }
        };

        public Home()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            cbCouleurs.SelectedIndex = 0;

            //Méthode de changement de couleur de base
            delegChangeCouleur = uneCouleur;
        }

        //Méthodes du delegate---------------------
        private void uneCouleur(Color couleurChoisie)
        {
            if (creation)
            {
                //Changer la couleur du pinceau
                couleur = couleurChoisie;
                //Affecter à ce bouton la couleur selectionnée
                btnCouleur.BackColor = couleurChoisie;
            }
            else if (formeSelected != null)
            {
                //Changer la couleur de la forme sélectionnée
                formeSelected.Couleur = couleurChoisie;
            }
        }

        private void toutesLesCouleurs(Color couleur)
        {
            foreach (Forme forme in formes)
            {
                forme.Couleur = couleur;
            }
            Invalidate();
        }
        //--------------------------------------------------

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            debut = e.Location;

            if(creation)
                dessine = true;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (dessine)
            {
                fin = e.Location;
                Size taille = new Size(fin.X - debut.X, fin.Y - debut.Y);

                g.Clear(Color.White);

                Point[] pts = null;

                if (nomForme == NomForme.Polygone || nomForme == NomForme.Triangle)
                {
                    int nbPoints = int.Parse(numCotes.Text);

                    //Si c'est un triangle, on fait un polygone à trois côtés
                    if (nomForme == NomForme.Triangle)
                        nbPoints = 3;

                    pts = new Point[nbPoints];

                    //Calcul de la position des points du polygone
                    for (int i = 0; i < nbPoints; i++)
                        pts[i] = positionPoint(i, nbPoints, taille);
                }

                //MAJ le dessin de la forme pendant le mouvement de souris
                switch (nomForme)
                {
                    case NomForme.Rectangle:
                        new MonRectangle(debut, taille, couleur, rempli, epaisseur).Dessiner(g);
                        break;
                    case NomForme.Polygone:
                        new MonPolygone(pts, debut, taille, couleur, rempli, epaisseur).Dessiner(g);
                        break;
                    case NomForme.Triangle:
                        new MonPolygone(pts, debut, taille, couleur, rempli, epaisseur).Dessiner(g);
                        break;
                    case NomForme.Ligne:
                        new MaLigne(debut, taille, couleur, rempli, epaisseur).Dessiner(g);
                        break;
                    case NomForme.Cercle:
                        new MonCercle(debut, taille, couleur, rempli, epaisseur).Dessiner(g);
                        break;
                }

                Actualiser();
            }
        }

        private Point positionPoint(int i, int nbPoints, Size taille)
        {
            //Formule de calcule de la position des points en fonction du nombre de cotés
            return new Point(Convert.ToInt32(debut.X + taille.Width / 2 + taille.Width * Math.Cos(2 * Math.PI * i / nbPoints)),
                             Convert.ToInt32(debut.Y + taille.Height / 2 + taille.Height * Math.Sin(2 * Math.PI * i / nbPoints)));
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            if (creation)
            {
                dessine = false;

                fin = e.Location;
                Size taille = new Size(fin.X - debut.X, fin.Y - debut.Y);

                Point[] pts = null;

                if (nomForme == NomForme.Polygone || nomForme == NomForme.Triangle)
                {
                    int nbPoints = int.Parse(numCotes.Text);

                    //Si c'est un triangle, on fait un polygone à trois côtés
                    if (nomForme == NomForme.Triangle)
                        nbPoints = 3;

                    pts = new Point[nbPoints];

                    //Calcul de la position des points du polygone
                    for (int i = 0; i < nbPoints; i++)
                        pts[i] = positionPoint(i, nbPoints, taille);
                }

                //On ajoute dans la liste des formes, celle qui vient d'être dessinée
                switch (nomForme)
                {
                    case NomForme.Rectangle:
                        formes.Push(new MonRectangle(debut, taille, couleur, rempli, epaisseur));
                        break;
                    case NomForme.Polygone:
                        formes.Push(new MonPolygone(pts, debut, taille, couleur, rempli, epaisseur));
                        break;
                    case NomForme.Triangle:
                        formes.Push(new MonPolygone(pts, debut, taille, couleur, rempli, epaisseur));
                        break;
                    case NomForme.Ligne:
                        formes.Push(new MaLigne(debut, taille, couleur, rempli, epaisseur));
                        break;
                    case NomForme.Cercle:
                        formes.Push(new MonCercle(debut, taille, couleur, rempli, epaisseur));
                        break;
                }
            }
        }

        private void Actualiser()
        {
            //On redessine toutes les formes de la liste
            for (int i = 0; i < formes.Count; i++)
                formes.ElementAt(i).Dessiner(g);

            //Si on est en mode sélection et qu'une forme est sélectionnée, alors il faut afficher les carrés dans les coins
            if (!creation && formeSelected != null)
                formeSelected.Selectionner(g);
        }

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            if (!creation && formes.Count > 0)
            {
                //Pour savoir si une forme a été sélectionnée ou pas
                bool trouvee = false;

                //Au clic, vérifie pour toutes les formes si la souris est à l'intérieur de la forme 
                for (int i = 0; i < formes.Count; i++)
                {
                    Forme uneForme = formes.ElementAt(i);

                    //Vérification du clic
                    if (uneForme.EstSelectionnee(e.Location))
                    {
                        trouvee = true;

                        //Sélection
                        uneForme.Selectionner(g);

                        formeSelected = uneForme;
                    }
                }

                if (!trouvee)
                    formeSelected = null;

                Invalidate();
            }
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            //Changer la couleur de la forme
            cpForme.ShowDialog();

            //On change de méthode en fonction de ce qu'a sélectionné l'utilisateur
            if (cbCouleurs.Text == "Une couleur")
                delegChangeCouleur = uneCouleur;
            else
                delegChangeCouleur = toutesLesCouleurs;

            //On exécute la méthode choisie
            delegChangeCouleur(cpForme.Color);

            Invalidate();
        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {
            Actualiser();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (formes.Count > 0)
            {
                //Sauvegarde et suppression de la derniere forme
                derniere = formes.Pop();
                g.Clear(Color.White);
                Actualiser();
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (derniere != null)
            {
                //On remet en place la dernière forme
                formes.Push(derniere);

                derniere = null;
                //Et on actualise pour l'afficher
                Actualiser();
            }
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sauvegarde
            if (formes.Count > 0)
            {
                //Serialization
                XmlSerializer sf = new XmlSerializer(typeof(List<Forme>));
                FileStream fichierCreate = new FileStream("formes.xml", FileMode.Create);
                sf.Serialize(fichierCreate, formes.ToList());
                fichierCreate.Close();

                MessageBox.Show("Sauvegarde effectuée", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            //Effacer le graphics
            g.Clear(Color.White);
            //Effacer la liste des formes
            formes.Clear();

            g.Dispose();
            g = CreateGraphics();
        }

        private void btnRempli_Click(object sender, EventArgs e)
        {
            if(rempli)
                btnRempli.Text = "Contour";
            else
                btnRempli.Text = "Rempli";

            rempli = !rempli;
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if (creation)
                btnSelection.Text = "Mode Sélection";
            else
                btnSelection.Text = "Mode Création";

            creation = !creation;
        }

        private void btnForme_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;

            //On envoie le type de forme correspondant au bouton sur lequel on a cliqué
            dicoFormes.TryGetValue(btnName, out nomForme);

            //Si c'est un polygone, il faut pouvoir changer le nombre de côtés
            if (btnName == "Polygone")
            {
                lbCotes.Visible = true;
                numCotes.Visible = true;
            }
            else
            {
                lbCotes.Visible = false;
                numCotes.Visible = false;
            }
        }

        private void numEpaisseur_ValueChanged(object sender, EventArgs e)
        {
            epaisseur = Convert.ToInt32(numEpaisseur.Value);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }
    }
}