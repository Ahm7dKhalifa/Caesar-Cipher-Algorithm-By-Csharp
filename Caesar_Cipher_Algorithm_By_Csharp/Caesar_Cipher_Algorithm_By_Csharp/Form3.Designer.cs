namespace Caesar_Cipher_Algorithm_By_Csharp
{
    partial class Form3
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
            this.ovalPictureBox1 = new Caesar_Cipher_Algorithm_By_Csharp.OvalPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ovalPictureBox2 = new Caesar_Cipher_Algorithm_By_Csharp.OvalPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1.Image = global::Caesar_Cipher_Algorithm_By_Csharp.Properties.Resources.julius_caesar_4;
            this.ovalPictureBox1.Location = new System.Drawing.Point(68, 12);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(232, 198);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 0;
            this.ovalPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 59);
            this.textBox1.TabIndex = 2;
            // 
            // ovalPictureBox2
            // 
            this.ovalPictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox2.Image = global::Caesar_Cipher_Algorithm_By_Csharp.Properties.Resources.HZ;
            this.ovalPictureBox2.Location = new System.Drawing.Point(107, 463);
            this.ovalPictureBox2.Name = "ovalPictureBox2";
            this.ovalPictureBox2.Size = new System.Drawing.Size(121, 96);
            this.ovalPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox2.TabIndex = 4;
            this.ovalPictureBox2.TabStop = false;
            this.ovalPictureBox2.Click += new System.EventHandler(this.ovalPictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caesar_Cipher_Algorithm_By_Csharp.Properties.Resources.old_paper;
            this.pictureBox1.Location = new System.Drawing.Point(370, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(444, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 51);
            this.label2.TabIndex = 6;
            // 
            // MessageError
            // 
            this.MessageError.AutoSize = true;
            this.MessageError.BackColor = System.Drawing.Color.Transparent;
            this.MessageError.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageError.Location = new System.Drawing.Point(342, 451);
            this.MessageError.Name = "MessageError";
            this.MessageError.Size = new System.Drawing.Size(0, 43);
            this.MessageError.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "Increment Number :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 59);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(892, 571);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ovalPictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ovalPictureBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private OvalPictureBox ovalPictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MessageError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}