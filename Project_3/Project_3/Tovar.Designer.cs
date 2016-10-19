namespace Project_3
{
    partial class Tovar
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
            this.lName = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(118, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(53, 19);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // lCategory
            // 
            this.lCategory.ActiveLinkColor = System.Drawing.Color.Black;
            this.lCategory.AutoSize = true;
            this.lCategory.BackColor = System.Drawing.Color.Transparent;
            this.lCategory.LinkColor = System.Drawing.Color.Black;
            this.lCategory.Location = new System.Drawing.Point(119, 29);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(49, 13);
            this.lCategory.TabIndex = 2;
            this.lCategory.TabStop = true;
            this.lCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ціна:";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbText.Location = new System.Drawing.Point(113, 45);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(277, 70);
            this.tbText.TabIndex = 4;
            // 
            // lPrice
            // 
            this.lPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPrice.BackColor = System.Drawing.Color.Transparent;
            this.lPrice.Location = new System.Drawing.Point(312, 11);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(53, 17);
            this.lPrice.TabIndex = 5;
            this.lPrice.Text = "0.00";
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(363, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "грн.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість: ";
            // 
            // Tovar
            // 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tovar";
            this.Size = new System.Drawing.Size(400, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.LinkLabel lCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
