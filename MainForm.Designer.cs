namespace CellGame
{
    partial class MainForm
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
            this.CellsPictureBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StepButton = new System.Windows.Forms.Button();
            this.Turnlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CellsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CellsPictureBox
            // 
            this.CellsPictureBox.BackColor = System.Drawing.Color.Black;
            this.CellsPictureBox.Location = new System.Drawing.Point(9, 10);
            this.CellsPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.CellsPictureBox.Name = "CellsPictureBox";
            this.CellsPictureBox.Size = new System.Drawing.Size(1002, 1002);
            this.CellsPictureBox.TabIndex = 0;
            this.CellsPictureBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.ForeColor = System.Drawing.Color.Green;
            this.StartButton.Location = new System.Drawing.Point(1015, 10);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(76, 36);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StepButton
            // 
            this.StepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StepButton.Enabled = false;
            this.StepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepButton.ForeColor = System.Drawing.Color.Blue;
            this.StepButton.Location = new System.Drawing.Point(1015, 50);
            this.StepButton.Margin = new System.Windows.Forms.Padding(2);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(76, 34);
            this.StepButton.TabIndex = 2;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // Turnlabel
            // 
            this.Turnlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Turnlabel.AutoSize = true;
            this.Turnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Turnlabel.ForeColor = System.Drawing.Color.Blue;
            this.Turnlabel.Location = new System.Drawing.Point(1016, 86);
            this.Turnlabel.Name = "Turnlabel";
            this.Turnlabel.Size = new System.Drawing.Size(24, 26);
            this.Turnlabel.TabIndex = 3;
            this.Turnlabel.Text = "0";
            this.Turnlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 1021);
            this.Controls.Add(this.Turnlabel);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CellsPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Cell Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CellsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CellsPictureBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Label Turnlabel;
    }
}

