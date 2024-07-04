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
            cSizeBar = new NumericUpDown();
            rTriangleSizeBar = new NumericUpDown();
            rtHeightSizeBar = new NumericUpDown();
            rtWidthSizeBar = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            canvas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            canvas.BorderStyle = BorderStyle.FixedSingle;
            canvas.Location = new Point(12, 12);
            canvas.Name = "canvas";
            canvas.Size = new Size(676, 426);
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
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 1;
            label1.Text = "Border: ";
            // 
            // btnPen
            // 
            btnPen.BackColor = Color.Red;
            btnPen.Location = new Point(87, 17);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(30, 30);
            btnPen.TabIndex = 2;
            btnPen.UseVisualStyleBackColor = false;
            btnPen.Click += button1_Click;
            // 
            // btnFill
            // 
            btnFill.BackColor = Color.Yellow;
            btnFill.Location = new Point(187, 17);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(30, 30);
            btnFill.TabIndex = 4;
            btnFill.UseVisualStyleBackColor = false;
            btnFill.Click += btnFill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.25F);
            label2.Location = new Point(142, 20);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 3;
            label2.Text = "Fill: ";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            radioButton4.Location = new Point(10, 53);
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
            radioButton5.Location = new Point(10, 151);
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
            radioButton6.Location = new Point(10, 210);
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
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPen);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(btnFill);
            panel1.Controls.Add(radioButton4);
            panel1.Location = new Point(694, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 288);
            panel1.TabIndex = 12;
            // 
            // cSizeBar
            // 
            cSizeBar.Location = new Point(87, 239);
            cSizeBar.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            cSizeBar.Name = "cSizeBar";
            cSizeBar.Size = new Size(120, 23);
            cSizeBar.TabIndex = 22;
            cSizeBar.ValueChanged += cSizeBar_Scroll;
            // 
            // rTriangleSizeBar
            // 
            rTriangleSizeBar.Location = new Point(87, 182);
            rTriangleSizeBar.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            rTriangleSizeBar.Name = "rTriangleSizeBar";
            rTriangleSizeBar.Size = new Size(120, 23);
            rTriangleSizeBar.TabIndex = 23;
            rTriangleSizeBar.ValueChanged += rTriangleSizeBar_Scroll;
            // 
            // rtHeightSizeBar
            // 
            rtHeightSizeBar.Location = new Point(87, 110);
            rtHeightSizeBar.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            rtHeightSizeBar.Name = "rtHeightSizeBar";
            rtHeightSizeBar.Size = new Size(120, 23);
            rtHeightSizeBar.TabIndex = 24;
            rtHeightSizeBar.ValueChanged += rtHeightSizeBar_Scroll;
            // 
            // rtWidthSizeBar
            // 
            rtWidthSizeBar.Location = new Point(87, 81);
            rtWidthSizeBar.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            rtWidthSizeBar.Name = "rtWidthSizeBar";
            rtWidthSizeBar.Size = new Size(120, 23);
            rtWidthSizeBar.TabIndex = 21;
            rtWidthSizeBar.ValueChanged += sizeBar_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 239);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 20;
            label6.Text = "Radius:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 19;
            label5.Text = "Edge:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 113);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 18;
            label4.Text = "Height:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 17;
            label3.Text = "Width:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(panel1);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "ShapeDisplay";
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
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown rtWidthSizeBar;
        private NumericUpDown cSizeBar;
        private NumericUpDown rTriangleSizeBar;
        private NumericUpDown rtHeightSizeBar;
    }
}
