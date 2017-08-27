namespace BattleShip
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
            this.gameBoardTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetupGame = new System.Windows.Forms.Button();
            this.btnCalculateHitPercent = new System.Windows.Forms.Button();
            this.rdoUnknown = new System.Windows.Forms.RadioButton();
            this.rdoHit = new System.Windows.Forms.RadioButton();
            this.rdoMiss = new System.Windows.Forms.RadioButton();
            this.lblHitPercentage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameBoardTable
            // 
            this.gameBoardTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBoardTable.AutoScroll = true;
            this.gameBoardTable.BackColor = System.Drawing.Color.GhostWhite;
            this.gameBoardTable.ColumnCount = 1;
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameBoardTable.Location = new System.Drawing.Point(212, 12);
            this.gameBoardTable.Name = "gameBoardTable";
            this.gameBoardTable.Padding = new System.Windows.Forms.Padding(5);
            this.gameBoardTable.RowCount = 1;
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameBoardTable.Size = new System.Drawing.Size(776, 607);
            this.gameBoardTable.TabIndex = 0;
            // 
            // btnSetupGame
            // 
            this.btnSetupGame.Location = new System.Drawing.Point(12, 12);
            this.btnSetupGame.Name = "btnSetupGame";
            this.btnSetupGame.Size = new System.Drawing.Size(194, 23);
            this.btnSetupGame.TabIndex = 1;
            this.btnSetupGame.Text = "Setup Game";
            this.btnSetupGame.UseVisualStyleBackColor = true;
            this.btnSetupGame.Click += new System.EventHandler(this.btnSetupGame_Click);
            // 
            // btnCalculateHitPercent
            // 
            this.btnCalculateHitPercent.Location = new System.Drawing.Point(12, 41);
            this.btnCalculateHitPercent.Name = "btnCalculateHitPercent";
            this.btnCalculateHitPercent.Size = new System.Drawing.Size(194, 23);
            this.btnCalculateHitPercent.TabIndex = 2;
            this.btnCalculateHitPercent.Text = "Calculate Hit Percent";
            this.btnCalculateHitPercent.UseVisualStyleBackColor = true;
            this.btnCalculateHitPercent.Click += new System.EventHandler(this.btnCalculateHitPercent_Click);
            // 
            // rdoUnknown
            // 
            this.rdoUnknown.AutoSize = true;
            this.rdoUnknown.Location = new System.Drawing.Point(26, 120);
            this.rdoUnknown.Name = "rdoUnknown";
            this.rdoUnknown.Size = new System.Drawing.Size(71, 17);
            this.rdoUnknown.TabIndex = 3;
            this.rdoUnknown.TabStop = true;
            this.rdoUnknown.Text = "Unknown";
            this.rdoUnknown.UseVisualStyleBackColor = true;
            this.rdoUnknown.CheckedChanged += new System.EventHandler(this.rdoUnknown_CheckedChanged);
            // 
            // rdoHit
            // 
            this.rdoHit.AutoSize = true;
            this.rdoHit.Location = new System.Drawing.Point(26, 143);
            this.rdoHit.Name = "rdoHit";
            this.rdoHit.Size = new System.Drawing.Size(38, 17);
            this.rdoHit.TabIndex = 4;
            this.rdoHit.TabStop = true;
            this.rdoHit.Text = "Hit";
            this.rdoHit.UseVisualStyleBackColor = true;
            this.rdoHit.CheckedChanged += new System.EventHandler(this.rdoHit_CheckedChanged);
            // 
            // rdoMiss
            // 
            this.rdoMiss.AutoSize = true;
            this.rdoMiss.Location = new System.Drawing.Point(26, 166);
            this.rdoMiss.Name = "rdoMiss";
            this.rdoMiss.Size = new System.Drawing.Size(46, 17);
            this.rdoMiss.TabIndex = 5;
            this.rdoMiss.TabStop = true;
            this.rdoMiss.Text = "Miss";
            this.rdoMiss.UseVisualStyleBackColor = true;
            this.rdoMiss.CheckedChanged += new System.EventHandler(this.rdoMiss_CheckedChanged);
            // 
            // lblHitPercentage
            // 
            this.lblHitPercentage.AutoSize = true;
            this.lblHitPercentage.Location = new System.Drawing.Point(23, 104);
            this.lblHitPercentage.Name = "lblHitPercentage";
            this.lblHitPercentage.Size = new System.Drawing.Size(85, 13);
            this.lblHitPercentage.TabIndex = 6;
            this.lblHitPercentage.Text = "lblHitPercentage";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh Board";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 631);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHitPercentage);
            this.Controls.Add(this.rdoMiss);
            this.Controls.Add(this.rdoHit);
            this.Controls.Add(this.rdoUnknown);
            this.Controls.Add(this.btnCalculateHitPercent);
            this.Controls.Add(this.btnSetupGame);
            this.Controls.Add(this.gameBoardTable);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gameBoardTable;
        private System.Windows.Forms.Button btnSetupGame;
        private System.Windows.Forms.Button btnCalculateHitPercent;
        private System.Windows.Forms.RadioButton rdoUnknown;
        private System.Windows.Forms.RadioButton rdoHit;
        private System.Windows.Forms.RadioButton rdoMiss;
        private System.Windows.Forms.Label lblHitPercentage;
        private System.Windows.Forms.Button btnRefresh;
    }
}

