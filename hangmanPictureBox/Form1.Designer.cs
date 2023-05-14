using System;

namespace SPANZURATOARE
{
    partial class SPANZURATOAREA
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
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGuess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxGuess.Location = new System.Drawing.Point(482, 247);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(41, 22);
            this.textBoxGuess.TabIndex = 1;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGuess.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonGuess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuess.Location = new System.Drawing.Point(392, 287);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(219, 50);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "GHICI";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelGuesses
            // 
            this.labelGuesses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelGuesses.Location = new System.Drawing.Point(408, 213);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(128, 16);
            this.labelGuesses.TabIndex = 3;
            this.labelGuesses.Text = "labelGuessesLeft";
            // 
            // labelWord
            // 
            this.labelWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWord.AutoSize = true;
            this.labelWord.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(530, 213);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(116, 16);
            this.labelWord.TabIndex = 4;
            this.labelWord.Text = "labelDisplayWord";
            // 
            // SPANZURATOAREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPANZURATOARE.Properties.Resources.spanz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 514);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelGuesses);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SPANZURATOAREA";
            this.Text = "SPANZURATOAREA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelGuesses;
        private System.Windows.Forms.Label labelWord;
    }
}

