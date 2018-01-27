namespace CookieClicker
{
    partial class CookieForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCookieWorker = new System.Windows.Forms.PictureBox();
            this.PictureBoxCookie = new System.Windows.Forms.PictureBox();
            this.buttonBuyCookieWorker = new System.Windows.Forms.Button();
            this.labelCookieWorker = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCookieWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label 1";
            // 
            // pictureBoxCookieWorker
            // 
            this.pictureBoxCookieWorker.Image = global::CookieClicker.Properties.Resources.CookieWorker;
            this.pictureBoxCookieWorker.Location = new System.Drawing.Point(318, 61);
            this.pictureBoxCookieWorker.Name = "pictureBoxCookieWorker";
            this.pictureBoxCookieWorker.Size = new System.Drawing.Size(110, 102);
            this.pictureBoxCookieWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCookieWorker.TabIndex = 2;
            this.pictureBoxCookieWorker.TabStop = false;
            // 
            // PictureBoxCookie
            // 
            this.PictureBoxCookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxCookie.Image = global::CookieClicker.Properties.Resources.Cookie;
            this.PictureBoxCookie.Location = new System.Drawing.Point(88, 153);
            this.PictureBoxCookie.Name = "PictureBoxCookie";
            this.PictureBoxCookie.Size = new System.Drawing.Size(172, 162);
            this.PictureBoxCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCookie.TabIndex = 0;
            this.PictureBoxCookie.TabStop = false;
            this.PictureBoxCookie.Click += new System.EventHandler(this.PictureBoxCookie_Click);
            // 
            // buttonBuyCookieWorker
            // 
            this.buttonBuyCookieWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyCookieWorker.Location = new System.Drawing.Point(449, 61);
            this.buttonBuyCookieWorker.Name = "buttonBuyCookieWorker";
            this.buttonBuyCookieWorker.Size = new System.Drawing.Size(77, 32);
            this.buttonBuyCookieWorker.TabIndex = 3;
            this.buttonBuyCookieWorker.Text = "Buy 1";
            this.buttonBuyCookieWorker.UseVisualStyleBackColor = true;
            this.buttonBuyCookieWorker.Click += new System.EventHandler(this.buttonBuyCookieWorker_Click);
            // 
            // labelCookieWorker
            // 
            this.labelCookieWorker.AutoSize = true;
            this.labelCookieWorker.Location = new System.Drawing.Point(446, 124);
            this.labelCookieWorker.Name = "labelCookieWorker";
            this.labelCookieWorker.Size = new System.Drawing.Size(95, 13);
            this.labelCookieWorker.TabIndex = 4;
            this.labelCookieWorker.Text = "Cookie Workers: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CookieForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.labelCookieWorker);
            this.Controls.Add(this.buttonBuyCookieWorker);
            this.Controls.Add(this.pictureBoxCookieWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxCookie);
            this.Name = "CookieForm1";
            this.Text = "CookieForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCookieWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCookie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxCookie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCookieWorker;
        private System.Windows.Forms.Button buttonBuyCookieWorker;
        private System.Windows.Forms.Label labelCookieWorker;
        private System.Windows.Forms.Timer timer1;
    }
}

