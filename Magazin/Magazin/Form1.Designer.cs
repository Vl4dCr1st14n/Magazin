namespace Magazin
{
    partial class magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magazin));
            this.picBx = new System.Windows.Forms.PictureBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.pcBox1 = new System.Windows.Forms.PictureBox();
            this.grBoxG = new System.Windows.Forms.GroupBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblHorror = new System.Windows.Forms.Label();
            this.lblAdv = new System.Windows.Forms.Label();
            this.pcBox2 = new System.Windows.Forms.PictureBox();
            this.pcBox4 = new System.Windows.Forms.PictureBox();
            this.pcBox3 = new System.Windows.Forms.PictureBox();
            this.pcBox5 = new System.Windows.Forms.PictureBox();
            this.pcBox6 = new System.Windows.Forms.PictureBox();
            this.lblPret1 = new System.Windows.Forms.Label();
            this.lblPret2 = new System.Windows.Forms.Label();
            this.lblPret3 = new System.Windows.Forms.Label();
            this.lblPret4 = new System.Windows.Forms.Label();
            this.lblPret5 = new System.Windows.Forms.Label();
            this.lblPret6 = new System.Windows.Forms.Label();
            this.lblShooter = new System.Windows.Forms.Label();
            this.lblAutoChess = new System.Windows.Forms.Label();
            this.lblTBS = new System.Windows.Forms.Label();
            this.lblTBT = new System.Windows.Forms.Label();
            this.lblRacing = new System.Windows.Forms.Label();
            this.lblTrivia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox1)).BeginInit();
            this.grBoxG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picBx
            // 
            this.picBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBx.Image = ((System.Drawing.Image)(resources.GetObject("picBx.Image")));
            this.picBx.Location = new System.Drawing.Point(652, 1);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(58, 54);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx.TabIndex = 0;
            this.picBx.TabStop = false;
            this.picBx.Click += new System.EventHandler(this.picBx_Click);
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblGenres.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.White;
            this.lblGenres.Location = new System.Drawing.Point(30, 23);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(162, 20);
            this.lblGenres.TabIndex = 1;
            this.lblGenres.Text = "Alege o categorie";
            this.lblGenres.Click += new System.EventHandler(this.lblGenres_Click);
            // 
            // pcBox1
            // 
            this.pcBox1.Location = new System.Drawing.Point(222, 33);
            this.pcBox1.Name = "pcBox1";
            this.pcBox1.Size = new System.Drawing.Size(176, 121);
            this.pcBox1.TabIndex = 2;
            this.pcBox1.TabStop = false;
            this.pcBox1.Tag = "invisibleObj";
            this.pcBox1.Visible = false;
            // 
            // grBoxG
            // 
            this.grBoxG.BackColor = System.Drawing.Color.Transparent;
            this.grBoxG.Controls.Add(this.lblTrivia);
            this.grBoxG.Controls.Add(this.lblRacing);
            this.grBoxG.Controls.Add(this.lblTBT);
            this.grBoxG.Controls.Add(this.lblTBS);
            this.grBoxG.Controls.Add(this.lblAutoChess);
            this.grBoxG.Controls.Add(this.lblShooter);
            this.grBoxG.Controls.Add(this.lblSport);
            this.grBoxG.Controls.Add(this.lblHorror);
            this.grBoxG.Controls.Add(this.lblAdv);
            this.grBoxG.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxG.ForeColor = System.Drawing.Color.White;
            this.grBoxG.Location = new System.Drawing.Point(1, 61);
            this.grBoxG.Name = "grBoxG";
            this.grBoxG.Size = new System.Drawing.Size(120, 399);
            this.grBoxG.TabIndex = 3;
            this.grBoxG.TabStop = false;
            this.grBoxG.Text = "Categorii";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.Location = new System.Drawing.Point(11, 116);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(62, 20);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport";
            this.lblSport.Click += new System.EventHandler(this.lblSport_Click);
            // 
            // lblHorror
            // 
            this.lblHorror.AutoSize = true;
            this.lblHorror.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorror.Location = new System.Drawing.Point(11, 75);
            this.lblHorror.Name = "lblHorror";
            this.lblHorror.Size = new System.Drawing.Size(78, 20);
            this.lblHorror.TabIndex = 1;
            this.lblHorror.Text = "Horror";
            this.lblHorror.Click += new System.EventHandler(this.lblHorror_Click);
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdv.Location = new System.Drawing.Point(11, 34);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(103, 20);
            this.lblAdv.TabIndex = 0;
            this.lblAdv.Text = "Adventure";
            this.lblAdv.Click += new System.EventHandler(this.lblAdv_Click);
            // 
            // pcBox2
            // 
            this.pcBox2.Location = new System.Drawing.Point(441, 33);
            this.pcBox2.Name = "pcBox2";
            this.pcBox2.Size = new System.Drawing.Size(176, 121);
            this.pcBox2.TabIndex = 4;
            this.pcBox2.TabStop = false;
            this.pcBox2.Tag = "invisibleObj";
            this.pcBox2.Visible = false;
            // 
            // pcBox4
            // 
            this.pcBox4.Location = new System.Drawing.Point(441, 179);
            this.pcBox4.Name = "pcBox4";
            this.pcBox4.Size = new System.Drawing.Size(176, 121);
            this.pcBox4.TabIndex = 5;
            this.pcBox4.TabStop = false;
            this.pcBox4.Tag = "invisibleObj";
            this.pcBox4.Visible = false;
            // 
            // pcBox3
            // 
            this.pcBox3.Location = new System.Drawing.Point(222, 179);
            this.pcBox3.Name = "pcBox3";
            this.pcBox3.Size = new System.Drawing.Size(176, 121);
            this.pcBox3.TabIndex = 6;
            this.pcBox3.TabStop = false;
            this.pcBox3.Tag = "invisibleObj";
            this.pcBox3.Visible = false;
            // 
            // pcBox5
            // 
            this.pcBox5.Location = new System.Drawing.Point(222, 326);
            this.pcBox5.Name = "pcBox5";
            this.pcBox5.Size = new System.Drawing.Size(176, 121);
            this.pcBox5.TabIndex = 7;
            this.pcBox5.TabStop = false;
            this.pcBox5.Tag = "invisibleObj";
            this.pcBox5.Visible = false;
            // 
            // pcBox6
            // 
            this.pcBox6.Location = new System.Drawing.Point(441, 326);
            this.pcBox6.Name = "pcBox6";
            this.pcBox6.Size = new System.Drawing.Size(176, 121);
            this.pcBox6.TabIndex = 8;
            this.pcBox6.TabStop = false;
            this.pcBox6.Tag = "invisibleObj";
            this.pcBox6.Visible = false;
            // 
            // lblPret1
            // 
            this.lblPret1.AutoSize = true;
            this.lblPret1.Location = new System.Drawing.Point(181, 91);
            this.lblPret1.Name = "lblPret1";
            this.lblPret1.Size = new System.Drawing.Size(35, 13);
            this.lblPret1.TabIndex = 9;
            this.lblPret1.Tag = "invisibleObj";
            this.lblPret1.Text = "label1";
            this.lblPret1.Visible = false;
            // 
            // lblPret2
            // 
            this.lblPret2.AutoSize = true;
            this.lblPret2.Location = new System.Drawing.Point(623, 91);
            this.lblPret2.Name = "lblPret2";
            this.lblPret2.Size = new System.Drawing.Size(35, 13);
            this.lblPret2.TabIndex = 10;
            this.lblPret2.Tag = "invisibleObj";
            this.lblPret2.Text = "label2";
            this.lblPret2.Visible = false;
            // 
            // lblPret3
            // 
            this.lblPret3.AutoSize = true;
            this.lblPret3.Location = new System.Drawing.Point(181, 232);
            this.lblPret3.Name = "lblPret3";
            this.lblPret3.Size = new System.Drawing.Size(35, 13);
            this.lblPret3.TabIndex = 11;
            this.lblPret3.Tag = "invisibleObj";
            this.lblPret3.Text = "label3";
            this.lblPret3.Visible = false;
            // 
            // lblPret4
            // 
            this.lblPret4.AutoSize = true;
            this.lblPret4.Location = new System.Drawing.Point(623, 232);
            this.lblPret4.Name = "lblPret4";
            this.lblPret4.Size = new System.Drawing.Size(35, 13);
            this.lblPret4.TabIndex = 12;
            this.lblPret4.Tag = "invisibleObj";
            this.lblPret4.Text = "label4";
            this.lblPret4.Visible = false;
            // 
            // lblPret5
            // 
            this.lblPret5.AutoSize = true;
            this.lblPret5.Location = new System.Drawing.Point(181, 377);
            this.lblPret5.Name = "lblPret5";
            this.lblPret5.Size = new System.Drawing.Size(35, 13);
            this.lblPret5.TabIndex = 13;
            this.lblPret5.Tag = "invisibleObj";
            this.lblPret5.Text = "label5";
            this.lblPret5.Visible = false;
            // 
            // lblPret6
            // 
            this.lblPret6.AutoSize = true;
            this.lblPret6.Location = new System.Drawing.Point(623, 377);
            this.lblPret6.Name = "lblPret6";
            this.lblPret6.Size = new System.Drawing.Size(35, 13);
            this.lblPret6.TabIndex = 14;
            this.lblPret6.Tag = "invisibleObj";
            this.lblPret6.Text = "label6";
            this.lblPret6.Visible = false;
            // 
            // lblShooter
            // 
            this.lblShooter.AutoSize = true;
            this.lblShooter.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShooter.Location = new System.Drawing.Point(11, 157);
            this.lblShooter.Name = "lblShooter";
            this.lblShooter.Size = new System.Drawing.Size(84, 20);
            this.lblShooter.TabIndex = 3;
            this.lblShooter.Text = "Shooter";
            this.lblShooter.Click += new System.EventHandler(this.lblShooter_Click);
            // 
            // lblAutoChess
            // 
            this.lblAutoChess.AutoSize = true;
            this.lblAutoChess.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoChess.Location = new System.Drawing.Point(11, 198);
            this.lblAutoChess.Name = "lblAutoChess";
            this.lblAutoChess.Size = new System.Drawing.Size(104, 20);
            this.lblAutoChess.TabIndex = 4;
            this.lblAutoChess.Text = "Auto chess";
            this.lblAutoChess.Click += new System.EventHandler(this.lblAutoChess_Click);
            // 
            // lblTBS
            // 
            this.lblTBS.AutoSize = true;
            this.lblTBS.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBS.Location = new System.Drawing.Point(11, 239);
            this.lblTBS.Name = "lblTBS";
            this.lblTBS.Size = new System.Drawing.Size(39, 20);
            this.lblTBS.TabIndex = 5;
            this.lblTBS.Text = "TBS";
            this.lblTBS.Click += new System.EventHandler(this.lblTBS_Click);
            // 
            // lblTBT
            // 
            this.lblTBT.AutoSize = true;
            this.lblTBT.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBT.Location = new System.Drawing.Point(11, 280);
            this.lblTBT.Name = "lblTBT";
            this.lblTBT.Size = new System.Drawing.Size(40, 20);
            this.lblTBT.TabIndex = 6;
            this.lblTBT.Text = "TBT";
            this.lblTBT.Click += new System.EventHandler(this.lblTBT_Click);
            // 
            // lblRacing
            // 
            this.lblRacing.AutoSize = true;
            this.lblRacing.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacing.Location = new System.Drawing.Point(11, 321);
            this.lblRacing.Name = "lblRacing";
            this.lblRacing.Size = new System.Drawing.Size(68, 20);
            this.lblRacing.TabIndex = 7;
            this.lblRacing.Text = "Racing";
            this.lblRacing.Click += new System.EventHandler(this.lblRacing_Click);
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrivia.Location = new System.Drawing.Point(11, 362);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(63, 20);
            this.lblTrivia.TabIndex = 8;
            this.lblTrivia.Text = "Trivia";
            this.lblTrivia.Click += new System.EventHandler(this.lblTrivia_Click);
            // 
            // magazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 472);
            this.Controls.Add(this.lblPret6);
            this.Controls.Add(this.lblPret5);
            this.Controls.Add(this.lblPret4);
            this.Controls.Add(this.lblPret3);
            this.Controls.Add(this.lblPret2);
            this.Controls.Add(this.lblPret1);
            this.Controls.Add(this.pcBox6);
            this.Controls.Add(this.pcBox5);
            this.Controls.Add(this.pcBox3);
            this.Controls.Add(this.pcBox4);
            this.Controls.Add(this.pcBox2);
            this.Controls.Add(this.grBoxG);
            this.Controls.Add(this.pcBox1);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.picBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "magazin";
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox1)).EndInit();
            this.grBoxG.ResumeLayout(false);
            this.grBoxG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.PictureBox pcBox1;
        private System.Windows.Forms.GroupBox grBoxG;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.PictureBox pcBox2;
        private System.Windows.Forms.PictureBox pcBox4;
        private System.Windows.Forms.PictureBox pcBox3;
        private System.Windows.Forms.Label lblHorror;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.PictureBox pcBox5;
        private System.Windows.Forms.PictureBox pcBox6;
        private System.Windows.Forms.Label lblPret1;
        private System.Windows.Forms.Label lblPret2;
        private System.Windows.Forms.Label lblPret3;
        private System.Windows.Forms.Label lblPret4;
        private System.Windows.Forms.Label lblPret5;
        private System.Windows.Forms.Label lblPret6;
        private System.Windows.Forms.Label lblTBS;
        private System.Windows.Forms.Label lblAutoChess;
        private System.Windows.Forms.Label lblShooter;
        private System.Windows.Forms.Label lblTBT;
        private System.Windows.Forms.Label lblRacing;
        private System.Windows.Forms.Label lblTrivia;
    }
}

