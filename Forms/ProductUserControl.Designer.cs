namespace ShoesStoreProject.Forms
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            PictureBox = new PictureBox();
            panel3 = new Panel();
            NewPriceLbl = new Label();
            label2 = new Label();
            CntLbl = new Label();
            UnitLbl = new Label();
            PriceLbl = new Label();
            SupLbl = new Label();
            ProdLbl = new Label();
            DescLbl = new Label();
            FullNameLbl = new Label();
            panel2 = new Panel();
            DiscLbl = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 244);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(PictureBox);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 236);
            panel4.TabIndex = 2;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(19, 17);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(300, 200);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(NewPriceLbl);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(CntLbl);
            panel3.Controls.Add(UnitLbl);
            panel3.Controls.Add(PriceLbl);
            panel3.Controls.Add(SupLbl);
            panel3.Controls.Add(ProdLbl);
            panel3.Controls.Add(DescLbl);
            panel3.Controls.Add(FullNameLbl);
            panel3.Location = new Point(353, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 236);
            panel3.TabIndex = 1;
            // 
            // NewPriceLbl
            // 
            NewPriceLbl.AutoSize = true;
            NewPriceLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NewPriceLbl.Location = new Point(151, 140);
            NewPriceLbl.Name = "NewPriceLbl";
            NewPriceLbl.Size = new Size(42, 17);
            NewPriceLbl.TabIndex = 8;
            NewPriceLbl.Text = "label1";
            NewPriceLbl.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(18, 140);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 7;
            label2.Text = "Цена:";
            // 
            // CntLbl
            // 
            CntLbl.AutoSize = true;
            CntLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CntLbl.Location = new Point(20, 200);
            CntLbl.Name = "CntLbl";
            CntLbl.Size = new Size(146, 17);
            CntLbl.TabIndex = 6;
            CntLbl.Text = "Количество на складе";
            // 
            // UnitLbl
            // 
            UnitLbl.AutoSize = true;
            UnitLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnitLbl.Location = new Point(20, 167);
            UnitLbl.Name = "UnitLbl";
            UnitLbl.Size = new Size(157, 17);
            UnitLbl.TabIndex = 5;
            UnitLbl.Text = "Единица измерения: шт.";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceLbl.Location = new Point(79, 140);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(42, 17);
            PriceLbl.TabIndex = 4;
            PriceLbl.Text = "label1";
            // 
            // SupLbl
            // 
            SupLbl.AutoSize = true;
            SupLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SupLbl.Location = new Point(20, 106);
            SupLbl.Name = "SupLbl";
            SupLbl.Size = new Size(42, 17);
            SupLbl.TabIndex = 3;
            SupLbl.Text = "label1";
            // 
            // ProdLbl
            // 
            ProdLbl.AutoSize = true;
            ProdLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ProdLbl.Location = new Point(20, 77);
            ProdLbl.Name = "ProdLbl";
            ProdLbl.Size = new Size(42, 17);
            ProdLbl.TabIndex = 2;
            ProdLbl.Text = "label1";
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescLbl.Location = new Point(20, 50);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(42, 17);
            DescLbl.TabIndex = 1;
            DescLbl.Text = "label1";
            // 
            // FullNameLbl
            // 
            FullNameLbl.AutoSize = true;
            FullNameLbl.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FullNameLbl.Location = new Point(20, 17);
            FullNameLbl.Name = "FullNameLbl";
            FullNameLbl.Size = new Size(55, 20);
            FullNameLbl.TabIndex = 0;
            FullNameLbl.Text = "label1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(DiscLbl);
            panel2.Location = new Point(966, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(123, 236);
            panel2.TabIndex = 0;
            // 
            // DiscLbl
            // 
            DiscLbl.AutoSize = true;
            DiscLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DiscLbl.Location = new Point(44, 106);
            DiscLbl.Name = "DiscLbl";
            DiscLbl.Size = new Size(42, 17);
            DiscLbl.TabIndex = 7;
            DiscLbl.Text = "label1";
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductUserControl";
            Size = new Size(1100, 250);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;

        private PictureBox PictureBox;

        private Label FullNameLbl;
        private Label DescLbl;
        private Label ProdLbl;
        private Label SupLbl;
        private Label PriceLbl;
        private Label UnitLbl;
        private Label CntLbl;
        private Label DiscLbl;
        private Label NewPriceLbl;
        private Label label2;

    }
}
