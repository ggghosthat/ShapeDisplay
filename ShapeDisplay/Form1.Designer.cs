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
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
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
            canvas.MouseUp += canvas_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.25F);
            label1.Location = new Point(658, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 1;
            label1.Text = "Pen: ";
            // 
            // btnPen
            // 
            btnPen.BackColor = Color.Red;
            btnPen.Location = new Point(711, 12);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(23, 23);
            btnPen.TabIndex = 2;
            btnPen.UseVisualStyleBackColor = false;
            btnPen.Click += button1_Click;
            // 
            // btnFill
            // 
            btnFill.BackColor = Color.Yellow;
            btnFill.Location = new Point(711, 44);
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
            label2.Location = new Point(658, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 3;
            label2.Text = "Fill: ";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            radioButton4.Location = new Point(658, 84);
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
            radioButton5.Location = new Point(658, 112);
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
            radioButton6.Location = new Point(656, 137);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(71, 27);
            radioButton6.TabIndex = 10;
            radioButton6.Text = "circle";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(btnFill);
            Controls.Add(label2);
            Controls.Add(btnPen);
            Controls.Add(label1);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
