using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram
{
    public class ArrowDrawer
    {
        private Graphics g { get; set; }
        public ArrowDrawer(Graphics g)
        {
            this.g = g;
        }
        public enum Type
        {
            classic,
            diamond
        }
        public void Draw(Type type, Pen pen, int X, int Y, int rotation)
        {
            g.TranslateTransform(X, Y);
            g.RotateTransform(rotation);
            switch (type)
            {
                case Type.classic:
                    DrawClassic(pen);
                    break;
                case Type.diamond:
                    DrawDiamond(pen);
                    break;
                default:
                    break;
            }
            g.ResetTransform();
        }

        private void DrawClassic(Pen pen)
        {
            g.DrawLines(pen, new Point[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10) });
        }
        private void DrawDiamond(Pen pen)
        {
            Color color = Control.DefaultBackColor;
            g.FillPolygon(new SolidBrush(color), new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10), new Point(-30, 0) });
            g.DrawPolygon(pen, new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10), new Point(-30, 0) });
        }
    }
}
