namespace pc_build
{
    partial class Form1
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
            main_form1 = new main_form();
            SuspendLayout();
            // 
            // main_form1
            // 
            main_form1.BackColor = Color.FromArgb(41, 43, 47);
            main_form1.Location = new Point(0, 0);
            main_form1.Name = "main_form1";
            main_form1.Size = new Size(1284, 681);
            main_form1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 43, 47);
            ClientSize = new Size(1284, 682);
            Controls.Add(main_form1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private main_form main_form1;
    }
}