namespace week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnColor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.btnColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnSelectBall);
            this.mainPanel.Controls.Add(this.btnSelectCar);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(703, 410);
            this.mainPanel.TabIndex = 0;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(349, 27);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(64, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Comint Next";
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(148, 27);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBall.TabIndex = 1;
            this.btnSelectBall.Text = "Ball";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(52, 27);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCar.TabIndex = 0;
            this.btnSelectCar.Text = "Car";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            // 
            // createTimer
            // 
            this.createTimer.Interval = 3000;
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Interval = 10;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(250, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Timer createTimer;
        public System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnColor;
    }
}

