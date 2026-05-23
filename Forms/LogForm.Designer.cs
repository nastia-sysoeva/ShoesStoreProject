namespace ShoesStoreProject.Forms
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            LogTB = new TextBox();
            PasTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LogBtn = new Button();
            GuestBtn = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogTB
            // 
            LogTB.Location = new Point(418, 293);
            LogTB.Name = "LogTB";
            LogTB.Size = new Size(365, 27);
            LogTB.TabIndex = 0;
            // 
            // PasTB
            // 
            PasTB.Location = new Point(418, 395);
            PasTB.Name = "PasTB";
            PasTB.Size = new Size(365, 27);
            PasTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(418, 257);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 2;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(418, 361);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // LogBtn
            // 
            LogBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogBtn.Location = new Point(689, 467);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(94, 29);
            LogBtn.TabIndex = 4;
            LogBtn.Text = "Войти";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // GuestBtn
            // 
            GuestBtn.AutoSize = true;
            GuestBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuestBtn.LinkColor = Color.Black;
            GuestBtn.Location = new Point(418, 476);
            GuestBtn.Name = "GuestBtn";
            GuestBtn.Size = new Size(109, 17);
            GuestBtn.TabIndex = 5;
            GuestBtn.TabStop = true;
            GuestBtn.Text = "Войти как гость";
            GuestBtn.LinkClicked += GuestBtn_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(418, 207);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 6;
            label3.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(GuestBtn);
            Controls.Add(LogBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasTB);
            Controls.Add(LogTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogTB;
        private TextBox PasTB;
        private Label label1;
        private Label label2;
        private Button LogBtn;
        private LinkLabel GuestBtn;
        private Label label3;
        private PictureBox pictureBox1;
    }
}