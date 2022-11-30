namespace TheInterface._30._11._22
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Kinly = new System.Windows.Forms.Button();
            this.Cola = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iitem item = new Cola();";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kinly
            // 
            this.Kinly.Location = new System.Drawing.Point(93, 452);
            this.Kinly.Name = "Kinly";
            this.Kinly.Size = new System.Drawing.Size(75, 23);
            this.Kinly.TabIndex = 1;
            this.Kinly.Text = "Kinly";
            this.Kinly.UseVisualStyleBackColor = true;
            this.Kinly.Click += new System.EventHandler(this.Kinly_Click);
            // 
            // Cola
            // 
            this.Cola.Location = new System.Drawing.Point(12, 452);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(75, 23);
            this.Cola.TabIndex = 2;
            this.Cola.Text = "Cola";
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.Click += new System.EventHandler(this.Cola_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.Kinly);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button Kinly;
        private Button Cola;

        

        private Button button2;
        private BindingSource bindingSource1;
    }


}