namespace SigaoMestre
{
    partial class GameForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picYellow = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // picRed
            // 
            this.picRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picRed.Location = new System.Drawing.Point(32, 30);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(136, 112);
            this.picRed.TabIndex = 0;
            this.picRed.TabStop = false;
            this.picRed.Tag = "R";
            this.picRed.Click += new System.EventHandler(this.Click);
            // 
            // picBlue
            // 
            this.picBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picBlue.Location = new System.Drawing.Point(195, 30);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(136, 112);
            this.picBlue.TabIndex = 1;
            this.picBlue.TabStop = false;
            this.picBlue.Tag = "B";
            this.picBlue.Click += new System.EventHandler(this.Click);
            // 
            // picGreen
            // 
            this.picGreen.BackColor = System.Drawing.Color.Green;
            this.picGreen.Location = new System.Drawing.Point(32, 166);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(136, 112);
            this.picGreen.TabIndex = 2;
            this.picGreen.TabStop = false;
            this.picGreen.Tag = "G";
            this.picGreen.Click += new System.EventHandler(this.Click);
            // 
            // picYellow
            // 
            this.picYellow.BackColor = System.Drawing.Color.Yellow;
            this.picYellow.Location = new System.Drawing.Point(195, 166);
            this.picYellow.Name = "picYellow";
            this.picYellow.Size = new System.Drawing.Size(136, 112);
            this.picYellow.TabIndex = 3;
            this.picYellow.TabStop = false;
            this.picYellow.Tag = "Y";
            this.picYellow.Click += new System.EventHandler(this.Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(32, 342);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 48);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(195, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoints.Location = new System.Drawing.Point(28, 299);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(70, 23);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "PONTOS:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(365, 413);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picYellow);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siga O Mestre!";
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picYellow;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPoints;
    }
}

