namespace DesignPattern
{
    partial class Form2
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.Pen = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoFill = new System.Windows.Forms.RadioButton();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.rbPatternFill = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.lblBrushColor = new System.Windows.Forms.Label();
            this.cdBrushColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.Pen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(8, 12);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(559, 438);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nét vẽ";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(20, 46);
            this.lblPenColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(27, 13);
            this.lblPenColor.TabIndex = 2;
            this.lblPenColor.Text = "màu";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(82, 15);
            this.inpPenWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(93, 20);
            this.inpPenWidth.TabIndex = 3;
            this.inpPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpPenWidth.ValueChanged += new System.EventHandler(this.inpPenWidth_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(99, 42);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(76, 21);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Chọn màu";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // Pen
            // 
            this.Pen.Controls.Add(this.btnColor);
            this.Pen.Controls.Add(this.label1);
            this.Pen.Controls.Add(this.inpPenWidth);
            this.Pen.Controls.Add(this.lblPenColor);
            this.Pen.Location = new System.Drawing.Point(572, 12);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(200, 76);
            this.Pen.TabIndex = 6;
            this.Pen.TabStop = false;
            this.Pen.Text = "Pen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFillColor);
            this.groupBox1.Controls.Add(this.rbPatternFill);
            this.groupBox1.Controls.Add(this.rbFill);
            this.groupBox1.Controls.Add(this.lblBrushColor);
            this.groupBox1.Controls.Add(this.rbNoFill);
            this.groupBox1.Location = new System.Drawing.Point(572, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brush";
            // 
            // rbNoFill
            // 
            this.rbNoFill.AutoSize = true;
            this.rbNoFill.Checked = true;
            this.rbNoFill.Location = new System.Drawing.Point(23, 19);
            this.rbNoFill.Name = "rbNoFill";
            this.rbNoFill.Size = new System.Drawing.Size(54, 17);
            this.rbNoFill.TabIndex = 0;
            this.rbNoFill.TabStop = true;
            this.rbNoFill.Text = "No Fill";
            this.rbNoFill.UseVisualStyleBackColor = true;
            this.rbNoFill.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(23, 42);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(37, 17);
            this.rbFill.TabIndex = 0;
            this.rbFill.Text = "Fill";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // rbPatternFill
            // 
            this.rbPatternFill.AutoSize = true;
            this.rbPatternFill.Location = new System.Drawing.Point(23, 65);
            this.rbPatternFill.Name = "rbPatternFill";
            this.rbPatternFill.Size = new System.Drawing.Size(74, 17);
            this.rbPatternFill.TabIndex = 0;
            this.rbPatternFill.Text = "Pattern Fill";
            this.rbPatternFill.UseVisualStyleBackColor = true;
            this.rbPatternFill.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCircle);
            this.groupBox2.Controls.Add(this.rbRectangle);
            this.groupBox2.Location = new System.Drawing.Point(572, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Checked = true;
            this.rbRectangle.Location = new System.Drawing.Point(23, 20);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(23, 43);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(99, 94);
            this.btnFillColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(76, 21);
            this.btnFillColor.TabIndex = 4;
            this.btnFillColor.Text = "Chọn màu";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnColor_Click_2);
            // 
            // lblBrushColor
            // 
            this.lblBrushColor.AutoSize = true;
            this.lblBrushColor.Location = new System.Drawing.Point(20, 98);
            this.lblBrushColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrushColor.Name = "lblBrushColor";
            this.lblBrushColor.Size = new System.Drawing.Size(27, 13);
            this.lblBrushColor.TabIndex = 2;
            this.lblBrushColor.Text = "màu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Pen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.Pen.ResumeLayout(false);
            this.Pen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.GroupBox Pen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPatternFill;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.RadioButton rbNoFill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label lblBrushColor;
        private System.Windows.Forms.ColorDialog cdBrushColor;
    }
}