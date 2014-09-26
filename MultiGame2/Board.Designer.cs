using System.Windows.Forms;

namespace MultiGame2
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bool running = true;

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
            this.SuspendLayout();
            this.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 522);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 546);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Board";
            this.Text = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            //this.OnFormClosing(OnClosing();
            this.FormClosed += new FormClosedEventHandler(onClose);

            //MouseListener

            

        }

        #endregion

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "Left Button Click"+e.X);
                    break;
                case MouseButtons.Right:
                    MessageBox.Show(this, "Right Button Click");
                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            }

        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}