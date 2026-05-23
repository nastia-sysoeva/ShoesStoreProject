namespace ShoesStoreProject.Forms
{
    partial class ProductsForm
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
            UserNameLbl = new Label();
            panel1 = new Panel();
            FlowLayoutPanel = new FlowLayoutPanel();
            AdminMngrPanel = new Panel();
            OrdersBtn = new Button();
            SearchTB = new TextBox();
            AddBtn = new Button();
            FilterCB = new ComboBox();
            label3 = new Label();
            SortCB = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            AdminMngrPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Dock = DockStyle.Right;
            UserNameLbl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserNameLbl.Location = new Point(331, 0);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.RightToLeft = RightToLeft.No;
            UserNameLbl.Size = new Size(41, 17);
            UserNameLbl.TabIndex = 0;
            UserNameLbl.Text = "ФИО";
            UserNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            UserNameLbl.Click += UserNameLbl_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(UserNameLbl);
            panel1.Location = new Point(783, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 23);
            panel1.TabIndex = 1;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.AutoScroll = true;
            FlowLayoutPanel.Location = new Point(12, 133);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(1158, 608);
            FlowLayoutPanel.TabIndex = 2;
            // 
            // AdminMngrPanel
            // 
            AdminMngrPanel.Controls.Add(OrdersBtn);
            AdminMngrPanel.Controls.Add(SearchTB);
            AdminMngrPanel.Controls.Add(AddBtn);
            AdminMngrPanel.Controls.Add(FilterCB);
            AdminMngrPanel.Controls.Add(label3);
            AdminMngrPanel.Controls.Add(SortCB);
            AdminMngrPanel.Controls.Add(label2);
            AdminMngrPanel.Controls.Add(label1);
            AdminMngrPanel.Location = new Point(12, 72);
            AdminMngrPanel.Name = "AdminMngrPanel";
            AdminMngrPanel.Size = new Size(1158, 55);
            AdminMngrPanel.TabIndex = 3;
            // 
            // OrdersBtn
            // 
            OrdersBtn.Location = new Point(1007, 14);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Size = new Size(133, 29);
            OrdersBtn.TabIndex = 9;
            OrdersBtn.Text = "Заказы";
            OrdersBtn.UseVisualStyleBackColor = true;
            OrdersBtn.Click += OrdersBtn_Click;
            // 
            // SearchTB
            // 
            SearchTB.Location = new Point(80, 16);
            SearchTB.Name = "SearchTB";
            SearchTB.Size = new Size(151, 27);
            SearchTB.TabIndex = 3;
            SearchTB.TextChanged += SearchTB_TextChanged;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(858, 14);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(133, 29);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Добавить товар";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Visible = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // FilterCB
            // 
            FilterCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterCB.FormattingEnabled = true;
            FilterCB.Items.AddRange(new object[] { "Все поставщики", "Kari", "Обувь для вас" });
            FilterCB.Location = new Point(604, 15);
            FilterCB.Name = "FilterCB";
            FilterCB.Size = new Size(151, 28);
            FilterCB.TabIndex = 7;
            FilterCB.SelectedIndexChanged += FilterCB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(517, 21);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(84, 17);
            label3.TabIndex = 6;
            label3.Text = "Фильтрация:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortCB
            // 
            SortCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SortCB.FormattingEnabled = true;
            SortCB.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            SortCB.Location = new Point(342, 15);
            SortCB.Name = "SortCB";
            SortCB.Size = new Size(151, 28);
            SortCB.TabIndex = 5;
            SortCB.SelectedIndexChanged += SortCB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(255, 21);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(84, 17);
            label2.TabIndex = 4;
            label2.Text = "Сортировка:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(50, 17);
            label1.TabIndex = 2;
            label1.Text = "Поиск:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1158, 54);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(517, 16);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 3;
            label4.Text = "Список товаров";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(24, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 17);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Назад";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(AdminMngrPanel);
            Controls.Add(FlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AdminMngrPanel.ResumeLayout(false);
            AdminMngrPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label UserNameLbl;
        private Panel panel1;
        private FlowLayoutPanel FlowLayoutPanel;
        private Panel AdminMngrPanel;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private ComboBox FilterCB;
        private Label label3;
        private ComboBox SortCB;
        private Label label2;
        private TextBox SearchTB;
        private Label label1;
        private Button AddBtn;
        private Button OrdersBtn;
        private Label label4;
    }
}