using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram.Drawers
{
    public class ClassDrawer
    {
        public ClassModel drawnClass { get; set; }
        public ClassDrawer(ClassModel drawnClass)
        {
            this.drawnClass = drawnClass;
        }
        public void Draw(Graphics g)
        {
            drawnClass.height = 40 + 20 * drawnClass.props.Count + 20 * drawnClass.methods.Count;

            RecalculateWidth(g);

            g.FillRectangle(Brushes.LightGray, drawnClass.X, drawnClass.Y, drawnClass.width, drawnClass.height); // background
            DrawClassName(g);
            DrawProps(g);
            DrawMethods(g);
            g.DrawRectangle(Pens.Black, drawnClass.X, drawnClass.Y, drawnClass.width, drawnClass.height);
        }
        public void RecalculateWidth(Graphics g)
        {
            drawnClass.width = 50;

            Font fontClassName = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold); // font for class name
            if (drawnClass.isInterface)
                drawnClass.width = drawnClass.width < (int)g.MeasureString("<interface>   " + drawnClass.name, fontClassName).Width ? (int)g.MeasureString("<interface>   " + drawnClass.name, fontClassName).Width + 20 : drawnClass.width; // scale width with class name w interface
            drawnClass.width = drawnClass.width < (int)g.MeasureString(drawnClass.name, fontClassName).Width ? (int)g.MeasureString(drawnClass.name, fontClassName).Width + 20 : drawnClass.width; // scale width with class name

            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for props
            for (int i = 0; i < drawnClass.props.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(drawnClass.props[i].accessMod); // "public -> +" etc...
                string propDisplay = $"{accessModShort}  {drawnClass.props[i].name}: {drawnClass.props[i].type}"; // prop string to display on class
                drawnClass.width = drawnClass.width < (int)g.MeasureString(propDisplay, fontProps).Width ? (int)g.MeasureString(propDisplay, fontProps).Width : drawnClass.width; // scale width with widest prop
            }

            for (int i = 0; i < drawnClass.methods.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(drawnClass.methods[i].accessMod); // "public -> +" etc...

                string paramsDisplay = "";
                foreach (var param in drawnClass.methods[i].parameters) // formating param string to insert to method display string
                {
                    paramsDisplay += $"{param.type} {param.name}, ";
                }
                if (paramsDisplay.Length != 0)
                    paramsDisplay = paramsDisplay.Remove(paramsDisplay.Length - 2);
                string propDisplay = $"{accessModShort} {drawnClass.methods[i].name}({paramsDisplay}) : {drawnClass.methods[i].type}"; // method string to display on class
                drawnClass.width = drawnClass.width < (int)g.MeasureString(propDisplay, fontProps).Width ? (int)g.MeasureString(propDisplay, fontProps).Width : drawnClass.width; // scale width with widest method
            }

            drawnClass.width += 10;
        }
        public void DrawShadow(Graphics g)
        {
            int shadowOffset = 3;
            g.FillRectangle(Brushes.DarkGray, drawnClass.X + shadowOffset, drawnClass.Y + shadowOffset, drawnClass.width + shadowOffset, drawnClass.height + shadowOffset); // shadow

        }
        private void DrawClassName(Graphics g)
        {
            int itemEndX = drawnClass.X + drawnClass.width;
            g.DrawLine(Pens.Black, drawnClass.X, drawnClass.Y + 20, itemEndX, drawnClass.Y + 20); //line under class name
            Font fontClassName = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold); // font for class name
            if (drawnClass.isInterface)
            {
                g.DrawString("<interface>   " + drawnClass.name, fontClassName, Brushes.Black, drawnClass.X, drawnClass.Y); // class name w "interface"
            }
            else
            {
                g.DrawString(drawnClass.name, fontClassName, Brushes.Black, drawnClass.X, drawnClass.Y); // class name
            }
        }
        private void DrawProps(Graphics g)
        {
            int itemEndX = drawnClass.X + drawnClass.width;
            g.DrawLine(Pens.Black, drawnClass.X, drawnClass.Y + 20 + 20 * drawnClass.props.Count, itemEndX, drawnClass.Y + 20 + 20 * drawnClass.props.Count); // line under props
            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for props
            for (int i = 0; i < drawnClass.props.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(drawnClass.props[i].accessMod); // "public -> +" etc...
                string propDisplay = $"{accessModShort}  {drawnClass.props[i].name}: {drawnClass.props[i].type}"; // prop string to display on class
                g.DrawString(propDisplay, fontProps, Brushes.Black, drawnClass.X, drawnClass.Y + 20 * (i + 1)); // displaying the string
            }
        }
        private void DrawMethods(Graphics g)
        {
            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for methods
            for (int i = 0; i < drawnClass.methods.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(drawnClass.methods[i].accessMod); // "public -> +" etc...

                string paramsDisplay = "";
                foreach (var param in drawnClass.methods[i].parameters) // formating param string to insert to method display string
                {
                    paramsDisplay += $"{param.type} {param.name}, ";
                }
                if (paramsDisplay.Length != 0)
                    paramsDisplay = paramsDisplay.Remove(paramsDisplay.Length - 2);
                string propDisplay = $"{accessModShort} {drawnClass.methods[i].name}({paramsDisplay}) : {drawnClass.methods[i].type}"; // method string to display on class
                g.DrawString(propDisplay, fontProps, Brushes.Black, drawnClass.X, drawnClass.Y + 20 * drawnClass.props.Count + 20 * (i + 1)); // displaying the string

            }
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
            g.DrawRectangle(Pens.Blue, drawnClass.X - borderOffset, drawnClass.Y - borderOffset, drawnClass.width + 2 * borderOffset, drawnClass.height + 2 * borderOffset);
        }
        public void Move(int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            drawnClass.X = mouseX - relMousePosToObjX;
            drawnClass.Y = mouseY - relMousePosToObjY;
        }
    }
}
