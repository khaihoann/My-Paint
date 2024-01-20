using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class Form2 : Form
    {
        private Graphics _graphic;
        private Point _aPoint;
        private Pen _pen;
        private Point _sPoint;
        private bool _moving;
        private LinkedList<MyRectangle> _rectangles;
        private LinkedList<MyCircle> _circles;
        private LinkedList<MyColorRectangle> _cRectangle;
        private LinkedList<MyColorCircle> _cCircles;
        private int _widthvalue;
        public Form2()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangles = new LinkedList<MyRectangle>();
            _circles = new LinkedList<MyCircle>();
            _cRectangle = new LinkedList<MyColorRectangle>();
            _cCircles = new LinkedList<MyColorCircle>();
            _widthvalue = inpPenWidth.Width;
        }

       
        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            if (rbNoFill.Checked)
            {
                foreach (MyRectangle rect in _rectangles)
                {
                    rect.Draw(_graphic);
                }
                foreach (MyCircle circle in _circles)
                {
                    circle.Draw(_graphic);
                }
            }
            else
            {
                foreach(MyColorRectangle cRec in _cRectangle)
                {
                    cRec.Draw(_graphic);
                }
                foreach(MyColorCircle cCir in _cCircles)
                {
                    cCir.Draw(_graphic);
                }
            }

            
            
        }
       

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            Color brushColor = cdBrushColor.Color;  

            if (rbRectangle.Checked) {
                if (rbNoFill.Checked)
                {
                    MyRectangle rec = new MyRectangle(_sPoint, e.Location, penWidth, penColor);
                    rec.Draw(_graphic);
                }
                else if (rbFill.Checked)
                {
                    MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth, penColor, brushColor);
                    cRec.Draw(_graphic);
                }
                else
                {
                    //MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth, penColor, brushColor);
                    //cRec.Draw(_graphic);
                }
            }
            else
            {
                if (rbNoFill.Checked)
                {
                    MyCircle cir = new MyCircle(_sPoint, e.Location, penWidth, penColor);
                    cir.Draw(_graphic);
                }
                else if (rbFill.Checked)
                {
                    MyColorCircle cCir = new MyColorCircle(_sPoint, e.Location, penWidth, penColor, brushColor);
                    cCir.Draw(_graphic);
                }
                else
                {
                    //MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth, penColor, brushColor);
                    //cRec.Draw(_graphic);
                }
            }
            
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            Color brushColor = cdBrushColor.Color;
            if (rbRectangle.Checked)
            {
                if (rbNoFill.Checked)
                {
                    MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth,
                   penColor);
                    _rectangles.AddLast(rect);
                }
                else if(rbFill.Checked)
                {
                    MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth,penColor, brushColor);
                    _cRectangle.AddLast(cRec);
                }
                else
                {
                    //MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth,penColor, brushColor);
                    //_cRectangle.AddLast(cRec);
                }
            }
            else 
            {
                if (rbNoFill.Checked)
                {
                    MyCircle cir = new MyCircle(_sPoint, e.Location, penWidth,
                   penColor);
                    _circles.AddLast(cir);
                }
                else if (rbFill.Checked)
                {
                    MyColorCircle cCir = new MyColorCircle(_sPoint, e.Location, penWidth, penColor, brushColor);
                    _cCircles.AddLast(cCir);
                }
                else
                {
                    //MyColorRectangle cRec = new MyColorRectangle(_sPoint, e.Location, penWidth,penColor, brushColor);
                    //_cRectangle.AddLast(cRec);
                }
            }

            
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                lblPenColor.ForeColor = cdPenColor.Color;
            }
        }

        private void btnColor_Click_2(object sender, EventArgs e)
        {
            if (cdBrushColor.ShowDialog() == DialogResult.OK)
            {
                lblBrushColor.ForeColor = cdBrushColor.Color;
            }
        }



        private void inpPenWidth_ValueChanged(object sender, EventArgs e)
        {
            if (_widthvalue == 0)
            {
                _widthvalue =  1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
