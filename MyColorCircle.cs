using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class MyColorCircle : MyCircle
    {
        public Point Location { get; set; }

        public int _width { get; set; }

        public int _height { get; set; }

        public int _borderWidth { get; set; }

        public Color _borderColor { get; set; }

        private Color _brushColor { get; set; }

        public MyColorCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color brushColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            int w = Math.Abs(sPoint.X - ePoint.X);
            int h = Math.Abs(sPoint.Y - ePoint.Y);

            Location = new Point(x, y);
            _width = w;
            _height = h;
            _borderWidth = borderWidth;
            _borderColor = borderColor;
            _brushColor = brushColor;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(_borderColor, _borderWidth);
            RectangleF r = new RectangleF(Location, new Size(_width, _height));
            g.FillEllipse(new SolidBrush(_brushColor), r);
            g.DrawEllipse(p, r);
        }
    }
}
