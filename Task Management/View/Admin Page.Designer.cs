namespace Task_Management
{
    partial class Admin_Page
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(224, 75);
            label1.TabIndex = 0;
            label1.Text = "Admin Page ";
            // 
            // button1
            // 
            button1.Location = new Point(356, 319);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 1;
            button1.Text = "TAMPILKAN DAFTAR TUGAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(562, 319);
            button2.Name = "button2";
            button2.Size = new Size(207, 23);
            button2.TabIndex = 2;
            button2.Text = "MENAMBAH TUGAS BARU";
            button2.UseVisualStyleBackColor = true;
            // 
            // Admin_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Admin_Page";
            Text = "Admin_Page";
            Load += Admin_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}