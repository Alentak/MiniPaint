using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    public class MaLigne : Forme
    {
        public MaLigne() { }
        public MaLigne(Point origine, Size taille, Color color, bool filled, int epaisseur) : base(origine, taille, color, filled, epaisseur) { }
        public override void Dessiner(Graphics g)
        {
            g.DrawLine(new Pen(color, epaisseur), origine.X, origine.Y, origine.X + taille.Width, origine.Y + taille.Height);
        }
    }
}