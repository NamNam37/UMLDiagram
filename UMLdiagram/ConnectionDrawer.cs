using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class ConnectionDrawer
    {
        private Graphics g { get; set; }
        public ConnectionDrawer(Graphics g)
        {
            this.g = g;
        }
        public void Draw(Pen pen, List<ConnectionModel> connections)
        {
            int offset = 0;
            foreach (ConnectionModel connection in connections)
            {
                Size Top1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y - offset);
                Size Top2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y - offset);
                Size Left1 = new Size(connection.class1.X - offset, connection.class1.Y + connection.class1.height / 2);
                Size Left2 = new Size(connection.class2.X - offset, connection.class2.Y + connection.class2.height / 2);
                Size Right1 = new Size(connection.class1.X + connection.class1.width + offset, connection.class1.Y + connection.class1.height / 2);
                Size Right2 = new Size(connection.class2.X + connection.class1.width + offset, connection.class2.Y + connection.class2.height / 2);
                Size Bottom1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y + connection.class1.height + offset);
                Size Bottom2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y + connection.class2.height + offset);

                int TopDis = Math.Abs(Top1.Height - Bottom2.Height);
                int LeftDis = Math.Abs(Left1.Width - Right2.Width);
                int RightDis = Math.Abs(Right1.Width - Left2.Width);
                int BottomDis = Math.Abs(Bottom1.Height - Top2.Height);
                int[] distances = new int[] { TopDis, LeftDis, RightDis, BottomDis };

                if (distances.Max() == TopDis)
                    g.DrawLines(pen, new Point[] { new Point(Bottom1), new Point(Bottom1.Width, (Bottom1.Height + Top2.Height) / 2), new Point(Top2.Width, (Bottom1.Height + Top2.Height) / 2), new Point(Top2) });
                if (distances.Max() == LeftDis)
                    g.DrawLines(pen, new Point[] { new Point(Right1), new Point((Right1.Width + Left2.Width) / 2, Right1.Height), new Point((Right1.Width + Left2.Width) / 2, Left2.Height), new Point(Left2) });
                if (distances.Max() == RightDis)
                    g.DrawLines(pen, new Point[] { new Point(Left1), new Point((Left1.Width + Right2.Width) / 2, Left1.Height), new Point((Left1.Width + Right2.Width) / 2, Right2.Height), new Point(Right2) });
                if (distances.Max() == BottomDis)
                    g.DrawLines(pen, new Point[] { new Point(Top1), new Point(Top1.Width, (Top1.Height + Bottom2.Height) / 2), new Point(Bottom2.Width, (Top1.Height + Bottom2.Height) / 2), new Point(Bottom2) });

                if (distances.Max() == TopDis)
                    new ArrowDrawer(g).Draw(connection.type, Pens.Black, Top2.Width, Top2.Height, 90);
                if (distances.Max() == LeftDis)
                    new ArrowDrawer(g).Draw(connection.type, Pens.Black, Left2.Width, Left2.Height, 0);
                if (distances.Max() == RightDis)
                    new ArrowDrawer(g).Draw(connection.type, Pens.Black, Right2.Width, Right2.Height, 180);
                if (distances.Max() == BottomDis)
                    new ArrowDrawer(g).Draw(connection.type, Pens.Black, Bottom2.Width, Bottom2.Height, 270);
            }
        }
    }
}
