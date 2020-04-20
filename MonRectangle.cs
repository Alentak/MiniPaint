using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    public class MonRectangle : Forme
    {
        public MonRectangle() { }
        public MonRectangle(Point origine, Size taille, Color color, bool filled, int epaisseur) : base(origine, taille, color, filled, epaisseur) { }
        public override void Dessiner(Graphics g)
        {
            if (filled)
                g.FillRectangle(new SolidBrush(color), origine.X, origine.Y, taille.Width, taille.Height);
            else
                g.DrawRectangle(new Pen(color, epaisseur), origine.X, origine.Y, taille.Width, taille.Height);
        }
    }
}