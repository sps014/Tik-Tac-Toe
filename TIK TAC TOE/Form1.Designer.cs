namespace TIK_TAC_TOE
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
            this.button1 = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tileSpot2 = new TIK_TAC_TOE.TileSpot();
            this.tileSpot1 = new TIK_TAC_TOE.TileSpot();
            this.blackBoard1 = new TIK_TAC_TOE.BlackBoard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(572, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.turnLabel.Location = new System.Drawing.Point(637, 209);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(119, 25);
            this.turnLabel.TabIndex = 2;
            this.turnLabel.Text = "Player Move";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(637, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "AI Move";
            // 
            // tileSpot2
            // 
            this.tileSpot2.ColorAI = System.Drawing.Color.DeepPink;
            this.tileSpot2.ColorPlayer = System.Drawing.Color.DodgerBlue;
            this.tileSpot2.Enabled = false;
            this.tileSpot2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSpot2.ForeColor = System.Drawing.Color.White;
            this.tileSpot2.Location = new System.Drawing.Point(572, 266);
            this.tileSpot2.Name = "tileSpot2";
            this.tileSpot2.Owner = TIK_TAC_TOE.OwnerType.AI;
            this.tileSpot2.Size = new System.Drawing.Size(58, 51);
            this.tileSpot2.TabIndex = 4;
            this.tileSpot2.Text = "O";
            this.tileSpot2.Uid = 0;
            // 
            // tileSpot1
            // 
            this.tileSpot1.ColorAI = System.Drawing.Color.DeepPink;
            this.tileSpot1.ColorPlayer = System.Drawing.Color.DodgerBlue;
            this.tileSpot1.Enabled = false;
            this.tileSpot1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSpot1.ForeColor = System.Drawing.Color.White;
            this.tileSpot1.Location = new System.Drawing.Point(573, 195);
            this.tileSpot1.Name = "tileSpot1";
            this.tileSpot1.Owner = TIK_TAC_TOE.OwnerType.PLAYER;
            this.tileSpot1.Size = new System.Drawing.Size(58, 51);
            this.tileSpot1.TabIndex = 3;
            this.tileSpot1.Text = "X";
            this.tileSpot1.Uid = 0;
            // 
            // blackBoard1
            // 
            this.blackBoard1.LineWidth = 2;
            this.blackBoard1.Location = new System.Drawing.Point(67, 41);
            this.blackBoard1.Name = "blackBoard1";
            this.blackBoard1.Size = new System.Drawing.Size(429, 376);
            this.blackBoard1.TabIndex = 0;
            this.blackBoard1.Text = "Tic Tac Toe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tileSpot2);
            this.Controls.Add(this.tileSpot1);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blackBoard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlackBoard blackBoard1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label turnLabel;
        private TileSpot tileSpot1;
        private TileSpot tileSpot2;
        public System.Windows.Forms.Label label1;
    }
}

