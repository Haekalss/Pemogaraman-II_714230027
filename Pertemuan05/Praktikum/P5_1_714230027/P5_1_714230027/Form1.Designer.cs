namespace P5_1_714230027
{
    partial class Form1
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
            this.Outputlabel = new System.Windows.Forms.Label();
            this.el1_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Outputlabel
            // 
            this.Outputlabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Outputlabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputlabel.Location = new System.Drawing.Point(5, 20);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(264, 23);
            this.Outputlabel.TabIndex = 0;
            this.Outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Outputlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // el1_Click
            // 
            this.el1_Click.Location = new System.Drawing.Point(57, 87);
            this.el1_Click.Name = "el1_Click";
            this.el1_Click.Size = new System.Drawing.Size(75, 25);
            this.el1_Click.TabIndex = 1;
            this.el1_Click.Text = "Say Hello";
            this.el1_Click.UseVisualStyleBackColor = true;
            this.el1_Click.Click += new System.EventHandler(this.el1_Click_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.el1_Click);
            this.Controls.Add(this.Outputlabel);
            this.Name = "Form1";
            this.Text = "Form Hello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.Button el1_Click;
        private System.Windows.Forms.Button button2;
    }
}

