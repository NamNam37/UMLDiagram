using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram.Drawers
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
            none,
            classic,
            classicDotdash,
            triangle,
            triangleDotdash,
            diamond,
            diamondEmpty
        }
        public void Draw(Type type, int X, int Y, int rotation)
        {
            g.TranslateTransform(X, Y);
            g.RotateTransform(rotation);
            switch (type)
            {
                case Type.none:
                    break;
                case Type.classic:
                    DrawClassic();
                    break;
                case Type.classicDotdash:
                    DrawClassicDotdash();
                    break;
                case Type.triangle:
                    DrawTriangle();
                    break;
                case Type.triangleDotdash:
                    DrawTriangleDotdash();
                    break;
                case Type.diamond:
                    DrawDiamond();
                    break;
                case Type.diamondEmpty:
                    DrawDiamondEmpty();
                    break;
            }
            g.ResetTransform();
        }

        private void DrawClassic()
        {
            g.DrawLines(Pens.Black, new Point[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10) });
        }
        private void DrawClassicDotdash()
        {
            g.DrawLines(Pens.Black, new Point[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10) });
        }
        private void DrawTriangle()
        {
            g.FillPolygon(Brushes.Black, new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10) });
        }
        private void DrawTriangleDotdash()
        {
            g.FillPolygon(Brushes.Black, new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10) });
        }
        private void DrawDiamondEmpty()
        {
            Color color = Control.DefaultBackColor;
            g.FillPolygon(new SolidBrush(color), new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10), new Point(-30, 0) });
            g.DrawPolygon(Pens.Black, new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10), new Point(-30, 0) });
        }
        private void DrawDiamond()
        {
            g.FillPolygon(Brushes.Black, new PointF[] { new Point(-15, 10), new Point(0, 0), new Point(-15, -10), new Point(-30, 0) });
        }
    }
}
