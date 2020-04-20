using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MiniPaint
{
    public enum NomForme
    {
        Rectangle,
        Polygone,
        Ligne,
        Cercle,
        Triangle
    }
    [DataContract]
    [XmlInclude(typeof(MonCercle))]
    [XmlInclude(typeof(MonRectangle))]
    [XmlInclude(typeof(MonPolygone))]
    [XmlInclude(typeof(MaLigne))]
    public abstract class Forme
    {
        protected Point origine;
        protected Size taille;
        protected Color color;
        protected bool filled;
        protected int epaisseur;

        public int intCouleur;

        [XmlIgnore]
        public Color Couleur
        {
            get { return Color.FromArgb(intCouleur); }
            set
            {
                color = value;
                intCouleur = color.ToArgb();
            }
        }
        public Point Origine
        {
            get { return origine; }
            set { origine = value; }
        }

        public Size Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        public int Epaisseur
        {
            get { return epaisseur; }
            set { epaisseur = value; }
        }

        //Liste
        public static List<MonRectangle> formesSelection = new List<MonRectangle>();

        public Forme()
        {

        }
        public Forme(Point origine, Size taille, Color color, bool filled, int epaisseur)
        {
            this.origine = origine;
            this.taille = taille;
            this.filled = filled;
            this.epaisseur = epaisseur;

            Couleur = color;
        }

        public abstract void Dessiner(Graphics g);  

        public bool EstSelectionnee(Point m)
        {
            if (m.X >= origine.X && m.X <= origine.X + taille.Width &&
                m.Y >= origine.Y && m.Y <= origine.Y + taille.Height)
                return true;
            else
                return false;
        }

        public void Selectionner(Graphics g)
        {
            new MonRectangle(new Point(origine.X - 5, origine.Y - 5), new Size(10, 10), Color.Red, filled, epaisseur).Dessiner(g);
            new MonRectangle(new Point(origine.X + taille.Width - 5, origine.Y - 5), new Size(10, 10), Color.Red, filled, epaisseur).Dessiner(g);
            new MonRectangle(new Point(origine.X + taille.Width - 5, origine.Y + taille.Height - 5), new Size(10, 10), Color.Red, filled, epaisseur).Dessiner(g);
            new MonRectangle(new Point(origine.X - 5, origine.Y + taille.Height - 5), new Size(10, 10), Color.Red, filled, epaisseur).Dessiner(g);
        }

        //Decalage de la forme un par rapport a la forme deux, en comparant les centres des formes
        public static Point operator -(Forme un, Forme deux)
        {
            Point decalage = new Point();

            Point centreUn = new Point();
            centreUn.X = un.origine.X + un.taille.Width / 2;
            centreUn.Y = un.origine.Y + un.taille.Height / 2;
            Point centreDeux = new Point();
            centreDeux.X = deux.origine.X + deux.taille.Width / 2;
            centreDeux.Y = deux.origine.Y + deux.taille.Height / 2;

            decalage.X = centreUn.X - centreDeux.X;
            decalage.Y = centreUn.Y - centreDeux.Y;

            return decalage;
        }
    }
}