namespace pc_build
{
    partial class main_form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roundedCornerPictureBox1 = new CustomControls.RoundedCornerPictureBox();
            label2 = new Label();
            cpu_combobox = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            roundedCornerPictureBox4 = new CustomControls.RoundedCornerPictureBox();
            label8 = new Label();
            gpu_combobox = new ComboBox();
            label9 = new Label();
            panel5 = new Panel();
            label16 = new Label();
            roundedCornerPictureBox5 = new CustomControls.RoundedCornerPictureBox();
            mobo_combobox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            price_combobox = new ComboBox();
            panel2 = new Panel();
            roundedCornerPictureBox2 = new CustomControls.RoundedCornerPictureBox();
            label3 = new Label();
            psu_combobox = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            roundedCornerPictureBox3 = new CustomControls.RoundedCornerPictureBox();
            label5 = new Label();
            case_combobox = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            roundedCornerPictureBox6 = new CustomControls.RoundedCornerPictureBox();
            label12 = new Label();
            ram_combobox = new ComboBox();
            label13 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            roundedCornerPictureBox7 = new CustomControls.RoundedCornerPictureBox();
            label14 = new Label();
            cpu_cooler_combobox = new ComboBox();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 149, 250);
            panel1.Controls.Add(roundedCornerPictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cpu_combobox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 160);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // roundedCornerPictureBox1
            // 
            roundedCornerPictureBox1.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox1.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox1.BorderWidth = 2;
            roundedCornerPictureBox1.CornerRadius = 20;
            roundedCornerPictureBox1.Location = new Point(13, 13);
            roundedCornerPictureBox1.Name = "roundedCornerPictureBox1";
            roundedCornerPictureBox1.Size = new Size(130, 130);
            roundedCornerPictureBox1.TabIndex = 5;
            roundedCornerPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(240, 250, 255);
            label2.Location = new Point(295, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Advance Search";
            label2.Click += label2_Click;
            // 
            // cpu_combobox
            // 
            cpu_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpu_combobox.FormattingEnabled = true;
            cpu_combobox.Location = new Point(149, 35);
            cpu_combobox.Name = "cpu_combobox";
            cpu_combobox.Size = new Size(240, 29);
            cpu_combobox.Sorted = true;
            cpu_combobox.TabIndex = 2;
            cpu_combobox.SelectedIndexChanged += cpu_combobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(240, 250, 255);
            label1.Location = new Point(159, 6);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 1;
            label1.Text = "CPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(211, 251, 216);
            label7.Location = new Point(15, 17);
            label7.Name = "label7";
            label7.Size = new Size(383, 23);
            label7.TabIndex = 6;
            label7.Text = "Are you on a Budget? Select the range:";
            label7.Click += label7_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 149, 250);
            panel4.Controls.Add(roundedCornerPictureBox4);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(gpu_combobox);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(868, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 160);
            panel4.TabIndex = 6;
            // 
            // roundedCornerPictureBox4
            // 
            roundedCornerPictureBox4.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox4.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox4.BorderWidth = 2;
            roundedCornerPictureBox4.CornerRadius = 20;
            roundedCornerPictureBox4.Location = new Point(13, 13);
            roundedCornerPictureBox4.Name = "roundedCornerPictureBox4";
            roundedCornerPictureBox4.Size = new Size(130, 130);
            roundedCornerPictureBox4.TabIndex = 5;
            roundedCornerPictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(240, 250, 255);
            label8.Location = new Point(295, 67);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 3;
            label8.Text = "Advance Search";
            // 
            // gpu_combobox
            // 
            gpu_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gpu_combobox.FormattingEnabled = true;
            gpu_combobox.Location = new Point(149, 35);
            gpu_combobox.Name = "gpu_combobox";
            gpu_combobox.Size = new Size(240, 29);
            gpu_combobox.Sorted = true;
            gpu_combobox.TabIndex = 2;
            gpu_combobox.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(240, 250, 255);
            label9.Location = new Point(159, 6);
            label9.Name = "label9";
            label9.Size = new Size(172, 23);
            label9.TabIndex = 1;
            label9.Text = "GRAPHICS CARD";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 149, 250);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(roundedCornerPictureBox5);
            panel5.Controls.Add(mobo_combobox);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(441, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 160);
            panel5.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(240, 250, 255);
            label16.Location = new Point(295, 67);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 6;
            label16.Text = "Advance Search";
            // 
            // roundedCornerPictureBox5
            // 
            roundedCornerPictureBox5.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox5.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox5.BorderWidth = 2;
            roundedCornerPictureBox5.CornerRadius = 20;
            roundedCornerPictureBox5.Location = new Point(13, 13);
            roundedCornerPictureBox5.Name = "roundedCornerPictureBox5";
            roundedCornerPictureBox5.Size = new Size(130, 130);
            roundedCornerPictureBox5.TabIndex = 5;
            roundedCornerPictureBox5.TabStop = false;
            // 
            // mobo_combobox
            // 
            mobo_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobo_combobox.FormattingEnabled = true;
            mobo_combobox.Location = new Point(149, 35);
            mobo_combobox.Name = "mobo_combobox";
            mobo_combobox.Size = new Size(240, 29);
            mobo_combobox.Sorted = true;
            mobo_combobox.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(240, 250, 255);
            label11.Location = new Point(159, 6);
            label11.Name = "label11";
            label11.Size = new Size(164, 23);
            label11.TabIndex = 1;
            label11.Text = "MOTHERBOARD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(240, 250, 255);
            label10.Location = new Point(588, 45);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 3;
            label10.Text = "Advance Filter";
            label10.Click += label10_Click;
            // 
            // price_combobox
            // 
            price_combobox.BackColor = Color.FromArgb(211, 251, 216);
            price_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price_combobox.ForeColor = Color.FromArgb(41, 43, 47);
            price_combobox.FormattingEnabled = true;
            price_combobox.Items.AddRange(new object[] { "ALL", "LOW END", "ENTRY-LEVEL", "MID-RANGE", "HIGH-END", "LOW END to ENTRY LEVEL", "LOW END to MID RANGE", "ENTRY-LEVEL to MID-RANGE", "ENTRY LEVEL to HIGH END", "MID-RANGE to HIGH-END" });
            price_combobox.Location = new Point(404, 16);
            price_combobox.Name = "price_combobox";
            price_combobox.Size = new Size(269, 29);
            price_combobox.TabIndex = 6;
            price_combobox.SelectedIndexChanged += price_combobox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 149, 250);
            panel2.Controls.Add(roundedCornerPictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(psu_combobox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(441, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 160);
            panel2.TabIndex = 7;
            // 
            // roundedCornerPictureBox2
            // 
            roundedCornerPictureBox2.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox2.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox2.BorderWidth = 2;
            roundedCornerPictureBox2.CornerRadius = 20;
            roundedCornerPictureBox2.Location = new Point(13, 13);
            roundedCornerPictureBox2.Name = "roundedCornerPictureBox2";
            roundedCornerPictureBox2.Size = new Size(130, 130);
            roundedCornerPictureBox2.TabIndex = 5;
            roundedCornerPictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(240, 250, 255);
            label3.Location = new Point(295, 67);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Advance Search";
            // 
            // psu_combobox
            // 
            psu_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            psu_combobox.FormattingEnabled = true;
            psu_combobox.Location = new Point(149, 35);
            psu_combobox.Name = "psu_combobox";
            psu_combobox.Size = new Size(240, 29);
            psu_combobox.Sorted = true;
            psu_combobox.TabIndex = 2;
            psu_combobox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(240, 250, 255);
            label4.Location = new Point(159, 6);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 1;
            label4.Text = "PSU";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 149, 250);
            panel3.Controls.Add(roundedCornerPictureBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(case_combobox);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(868, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 160);
            panel3.TabIndex = 6;
            // 
            // roundedCornerPictureBox3
            // 
            roundedCornerPictureBox3.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox3.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox3.BorderWidth = 2;
            roundedCornerPictureBox3.CornerRadius = 20;
            roundedCornerPictureBox3.Location = new Point(13, 13);
            roundedCornerPictureBox3.Name = "roundedCornerPictureBox3";
            roundedCornerPictureBox3.Size = new Size(130, 130);
            roundedCornerPictureBox3.TabIndex = 5;
            roundedCornerPictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(240, 250, 255);
            label5.Location = new Point(295, 67);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 3;
            label5.Text = "Advance Search";
            // 
            // case_combobox
            // 
            case_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            case_combobox.FormattingEnabled = true;
            case_combobox.Location = new Point(149, 35);
            case_combobox.Name = "case_combobox";
            case_combobox.Size = new Size(240, 29);
            case_combobox.Sorted = true;
            case_combobox.TabIndex = 2;
            case_combobox.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(240, 250, 255);
            label6.Location = new Point(159, 6);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 1;
            label6.Text = "CASE";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 149, 250);
            panel6.Controls.Add(roundedCornerPictureBox6);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(ram_combobox);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(12, 260);
            panel6.Name = "panel6";
            panel6.Size = new Size(402, 160);
            panel6.TabIndex = 6;
            // 
            // roundedCornerPictureBox6
            // 
            roundedCornerPictureBox6.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox6.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox6.BorderWidth = 2;
            roundedCornerPictureBox6.CornerRadius = 20;
            roundedCornerPictureBox6.Location = new Point(13, 13);
            roundedCornerPictureBox6.Name = "roundedCornerPictureBox6";
            roundedCornerPictureBox6.Size = new Size(130, 130);
            roundedCornerPictureBox6.TabIndex = 5;
            roundedCornerPictureBox6.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(240, 250, 255);
            label12.Location = new Point(295, 67);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 3;
            label12.Text = "Advance Search";
            // 
            // ram_combobox
            // 
            ram_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ram_combobox.FormattingEnabled = true;
            ram_combobox.Location = new Point(149, 35);
            ram_combobox.Name = "ram_combobox";
            ram_combobox.Size = new Size(240, 29);
            ram_combobox.Sorted = true;
            ram_combobox.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(240, 250, 255);
            label13.Location = new Point(159, 6);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 1;
            label13.Text = "RAM";
            // 
            // panel7
            // 
            panel7.Location = new Point(12, 448);
            panel7.Name = "panel7";
            panel7.Size = new Size(831, 215);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 149, 250);
            panel8.Controls.Add(roundedCornerPictureBox7);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(cpu_cooler_combobox);
            panel8.Controls.Add(label15);
            panel8.Location = new Point(868, 448);
            panel8.Name = "panel8";
            panel8.Size = new Size(402, 160);
            panel8.TabIndex = 7;
            // 
            // roundedCornerPictureBox7
            // 
            roundedCornerPictureBox7.BackColor = Color.FromArgb(240, 250, 255);
            roundedCornerPictureBox7.BorderColor = Color.FromArgb(211, 251, 216);
            roundedCornerPictureBox7.BorderWidth = 2;
            roundedCornerPictureBox7.CornerRadius = 20;
            roundedCornerPictureBox7.Location = new Point(13, 13);
            roundedCornerPictureBox7.Name = "roundedCornerPictureBox7";
            roundedCornerPictureBox7.Size = new Size(130, 130);
            roundedCornerPictureBox7.TabIndex = 5;
            roundedCornerPictureBox7.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(240, 250, 255);
            label14.Location = new Point(295, 67);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 3;
            label14.Text = "Advance Search";
            // 
            // cpu_cooler_combobox
            // 
            cpu_cooler_combobox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpu_cooler_combobox.FormattingEnabled = true;
            cpu_cooler_combobox.Location = new Point(149, 35);
            cpu_cooler_combobox.Name = "cpu_cooler_combobox";
            cpu_cooler_combobox.Size = new Size(240, 29);
            cpu_cooler_combobox.Sorted = true;
            cpu_cooler_combobox.TabIndex = 2;
            cpu_cooler_combobox.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(240, 250, 255);
            label15.Location = new Point(159, 6);
            label15.Name = "label15";
            label15.Size = new Size(135, 23);
            label15.TabIndex = 1;
            label15.Text = "CPU COOLER";
            // 
            // main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 43, 47);
            Controls.Add(price_combobox);
            Controls.Add(label10);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(41, 43, 47);
            Name = "main_form";
            Size = new Size(1284, 681);
            Load += main_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedCornerPictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cpu_combobox;
        private Label label2;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox1;
        private Label label7;
        private Panel panel4;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox4;
        private Label label8;
        private ComboBox gpu_combobox;
        private Label label9;
        private Panel panel5;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox5;
        private Label label10;
        private ComboBox mobo_combobox;
        private Label label11;
        private ComboBox price_combobox;
        private Panel panel2;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox2;
        private Label label3;
        private ComboBox psu_combobox;
        private Label label4;
        private Panel panel3;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox3;
        private Label label5;
        private ComboBox case_combobox;
        private Label label6;
        private Panel panel6;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox6;
        private Label label12;
        private ComboBox ram_combobox;
        private Label label13;
        private Panel panel7;
        private Panel panel8;
        private CustomControls.RoundedCornerPictureBox roundedCornerPictureBox7;
        private Label label14;
        private ComboBox cpu_cooler_combobox;
        private Label label15;
        private Label label16;
    }
}
