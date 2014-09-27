using System;
using System.Windows.Forms;

namespace MultiGame2
{
    partial class PlayGame
    {

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Board b;
        private TextBox textBox2;
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AccessibleDescription = "startButton";
            this.startButton.AccessibleName = "sButton";
            this.startButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Red;
            this.startButton.Location = new System.Drawing.Point(517, 288);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 76);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startClick);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(517, 242);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(536, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 465);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 20);
            this.textBox2.TabIndex = 5;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 602);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Name = "PlayGame";
            this.Text = "selectPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

            

            

        }

        #endregion


        private void startClick(object sender, System.EventArgs e)
        {
            string theText = this.textBox1.Text;

            //Check the player has entered a name
            if (this.textBox1.Text.Trim().Length != 0)
            {
                //if they have start a new game
                textBox2.AppendText("PlayerName: " + this.textBox1.Text);
                b = new Board();
                b.Show();
                this.Hide();
            
            }
            else
            {
                //else ask them to enter one
                MessageBox.Show(this, "Please enter a name");
                textBox1.Focus();
            }
            
        

        }

    }
}

