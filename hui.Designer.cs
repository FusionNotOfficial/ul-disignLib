namespace ULControls
{
    partial class hui
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
            ulTextBox1 = new ULTextBox();
            ulTextBox2 = new ULTextBox();
            SuspendLayout();
            // 
            // ulTextBox1
            // 
            ulTextBox1.BackColor = SystemColors.Menu;
            ulTextBox1.BorderColor = Color.MediumSlateBlue;
            ulTextBox1.BorderFocusColor = Color.HotPink;
            ulTextBox1.BorderSize = 2;
            ulTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulTextBox1.ForeColor = Color.DimGray;
            ulTextBox1.Location = new Point(274, 131);
            ulTextBox1.Multiline = false;
            ulTextBox1.Name = "ulTextBox1";
            ulTextBox1.Padding = new Padding(7);
            ulTextBox1.PasswordChar = false;
            ulTextBox1.Size = new Size(250, 30);
            ulTextBox1.TabIndex = 0;
            ulTextBox1.Texts = "hui";
            ulTextBox1.UnderlinedStyle = true;
            // 
            // ulTextBox2
            // 
            ulTextBox2.BackColor = SystemColors.Window;
            ulTextBox2.BorderColor = Color.MediumSlateBlue;
            ulTextBox2.BorderFocusColor = Color.HotPink;
            ulTextBox2.BorderSize = 2;
            ulTextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulTextBox2.ForeColor = Color.DimGray;
            ulTextBox2.Location = new Point(263, 272);
            ulTextBox2.Multiline = false;
            ulTextBox2.Name = "ulTextBox2";
            ulTextBox2.Padding = new Padding(7);
            ulTextBox2.PasswordChar = false;
            ulTextBox2.Size = new Size(250, 30);
            ulTextBox2.TabIndex = 1;
            ulTextBox2.Texts = "";
            ulTextBox2.UnderlinedStyle = false;
            // 
            // hui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ulTextBox2);
            Controls.Add(ulTextBox1);
            Name = "hui";
            Text = "hui";
            ResumeLayout(false);
        }

        #endregion

        private ULTextBox ulTextBox1;
        private ULTextBox ulTextBox2;
    }
}