namespace GeodesicCalculator
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.slopeButton = new System.Windows.Forms.Button();
            this.straigthCutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geodesic Calculator";
            // 
            // slopeButton
            // 
            this.slopeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slopeButton.Location = new System.Drawing.Point(48, 163);
            this.slopeButton.Name = "slopeButton";
            this.slopeButton.Size = new System.Drawing.Size(245, 95);
            this.slopeButton.TabIndex = 1;
            this.slopeButton.Text = "Slope between two points with known elevations";
            this.slopeButton.UseVisualStyleBackColor = true;
            this.slopeButton.Click += new System.EventHandler(this.slopeButton_Click_1);
            // 
            // straigthCutButton
            // 
            this.straigthCutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.straigthCutButton.Location = new System.Drawing.Point(439, 163);
            this.straigthCutButton.Name = "straigthCutButton";
            this.straigthCutButton.Size = new System.Drawing.Size(245, 95);
            this.straigthCutButton.TabIndex = 2;
            this.straigthCutButton.Text = "Straigth cut";
            this.straigthCutButton.UseVisualStyleBackColor = true;
            this.straigthCutButton.Click += new System.EventHandler(this.straigthCutButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(675, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.straigthCutButton);
            this.Controls.Add(this.slopeButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Geodesic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button slopeButton;
        private System.Windows.Forms.Button straigthCutButton;
        private System.Windows.Forms.Button button1;
    }
}
