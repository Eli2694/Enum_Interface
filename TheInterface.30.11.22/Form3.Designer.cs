namespace TheInterface._30._11._22
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowResults = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Moon = new System.Windows.Forms.CheckBox();
            this.Triangle = new System.Windows.Forms.CheckBox();
            this.Ellipse = new System.Windows.Forms.CheckBox();
            this.Circle = new System.Windows.Forms.CheckBox();
            this.Rectangle = new System.Windows.Forms.CheckBox();
            this.KodkosSum = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.KodkosSum);
            this.groupBox1.Controls.Add(this.ShowResults);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Moon);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.Ellipse);
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Controls.Add(this.Rectangle);
            this.groupBox1.Location = new System.Drawing.Point(96, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ShowResults
            // 
            this.ShowResults.Location = new System.Drawing.Point(109, 62);
            this.ShowResults.Name = "ShowResults";
            this.ShowResults.Size = new System.Drawing.Size(121, 36);
            this.ShowResults.TabIndex = 5;
            this.ShowResults.Text = "ShowResults";
            this.ShowResults.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(134, 16);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 40);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Moon
            // 
            this.Moon.AutoSize = true;
            this.Moon.Location = new System.Drawing.Point(6, 122);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(58, 19);
            this.Moon.TabIndex = 4;
            this.Moon.Text = "Moon";
            this.Moon.UseVisualStyleBackColor = true;
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(6, 97);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(67, 19);
            this.Triangle.TabIndex = 3;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(6, 72);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(59, 19);
            this.Ellipse.TabIndex = 2;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(6, 47);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(56, 19);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(6, 22);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(78, 19);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // KodkosSum
            // 
            this.KodkosSum.AutoSize = true;
            this.KodkosSum.Location = new System.Drawing.Point(6, 174);
            this.KodkosSum.Name = "KodkosSum";
            this.KodkosSum.Size = new System.Drawing.Size(95, 15);
            this.KodkosSum.TabIndex = 1;
            this.KodkosSum.Text = "Sum Of Kodkos: ";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(134, 104);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 37);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 412);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Rectangle;
        private CheckBox Moon;
        private CheckBox Triangle;
        private CheckBox Ellipse;
        private CheckBox Circle;
        private Button Add;
        private Button ShowResults;
        private Button Reset;
        private Label KodkosSum;
    }
}