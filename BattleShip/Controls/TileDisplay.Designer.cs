namespace BattleShip.Controls
{
    partial class TileDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelCoordinates.Location = new System.Drawing.Point(-2, -2);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(35, 13);
            this.labelCoordinates.TabIndex = 0;
            this.labelCoordinates.Text = "label1";
            this.labelCoordinates.Click += new System.EventHandler(this.labelCoordinates_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblPlayerName.Location = new System.Drawing.Point(-2, 10);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "label1";
            this.lblPlayerName.Click += new System.EventHandler(this.labelCoordinates_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblPercentage.Location = new System.Drawing.Point(-2, 23);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(35, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "label1";
            this.lblPercentage.Click += new System.EventHandler(this.labelCoordinates_Click);
            // 
            // TileDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.labelCoordinates);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TileDisplay";
            this.Size = new System.Drawing.Size(40, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPercentage;
    }
}
