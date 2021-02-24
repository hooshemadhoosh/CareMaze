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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.reload_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.Win_printer = new System.Windows.Forms.Label();
            this.Lose_printer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
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
            this.reload_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.reload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reload_btn.Location = new System.Drawing.Point(559, 696);
            this.reload_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(164, 52);
            this.reload_btn.TabIndex = 4;
            this.reload_btn.Text = "Reload";
            this.reload_btn.UseVisualStyleBackColor = false;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.AccessibleName = "";
            this.setting_btn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setting_btn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_btn.Location = new System.Drawing.Point(185, 696);
            this.setting_btn.Margin = new System.Windows.Forms.Padding(4);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(367, 50);
            this.setting_btn.TabIndex = 7;
            this.setting_btn.Text = "Setting";
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.AccessibleDescription = "";
            this.help_btn.AccessibleName = "";
            this.help_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help_btn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(15, 695);
            this.help_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(164, 52);
            this.help_btn.TabIndex = 8;
            this.help_btn.Text = "Help and About";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // Win_printer
            // 
            this.Win_printer.AutoSize = true;
            this.Win_printer.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win_printer.ForeColor = System.Drawing.Color.LimeGreen;
            this.Win_printer.Location = new System.Drawing.Point(11, 6);
            this.Win_printer.Name = "Win_printer";
            this.Win_printer.Size = new System.Drawing.Size(44, 18);
            this.Win_printer.TabIndex = 9;
            this.Win_printer.Text = "Win:";
            // 
            // Lose_printer
            // 
            this.Lose_printer.AutoSize = true;
            this.Lose_printer.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose_printer.ForeColor = System.Drawing.Color.Red;
            this.Lose_printer.Location = new System.Drawing.Point(129, 8);
            this.Lose_printer.Name = "Lose_printer";
            this.Lose_printer.Size = new System.Drawing.Size(49, 18);
            this.Lose_printer.TabIndex = 10;
            this.Lose_printer.Text = "Lose:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(737, 759);
            this.Controls.Add(this.Lose_printer);
            this.Controls.Add(this.Win_printer);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.reload_btn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareMaze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reload_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label Win_printer;
        private System.Windows.Forms.Label Lose_printer;
    }
}

