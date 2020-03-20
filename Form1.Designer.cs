namespace DiceGame
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
            this.lbl_Dice1 = new System.Windows.Forms.Label();
            this.lbl_Dice2 = new System.Windows.Forms.Label();
            this.lbl_Dice3 = new System.Windows.Forms.Label();
            this.lbl_Dice4 = new System.Windows.Forms.Label();
            this.lbl_Dice5 = new System.Windows.Forms.Label();
            this.btn_DiceGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Dice1
            // 
            this.lbl_Dice1.Image = global::DiceGame.Properties.Resources._1;
            this.lbl_Dice1.Location = new System.Drawing.Point(562, 65);
            this.lbl_Dice1.Name = "lbl_Dice1";
            this.lbl_Dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_Dice1.TabIndex = 0;
            // 
            // lbl_Dice2
            // 
            this.lbl_Dice2.Image = global::DiceGame.Properties.Resources._1;
            this.lbl_Dice2.Location = new System.Drawing.Point(392, 65);
            this.lbl_Dice2.Name = "lbl_Dice2";
            this.lbl_Dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_Dice2.TabIndex = 1;
            // 
            // lbl_Dice3
            // 
            this.lbl_Dice3.Image = global::DiceGame.Properties.Resources._1;
            this.lbl_Dice3.Location = new System.Drawing.Point(448, 65);
            this.lbl_Dice3.Name = "lbl_Dice3";
            this.lbl_Dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_Dice3.TabIndex = 2;
            // 
            // lbl_Dice4
            // 
            this.lbl_Dice4.Image = global::DiceGame.Properties.Resources._1;
            this.lbl_Dice4.Location = new System.Drawing.Point(504, 65);
            this.lbl_Dice4.Name = "lbl_Dice4";
            this.lbl_Dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_Dice4.TabIndex = 3;
            // 
            // lbl_Dice5
            // 
            this.lbl_Dice5.Image = global::DiceGame.Properties.Resources._1;
            this.lbl_Dice5.Location = new System.Drawing.Point(331, 65);
            this.lbl_Dice5.Name = "lbl_Dice5";
            this.lbl_Dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_Dice5.TabIndex = 4;
            // 
            // btn_DiceGame
            // 
            this.btn_DiceGame.Location = new System.Drawing.Point(395, 200);
            this.btn_DiceGame.Name = "btn_DiceGame";
            this.btn_DiceGame.Size = new System.Drawing.Size(200, 50);
            this.btn_DiceGame.TabIndex = 5;
            this.btn_DiceGame.Text = "Row Dice";
            this.btn_DiceGame.UseVisualStyleBackColor = true;
            this.btn_DiceGame.Click += new System.EventHandler(this.btn_DiceGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btn_DiceGame);
            this.Controls.Add(this.lbl_Dice5);
            this.Controls.Add(this.lbl_Dice4);
            this.Controls.Add(this.lbl_Dice3);
            this.Controls.Add(this.lbl_Dice2);
            this.Controls.Add(this.lbl_Dice1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dice1;
        private System.Windows.Forms.Label lbl_Dice2;
        private System.Windows.Forms.Label lbl_Dice3;
        private System.Windows.Forms.Label lbl_Dice4;
        private System.Windows.Forms.Label lbl_Dice5;
        private System.Windows.Forms.Button btn_DiceGame;
    }
}

