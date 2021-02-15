namespace CareMaze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.reload_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // reload_btn
            // 
            this.reload_btn.AccessibleDescription = "";
            this.reload_btn.AccessibleName = "";
            this.reload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload_btn.Location = new System.Drawing.Point(625, 694);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(100, 63);
            this.reload_btn.TabIndex = 4;
            this.reload_btn.Text = "Reload";
            this.reload_btn.UseVisualStyleBackColor = false;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 18;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(166, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Setting";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.AccessibleName = "";
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(12, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Help and About";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.Image = global::CareMaze.Properties.Resources.Exit;
            this.Exit_btn.InitialImage = null;
            this.Exit_btn.Location = new System.Drawing.Point(707, -2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(29, 29);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.WaitOnLoad = true;
            this.Exit_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(737, 759);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reload_btn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareMaze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reload_btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Exit_btn;
    }
}

