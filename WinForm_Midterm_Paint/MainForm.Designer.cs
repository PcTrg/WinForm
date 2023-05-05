namespace WinForm_Midterm_Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawPanel = new System.Windows.Forms.Panel();
            this.lineBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.fillEllipseBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.fillRectBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.fillCircleBtn = new System.Windows.Forms.Button();
            this.arcBtn = new System.Windows.Forms.Button();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.fillPolygonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.drawPanel.Location = new System.Drawing.Point(12, 97);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(718, 315);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // lineBtn
            // 
            this.lineBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.diagonal_line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineBtn.Location = new System.Drawing.Point(194, 25);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(30, 30);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.ellipse;
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipseBtn.Location = new System.Drawing.Point(230, 25);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(30, 30);
            this.ellipseBtn.TabIndex = 4;
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // fillEllipseBtn
            // 
            this.fillEllipseBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.ellipse__1_;
            this.fillEllipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillEllipseBtn.Location = new System.Drawing.Point(266, 25);
            this.fillEllipseBtn.Name = "fillEllipseBtn";
            this.fillEllipseBtn.Size = new System.Drawing.Size(30, 30);
            this.fillEllipseBtn.TabIndex = 5;
            this.fillEllipseBtn.UseVisualStyleBackColor = true;
            this.fillEllipseBtn.Click += new System.EventHandler(this.fillEllipseBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.rectangle;
            this.rectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectBtn.Location = new System.Drawing.Point(302, 25);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(30, 30);
            this.rectBtn.TabIndex = 6;
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // fillRectBtn
            // 
            this.fillRectBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.rectangle__1_;
            this.fillRectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillRectBtn.Location = new System.Drawing.Point(338, 25);
            this.fillRectBtn.Name = "fillRectBtn";
            this.fillRectBtn.Size = new System.Drawing.Size(30, 30);
            this.fillRectBtn.TabIndex = 7;
            this.fillRectBtn.UseVisualStyleBackColor = true;
            this.fillRectBtn.Click += new System.EventHandler(this.fillRectBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.dry_clean;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleBtn.Location = new System.Drawing.Point(194, 61);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(30, 30);
            this.circleBtn.TabIndex = 8;
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // fillCircleBtn
            // 
            this.fillCircleBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.new_moon;
            this.fillCircleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillCircleBtn.Location = new System.Drawing.Point(230, 61);
            this.fillCircleBtn.Name = "fillCircleBtn";
            this.fillCircleBtn.Size = new System.Drawing.Size(30, 30);
            this.fillCircleBtn.TabIndex = 9;
            this.fillCircleBtn.UseVisualStyleBackColor = true;
            this.fillCircleBtn.Click += new System.EventHandler(this.fillCircleBtn_Click);
            // 
            // arcBtn
            // 
            this.arcBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.arc;
            this.arcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arcBtn.Location = new System.Drawing.Point(266, 61);
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.Size = new System.Drawing.Size(30, 30);
            this.arcBtn.TabIndex = 10;
            this.arcBtn.UseVisualStyleBackColor = true;
            this.arcBtn.Click += new System.EventHandler(this.arcBtn_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.polygon;
            this.polygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polygonBtn.Location = new System.Drawing.Point(302, 61);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(30, 30);
            this.polygonBtn.TabIndex = 11;
            this.polygonBtn.UseVisualStyleBackColor = true;
            // 
            // fillPolygonBtn
            // 
            this.fillPolygonBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.hexagon;
            this.fillPolygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillPolygonBtn.Location = new System.Drawing.Point(338, 61);
            this.fillPolygonBtn.Name = "fillPolygonBtn";
            this.fillPolygonBtn.Size = new System.Drawing.Size(30, 30);
            this.fillPolygonBtn.TabIndex = 12;
            this.fillPolygonBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 424);
            this.Controls.Add(this.fillPolygonBtn);
            this.Controls.Add(this.polygonBtn);
            this.Controls.Add(this.arcBtn);
            this.Controls.Add(this.fillCircleBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.fillRectBtn);
            this.Controls.Add(this.rectBtn);
            this.Controls.Add(this.fillEllipseBtn);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.drawPanel);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button fillEllipseBtn;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Button fillRectBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button fillCircleBtn;
        private System.Windows.Forms.Button arcBtn;
        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button fillPolygonBtn;
    }
}

