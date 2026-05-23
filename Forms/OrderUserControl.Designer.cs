namespace ShoesStoreProject.Forms
{
    partial class OrderUserControl
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
            panel3 = new Panel();
            DeliveryDateLbl = new Label();
            panel2 = new Panel();
            OrderDateLbl = new Label();
            AddressLbl = new Label();
            StatusLbl = new Label();
            ArticleLbl = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 144);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(DeliveryDateLbl);
            panel3.Location = new Point(852, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 136);
            panel3.TabIndex = 1;
            // 
            // DeliveryDateLbl
            // 
            DeliveryDateLbl.AutoSize = true;
            DeliveryDateLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeliveryDateLbl.Location = new Point(100, 71);
            DeliveryDateLbl.Name = "DeliveryDateLbl";
            DeliveryDateLbl.Size = new Size(42, 17);
            DeliveryDateLbl.TabIndex = 4;
            DeliveryDateLbl.Text = "label5";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(OrderDateLbl);
            panel2.Controls.Add(AddressLbl);
            panel2.Controls.Add(StatusLbl);
            panel2.Controls.Add(ArticleLbl);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 136);
            panel2.TabIndex = 0;
            // 
            // OrderDateLbl
            // 
            OrderDateLbl.AutoSize = true;
            OrderDateLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderDateLbl.Location = new Point(21, 99);
            OrderDateLbl.Name = "OrderDateLbl";
            OrderDateLbl.Size = new Size(42, 17);
            OrderDateLbl.TabIndex = 3;
            OrderDateLbl.Text = "label4";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLbl.Location = new Point(21, 71);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(42, 17);
            AddressLbl.TabIndex = 2;
            AddressLbl.Text = "label3";
            // 
            // StatusLbl
            // 
            StatusLbl.AutoSize = true;
            StatusLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StatusLbl.Location = new Point(21, 45);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(42, 17);
            StatusLbl.TabIndex = 1;
            StatusLbl.Text = "label2";
            // 
            // ArticleLbl
            // 
            ArticleLbl.AutoSize = true;
            ArticleLbl.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ArticleLbl.Location = new Point(21, 16);
            ArticleLbl.Name = "ArticleLbl";
            ArticleLbl.Size = new Size(55, 20);
            ArticleLbl.TabIndex = 0;
            ArticleLbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(69, 45);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 5;
            label1.Text = "Дата доставки:";
            // 
            // OrderUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderUserControl";
            Size = new Size(1100, 150);
            panel1.ResumeLayout(false);
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
        private Label DeliveryDateLbl;
        private Label OrderDateLbl;
        private Label AddressLbl;
        private Label StatusLbl;
        private Label ArticleLbl;
        private Label label1;
    }
}
