namespace VentaDeTerrenos.BackEnd
{
    partial class Loading
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.circularLoading = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // circularLoading
            // 
            this.circularLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularLoading.AnimationSpeed = 1;
            this.circularLoading.BackColor = System.Drawing.Color.Transparent;
            this.circularLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.circularLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularLoading.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularLoading.InnerMargin = 0;
            this.circularLoading.InnerWidth = 0;
            this.circularLoading.Location = new System.Drawing.Point(200, 100);
            this.circularLoading.Margin = new System.Windows.Forms.Padding(0);
            this.circularLoading.MarqueeAnimationSpeed = 2000;
            this.circularLoading.Name = "circularLoading";
            this.circularLoading.OuterColor = System.Drawing.Color.Gray;
            this.circularLoading.OuterMargin = -120;
            this.circularLoading.OuterWidth = 120;
            this.circularLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularLoading.ProgressWidth = 80;
            this.circularLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.circularLoading.Size = new System.Drawing.Size(400, 400);
            this.circularLoading.StartAngle = 270;
            this.circularLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularLoading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularLoading.SubscriptText = "";
            this.circularLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 90, 0, 0);
            this.circularLoading.SuperscriptText = "%";
            this.circularLoading.TabIndex = 0;
            this.circularLoading.Text = "0";
            this.circularLoading.TextMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.circularLoading.UseWaitCursor = true;
            this.circularLoading.Value = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargando";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularLoading;
        private System.Windows.Forms.Label label1;
    }
}