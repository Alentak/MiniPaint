using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    public class MonPolygone : Forme
    {
        Point[] points;
        public MonPolygone() { }
        public MonPolygone(Point[] points, Point origine, Size taille, Color color, bool filled, int epaisseur) : base(origine, taille, color, filled, epaisseur)
        {
            this.points = points;
        }

        public override void Dessiner(Graphics g)
        {
            if (filled)
                g.FillPolygon(new SolidBrush(color), points);
            else
                g.DrawPolygon(new Pen(color, epaisseur), points);
        }
    }
}