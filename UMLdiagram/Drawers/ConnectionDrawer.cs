using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram.Drawers
{
    public class ConnectionDrawer
    {
        private Graphics g { get; set; }
        public ConnectionDrawer(Graphics g)
        {
            this.g = g;
        }
        public ConnectionDrawer()
        {

        }
        public void CheckObj(List<ConnectionModel> connections, int mouseX, int mouseY)
        {
            int missTolerance = 15;
            foreach (ConnectionModel connection in connections)
            {

                Size Top1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y);
                Size Top2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y);
                Size Left1 = new Size(connection.class1.X, connection.class1.Y + connection.class1.height / 2);
                Size Left2 = new Size(connection.class2.X, connection.class2.Y + connection.class2.height / 2);
                Size Right1 = new Size(connection.class1.X + connection.class1.width, connection.class1.Y + connection.class1.height / 2);
                Size Right2 = new Size(connection.class2.X + connection.class1.width, connection.class2.Y + connection.class2.height / 2);
                Size Bottom1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y + connection.class1.height);
                Size Bottom2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y + connection.class2.height);
                int TopDis = Math.Abs(Top1.Height - Bottom2.Height);
                int LeftDis = Math.Abs(Left1.Width - Right2.Width);
                int RightDis = Math.Abs(Right1.Width - Left2.Width);
                int BottomDis = Math.Abs(Bottom1.Height - Top2.Height);
                int[] distances = new int[] { TopDis, LeftDis, RightDis, BottomDis };
                if (distances.Max() == TopDis)
                {
                    int middlePart = (Bottom1.Height + Top2.Height) / 2;
                    
                    if (mouseY > Bottom1.Height && mouseY < middlePart && mouseX > Bottom1.Width - missTolerance && mouseX < Bottom1.Width + missTolerance)
                    {
                        Debug.WriteLine(mouseX + " " + mouseY);
                    }
                    if (mouseX > Bottom1.Width && mouseX < Top2.Width && mouseY > middlePart - missTolerance && mouseY < middlePart + missTolerance)
                    {
                        Debug.WriteLine(mouseX + " " + mouseY);
                    }
                    if (mouseY < Top2.Height && mouseY > middlePart && mouseX > Top2.Width - missTolerance && mouseX < Top2.Width + missTolerance)
                    {
                        Debug.WriteLine(mouseX + " " + mouseY);
                    }
                }
                if (distances.Max() == LeftDis)
                {

                }
                if (distances.Max() == RightDis)
                {

                }
                if (distances.Max() == BottomDis)
                {

                }
            }
        }
        public void Draw(List<ConnectionModel> connections)
        {
            foreach (ConnectionModel connection in connections)
            {

                Size Top1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y);
                Size Top2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y);
                Size Left1 = new Size(connection.class1.X, connection.class1.Y + connection.class1.height / 2);
                Size Left2 = new Size(connection.class2.X, connection.class2.Y + connection.class2.height / 2);
                Size Right1 = new Size(connection.class1.X + connection.class1.width, connection.class1.Y + connection.class1.height / 2);
                Size Right2 = new Size(connection.class2.X + connection.class1.width, connection.class2.Y + connection.class2.height / 2);
                Size Bottom1 = new Size(connection.class1.X + connection.class1.width / 2, connection.class1.Y + connection.class1.height);
                Size Bottom2 = new Size(connection.class2.X + connection.class1.width / 2, connection.class2.Y + connection.class2.height);

                int TopDis = Math.Abs(Top1.Height - Bottom2.Height);
                int LeftDis = Math.Abs(Left1.Width - Right2.Width);
                int RightDis = Math.Abs(Right1.Width - Left2.Width);
                int BottomDis = Math.Abs(Bottom1.Height - Top2.Height);
                int[] distances = new int[] { TopDis, LeftDis, RightDis, BottomDis };

                Pen pen = new Pen(Color.Black);
                if (connection.type == ArrowDrawer.Type.classicDotdash || connection.type == ArrowDrawer.Type.triangleDotdash)
                    pen.DashPattern = new float[] { 10, 10, 2, 10 };

                if (distances.Max() == TopDis)
                    g.DrawLines(pen, new Point[] { new Point(Bottom1), new Point(Bottom1.Width, (Bottom1.Height + Top2.Height) / 2), new Point(Top2.Width, (Bottom1.Height + Top2.Height) / 2), new Point(Top2) });
                if (distances.Max() == LeftDis)
                    g.DrawLines(pen, new Point[] { new Point(Right1), new Point((Right1.Width + Left2.Width) / 2, Right1.Height), new Point((Right1.Width + Left2.Width) / 2, Left2.Height), new Point(Left2) });
                if (distances.Max() == RightDis)
                    g.DrawLines(pen, new Point[] { new Point(Left1), new Point((Left1.Width + Right2.Width) / 2, Left1.Height), new Point((Left1.Width + Right2.Width) / 2, Right2.Height), new Point(Right2) });
                if (distances.Max() == BottomDis)
                    g.DrawLines(pen, new Point[] { new Point(Top1), new Point(Top1.Width, (Top1.Height + Bottom2.Height) / 2), new Point(Bottom2.Width, (Top1.Height + Bottom2.Height) / 2), new Point(Bottom2) });

                if (distances.Max() == TopDis)
                    new ArrowDrawer(g).Draw(connection.type, Top2.Width, Top2.Height, 90);
                if (distances.Max() == LeftDis)
                    new ArrowDrawer(g).Draw(connection.type, Left2.Width, Left2.Height, 0);
                if (distances.Max() == RightDis)
                    new ArrowDrawer(g).Draw(connection.type, Right2.Width, Right2.Height, 180);
                if (distances.Max() == BottomDis)
                    new ArrowDrawer(g).Draw(connection.type, Bottom2.Width, Bottom2.Height, 270);
            }
        }
        private int[] GetOffsets(int objsNextToEachOther)
        {
            if (objsNextToEachOther != 0)
            {
                int[] entityOffsets = new int[objsNextToEachOther];
                int globalOffset = 12;
                if (objsNextToEachOther % 2 == 0)
                {
                    entityOffsets[0] = -globalOffset/2;
                    entityOffsets[1] = globalOffset/2;
                    int curr = 18;
                    for (int i = 2; i < objsNextToEachOther; i++)
                    {
                        if (i % 2 != 0)
                        {
                            entityOffsets[i] = -curr;
                            curr += globalOffset;
                        }
                        else
                        {
                            entityOffsets[i] = curr;
                        }
                    }
                } else
                {
                
                    entityOffsets[0] = 0;
                    int curr = globalOffset;
                    for (int i = 1; i < objsNextToEachOther; i++)
                    {
                        if (i % 2 == 0)
                        {
                            entityOffsets[i] = -curr;
                            curr += globalOffset;
                        }
                        else
                        {
                            entityOffsets[i] = curr;
                        }
                    }
                
                }
                return entityOffsets;
            }
            return new int[0];
        }
    }
}
