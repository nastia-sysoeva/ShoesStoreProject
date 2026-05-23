namespace ShoesStoreProject.Forms
{
    partial class AddEditProductForm
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
            panel1 = new Panel();
            IdPanel = new Panel();
            IdTB = new TextBox();
            label10 = new Label();
            AddPicture = new LinkLabel();
            DeletePicture = new LinkLabel();
            PictureBox = new PictureBox();
            panel2 = new Panel();
            CntTB = new TextBox();
            DiscountTB = new TextBox();
            label9 = new Label();
            label8 = new Label();
            UnitTB = new TextBox();
            label7 = new Label();
            PriceTB = new TextBox();
            label6 = new Label();
            SupCB = new ComboBox();
            label5 = new Label();
            ProdCB = new ComboBox();
            label4 = new Label();
            DescTB = new TextBox();
            label3 = new Label();
            CatCB = new ComboBox();
            label2 = new Label();
            NameTB = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            TitleLbl = new Label();
            panel1.SuspendLayout();
            IdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(IdPanel);
            panel1.Controls.Add(AddPicture);
            panel1.Controls.Add(DeletePicture);
            panel1.Controls.Add(PictureBox);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 214);
            panel1.TabIndex = 0;
            // 
            // IdPanel
            // 
            IdPanel.Controls.Add(IdTB);
            IdPanel.Controls.Add(label10);
            IdPanel.Location = new Point(319, 146);
            IdPanel.Name = "IdPanel";
            IdPanel.Size = new Size(233, 60);
            IdPanel.TabIndex = 22;
            IdPanel.Visible = false;
            // 
            // IdTB
            // 
            IdTB.Location = new Point(7, 28);
            IdTB.Name = "IdTB";
            IdTB.ReadOnly = true;
            IdTB.Size = new Size(105, 27);
            IdTB.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(7, 8);
            label10.Name = "label10";
            label10.Size = new Size(27, 17);
            label10.TabIndex = 20;
            label10.Text = "ID:";
            // 
            // AddPicture
            // 
            AddPicture.AutoSize = true;
            AddPicture.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPicture.LinkColor = Color.Black;
            AddPicture.Location = new Point(320, 39);
            AddPicture.Name = "AddPicture";
            AddPicture.Size = new Size(102, 17);
            AddPicture.TabIndex = 3;
            AddPicture.TabStop = true;
            AddPicture.Text = "Добавить фото";
            AddPicture.LinkClicked += AddPicture_LinkClicked;
            // 
            // DeletePicture
            // 
            DeletePicture.AutoSize = true;
            DeletePicture.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeletePicture.LinkColor = Color.Black;
            DeletePicture.Location = new Point(320, 7);
            DeletePicture.Name = "DeletePicture";
            DeletePicture.Size = new Size(94, 17);
            DeletePicture.TabIndex = 2;
            DeletePicture.TabStop = true;
            DeletePicture.Text = "Удалить фото";
            DeletePicture.LinkClicked += DeletePicture_LinkClicked;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(14, 6);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(300, 200);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CntTB);
            panel2.Controls.Add(DiscountTB);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(UnitTB);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PriceTB);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(SupCB);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ProdCB);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(DescTB);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CatCB);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NameTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 452);
            panel2.TabIndex = 1;
            // 
            // CntTB
            // 
            CntTB.Location = new Point(287, 339);
            CntTB.Name = "CntTB";
            CntTB.Size = new Size(252, 27);
            CntTB.TabIndex = 19;
            // 
            // DiscountTB
            // 
            DiscountTB.Location = new Point(287, 403);
            DiscountTB.Name = "DiscountTB";
            DiscountTB.Size = new Size(252, 27);
            DiscountTB.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(287, 383);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 17;
            label9.Text = "Скидка:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(287, 319);
            label8.Name = "label8";
            label8.Size = new Size(149, 17);
            label8.TabIndex = 15;
            label8.Text = "Количество на складе:";
            // 
            // UnitTB
            // 
            UnitTB.Location = new Point(14, 403);
            UnitTB.Name = "UnitTB";
            UnitTB.Size = new Size(252, 27);
            UnitTB.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(14, 383);
            label7.Name = "label7";
            label7.Size = new Size(132, 17);
            label7.TabIndex = 13;
            label7.Text = "Единица измерения:";
            // 
            // PriceTB
            // 
            PriceTB.Location = new Point(14, 339);
            PriceTB.Name = "PriceTB";
            PriceTB.Size = new Size(252, 27);
            PriceTB.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(14, 319);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 11;
            label6.Text = "Цена:";
            // 
            // SupCB
            // 
            SupCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SupCB.FormattingEnabled = true;
            SupCB.Items.AddRange(new object[] { "Kari", "Обувь для вас" });
            SupCB.Location = new Point(14, 274);
            SupCB.Name = "SupCB";
            SupCB.Size = new Size(525, 28);
            SupCB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(14, 254);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 9;
            label5.Text = "Поставщик:";
            // 
            // ProdCB
            // 
            ProdCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ProdCB.FormattingEnabled = true;
            ProdCB.Items.AddRange(new object[] { "Kari", "Marco Tozzi", "Рос", "Rieker", "Alessio Nesca", "CROSBY" });
            ProdCB.Location = new Point(14, 214);
            ProdCB.Name = "ProdCB";
            ProdCB.Size = new Size(525, 28);
            ProdCB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(14, 194);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 7;
            label4.Text = "Производитель:";
            // 
            // DescTB
            // 
            DescTB.Location = new Point(14, 154);
            DescTB.Name = "DescTB";
            DescTB.Size = new Size(525, 27);
            DescTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 134);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 5;
            label3.Text = "Описание:";
            // 
            // CatCB
            // 
            CatCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CatCB.FormattingEnabled = true;
            CatCB.Items.AddRange(new object[] { "Мужская обувь", "Женская обувь" });
            CatCB.Location = new Point(14, 94);
            CatCB.Name = "CatCB";
            CatCB.Size = new Size(525, 28);
            CatCB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 2;
            label2.Text = "Категория:";
            // 
            // NameTB
            // 
            NameTB.Location = new Point(14, 33);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(525, 27);
            NameTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Наименование:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(SaveBtn);
            panel3.Location = new Point(12, 718);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 51);
            panel3.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(22, 10);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(124, 29);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Visible = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(415, 10);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(124, 29);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TitleLbl.Location = new Point(12, 9);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(63, 20);
            TitleLbl.TabIndex = 3;
            TitleLbl.Text = "label11";
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 775);
            Controls.Add(TitleLbl);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            IdPanel.ResumeLayout(false);
            IdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox PictureBox;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox CntTB;
        private TextBox DiscountTB;
        private Label label9;
        private Label label8;
        private TextBox UnitTB;
        private Label label7;
        private TextBox PriceTB;
        private Label label6;
        private ComboBox SupCB;
        private Label label5;
        private ComboBox ProdCB;
        private Label label4;
        private TextBox DescTB;
        private Label label3;
        private ComboBox CatCB;
        private Label label2;
        private TextBox NameTB;
        private Button SaveBtn;
        private LinkLabel AddPicture;
        private LinkLabel DeletePicture;
        private TextBox IdTB;
        private Label label10;
        private Panel IdPanel;
        private Button DeleteBtn;
        private Label TitleLbl;
    }
}