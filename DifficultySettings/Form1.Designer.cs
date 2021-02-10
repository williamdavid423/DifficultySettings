namespace DifficultySettings
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
            this.heroNameLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.heroNameInput = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heroNameLabel
            // 
            this.heroNameLabel.AutoSize = true;
            this.heroNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroNameLabel.ForeColor = System.Drawing.Color.White;
            this.heroNameLabel.Location = new System.Drawing.Point(22, 41);
            this.heroNameLabel.Name = "heroNameLabel";
            this.heroNameLabel.Size = new System.Drawing.Size(184, 19);
            this.heroNameLabel.TabIndex = 0;
            this.heroNameLabel.Text = "Enter Your Name Hero:";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.White;
            this.difficultyLabel.Location = new System.Drawing.Point(88, 97);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(284, 24);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Select Your Difficulty Level:";
            // 
            // heroNameInput
            // 
            this.heroNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroNameInput.Location = new System.Drawing.Point(212, 41);
            this.heroNameInput.Name = "heroNameInput";
            this.heroNameInput.Size = new System.Drawing.Size(219, 29);
            this.heroNameInput.TabIndex = 2;
            this.heroNameInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(26, 173);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(122, 52);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Black;
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(172, 173);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(122, 52);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(318, 173);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(122, 52);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(26, 294);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(414, 62);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(89, 378);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(280, 23);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // outputLabel2
            // 
            this.outputLabel2.ForeColor = System.Drawing.Color.White;
            this.outputLabel2.Location = new System.Drawing.Point(89, 418);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(280, 23);
            this.outputLabel2.TabIndex = 8;
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel2.Click += new System.EventHandler(this.OuputLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.heroNameInput);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.heroNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroNameLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.TextBox heroNameInput;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabel2;
    }
}

