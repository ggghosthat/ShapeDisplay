namespace ShapeDisplay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            canvas = new PictureBox();
            label1 = new Label();
            btnPen = new Button();
            btnFill = new Button();
            label2 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel1 = new Panel();
            cSizeBar = new TrackBar();
            rTriangleSizeBar = new TrackBar();
            rtHeightSizeBar = new TrackBar();
            rtWidthSizeBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cSizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rTriangleSizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rtHeightSizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rtWidthSizeBar).BeginInit();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.Location = new Point(12, 12);
            canvas.Name = "canvas";
            canvas.Size = new Size(630, 426);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.25F);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 1;
            label1.Text = "Pen: ";
            // 
            // btnPen
            // 
            btnPen.BackColor = Color.Red;
            btnPen.Location = new Point(67, 9);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(23, 23);
            btnPen.TabIndex = 2;
            btnPen.UseVisualStyleBackColor = false;
            btnPen.Click += button1_Click;
            // 
            // btnFill
            // 
            btnFill.BackColor = Color.Yellow;
            btnFill.Location = new Point(67, 41);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(23, 23);
            btnFill.TabIndex = 4;
            btnFill.UseVisualStyleBackColor = false;
            btnFill.Click += btnFill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.25F);
            label2.Location = new Point(14, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 3;
            label2.Text = "Fill: ";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            radioButton4.Location = new Point(14, 81);
            radioButton4.Margin = new Padding(1);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(101, 30);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "rectangle";
            radioButton4.UseCompatibleTextRendering = true;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            radioButton5.Location = new Point(14, 189);
            radioButton5.Margin = new Padding(1);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(132, 27);
            radioButton5.TabIndex = 9;
            radioButton5.Text = "right triangle";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            radioButton6.Location = new Point(14, 269);
            radioButton6.Margin = new Padding(1);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(71, 27);
            radioButton6.TabIndex = 10;
            radioButton6.Text = "circle";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(cSizeBar);
            panel1.Controls.Add(rTriangleSizeBar);
            panel1.Controls.Add(rtHeightSizeBar);
            panel1.Controls.Add(rtWidthSizeBar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPen);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(btnFill);
            panel1.Controls.Add(radioButton4);
            panel1.Location = new Point(648, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 426);
            panel1.TabIndex = 12;
            // 
            // cSizeBar
            // 
            cSizeBar.Location = new Point(14, 298);
            cSizeBar.Margin = new Padding(1);
            cSizeBar.Maximum = 200;
            cSizeBar.Minimum = 10;
            cSizeBar.Name = "cSizeBar";
            cSizeBar.Size = new Size(162, 45);
            cSizeBar.TabIndex = 16;
            cSizeBar.TickStyle = TickStyle.None;
            cSizeBar.UseWaitCursor = true;
            cSizeBar.Value = 10;
            cSizeBar.Scroll += cSizeBar_Scroll;
            // 
            // rTriangleSizeBar
            // 
            rTriangleSizeBar.Location = new Point(14, 218);
            rTriangleSizeBar.Margin = new Padding(1);
            rTriangleSizeBar.Maximum = 200;
            rTriangleSizeBar.Minimum = 10;
            rTriangleSizeBar.Name = "rTriangleSizeBar";
            rTriangleSizeBar.Size = new Size(162, 45);
            rTriangleSizeBar.TabIndex = 15;
            rTriangleSizeBar.TickStyle = TickStyle.None;
            rTriangleSizeBar.UseWaitCursor = true;
            rTriangleSizeBar.Value = 10;
            rTriangleSizeBar.Scroll += rTriangleSizeBar_Scroll;
            // 
            // rtHeightSizeBar
            // 
            rtHeightSizeBar.Location = new Point(14, 142);
            rtHeightSizeBar.Margin = new Padding(1);
            rtHeightSizeBar.Maximum = 200;
            rtHeightSizeBar.Minimum = 10;
            rtHeightSizeBar.Name = "rtHeightSizeBar";
            rtHeightSizeBar.Size = new Size(162, 45);
            rtHeightSizeBar.TabIndex = 14;
            rtHeightSizeBar.TickStyle = TickStyle.None;
            rtHeightSizeBar.UseWaitCursor = true;
            rtHeightSizeBar.Value = 10;
            rtHeightSizeBar.Scroll += rtHeightSizeBar_Scroll;
            // 
            // rtWidthSizeBar
            // 
            rtWidthSizeBar.Location = new Point(14, 113);
            rtWidthSizeBar.Margin = new Padding(1);
            rtWidthSizeBar.Maximum = 200;
            rtWidthSizeBar.Minimum = 10;
            rtWidthSizeBar.Name = "rtWidthSizeBar";
            rtWidthSizeBar.Size = new Size(162, 45);
            rtWidthSizeBar.TabIndex = 13;
            rtWidthSizeBar.TickStyle = TickStyle.None;
            rtWidthSizeBar.UseWaitCursor = true;
            rtWidthSizeBar.Value = 10;
            rtWidthSizeBar.Scroll += sizeBar_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(panel1);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cSizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rTriangleSizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rtHeightSizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rtWidthSizeBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private Label label1;
        private Button btnPen;
        private Button btnFill;
        private Label label2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel1;
        private TrackBar rtWidthSizeBar;
        private TrackBar cSizeBar;
        private TrackBar rTriangleSizeBar;
        private TrackBar rtHeightSizeBar;
    }
}
