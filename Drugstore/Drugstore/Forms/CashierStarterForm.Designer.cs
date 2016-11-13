namespace Drugstore
{
    partial class CashierStarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierStarterForm));
            this.btnViewItem = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewItem
            // 
            this.btnViewItem.BackColor = System.Drawing.Color.Transparent;
            this.btnViewItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewItem.BackgroundImage")));
            this.btnViewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewItem.FlatAppearance.BorderSize = 0;
            this.btnViewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewItem.Location = new System.Drawing.Point(12, 293);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(160, 50);
            this.btnViewItem.TabIndex = 1;
            this.btnViewItem.Text = "Переглянути список товарів";
            this.btnViewItem.UseVisualStyleBackColor = false;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSell.BackgroundImage")));
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSell.Location = new System.Drawing.Point(12, 349);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(160, 50);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Продаж товарів";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // CashierStarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Drugstore.Properties.Resources.StartImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnViewItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashierStarterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Стартова сторінка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Button btnSell;
    }
}