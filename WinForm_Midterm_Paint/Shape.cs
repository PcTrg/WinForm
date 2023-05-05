using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Midterm_Paint
{
    public enum ShapePos
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
    }

    public abstract class Shape
    {
        private Point p1;
        private Point p2;
        private Point dis; // distance from mouse to p1

        private Pen pen;
        private Pen resizePen = new Pen(Color.DodgerBlue);

        GraphicsPath path;
        GraphicsPath resizeTopLeft;
        GraphicsPath resizeTopRight;
        GraphicsPath resizeBottomLeft;
        GraphicsPath resizeBottomRight;

        private bool isSelected = false;
        private bool isResizing = false;
        private bool isMoving = false;

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Pen Pen { get => pen; set => pen = value; }
        public GraphicsPath Path { get => path; set => path = value; }
        public GraphicsPath ResizeTopLeft { get => resizeTopLeft; set => resizeTopLeft = value; }
        public GraphicsPath ResizeTopRight { get => resizeTopRight; set => resizeTopRight = value; }
        public GraphicsPath ResizeBottomLeft { get => resizeBottomLeft; set => resizeBottomLeft = value; }
        public GraphicsPath ResizeBottomRight { get => resizeBottomRight; set => resizeBottomRight = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public bool IsMoving { get => isMoving; set => isMoving = value; }
        public Point Dis { get => dis; set => dis = value; }
        public bool IsResizing { get => isResizing; set => isResizing = value; }

        public Shape(Point p1, Point p2, Pen pen)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.pen = pen;
        }

        private void swap(Point a, Point b)
        {
            Point temp = a;
            a = b;
            b = temp;
        }

        public void UpdatePath(MouseEventArgs e)
        {
            //restric P1<P2
            if (p1.X > p2.X && p1.Y < p2.Y || 
                p1.X > p2.X && p1.Y > p2.Y)
            {
                swap(p1, p2);
            }
            
            // calculate path
            Point start = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            Point end = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            // add pic path
            path = new GraphicsPath();

            path.AddRectangle(
                    new Rectangle(
                        start, 
                        new Size(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y))));

            // add resize path
            resizeTopLeft = new GraphicsPath();
            resizeTopRight = new GraphicsPath();
            resizeBottomLeft = new GraphicsPath();
            resizeBottomRight = new GraphicsPath();

            resizeTopLeft.AddRectangle(
                    new Rectangle(
                        new Point(start.X-10, start.Y- 10),
                        new Size(20,20)));
            resizeTopRight.AddRectangle(
                    new Rectangle(
                        new Point(end.X - 10, start.Y - 10),
                        new Size(20, 20)));
            resizeBottomLeft.AddRectangle(
                    new Rectangle(
                        new Point(start.X - 10, end.Y - 10),
                        new Size(20, 20)));
            resizeBottomRight.AddRectangle(
                    new Rectangle(
                        new Point(end.X - 10, end.Y - 10),
                        new Size(20, 20)));
        }
        public virtual void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            switch (resizePos)
            {
                case ShapePos.TopLeft:
                    {
                        p1 = e.Location;
                        break;
                    }
                case ShapePos.TopRight:
                    {
                        p1 = new Point(p1.X, e.Location.Y);
                        p2 = new Point(e.Location.X, p2.Y);
                        break;
                    }
                case ShapePos.BottomLeft:
                    {
                        p1 = new Point(e.Location.X, p1.Y);
                        p2 = new Point(p2.X, e.Location.Y);
                        break;
                    }
                case ShapePos.BottomRight:
                    {
                        p2 = e.Location;
                        break;
                    }
            }
        }
        public virtual void MoveShape(MouseEventArgs e)
        {
            Point originalDis_From_P1toP2 = new Point(p2.X - p1.X, p2.Y - p1.Y);

            p1 = new Point(e.Location.X - dis.X, e.Location.Y - dis.Y);
            p2 = new Point(p1.X + originalDis_From_P1toP2.X, p1.Y + originalDis_From_P1toP2.Y);
        }
        public virtual void DrawShape(PaintEventArgs e)
        {

        }

        public static void DrawAllPath(List<Shape> shapList, PaintEventArgs e)
        {
            for(int i = 0; i < shapList.Count; i++)
            {
                if (shapList[i].isSelected)
                {
                    // draw the path
                    e.Graphics.DrawPath(shapList[i].resizePen, shapList[i].path);

                    // draw 4 resize path
                    e.Graphics.DrawPath(shapList[i].resizePen, shapList[i].resizeTopLeft);
                    e.Graphics.DrawPath(shapList[i].resizePen, shapList[i].resizeTopRight);
                    e.Graphics.DrawPath(shapList[i].resizePen, shapList[i].resizeBottomLeft);
                    e.Graphics.DrawPath(shapList[i].resizePen, shapList[i].resizeBottomRight);
                }
            }
        }
    }

    public class Line: Shape
    {
        public Line(Point p1, Point p2, Pen pen): base(p1, p2, pen)
        {

        }

        public override void DrawShape(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pen, P1, P2);
        }
        public override void MoveShape(MouseEventArgs e)
        {
            base.MoveShape(e);
        }
        public override void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            base.UpdateShape(resizePos, e);
        }
    }
    public class Ellipse: Shape
    {
        private Rectangle ellipseRect;
        public Rectangle EllipseRect { get => ellipseRect; set => ellipseRect = value; }

        public Ellipse(Point p1, Point p2, Pen pen, Rectangle ellipseRect) : base(p1, p2, pen)
        {
            this.ellipseRect = ellipseRect;
        }

        protected void UpdateRect()
        {
            ellipseRect = new Rectangle(P1, new Size(P2.X - P1.X, P2.Y - P1.Y));
        }

        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.DrawEllipse(Pen, ellipseRect);
        }
        public override void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            base.UpdateShape(resizePos, e);
            UpdateRect();
        }
        public override void MoveShape(MouseEventArgs e)
        {
            base.MoveShape(e);
            UpdateRect();
        }
    }

    public class FillEllipse: Ellipse
    {
        private Brush brush;
        public Brush Brush { get => brush; set => brush = value; }
        public FillEllipse(Point p1, Point p2, Pen pen, Rectangle ellipseRect, Brush brush) : base(p1, p2, pen, ellipseRect)
        {
            this.brush = brush;
        }
        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.FillEllipse(brush, EllipseRect);
        }
    }

    public class Rectangles: Shape
    {
        private Rectangle rectRect;
        public Rectangle RectRect { get => rectRect; set => rectRect = value; }

        public Rectangles(Point p1, Point p2, Pen pen, Rectangle rectRect) : base(p1, p2, pen)
        {
            this.rectRect = rectRect;
        }
        protected void UpdateRect()
        {
            rectRect = new Rectangle(P1, new Size(P2.X - P1.X, P2.Y - P1.Y));
        }
        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.DrawRectangle(Pen, rectRect);
        }
        public override void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            base.UpdateShape(resizePos, e);
            UpdateRect();
        }
        public override void MoveShape(MouseEventArgs e)
        {
            base.MoveShape(e);
            UpdateRect();
        }
    }

    public class FillRect: Rectangles
    {
        private Brush brush;
        public Brush Brush { get => brush; set => brush = value; }

        public FillRect(Point p1, Point p2, Pen pen, Rectangle ellipseRect, Brush brush) : base(p1, p2, pen, ellipseRect)
        {
            this.brush = brush;
        }
        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.FillRectangle(brush, RectRect);
        }
    }

    public class Circle: Shape
    {
        private Rectangle circleRect;
        public Rectangle CircleRect { get => circleRect; set => circleRect = value; }

        public Circle(Point p1, Point p2, Pen pen, Rectangle ellipseRect) : base(p1, p2, pen)
        {
            this.circleRect = ellipseRect;
        }

        protected void UpdateRect()
        {
            circleRect = new Rectangle(P1, new Size(P2.X - P1.X, P2.Y - P1.Y));
        }

        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.DrawEllipse(Pen, circleRect);
        }
        public override void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            int distance = 0; // distance from mouse location to the opposite point (unchanged point)

            switch (resizePos)
            {
                case ShapePos.TopLeft:
                    {
                        distance = P2.X - e.Location.X;

                        P1 = new Point(P2.X - distance, P2.Y - distance);
                        break;
                    }
                case ShapePos.TopRight:
                    {
                        distance = e.Location.X - P1.X;

                        P1 = new Point(P1.X, P2.Y - distance);
                        P2 = new Point(P1.X + distance, P2.Y);
                        break;
                    }
                case ShapePos.BottomLeft:
                    {
                        distance = P2.X - e.Location.X;

                        P1 = new Point(P2.X - distance, P1.Y);
                        P2 = new Point(P2.X , P1.Y + distance);
                        break;
                    }
                case ShapePos.BottomRight:
                    {
                        distance = e.Location.X - P1.X;

                        P2 = new Point(P1.X + distance, P1.Y +distance);
                        break;
                    }
            }

            UpdateRect();
        }
        public override void MoveShape(MouseEventArgs e)
        {
            base.MoveShape(e);
            UpdateRect();
        }
    }

    public class FillCircle: Circle
    {
        private Brush brush;
        public Brush Brush { get => brush; set => brush = value; }
        public FillCircle(Point p1, Point p2, Pen pen, Rectangle circleRect, Brush brush) : base(p1, p2, pen, circleRect)
        {
            this.brush = brush;
        }
        public override void DrawShape(PaintEventArgs e)
        {
            UpdateRect();
            e.Graphics.FillEllipse(brush, CircleRect);
        }
    }

    public class Arc: Shape
    {
        private Rectangle arcRect;
        public Rectangle ArcRect { get => arcRect; set => arcRect = value; }

        public Arc(Point p1, Point p2, Pen pen, Rectangle arcRect) : base(p1, p2, pen)
        {
            this.arcRect = arcRect;
        }

        protected void UpdateArcRect()
        {
            arcRect = new Rectangle(
                new Point(P1.X, P1.Y - (P2.Y-P1.Y)), // left to right
                //new Point(P1.X - (P2.X - P1.X), P1.Y - (P2.Y - P1.Y)), // right to left
                new Size((P2.X - P1.X)*2, (P2.Y - P1.Y)*2));
        }

        public override void DrawShape(PaintEventArgs e)
        {
            UpdateArcRect();

            e.Graphics.DrawArc(Pen, arcRect, 90, 90); // left to right
            //e.Graphics.DrawArc(Pen, arcRect, 0, 90);    // right to left
        }
        public override void UpdateShape(ShapePos resizePos, MouseEventArgs e)
        {
            base.UpdateShape(resizePos, e);
            UpdateArcRect();
        }
        public override void MoveShape(MouseEventArgs e)
        {
            base.MoveShape(e);
            UpdateArcRect();
        }
    }
}
