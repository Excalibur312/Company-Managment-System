using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace loginScreen
{
    public class CustomBtn : Button
    {
        //Fie1ds
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderCoIor = Color.PaleVioletRed;


        //Properties
        [Category("Custom Code Advance  ")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custom Code Advance  ")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                this.Invalidate();
            }
        }
        [Category("Custom Code Advance  ")]
        public Color BorderCoIor
        {
            get
            {
                return borderCoIor;
            }
            set
            {
                borderCoIor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Code Advance  ")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Custom Code Advance  ")]
        public Color TextdColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Constructor
        public CustomBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

        }


        //Methods

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;

        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width, this.Height);

            if (borderRadius > 2)  // Rounded button 
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderCoIor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //BUtton Surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border
                    if (borderSize >= 1)
                    {
                        //Draw control border
                        pevent.Graphics.DrawPath(penSurface, pathSurface);
                    }
                }


            }
            else // Normal button
            {
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderCoIor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width, this.Height - 1);
                    }
                }
            }

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius -= this.Height;
        }


    }
}
