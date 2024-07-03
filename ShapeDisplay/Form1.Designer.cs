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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            canvas = new PictureBox();
            label1 = new Label();
            btnPen = new Button();
            btnFill = new Button();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
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
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoCheck = false;
            radioButton1.AutoSize = true;
            radioButton1.Cursor = Cursors.Cross;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Image = (Image)resources.GetObject("radioButton1.Image");
            radioButton1.Location = new Point(658, 73);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 40);
            radioButton1.TabIndex = 5;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoCheck = false;
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.Cross;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Image = (Image)resources.GetObject("radioButton2.Image");
            radioButton2.Location = new Point(658, 165);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(40, 40);
            radioButton2.TabIndex = 6;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.AutoCheck = false;
            radioButton3.AutoSize = true;
            radioButton3.Cursor = Cursors.Cross;
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Image = (Image)resources.GetObject("radioButton3.Image");
            radioButton3.Location = new Point(658, 119);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 40);
            radioButton3.TabIndex = 7;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Visible = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
