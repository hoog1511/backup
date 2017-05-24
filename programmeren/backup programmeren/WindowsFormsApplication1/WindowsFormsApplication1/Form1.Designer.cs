namespace WindowsFormsApplication1
{
    partial class pizzaracer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaracer));
            this.life = new System.Windows.Forms.ProgressBar();
            this.player_1 = new System.Windows.Forms.PictureBox();
            this.player_2 = new System.Windows.Forms.PictureBox();
            this.map1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).BeginInit();
            this.SuspendLayout();
            // 
            // life
            // 
            this.life.Location = new System.Drawing.Point(12, 12);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(100, 23);
            this.life.TabIndex = 0;
            this.life.Value = 100;
            // 
            // player_1
            // 
            this.player_1.Image = ((System.Drawing.Image)(resources.GetObject("player_1.Image")));
            this.player_1.Location = new System.Drawing.Point(282, 290);
            this.player_1.Name = "player_1";
            this.player_1.Size = new System.Drawing.Size(43, 98);
            this.player_1.TabIndex = 1;
            this.player_1.TabStop = false;
            this.player_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player_2
            // 
            this.player_2.Image = ((System.Drawing.Image)(resources.GetObject("player_2.Image")));
            this.player_2.Location = new System.Drawing.Point(371, 290);
            this.player_2.Name = "player_2";
            this.player_2.Size = new System.Drawing.Size(43, 98);
            this.player_2.TabIndex = 2;
            this.player_2.TabStop = false;
            this.player_2.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // map1
            // 
            this.map1.Image = ((System.Drawing.Image)(resources.GetObject("map1.Image")));
            this.map1.Location = new System.Drawing.Point(-3, -8);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(2151, 1311);
            this.map1.TabIndex = 3;
            this.map1.TabStop = false;
            this.map1.Click += new System.EventHandler(this.map1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(132, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // pizzaracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.player_2);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.life);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.map1);
            this.Name = "pizzaracer";
            this.Text = "pizzracer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar life;
        private System.Windows.Forms.PictureBox player_1;
        private System.Windows.Forms.PictureBox player_2;
        private System.Windows.Forms.PictureBox map1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

