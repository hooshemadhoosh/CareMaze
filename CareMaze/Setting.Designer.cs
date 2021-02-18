
namespace CareMaze
{
    partial class Setting
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
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_G = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.rab_hard = new System.Windows.Forms.RadioButton();
            this.rab_medium = new System.Windows.Forms.RadioButton();
            this.rab_easy = new System.Windows.Forms.RadioButton();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.trb_B = new System.Windows.Forms.TrackBar();
            this.trb_G = new System.Windows.Forms.TrackBar();
            this.trb_R = new System.Windows.Forms.TrackBar();
            this.lbl_change_color = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_R)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.BackColor = System.Drawing.Color.Transparent;
            this.lbl_B.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.Location = new System.Drawing.Point(100, 348);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(20, 21);
            this.lbl_B.TabIndex = 30;
            this.lbl_B.Text = "B";
            // 
            // lbl_G
            // 
            this.lbl_G.AutoSize = true;
            this.lbl_G.BackColor = System.Drawing.Color.Transparent;
            this.lbl_G.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_G.Location = new System.Drawing.Point(99, 297);
            this.lbl_G.Name = "lbl_G";
            this.lbl_G.Size = new System.Drawing.Size(21, 21);
            this.lbl_G.TabIndex = 29;
            this.lbl_G.Text = "G";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.BackColor = System.Drawing.Color.Transparent;
            this.lbl_R.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_R.Location = new System.Drawing.Point(100, 246);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(20, 21);
            this.lbl_R.TabIndex = 28;
            this.lbl_R.Text = "R";
            // 
            // rab_hard
            // 
            this.rab_hard.AutoSize = true;
            this.rab_hard.BackColor = System.Drawing.Color.Transparent;
            this.rab_hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rab_hard.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rab_hard.Location = new System.Drawing.Point(373, 444);
            this.rab_hard.Name = "rab_hard";
            this.rab_hard.Size = new System.Drawing.Size(56, 21);
            this.rab_hard.TabIndex = 27;
            this.rab_hard.Text = "Hard";
            this.rab_hard.UseVisualStyleBackColor = false;
            // 
            // rab_medium
            // 
            this.rab_medium.AutoSize = true;
            this.rab_medium.BackColor = System.Drawing.Color.Transparent;
            this.rab_medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rab_medium.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rab_medium.Location = new System.Drawing.Point(241, 444);
            this.rab_medium.Name = "rab_medium";
            this.rab_medium.Size = new System.Drawing.Size(76, 21);
            this.rab_medium.TabIndex = 26;
            this.rab_medium.Text = "Medium";
            this.rab_medium.UseVisualStyleBackColor = false;
            // 
            // rab_easy
            // 
            this.rab_easy.AutoSize = true;
            this.rab_easy.BackColor = System.Drawing.Color.Transparent;
            this.rab_easy.Checked = true;
            this.rab_easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rab_easy.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rab_easy.Location = new System.Drawing.Point(125, 444);
            this.rab_easy.Name = "rab_easy";
            this.rab_easy.Size = new System.Drawing.Size(53, 21);
            this.rab_easy.TabIndex = 25;
            this.rab_easy.TabStop = true;
            this.rab_easy.Text = "Easy";
            this.rab_easy.UseVisualStyleBackColor = false;
            // 
            // cmb_color
            // 
            this.cmb_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Items.AddRange(new object[] {
            "BackGround of mainpage",
            "BackGround of settingpage",
            "Pixels",
            "Direction Pixels",
            "Help Button",
            "Setting Button",
            "Relod Buttton",
            "Text of Help Button",
            "Text of Setting Button",
            "Text of Relod Buttton",
            "Text of Win",
            "Text of lose",
            "ComboBox",
            "Text of  easy level",
            "Text of  medium level",
            "Text of hard level",
            "Text of TrackBar R",
            "Text of TrackBar G",
            "Text of TrackBar B",
            "Text of RadioButton easy",
            "Text of RadioButton medium",
            "Text of RadioButton hard"});
            this.cmb_color.Location = new System.Drawing.Point(150, 156);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(265, 21);
            this.cmb_color.TabIndex = 24;
            this.cmb_color.SelectedIndexChanged += new System.EventHandler(this.cmb_color_SelectedIndexChanged);
            // 
            // trb_B
            // 
            this.trb_B.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trb_B.Location = new System.Drawing.Point(116, 348);
            this.trb_B.Maximum = 255;
            this.trb_B.Name = "trb_B";
            this.trb_B.Size = new System.Drawing.Size(337, 45);
            this.trb_B.TabIndex = 23;
            this.trb_B.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trb_B.Scroll += new System.EventHandler(this.trb_B_Scroll);
            // 
            // trb_G
            // 
            this.trb_G.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trb_G.Location = new System.Drawing.Point(116, 297);
            this.trb_G.Maximum = 255;
            this.trb_G.Name = "trb_G";
            this.trb_G.Size = new System.Drawing.Size(337, 45);
            this.trb_G.TabIndex = 22;
            this.trb_G.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trb_G.Scroll += new System.EventHandler(this.trb_G_Scroll);
            // 
            // trb_R
            // 
            this.trb_R.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trb_R.Location = new System.Drawing.Point(116, 246);
            this.trb_R.Maximum = 255;
            this.trb_R.Name = "trb_R";
            this.trb_R.Size = new System.Drawing.Size(337, 45);
            this.trb_R.TabIndex = 31;
            this.trb_R.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trb_R.Scroll += new System.EventHandler(this.trb_R_Scroll);
            // 
            // lbl_change_color
            // 
            this.lbl_change_color.AutoSize = true;
            this.lbl_change_color.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change_color.Location = new System.Drawing.Point(147, 129);
            this.lbl_change_color.Name = "lbl_change_color";
            this.lbl_change_color.Size = new System.Drawing.Size(188, 15);
            this.lbl_change_color.TabIndex = 32;
            this.lbl_change_color.Text = "Change the color of the elements :";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(553, 617);
            this.Controls.Add(this.lbl_change_color);
            this.Controls.Add(this.trb_R);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_G);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.rab_hard);
            this.Controls.Add(this.rab_medium);
            this.Controls.Add(this.rab_easy);
            this.Controls.Add(this.cmb_color);
            this.Controls.Add(this.trb_B);
            this.Controls.Add(this.trb_G);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_G;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.RadioButton rab_hard;
        private System.Windows.Forms.RadioButton rab_medium;
        private System.Windows.Forms.RadioButton rab_easy;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.TrackBar trb_B;
        private System.Windows.Forms.TrackBar trb_G;
        private System.Windows.Forms.TrackBar trb_R;
        private System.Windows.Forms.Label lbl_change_color;
    }
}