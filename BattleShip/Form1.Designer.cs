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
            this.SuspendLayout();
            // 
            // gameBoardTable
            // 
            this.gameBoardTable.AutoScroll = true;
            this.gameBoardTable.BackColor = System.Drawing.Color.GhostWhite;
            this.gameBoardTable.ColumnCount = 1;
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameBoardTable.Location = new System.Drawing.Point(212, 12);
            this.gameBoardTable.Name = "gameBoardTable";
            this.gameBoardTable.Padding = new System.Windows.Forms.Padding(5);
            this.gameBoardTable.RowCount = 1;
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameBoardTable.Size = new System.Drawing.Size(612, 567);
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
            this.btnCalculateHitPercent.Location = new System.Drawing.Point(12, 169);
            this.btnCalculateHitPercent.Name = "btnCalculateHitPercent";
            this.btnCalculateHitPercent.Size = new System.Drawing.Size(194, 23);
            this.btnCalculateHitPercent.TabIndex = 2;
            this.btnCalculateHitPercent.Text = "Calculate Hit Percent";
            this.btnCalculateHitPercent.UseVisualStyleBackColor = true;
            this.btnCalculateHitPercent.Click += new System.EventHandler(this.btnCalculateHitPercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.btnCalculateHitPercent);
            this.Controls.Add(this.btnSetupGame);
            this.Controls.Add(this.gameBoardTable);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gameBoardTable;
        private System.Windows.Forms.Button btnSetupGame;
        private System.Windows.Forms.Button btnCalculateHitPercent;
    }
}

