namespace Client
{
    partial class SnakeWindowsFormClient
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.lblStatue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(173, 31);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(166, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 68);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(601, 420);
            this.panel.TabIndex = 2;
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(64, 5);
            this.nudInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(75, 20);
            this.nudInterval.TabIndex = 3;
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.ValueChanged += new System.EventHandler(this.nudInterval_ValueChanged);
            // 
            // lblStatue
            // 
            this.lblStatue.AutoSize = true;
            this.lblStatue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatue.ForeColor = System.Drawing.Color.Red;
            this.lblStatue.Location = new System.Drawing.Point(382, 7);
            this.lblStatue.Name = "lblStatue";
            this.lblStatue.Size = new System.Drawing.Size(29, 15);
            this.lblStatue.TabIndex = 0;
            this.lblStatue.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interval";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(211, 5);
            this.nudWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(39, 20);
            this.nudWidth.TabIndex = 5;
            this.nudWidth.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(300, 5);
            this.nudHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(39, 20);
            this.nudHeight.TabIndex = 6;
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // SnakeWindowsFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatue);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "SnakeWindowsFormClient";
            this.Text = "2D Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lblStatue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

