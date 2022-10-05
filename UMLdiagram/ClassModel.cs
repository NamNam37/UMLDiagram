using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLdiagram
{
    public class ClassModel
    {
        public int X = 0;
        public int Y = 0;
        public int width = 100;
        public int height = 20;
        public string name { get; set; }
        public List<PropertyModel> props { get; set; } = new List<PropertyModel>();
        public ClassModel(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void Draw(Graphics g)
        {
            height = 20 + 20 * props.Count;
            height += 200; //temp

            int itemEndX = X + width;
            int itemEndY = Y + height;

            g.DrawLine(Pens.Black, X, Y + 20, itemEndX, Y + 20);
            Font fontClassName = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            g.DrawString(name, fontClassName, Brushes.Black, X, Y);
            g.DrawLine(Pens.Black, X, Y + 20+ 20 * props.Count, itemEndX, Y + 20 + 20 * props.Count);
            Font fontProps = new Font(FontFamily.GenericSansSerif, 9);

            for (int i = 0; i < props.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(props[i].accessMod);
                
                string propDisplay = $"{accessModShort}  {props[i].name}: {props[i].type}";
                g.DrawString(propDisplay, fontProps, Brushes.Black, X, Y + 20*(i+1));
                width = width < (int)g.MeasureString(propDisplay, fontProps).Width ? (int)g.MeasureString(propDisplay, fontProps).Width : width;

            }
            g.DrawRectangle(Pens.Black, X, Y, width, height);


        }
        private char ShortenAccessModifier(string LongVer)
        {
            switch (LongVer)
            {
                case "private":
                    return '-';
                case "public":
                    return '+';
                case "protected":
                    return '#';
                default:
                    return '-';
            }
        }
        public void DrawSelection(Graphics g)
        {
            int borderOffset = 5;
            g.DrawRectangle(Pens.Blue, X - borderOffset, Y - borderOffset, width + 2 * borderOffset, height + 2 * borderOffset);
        }
        public void Move(int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            X = mouseX - relMousePosToObjX;
            Y = mouseY - relMousePosToObjY;
        }
    }
}
