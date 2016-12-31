namespace Scrabble
{
    partial class GameBoard
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SimulateGameCompleteButton = new System.Windows.Forms.Button();
            this.AvailableLetter1TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter2TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter3TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter4TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter5TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter6TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter7TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter8TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter9TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLetter10TextBox = new System.Windows.Forms.TextBox();
            this.AvailableLettersLabel = new System.Windows.Forms.Label();
            this.YourWordLabel = new System.Windows.Forms.Label();
            this.Letter10TextBox = new System.Windows.Forms.TextBox();
            this.Letter9TextBox = new System.Windows.Forms.TextBox();
            this.Letter8TextBox = new System.Windows.Forms.TextBox();
            this.Letter7TextBox = new System.Windows.Forms.TextBox();
            this.Letter6TextBox = new System.Windows.Forms.TextBox();
            this.Letter5TextBox = new System.Windows.Forms.TextBox();
            this.Letter4TextBox = new System.Windows.Forms.TextBox();
            this.Letter3TextBox = new System.Windows.Forms.TextBox();
            this.Letter2TextBox = new System.Windows.Forms.TextBox();
            this.Letter1TextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(15, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 0;
            // 
            // SimulateGameCompleteButton
            // 
            this.SimulateGameCompleteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SimulateGameCompleteButton.Location = new System.Drawing.Point(27, 304);
            this.SimulateGameCompleteButton.Name = "SimulateGameCompleteButton";
            this.SimulateGameCompleteButton.Size = new System.Drawing.Size(200, 23);
            this.SimulateGameCompleteButton.TabIndex = 1;
            this.SimulateGameCompleteButton.Text = "Simulate game completion";
            this.SimulateGameCompleteButton.UseVisualStyleBackColor = true;
            this.SimulateGameCompleteButton.Click += new System.EventHandler(this.SimulateGameCompleteButton_Click);
            // 
            // AvailableLetter1TextBox
            // 
            this.AvailableLetter1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter1TextBox.Location = new System.Drawing.Point(27, 209);
            this.AvailableLetter1TextBox.MaxLength = 1;
            this.AvailableLetter1TextBox.Name = "AvailableLetter1TextBox";
            this.AvailableLetter1TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter1TextBox.TabIndex = 2;
            // 
            // AvailableLetter2TextBox
            // 
            this.AvailableLetter2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter2TextBox.Location = new System.Drawing.Point(68, 209);
            this.AvailableLetter2TextBox.MaxLength = 1;
            this.AvailableLetter2TextBox.Name = "AvailableLetter2TextBox";
            this.AvailableLetter2TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter2TextBox.TabIndex = 3;
            // 
            // AvailableLetter3TextBox
            // 
            this.AvailableLetter3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter3TextBox.Location = new System.Drawing.Point(109, 209);
            this.AvailableLetter3TextBox.MaxLength = 1;
            this.AvailableLetter3TextBox.Name = "AvailableLetter3TextBox";
            this.AvailableLetter3TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter3TextBox.TabIndex = 4;
            // 
            // AvailableLetter4TextBox
            // 
            this.AvailableLetter4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter4TextBox.Location = new System.Drawing.Point(150, 209);
            this.AvailableLetter4TextBox.MaxLength = 1;
            this.AvailableLetter4TextBox.Name = "AvailableLetter4TextBox";
            this.AvailableLetter4TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter4TextBox.TabIndex = 5;
            // 
            // AvailableLetter5TextBox
            // 
            this.AvailableLetter5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter5TextBox.Location = new System.Drawing.Point(191, 209);
            this.AvailableLetter5TextBox.MaxLength = 1;
            this.AvailableLetter5TextBox.Name = "AvailableLetter5TextBox";
            this.AvailableLetter5TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter5TextBox.TabIndex = 6;
            // 
            // AvailableLetter6TextBox
            // 
            this.AvailableLetter6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter6TextBox.Location = new System.Drawing.Point(232, 209);
            this.AvailableLetter6TextBox.MaxLength = 1;
            this.AvailableLetter6TextBox.Name = "AvailableLetter6TextBox";
            this.AvailableLetter6TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter6TextBox.TabIndex = 7;
            // 
            // AvailableLetter7TextBox
            // 
            this.AvailableLetter7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter7TextBox.Location = new System.Drawing.Point(273, 209);
            this.AvailableLetter7TextBox.MaxLength = 1;
            this.AvailableLetter7TextBox.Name = "AvailableLetter7TextBox";
            this.AvailableLetter7TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter7TextBox.TabIndex = 8;
            // 
            // AvailableLetter8TextBox
            // 
            this.AvailableLetter8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter8TextBox.Location = new System.Drawing.Point(314, 209);
            this.AvailableLetter8TextBox.MaxLength = 1;
            this.AvailableLetter8TextBox.Name = "AvailableLetter8TextBox";
            this.AvailableLetter8TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter8TextBox.TabIndex = 9;
            // 
            // AvailableLetter9TextBox
            // 
            this.AvailableLetter9TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter9TextBox.Location = new System.Drawing.Point(355, 209);
            this.AvailableLetter9TextBox.MaxLength = 1;
            this.AvailableLetter9TextBox.Name = "AvailableLetter9TextBox";
            this.AvailableLetter9TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter9TextBox.TabIndex = 10;
            // 
            // AvailableLetter10TextBox
            // 
            this.AvailableLetter10TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLetter10TextBox.Location = new System.Drawing.Point(396, 209);
            this.AvailableLetter10TextBox.MaxLength = 1;
            this.AvailableLetter10TextBox.Name = "AvailableLetter10TextBox";
            this.AvailableLetter10TextBox.Size = new System.Drawing.Size(35, 38);
            this.AvailableLetter10TextBox.TabIndex = 11;
            // 
            // AvailableLettersLabel
            // 
            this.AvailableLettersLabel.AutoSize = true;
            this.AvailableLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLettersLabel.Location = new System.Drawing.Point(28, 178);
            this.AvailableLettersLabel.Name = "AvailableLettersLabel";
            this.AvailableLettersLabel.Size = new System.Drawing.Size(146, 24);
            this.AvailableLettersLabel.TabIndex = 12;
            this.AvailableLettersLabel.Text = "Available Letters";
            // 
            // YourWordLabel
            // 
            this.YourWordLabel.AutoSize = true;
            this.YourWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourWordLabel.Location = new System.Drawing.Point(28, 63);
            this.YourWordLabel.Name = "YourWordLabel";
            this.YourWordLabel.Size = new System.Drawing.Size(101, 24);
            this.YourWordLabel.TabIndex = 13;
            this.YourWordLabel.Text = "Your Word";
            // 
            // Letter10TextBox
            // 
            this.Letter10TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter10TextBox.Location = new System.Drawing.Point(396, 90);
            this.Letter10TextBox.MaxLength = 1;
            this.Letter10TextBox.Name = "Letter10TextBox";
            this.Letter10TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter10TextBox.TabIndex = 23;
            // 
            // Letter9TextBox
            // 
            this.Letter9TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter9TextBox.Location = new System.Drawing.Point(355, 90);
            this.Letter9TextBox.MaxLength = 1;
            this.Letter9TextBox.Name = "Letter9TextBox";
            this.Letter9TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter9TextBox.TabIndex = 22;
            // 
            // Letter8TextBox
            // 
            this.Letter8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter8TextBox.Location = new System.Drawing.Point(314, 90);
            this.Letter8TextBox.MaxLength = 1;
            this.Letter8TextBox.Name = "Letter8TextBox";
            this.Letter8TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter8TextBox.TabIndex = 21;
            // 
            // Letter7TextBox
            // 
            this.Letter7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter7TextBox.Location = new System.Drawing.Point(273, 90);
            this.Letter7TextBox.MaxLength = 1;
            this.Letter7TextBox.Name = "Letter7TextBox";
            this.Letter7TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter7TextBox.TabIndex = 20;
            // 
            // Letter6TextBox
            // 
            this.Letter6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter6TextBox.Location = new System.Drawing.Point(232, 90);
            this.Letter6TextBox.MaxLength = 1;
            this.Letter6TextBox.Name = "Letter6TextBox";
            this.Letter6TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter6TextBox.TabIndex = 19;
            // 
            // Letter5TextBox
            // 
            this.Letter5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter5TextBox.Location = new System.Drawing.Point(191, 90);
            this.Letter5TextBox.MaxLength = 1;
            this.Letter5TextBox.Name = "Letter5TextBox";
            this.Letter5TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter5TextBox.TabIndex = 18;
            // 
            // Letter4TextBox
            // 
            this.Letter4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter4TextBox.Location = new System.Drawing.Point(150, 90);
            this.Letter4TextBox.MaxLength = 1;
            this.Letter4TextBox.Name = "Letter4TextBox";
            this.Letter4TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter4TextBox.TabIndex = 17;
            // 
            // Letter3TextBox
            // 
            this.Letter3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter3TextBox.Location = new System.Drawing.Point(109, 90);
            this.Letter3TextBox.MaxLength = 1;
            this.Letter3TextBox.Name = "Letter3TextBox";
            this.Letter3TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter3TextBox.TabIndex = 16;
            // 
            // Letter2TextBox
            // 
            this.Letter2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter2TextBox.Location = new System.Drawing.Point(68, 90);
            this.Letter2TextBox.MaxLength = 1;
            this.Letter2TextBox.Name = "Letter2TextBox";
            this.Letter2TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter2TextBox.TabIndex = 15;
            // 
            // Letter1TextBox
            // 
            this.Letter1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter1TextBox.Location = new System.Drawing.Point(27, 90);
            this.Letter1TextBox.MaxLength = 1;
            this.Letter1TextBox.Name = "Letter1TextBox";
            this.Letter1TextBox.Size = new System.Drawing.Size(35, 38);
            this.Letter1TextBox.TabIndex = 14;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(356, 304);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "&Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 349);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Letter10TextBox);
            this.Controls.Add(this.Letter9TextBox);
            this.Controls.Add(this.Letter8TextBox);
            this.Controls.Add(this.Letter7TextBox);
            this.Controls.Add(this.Letter6TextBox);
            this.Controls.Add(this.Letter5TextBox);
            this.Controls.Add(this.Letter4TextBox);
            this.Controls.Add(this.Letter3TextBox);
            this.Controls.Add(this.Letter2TextBox);
            this.Controls.Add(this.Letter1TextBox);
            this.Controls.Add(this.YourWordLabel);
            this.Controls.Add(this.AvailableLettersLabel);
            this.Controls.Add(this.AvailableLetter10TextBox);
            this.Controls.Add(this.AvailableLetter9TextBox);
            this.Controls.Add(this.AvailableLetter8TextBox);
            this.Controls.Add(this.AvailableLetter7TextBox);
            this.Controls.Add(this.AvailableLetter6TextBox);
            this.Controls.Add(this.AvailableLetter5TextBox);
            this.Controls.Add(this.AvailableLetter4TextBox);
            this.Controls.Add(this.AvailableLetter3TextBox);
            this.Controls.Add(this.AvailableLetter2TextBox);
            this.Controls.Add(this.AvailableLetter1TextBox);
            this.Controls.Add(this.SimulateGameCompleteButton);
            this.Controls.Add(this.NameLabel);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SimulateGameCompleteButton;
        private System.Windows.Forms.TextBox AvailableLetter1TextBox;
        private System.Windows.Forms.TextBox AvailableLetter2TextBox;
        private System.Windows.Forms.TextBox AvailableLetter3TextBox;
        private System.Windows.Forms.TextBox AvailableLetter4TextBox;
        private System.Windows.Forms.TextBox AvailableLetter5TextBox;
        private System.Windows.Forms.TextBox AvailableLetter6TextBox;
        private System.Windows.Forms.TextBox AvailableLetter7TextBox;
        private System.Windows.Forms.TextBox AvailableLetter8TextBox;
        private System.Windows.Forms.TextBox AvailableLetter9TextBox;
        private System.Windows.Forms.TextBox AvailableLetter10TextBox;
        private System.Windows.Forms.Label AvailableLettersLabel;
        private System.Windows.Forms.Label YourWordLabel;
        private System.Windows.Forms.TextBox Letter10TextBox;
        private System.Windows.Forms.TextBox Letter9TextBox;
        private System.Windows.Forms.TextBox Letter8TextBox;
        private System.Windows.Forms.TextBox Letter7TextBox;
        private System.Windows.Forms.TextBox Letter6TextBox;
        private System.Windows.Forms.TextBox Letter5TextBox;
        private System.Windows.Forms.TextBox Letter4TextBox;
        private System.Windows.Forms.TextBox Letter3TextBox;
        private System.Windows.Forms.TextBox Letter2TextBox;
        private System.Windows.Forms.TextBox Letter1TextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}