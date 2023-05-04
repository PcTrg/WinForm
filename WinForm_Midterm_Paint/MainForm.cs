using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Midterm_Paint
{
    public partial class MainForm : Form
    {
        private bool btnLine = false;
        private bool btnEllipse = false;

        private bool isDrawing = false;
        private bool isMultiSelecting = false;

        private ShapePos resizePos;

        private List<Shape> shapeList = new List<Shape>();

        private Pen newPen = new Pen(Color.Black, 5);

        private void AddList(MouseEventArgs e)
        {
            if (btnLine)
            {
                Line newLine = new Line(e.Location, e.Location, newPen);
                shapeList.Add(newLine);
            }

            if (btnEllipse)
            {
                Ellipse newEllipse = new Ellipse(e.Location, e.Location, newPen, 
                    new Rectangle(e.Location, new Size(0,0)));
                shapeList.Add(newEllipse);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            drawPanel.SetDoubleBuffered();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            Shape.DrawAllPath(shapeList, e);

            for (int i = 0; i < shapeList.Count; i++)
            {
                shapeList[i].DrawShape(e);
            }
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnLine || btnEllipse)
            {
                isDrawing = true;
                AddList(e);

                drawPanel.Refresh();
            }

            if (!isDrawing)
            {
                // stop multiselect
                bool select = false;
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].Path.IsVisible(e.Location)) select = true;
                }
                if (!select) isMultiSelecting = false;

                // select, resize, move, unselect
                for (int i = 0; i < shapeList.Count; i++)
                {
                    // select
                    if (shapeList[i].Path.IsVisible(e.Location))
                    {
                        shapeList[i].IsSelected = true;
                        drawPanel.Refresh();
                    }

                    //resize
                    if (shapeList[i].IsSelected)
                    {
                        if (shapeList[i].ResizeTopLeft.IsVisible(e.Location))
                        {
                            shapeList[i].IsResizing = true;
                            resizePos = ShapePos.TopLeft;
                        }

                        if (shapeList[i].ResizeTopRight.IsVisible(e.Location))
                        {
                            shapeList[i].IsResizing = true;
                            resizePos = ShapePos.TopRight;
                        }

                        if (shapeList[i].ResizeBottomLeft.IsVisible(e.Location))
                        {
                            shapeList[i].IsResizing = true;
                            resizePos = ShapePos.BottomLeft;
                        }

                        if (shapeList[i].ResizeBottomRight.IsVisible(e.Location))
                        {
                            shapeList[i].IsResizing = true;
                            resizePos = ShapePos.BottomRight;
                        }
                    }

                    if (shapeList[i].IsSelected)
                    {
                        //move
                        if (shapeList[i].Path.IsVisible(e.Location) || isMultiSelecting)
                        {
                            shapeList[i].IsMoving = true;

                            shapeList[i].Dis = new Point(
                            e.Location.X - shapeList[i].P1.X,
                            e.Location.Y - shapeList[i].P1.Y);
                        }
                        else if (!shapeList[i].IsResizing)
                        {
                            // multi select
                            if (ModifierKeys == Keys.Control)
                            {
                                isMultiSelecting = true;
                            }
                            // unselect
                            else
                            {
                                shapeList[i].IsSelected = false;
                                isMultiSelecting = false;
                                drawPanel.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                shapeList[shapeList.Count - 1].UpdateShape(ShapePos.BottomRight, e);
                drawPanel.Refresh();
            }
            else
            {
                // resize
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].IsResizing)
                    {
                        shapeList[i].UpdateShape(resizePos, e);
                        shapeList[i].UpdatePath(e);
                        drawPanel.Refresh();
                    }
                }

                // multiple move obj allow
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].IsMoving)
                    {
                        shapeList[i].MoveShape(e);
                        shapeList[i].UpdatePath(e);
                        drawPanel.Refresh();
                    }
                }
            }
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                shapeList[shapeList.Count - 1].UpdatePath(e);
                drawPanel.Refresh();
            }

            // stop action
            isDrawing = false;
            for (int i = 0; i < shapeList.Count; i++)
            {
                shapeList[i].IsResizing = false;
                shapeList[i].IsMoving = false;
            }

            // btn reset
            btnLine = false;
            btnEllipse = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLine = true;

            //other false
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnEllipse = true;
        }
    }

    public static class ErrorFix
    {
        public static void SetDoubleBuffered(this Panel panel)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, panel, new object[] { true });
        }
    }
}
