namespace ShoesStoreProject.Forms
{
    partial class OrdersForm
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
            AddBtn = new Button();
            BackLink = new LinkLabel();
            FlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(BackLink);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 69);
            panel1.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(982, 21);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(154, 29);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Добавить заказ";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // BackLink
            // 
            BackLink.AutoSize = true;
            BackLink.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackLink.LinkColor = Color.Black;
            BackLink.Location = new Point(30, 28);
            BackLink.Name = "BackLink";
            BackLink.Size = new Size(47, 17);
            BackLink.TabIndex = 0;
            BackLink.TabStop = true;
            BackLink.Text = "Назад";
            BackLink.LinkClicked += BackLink_LinkClicked;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.AutoScroll = true;
            FlowLayoutPanel.Location = new Point(12, 87);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(1158, 654);
            FlowLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(520, 28);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 2;
            label1.Text = "Список заказов";
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(FlowLayoutPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddBtn;
        private LinkLabel BackLink;
        private FlowLayoutPanel FlowLayoutPanel;
        private Label label1;
    }
}