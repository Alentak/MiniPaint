using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    public class MonCercle : Forme
    {
        public MonCercle() { }
        public MonCercle(Point origine, Size taille, Color color, bool filled, int epaisseur) : base(origine, taille, color, filled, epaisseur){ }
        public override void Dessiner(Graphics g)
        {
            if (filled)
                g.FillEllipse(new SolidBrush(color), origine.X, origine.Y, taille.Width, taille.Height);
            else
                g.DrawEllipse(new Pen(color, epaisseur), origine.X, origine.Y, taille.Width, taille.Height);
        }
    }
}
