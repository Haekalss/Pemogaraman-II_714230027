namespace P5_3_714230027
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMerkHp = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_iod = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btn_Tampilkan = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk HP";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OS.Location = new System.Drawing.Point(34, 116);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(24, 18);
            this.OS.TabIndex = 1;
            this.OS.Text = "OS";
            this.OS.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki";
            // 
            // textMerkHp
            // 
            this.textMerkHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMerkHp.Location = new System.Drawing.Point(182, 47);
            this.textMerkHp.Name = "textMerkHp";
            this.textMerkHp.Size = new System.Drawing.Size(184, 22);
            this.textMerkHp.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(182, 116);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(61, 17);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_iod
            // 
            this.rb_iod.AutoSize = true;
            this.rb_iod.Location = new System.Drawing.Point(310, 116);
            this.rb_iod.Name = "rb_iod";
            this.rb_iod.Size = new System.Drawing.Size(43, 17);
            this.rb_iod.TabIndex = 5;
            this.rb_iod.TabStop = true;
            this.rb_iod.Text = "IOS";
            this.rb_iod.UseVisualStyleBackColor = true;
            this.rb_iod.CheckedChanged += new System.EventHandler(this.rb_iod_CheckedChanged);
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(182, 174);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(39, 17);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btn_Tampilkan
            // 
            this.btn_Tampilkan.Location = new System.Drawing.Point(104, 238);
            this.btn_Tampilkan.Name = "btn_Tampilkan";
            this.btn_Tampilkan.Size = new System.Drawing.Size(75, 23);
            this.btn_Tampilkan.TabIndex = 7;
            this.btn_Tampilkan.Text = "Tampilkan";
            this.btn_Tampilkan.UseVisualStyleBackColor = true;
            this.btn_Tampilkan.Click += new System.EventHandler(this.btn_Tampilkan_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(238, 238);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 8;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 312);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_Tampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_iod);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.textMerkHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Service HP";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_iod;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.TextBox textMerkHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_Tampilkan;
        private System.Windows.Forms.CheckBox cbYa;
    }
}

