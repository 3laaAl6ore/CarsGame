
namespace CarGame
{
    partial class EntryWindow
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
            this.titleStatistics = new System.Windows.Forms.Label();
            this.txtStatics = new System.Windows.Forms.TextBox();
            this.lblAddPlayer = new System.Windows.Forms.Label();
            this.lblPasswordSignUP = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFnameSignUP = new System.Windows.Forms.Label();
            this.txtFnameSignUP = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPasswordSignUP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btbSignUp = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtFnameLogIn = new System.Windows.Forms.TextBox();
            this.lblFnameLognIn = new System.Windows.Forms.Label();
            this.lblPasswordLogIn = new System.Windows.Forms.Label();
            this.txtPasswordLogIn = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstStatistics = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(758, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome... :)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleStatistics
            // 
            this.titleStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleStatistics.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleStatistics.Location = new System.Drawing.Point(51, 89);
            this.titleStatistics.Name = "titleStatistics";
            this.titleStatistics.Size = new System.Drawing.Size(160, 33);
            this.titleStatistics.TabIndex = 1;
            this.titleStatistics.Text = "Players Statistics";
            this.titleStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatics
            // 
            this.txtStatics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatics.Location = new System.Drawing.Point(51, 125);
            this.txtStatics.Name = "txtStatics";
            this.txtStatics.Size = new System.Drawing.Size(160, 24);
            this.txtStatics.TabIndex = 3;
            this.txtStatics.TextChanged += new System.EventHandler(this.txtStatics_TextChanged);
            // 
            // lblAddPlayer
            // 
            this.lblAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddPlayer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPlayer.Location = new System.Drawing.Point(542, 89);
            this.lblAddPlayer.Name = "lblAddPlayer";
            this.lblAddPlayer.Size = new System.Drawing.Size(228, 33);
            this.lblAddPlayer.TabIndex = 4;
            this.lblAddPlayer.Text = "New Player ?";
            this.lblAddPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordSignUP
            // 
            this.lblPasswordSignUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordSignUP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPasswordSignUP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignUP.Location = new System.Drawing.Point(542, 227);
            this.lblPasswordSignUP.Name = "lblPasswordSignUP";
            this.lblPasswordSignUP.Size = new System.Drawing.Size(109, 25);
            this.lblPasswordSignUP.TabIndex = 5;
            this.lblPasswordSignUP.Text = "Password :";
            this.lblPasswordSignUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(542, 196);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(109, 24);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLname
            // 
            this.lblLname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(542, 168);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(109, 22);
            this.lblLname.TabIndex = 7;
            this.lblLname.Text = "Last Name :";
            this.lblLname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFnameSignUP
            // 
            this.lblFnameSignUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFnameSignUP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFnameSignUP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameSignUP.Location = new System.Drawing.Point(542, 136);
            this.lblFnameSignUP.Name = "lblFnameSignUP";
            this.lblFnameSignUP.Size = new System.Drawing.Size(109, 24);
            this.lblFnameSignUP.TabIndex = 8;
            this.lblFnameSignUP.Text = "First Name :";
            this.lblFnameSignUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFnameSignUP
            // 
            this.txtFnameSignUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFnameSignUP.Location = new System.Drawing.Point(657, 136);
            this.txtFnameSignUP.Name = "txtFnameSignUP";
            this.txtFnameSignUP.Size = new System.Drawing.Size(113, 24);
            this.txtFnameSignUP.TabIndex = 25;
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLname.Location = new System.Drawing.Point(657, 166);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(113, 24);
            this.txtLname.TabIndex = 26;
            // 
            // txtPasswordSignUP
            // 
            this.txtPasswordSignUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordSignUP.Location = new System.Drawing.Point(657, 228);
            this.txtPasswordSignUP.Name = "txtPasswordSignUP";
            this.txtPasswordSignUP.PasswordChar = '*';
            this.txtPasswordSignUP.Size = new System.Drawing.Size(113, 24);
            this.txtPasswordSignUP.TabIndex = 27;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.Location = new System.Drawing.Point(657, 196);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(113, 24);
            this.txtCity.TabIndex = 28;
            // 
            // btbSignUp
            // 
            this.btbSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbSignUp.Location = new System.Drawing.Point(542, 259);
            this.btbSignUp.Name = "btbSignUp";
            this.btbSignUp.Size = new System.Drawing.Size(228, 28);
            this.btbSignUp.TabIndex = 29;
            this.btbSignUp.Text = "Sign Up";
            this.btbSignUp.UseVisualStyleBackColor = true;
            this.btbSignUp.Click += new System.EventHandler(this.btbSignUp_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSignUp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(542, 300);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(228, 22);
            this.lblSignUp.TabIndex = 30;
            this.lblSignUp.Text = "Alredy Have Account ?";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFnameLogIn
            // 
            this.txtFnameLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFnameLogIn.Location = new System.Drawing.Point(657, 335);
            this.txtFnameLogIn.Name = "txtFnameLogIn";
            this.txtFnameLogIn.Size = new System.Drawing.Size(113, 24);
            this.txtFnameLogIn.TabIndex = 31;
            // 
            // lblFnameLognIn
            // 
            this.lblFnameLognIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFnameLognIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFnameLognIn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameLognIn.Location = new System.Drawing.Point(542, 334);
            this.lblFnameLognIn.Name = "lblFnameLognIn";
            this.lblFnameLognIn.Size = new System.Drawing.Size(109, 25);
            this.lblFnameLognIn.TabIndex = 32;
            this.lblFnameLognIn.Text = "First Name :";
            this.lblFnameLognIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordLogIn
            // 
            this.lblPasswordLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordLogIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPasswordLogIn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogIn.Location = new System.Drawing.Point(542, 365);
            this.lblPasswordLogIn.Name = "lblPasswordLogIn";
            this.lblPasswordLogIn.Size = new System.Drawing.Size(109, 24);
            this.lblPasswordLogIn.TabIndex = 33;
            this.lblPasswordLogIn.Text = "Password :";
            this.lblPasswordLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswordLogIn
            // 
            this.txtPasswordLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordLogIn.Location = new System.Drawing.Point(657, 365);
            this.txtPasswordLogIn.Name = "txtPasswordLogIn";
            this.txtPasswordLogIn.PasswordChar = '*';
            this.txtPasswordLogIn.Size = new System.Drawing.Size(113, 24);
            this.txtPasswordLogIn.TabIndex = 34;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Location = new System.Drawing.Point(542, 395);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(228, 29);
            this.btnLogIn.TabIndex = 35;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::CarGame.Properties.Resources.car4;
            this.pictureBox4.Location = new System.Drawing.Point(417, 259);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 165);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::CarGame.Properties.Resources.car2;
            this.pictureBox3.Location = new System.Drawing.Point(306, 344);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 160);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::CarGame.Properties.Resources.car1;
            this.pictureBox2.Location = new System.Drawing.Point(306, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 137);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CarGame.Properties.Resources.car0;
            this.pictureBox1.Location = new System.Drawing.Point(440, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 134);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lstStatistics
            // 
            this.lstStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstStatistics.FormattingEnabled = true;
            this.lstStatistics.ItemHeight = 16;
            this.lstStatistics.Location = new System.Drawing.Point(12, 155);
            this.lstStatistics.Name = "lstStatistics";
            this.lstStatistics.Size = new System.Drawing.Size(237, 340);
            this.lstStatistics.TabIndex = 40;
            this.lstStatistics.SelectedIndexChanged += new System.EventHandler(this.lstStatistics_SelectedIndexChanged_1);
            // 
            // EntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(806, 527);
            this.Controls.Add(this.lstStatistics);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPasswordLogIn);
            this.Controls.Add(this.lblPasswordLogIn);
            this.Controls.Add(this.lblFnameLognIn);
            this.Controls.Add(this.txtFnameLogIn);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btbSignUp);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPasswordSignUP);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFnameSignUP);
            this.Controls.Add(this.lblFnameSignUP);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPasswordSignUP);
            this.Controls.Add(this.lblAddPlayer);
            this.Controls.Add(this.txtStatics);
            this.Controls.Add(this.titleStatistics);
            this.Controls.Add(this.lblTitle);
            this.Name = "EntryWindow";
            this.Text = "EntryWindow";
            this.Load += new System.EventHandler(this.EntryWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label titleStatistics;
        private System.Windows.Forms.TextBox txtStatics;
        private System.Windows.Forms.Label lblAddPlayer;
        private System.Windows.Forms.Label lblPasswordSignUP;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFnameSignUP;
        private System.Windows.Forms.TextBox txtFnameSignUP;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPasswordSignUP;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btbSignUp;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TextBox txtFnameLogIn;
        private System.Windows.Forms.Label lblFnameLognIn;
        private System.Windows.Forms.Label lblPasswordLogIn;
        private System.Windows.Forms.TextBox txtPasswordLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox lstStatistics;
    }
}