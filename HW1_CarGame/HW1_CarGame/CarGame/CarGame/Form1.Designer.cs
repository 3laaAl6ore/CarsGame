
namespace CarGame
{
    partial class TheRace
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.GameEnd = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.PictureBox();
            this.L5 = new System.Windows.Forms.PictureBox();
            this.L4 = new System.Windows.Forms.PictureBox();
            this.L3 = new System.Windows.Forms.PictureBox();
            this.L2 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGame.Controls.Add(this.GameEnd);
            this.panelGame.Controls.Add(this.player);
            this.panelGame.Controls.Add(this.Car2);
            this.panelGame.Controls.Add(this.Car1);
            this.panelGame.Controls.Add(this.L6);
            this.panelGame.Controls.Add(this.L5);
            this.panelGame.Controls.Add(this.L4);
            this.panelGame.Controls.Add(this.L3);
            this.panelGame.Controls.Add(this.L2);
            this.panelGame.Controls.Add(this.L1);
            this.panelGame.Location = new System.Drawing.Point(14, 58);
            this.panelGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(648, 702);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // GameEnd
            // 
            this.GameEnd.BackColor = System.Drawing.Color.FloralWhite;
            this.GameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameEnd.ForeColor = System.Drawing.Color.Black;
            this.GameEnd.Location = new System.Drawing.Point(224, 201);
            this.GameEnd.Name = "GameEnd";
            this.GameEnd.Size = new System.Drawing.Size(198, 85);
            this.GameEnd.TabIndex = 9;
            this.GameEnd.Text = "Game Over ):";
            this.GameEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameEnd.Visible = false;
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::CarGame.Properties.Resources.car0;
            this.player.Location = new System.Drawing.Point(322, 385);
            this.player.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(57, 123);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.BackColor = System.Drawing.Color.Transparent;
            this.Car2.Image = global::CarGame.Properties.Resources.car1;
            this.Car2.Location = new System.Drawing.Point(459, 423);
            this.Car2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(57, 129);
            this.Car2.TabIndex = 8;
            this.Car2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.BackColor = System.Drawing.Color.Transparent;
            this.Car1.Image = global::CarGame.Properties.Resources.car2;
            this.Car1.Location = new System.Drawing.Point(114, 330);
            this.Car1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(57, 124);
            this.Car1.TabIndex = 7;
            this.Car1.TabStop = false;
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L6.Location = new System.Drawing.Point(63, 363);
            this.L6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(19, 270);
            this.L6.TabIndex = 5;
            this.L6.TabStop = false;
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L5.Location = new System.Drawing.Point(541, 16);
            this.L5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(19, 270);
            this.L5.TabIndex = 4;
            this.L5.TabStop = false;
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L4.Location = new System.Drawing.Point(322, 363);
            this.L4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(19, 270);
            this.L4.TabIndex = 3;
            this.L4.TabStop = false;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L3.Location = new System.Drawing.Point(541, 363);
            this.L3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(19, 270);
            this.L3.TabIndex = 2;
            this.L3.TabStop = false;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L2.Location = new System.Drawing.Point(322, 16);
            this.L2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(19, 270);
            this.L2.TabIndex = 1;
            this.L2.TabStop = false;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L1.Location = new System.Drawing.Point(63, 16);
            this.L1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(19, 277);
            this.L1.TabIndex = 0;
            this.L1.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(285, 11);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(153, 43);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score:0";
            // 
            // timerAction
            // 
            this.timerAction.Enabled = true;
            this.timerAction.Interval = 1;
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(12, 11);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(267, 43);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player :";
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // TheRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 775);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panelGame);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TheRace";
            this.Text = "Car Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox L6;
        private System.Windows.Forms.PictureBox L5;
        private System.Windows.Forms.PictureBox L4;
        private System.Windows.Forms.PictureBox L3;
        private System.Windows.Forms.PictureBox L2;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Label GameEnd;
        private System.Windows.Forms.Label lblPlayer;
    }
}

