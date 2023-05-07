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
            this.sizePanel = new System.Windows.Forms.Panel();
            this.size3Btn = new System.Windows.Forms.Button();
            this.size2Btn = new System.Windows.Forms.Button();
            this.size1Btn = new System.Windows.Forms.Button();
            this.sizeLb = new System.Windows.Forms.Label();
            this.sizeBtn = new System.Windows.Forms.Button();
            this.arcBtn = new System.Windows.Forms.Button();
            this.fillCircleBtn = new System.Windows.Forms.Button();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.fillPolygonBtn = new System.Windows.Forms.Button();
            this.fillRectBtn = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.rectBtn = new System.Windows.Forms.Button();
            this.colorLb = new System.Windows.Forms.Label();
            this.fillEllipseBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.sizePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(12, 109);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(561, 303);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Click += new System.EventHandler(this.drawPanel_Click);
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // sizePanel
            // 
            this.sizePanel.AllowDrop = true;
            this.sizePanel.BackColor = System.Drawing.Color.Transparent;
            this.sizePanel.Controls.Add(this.size3Btn);
            this.sizePanel.Controls.Add(this.size2Btn);
            this.sizePanel.Controls.Add(this.size1Btn);
            this.sizePanel.Location = new System.Drawing.Point(298, 109);
            this.sizePanel.MaximumSize = new System.Drawing.Size(105, 63);
            this.sizePanel.MinimumSize = new System.Drawing.Size(105, 0);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(105, 0);
            this.sizePanel.TabIndex = 18;
            this.sizePanel.Click += new System.EventHandler(this.sizePanel_Click);
            // 
            // size3Btn
            // 
            this.size3Btn.BackColor = System.Drawing.Color.LightBlue;
            this.size3Btn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.width__3_;
            this.size3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.size3Btn.Location = new System.Drawing.Point(0, 40);
            this.size3Btn.Name = "size3Btn";
            this.size3Btn.Size = new System.Drawing.Size(102, 20);
            this.size3Btn.TabIndex = 1;
            this.size3Btn.UseVisualStyleBackColor = false;
            this.size3Btn.Click += new System.EventHandler(this.size3Btn_Click);
            // 
            // size2Btn
            // 
            this.size2Btn.BackColor = System.Drawing.Color.LightBlue;
            this.size2Btn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.width__2_;
            this.size2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.size2Btn.Location = new System.Drawing.Point(0, 20);
            this.size2Btn.Name = "size2Btn";
            this.size2Btn.Size = new System.Drawing.Size(102, 20);
            this.size2Btn.TabIndex = 2;
            this.size2Btn.UseVisualStyleBackColor = false;
            this.size2Btn.Click += new System.EventHandler(this.size2Btn_Click);
            // 
            // size1Btn
            // 
            this.size1Btn.BackColor = System.Drawing.Color.LightBlue;
            this.size1Btn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.width__1_;
            this.size1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.size1Btn.Location = new System.Drawing.Point(0, 3);
            this.size1Btn.Name = "size1Btn";
            this.size1Btn.Size = new System.Drawing.Size(102, 20);
            this.size1Btn.TabIndex = 1;
            this.size1Btn.UseVisualStyleBackColor = false;
            this.size1Btn.Click += new System.EventHandler(this.size1Btn_Click);
            // 
            // sizeLb
            // 
            this.sizeLb.AutoSize = true;
            this.sizeLb.BackColor = System.Drawing.Color.Transparent;
            this.sizeLb.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sizeLb.Location = new System.Drawing.Point(297, 66);
            this.sizeLb.Name = "sizeLb";
            this.sizeLb.Size = new System.Drawing.Size(29, 16);
            this.sizeLb.TabIndex = 18;
            this.sizeLb.Text = "Size";
            // 
            // sizeBtn
            // 
            this.sizeBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sizeBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.width;
            this.sizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sizeBtn.Location = new System.Drawing.Point(288, 13);
            this.sizeBtn.Name = "sizeBtn";
            this.sizeBtn.Size = new System.Drawing.Size(50, 50);
            this.sizeBtn.TabIndex = 0;
            this.sizeBtn.UseVisualStyleBackColor = false;
            this.sizeBtn.Click += new System.EventHandler(this.sizeBtn_Click);
            // 
            // arcBtn
            // 
            this.arcBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arcBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.arc;
            this.arcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arcBtn.Location = new System.Drawing.Point(82, 49);
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.Size = new System.Drawing.Size(30, 30);
            this.arcBtn.TabIndex = 10;
            this.arcBtn.UseVisualStyleBackColor = false;
            this.arcBtn.Click += new System.EventHandler(this.arcBtn_Click);
            // 
            // fillCircleBtn
            // 
            this.fillCircleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillCircleBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.new_moon;
            this.fillCircleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillCircleBtn.Location = new System.Drawing.Point(46, 49);
            this.fillCircleBtn.Name = "fillCircleBtn";
            this.fillCircleBtn.Size = new System.Drawing.Size(30, 30);
            this.fillCircleBtn.TabIndex = 9;
            this.fillCircleBtn.UseVisualStyleBackColor = false;
            this.fillCircleBtn.Click += new System.EventHandler(this.fillCircleBtn_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polygonBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.polygon1;
            this.polygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polygonBtn.Location = new System.Drawing.Point(118, 49);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(30, 30);
            this.polygonBtn.TabIndex = 11;
            this.polygonBtn.UseVisualStyleBackColor = false;
            this.polygonBtn.Click += new System.EventHandler(this.polygonBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circleBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.dry_clean;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleBtn.Location = new System.Drawing.Point(10, 49);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(30, 30);
            this.circleBtn.TabIndex = 8;
            this.circleBtn.UseVisualStyleBackColor = false;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // fillPolygonBtn
            // 
            this.fillPolygonBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillPolygonBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.hexagon1;
            this.fillPolygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillPolygonBtn.Location = new System.Drawing.Point(154, 49);
            this.fillPolygonBtn.Name = "fillPolygonBtn";
            this.fillPolygonBtn.Size = new System.Drawing.Size(30, 30);
            this.fillPolygonBtn.TabIndex = 12;
            this.fillPolygonBtn.UseVisualStyleBackColor = false;
            this.fillPolygonBtn.Click += new System.EventHandler(this.fillPolygonBtn_Click);
            // 
            // fillRectBtn
            // 
            this.fillRectBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillRectBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.rectangle__1_;
            this.fillRectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillRectBtn.Location = new System.Drawing.Point(154, 13);
            this.fillRectBtn.Name = "fillRectBtn";
            this.fillRectBtn.Size = new System.Drawing.Size(30, 30);
            this.fillRectBtn.TabIndex = 7;
            this.fillRectBtn.UseVisualStyleBackColor = false;
            this.fillRectBtn.Click += new System.EventHandler(this.fillRectBtn_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.colorPanel.Location = new System.Drawing.Point(217, 13);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(50, 50);
            this.colorPanel.TabIndex = 13;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.rectangle;
            this.rectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectBtn.Location = new System.Drawing.Point(118, 13);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(30, 30);
            this.rectBtn.TabIndex = 6;
            this.rectBtn.UseVisualStyleBackColor = false;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // colorLb
            // 
            this.colorLb.AutoSize = true;
            this.colorLb.BackColor = System.Drawing.Color.Transparent;
            this.colorLb.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorLb.Location = new System.Drawing.Point(223, 66);
            this.colorLb.Name = "colorLb";
            this.colorLb.Size = new System.Drawing.Size(36, 16);
            this.colorLb.TabIndex = 14;
            this.colorLb.Text = "Color";
            // 
            // fillEllipseBtn
            // 
            this.fillEllipseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillEllipseBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.ellipse__1_;
            this.fillEllipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillEllipseBtn.Location = new System.Drawing.Point(82, 13);
            this.fillEllipseBtn.Name = "fillEllipseBtn";
            this.fillEllipseBtn.Size = new System.Drawing.Size(30, 30);
            this.fillEllipseBtn.TabIndex = 5;
            this.fillEllipseBtn.UseVisualStyleBackColor = false;
            this.fillEllipseBtn.Click += new System.EventHandler(this.fillEllipseBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ellipseBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.ellipse;
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipseBtn.Location = new System.Drawing.Point(46, 13);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(30, 30);
            this.ellipseBtn.TabIndex = 4;
            this.ellipseBtn.UseVisualStyleBackColor = false;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Plum;
            this.deleteBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.bin;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.Location = new System.Drawing.Point(358, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(63, 66);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineBtn.BackgroundImage = global::WinForm_Midterm_Paint.Properties.Resources.diagonal_line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineBtn.Location = new System.Drawing.Point(10, 13);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(30, 30);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exportBtn.Location = new System.Drawing.Point(444, 13);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(94, 29);
            this.exportBtn.TabIndex = 19;
            this.exportBtn.Text = "Export to PNG";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.menuPanel.Controls.Add(this.exportBtn);
            this.menuPanel.Controls.Add(this.sizeBtn);
            this.menuPanel.Controls.Add(this.sizeLb);
            this.menuPanel.Controls.Add(this.fillRectBtn);
            this.menuPanel.Controls.Add(this.deleteBtn);
            this.menuPanel.Controls.Add(this.lineBtn);
            this.menuPanel.Controls.Add(this.colorPanel);
            this.menuPanel.Controls.Add(this.ellipseBtn);
            this.menuPanel.Controls.Add(this.fillEllipseBtn);
            this.menuPanel.Controls.Add(this.rectBtn);
            this.menuPanel.Controls.Add(this.colorLb);
            this.menuPanel.Controls.Add(this.fillCircleBtn);
            this.menuPanel.Controls.Add(this.arcBtn);
            this.menuPanel.Controls.Add(this.polygonBtn);
            this.menuPanel.Controls.Add(this.circleBtn);
            this.menuPanel.Controls.Add(this.fillPolygonBtn);
            this.menuPanel.Location = new System.Drawing.Point(12, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(561, 91);
            this.menuPanel.TabIndex = 20;
            this.menuPanel.Click += new System.EventHandler(this.menuPanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(580, 424);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.sizePanel);
            this.Controls.Add(this.drawPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.sizePanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.Button size3Btn;
        private System.Windows.Forms.Button size2Btn;
        private System.Windows.Forms.Button size1Btn;
        private System.Windows.Forms.Button sizeBtn;
        private System.Windows.Forms.Label sizeLb;
        private System.Windows.Forms.Button arcBtn;
        private System.Windows.Forms.Button fillCircleBtn;
        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button fillPolygonBtn;
        private System.Windows.Forms.Button fillRectBtn;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Label colorLb;
        private System.Windows.Forms.Button fillEllipseBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Panel menuPanel;
    }
}

