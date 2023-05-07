using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Midterm_Paint
{
    public partial class MainForm : Form
    {
        private int thickness = 5;

        private bool btnLine = false;
        private bool btnEllipse = false;
        private bool btnFillEllipse = false;
        private bool btnRect = false;
        private bool btnFillRect = false;
        private bool btnCircle = false;
        private bool btnFillCircle = false;
        private bool btnArc = false;
        private bool btnHexagon = false;
        private bool btnFillHex = false;

        private bool isCollapsed = true;

        private bool isDrawing = false;
        private bool isMultiSelecting = false;

        private ShapePos resizePos;

        private List<Shape> shapeList = new List<Shape>();

        private Color selectedColor = Color.Black;
        private Pen newPen = new Pen(Color.Black, 5);
        private Brush newBrush = new SolidBrush(Color.Black);

        private void AddList(MouseEventArgs e)
        {
            newPen = new Pen(selectedColor, thickness);
            newBrush = new SolidBrush(selectedColor);

            if (btnLine)
            {
                Line newLine = new Line(e.Location, e.Location, newPen);
                shapeList.Add(newLine);
            }

            if (btnEllipse)
            {
                Ellipse newEllipse = new Ellipse(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)));
                shapeList.Add(newEllipse);
            }

            if (btnFillEllipse)
            {
                FillEllipse newFillEllipse = new FillEllipse(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)), newBrush);
                shapeList.Add(newFillEllipse);
            }

            if (btnRect)
            {
                Rectangles newRect = new Rectangles(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)));
                shapeList.Add(newRect);
            }

            if (btnFillRect)
            {
                FillRect newFillRect = new FillRect(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)), newBrush);
                shapeList.Add(newFillRect);
            }

            if (btnCircle)
            {
                Circle newCircle = new Circle(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)));
                shapeList.Add(newCircle);
            }

            if (btnFillCircle)
            {
                FillCircle newFillCir = new FillCircle(e.Location, e.Location, newPen,
                    new Rectangle(e.Location, new Size(0, 0)), newBrush);
                shapeList.Add(newFillCir);
            }

            if (btnArc)
            {
                // Problem: winform cannot draw the arc that have the size(0,0)
                // Solution: make the p1 a bit back for system to draw the arc with size(1,1)

                Arc newArc = new Arc(new Point(e.Location.X - 1, e.Location.Y - 1), e.Location , newPen,
                    new Rectangle(e.Location, new Size(1, 1)));
                shapeList.Add(newArc);
            }

            if (btnHexagon)
            {
                Point[] points = new Point[6];
                Hexagon newHex = new Hexagon(e.Location, e.Location, newPen, points);

                shapeList.Add(newHex);
            }

            if (btnFillHex)
            {
                Point[] points = new Point[6];
                FillHexagon newFillHex = new FillHexagon(e.Location, e.Location, newPen, points, newBrush);
                shapeList.Add(newFillHex);
            }
        }

        private void Uncollapse()
        {
            if (!isCollapsed)
            {
                sizePanel.Size = sizePanel.MinimumSize;
                isCollapsed = true;
            }
        }

        // build-in function
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
            if (btnLine || btnEllipse || btnFillEllipse || btnRect || btnFillRect ||
                btnCircle || btnFillCircle || btnArc || btnHexagon || btnFillHex)
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
                    if (shapeList[i].IsSelected 
                        // not allow multiple resize
                        && !isMultiSelecting)
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

                    // move, unselect
                    if (shapeList[i].IsSelected)
                    {
                        //move
                        if ((shapeList[i].Path.IsVisible(e.Location)   
                            // prioritize the resize feature
                            && !shapeList[i].ResizeTopLeft.IsVisible(e.Location) 
                            && !shapeList[i].ResizeTopRight.IsVisible(e.Location)
                            && !shapeList[i].ResizeBottomLeft.IsVisible(e.Location)
                            && !shapeList[i].ResizeBottomRight.IsVisible(e.Location)) 
                            || isMultiSelecting)
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
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            Uncollapse();
        }

        private void sizePanel_Click(object sender, EventArgs e)
        {
            Uncollapse();
        }

        private void menuPanel_Click(object sender, EventArgs e)
        {
            Uncollapse();
        }

        private void drawPanel_Click(object sender, EventArgs e)
        {
            Uncollapse();
        }

        // btn shapes
        private void lineBtn_Click(object sender, EventArgs e)
        {
            btnLine = true;

            //Only allow player to draw 1 shape at one time
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            btnEllipse = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void fillEllipseBtn_Click(object sender, EventArgs e)
        {
            btnFillEllipse = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            btnRect = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void fillRectBtn_Click(object sender, EventArgs e)
        {
            btnFillRect = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            btnCircle = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void fillCircleBtn_Click(object sender, EventArgs e)
        {
            btnFillCircle = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnArc = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void arcBtn_Click(object sender, EventArgs e)
        {
            btnArc = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnHexagon = false;
            btnFillHex = false;
        }

        private void polygonBtn_Click(object sender, EventArgs e)
        {
            btnHexagon = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnFillHex = false;
        }

        private void fillPolygonBtn_Click(object sender, EventArgs e)
        {
            btnFillHex = true;

            //Only allow player to draw 1 shape at one time
            btnLine = false;
            btnEllipse = false;
            btnFillEllipse = false;
            btnRect = false;
            btnFillRect = false;
            btnCircle = false;
            btnFillCircle = false;
            btnArc = false;
            btnHexagon = false;
        }

        // color btn
        private void colorPanel_Click(object sender, EventArgs e)
        {
            // Show the color dialog and allow the user to select a color
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                colorPanel.BackColor = selectedColor;
            }
        }

        // size btn
        private void sizeBtn_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                sizePanel.Size = sizePanel.MaximumSize;
                isCollapsed = false;
            }
            else
            {
                sizePanel.Size = sizePanel.MinimumSize;
                isCollapsed = true;
            }
        }

        private void size1Btn_Click(object sender, EventArgs e)
        {
            thickness = 5;
            Uncollapse();
        }

        private void size2Btn_Click(object sender, EventArgs e)
        {
            thickness = 10;
            Uncollapse();
        }

        private void size3Btn_Click(object sender, EventArgs e)
        {
            thickness = 15;
            Uncollapse();
        }

        //delete btn
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            shapeList.RemoveAll(s => s.IsSelected);
            drawPanel.Refresh();
        }

        // eport btn
        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(drawPanel.Width, drawPanel.Height);
                Graphics eg = Graphics.FromImage(bmp);

                drawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, drawPanel.Width, drawPanel.Height));
                bmp.Save(@"\\Mac\Home\Desktop\Image.png", ImageFormat.Png);

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
