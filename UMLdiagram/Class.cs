using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLdiagram.Models;

namespace UMLdiagram
{
    public class Class
    {
        public int X { get; set; } = 20;
        public int Y { get; set; } = 20;
        public int width { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public bool isInterface { get; set; } = false;
        public List<PropertyModel> props { get; set; } = new List<PropertyModel>();
        public List<MethodModel> methods { get; set; } = new List<MethodModel>();
        public int topConnections { get; set; } = 0;
        public int leftConnections { get; set; } = 0;
        public int rightConnections { get; set; } = 0;
        public int bottomConnections { get; set; } = 0;
        public void Draw(Graphics g)
        {
            height = 40 + 20 * props.Count + 20 * methods.Count;

            RecalculateWidth(g);

            g.FillRectangle(Brushes.LightGray, X, Y, width, height); // background
            DrawClassName(g);
            DrawProps(g);
            DrawMethods(g);
            g.DrawRectangle(Pens.Black, X, Y, width, height);
        }
        public void RecalculateWidth(Graphics g)
        {
            width = 50;

            Font fontClassName = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold); // font for class name
            if (isInterface)
                width = width < (int)g.MeasureString("<interface>   " + name, fontClassName).Width ? (int)g.MeasureString("<interface>   " + name, fontClassName).Width + 20 : width; // scale width with class name w interface
            width = width < (int)g.MeasureString(name, fontClassName).Width ? (int)g.MeasureString(name, fontClassName).Width + 20 : width; // scale width with class name

            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for props
            for (int i = 0; i < props.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(props[i].accessMod); // "public -> +" etc...
                string propDisplay = $"{accessModShort}  {props[i].name}: {props[i].type}"; // prop string to display on class
                width = width < (int)g.MeasureString(propDisplay, fontProps).Width ? (int)g.MeasureString(propDisplay, fontProps).Width : width; // scale width with widest prop
            }

            for (int i = 0; i < methods.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(methods[i].accessMod); // "public -> +" etc...

                string paramsDisplay = "";
                foreach (var param in methods[i].parameters) // formating param string to insert to method display string
                {
                    paramsDisplay += $"{param.type} {param.name}, ";
                }
                if (paramsDisplay.Length != 0)
                    paramsDisplay = paramsDisplay.Remove(paramsDisplay.Length - 2);
                string propDisplay = $"{accessModShort} {methods[i].name}({paramsDisplay}) : {methods[i].type}"; // method string to display on class
                width = width < (int)g.MeasureString(propDisplay, fontProps).Width ? (int)g.MeasureString(propDisplay, fontProps).Width : width; // scale width with widest method
            }

            width += 10;
        }
        public void DrawShadow(Graphics g)
        {
            int shadowOffset = 3;
            g.FillRectangle(Brushes.DarkGray, X + shadowOffset, Y + shadowOffset, width + shadowOffset, height + shadowOffset); // shadow
            
        }
        private void DrawClassName(Graphics g)
        {
            int itemEndX = X + width;
            g.DrawLine(Pens.Black, X, Y + 20, itemEndX, Y + 20); //line under class name
            Font fontClassName = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold); // font for class name
            if (isInterface)
            {
                g.DrawString("<interface>   " + name, fontClassName, Brushes.Black, X, Y); // class name w "interface"
            }
            else
            {
                g.DrawString(name, fontClassName, Brushes.Black, X, Y); // class name
            }
        }
        private void DrawProps(Graphics g)
        {
            int itemEndX = X + width;
            g.DrawLine(Pens.Black, X, Y + 20 + 20 * props.Count, itemEndX, Y + 20 + 20 * props.Count); // line under props
            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for props
            for (int i = 0; i < props.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(props[i].accessMod); // "public -> +" etc...
                string propDisplay = $"{accessModShort}  {props[i].name}: {props[i].type}"; // prop string to display on class
                g.DrawString(propDisplay, fontProps, Brushes.Black, X, Y + 20 * (i + 1)); // displaying the string
            }
        }
        private void DrawMethods(Graphics g)
        {
            Font fontProps = new Font(FontFamily.GenericSansSerif, 9); // font for methods
            for (int i = 0; i < methods.Count; i++)
            {
                char accessModShort = ShortenAccessModifier(methods[i].accessMod); // "public -> +" etc...

                string paramsDisplay = "";
                foreach (var param in methods[i].parameters) // formating param string to insert to method display string
                {
                    paramsDisplay += $"{param.type} {param.name}, ";
                }
                if (paramsDisplay.Length != 0)
                    paramsDisplay = paramsDisplay.Remove(paramsDisplay.Length - 2);
                string propDisplay = $"{accessModShort} {methods[i].name}({paramsDisplay}) : {methods[i].type}"; // method string to display on class
                g.DrawString(propDisplay, fontProps, Brushes.Black, X, Y + 20 * props.Count + 20 * (i + 1)); // displaying the string
                
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
            g.DrawRectangle(Pens.Blue, X - borderOffset, Y - borderOffset, width + 2 * borderOffset, height + 2 * borderOffset);
        }
        public void Move(int mouseX, int mouseY, int relMousePosToObjX, int relMousePosToObjY)
        {
            X = mouseX - relMousePosToObjX;
            Y = mouseY - relMousePosToObjY;
        }
    }
}
