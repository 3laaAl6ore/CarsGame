
namespace CarGame
{
    partial class PlayerWindow
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtStatics = new System.Windows.Forms.TextBox();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lstStatistics = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(167, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome back ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatics
            // 
            this.txtStatics.Location = new System.Drawing.Point(384, 160);
            this.txtStatics.Name = "txtStatics";
            this.txtStatics.Size = new System.Drawing.Size(160, 24);
            this.txtStatics.TabIndex = 6;
            this.txtStatics.TextChanged += new System.EventHandler(this.txtStatics_TextChanged);
            // 
            // lblStatistics
            // 
            this.lblStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatistics.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(384, 124);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(160, 33);
            this.lblStatistics.TabIndex = 4;
            this.lblStatistics.Text = "Players Statistics";
            this.lblStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(197, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(356, 31);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Your Total Score is :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(232, 73);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(91, 34);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lstStatistics
            // 
            this.lstStatistics.FormattingEnabled = true;
            this.lstStatistics.ItemHeight = 16;
            this.lstStatistics.Location = new System.Drawing.Point(348, 190);
            this.lstStatistics.Name = "lstStatistics";
            this.lstStatistics.Size = new System.Drawing.Size(223, 260);
            this.lstStatistics.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.n3);
            this.panel1.Controls.Add(this.n2);
            this.panel1.Controls.Add(this.n1);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 107);
            this.panel1.TabIndex = 10;
            // 
            // n3
            // 
            this.n3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(0, 74);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(327, 33);
            this.n3.TabIndex = 11;
            this.n3.Text = "3rd";
            this.n3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // n2
            // 
            this.n2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(0, 33);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(327, 33);
            this.n2.TabIndex = 12;
            this.n2.Text = "2nd";
            this.n2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // n1
            // 
            this.n1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(0, 0);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(327, 33);
            this.n1.TabIndex = 13;
            this.n1.Text = "1st";
            this.n1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstStatistics);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtStatics);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lblTitle);
            this.Name = "PlayerWindow";
            this.Text = "PlayerWindow";
            this.Load += new System.EventHandler(this.PlayerWindow_Load);
            this.MouseHover += new System.EventHandler(this.PlayerWindow_MouseHover);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStatics;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ListBox lstStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n1;
    }
}