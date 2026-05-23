namespace ShoesStoreProject.Forms
{
    partial class AddEditOrderForm
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
            panel1 = new Panel();
            DeliveryDatePicker = new DateTimePicker();
            label5 = new Label();
            OrderDatePicker = new DateTimePicker();
            label4 = new Label();
            AddressesCB = new ComboBox();
            label3 = new Label();
            StatusCB = new ComboBox();
            label2 = new Label();
            ArticleLbl = new TextBox();
            panel2 = new Panel();
            SveBtn = new Button();
            TitleLbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 0;
            label1.Text = "Артикул:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DeliveryDatePicker);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(OrderDatePicker);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AddressesCB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(StatusCB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ArticleLbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 267);
            panel1.TabIndex = 1;
            // 
            // DeliveryDatePicker
            // 
            DeliveryDatePicker.Location = new Point(283, 215);
            DeliveryDatePicker.Name = "DeliveryDatePicker";
            DeliveryDatePicker.Size = new Size(255, 27);
            DeliveryDatePicker.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(283, 195);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 8;
            label5.Text = "Дата доставки:";
            // 
            // OrderDatePicker
            // 
            OrderDatePicker.Location = new Point(22, 215);
            OrderDatePicker.Name = "OrderDatePicker";
            OrderDatePicker.Size = new Size(255, 27);
            OrderDatePicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(22, 195);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 6;
            label4.Text = "Дата заказа:";
            // 
            // AddressesCB
            // 
            AddressesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AddressesCB.FormattingEnabled = true;
            AddressesCB.Location = new Point(22, 156);
            AddressesCB.Name = "AddressesCB";
            AddressesCB.Size = new Size(515, 28);
            AddressesCB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 136);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 4;
            label3.Text = "Адрес:";
            // 
            // StatusCB
            // 
            StatusCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Новый", "Завершён" });
            StatusCB.Location = new Point(20, 92);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(518, 28);
            StatusCB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "Статус:";
            // 
            // ArticleLbl
            // 
            ArticleLbl.Location = new Point(23, 36);
            ArticleLbl.Name = "ArticleLbl";
            ArticleLbl.Size = new Size(515, 27);
            ArticleLbl.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(SveBtn);
            panel2.Location = new Point(12, 329);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 68);
            panel2.TabIndex = 2;
            // 
            // SveBtn
            // 
            SveBtn.Location = new Point(402, 22);
            SveBtn.Name = "SveBtn";
            SveBtn.Size = new Size(136, 29);
            SveBtn.TabIndex = 0;
            SveBtn.Text = "Сохранить";
            SveBtn.UseVisualStyleBackColor = true;
            SveBtn.Click += SveBtn_Click;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TitleLbl.Location = new Point(12, 20);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(55, 20);
            TitleLbl.TabIndex = 3;
            TitleLbl.Text = "label6";
            // 
            // AddEditOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 408);
            Controls.Add(TitleLbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddEditOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DateTimePicker DeliveryDatePicker;
        private Label label5;
        private DateTimePicker OrderDatePicker;
        private Label label4;
        private ComboBox AddressesCB;
        private Label label3;
        private ComboBox StatusCB;
        private Label label2;
        private TextBox ArticleLbl;
        private Panel panel2;
        private Button SveBtn;
        private Label TitleLbl;
    }
}