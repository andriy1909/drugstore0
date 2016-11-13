namespace Drugstore
{
    partial class DirectorStarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorStarterForm));
            this.btnContItems = new System.Windows.Forms.Button();
            this.btnContClients = new System.Windows.Forms.Button();
            this.btnContWorkers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContItems
            // 
            this.btnContItems.BackColor = System.Drawing.Color.Transparent;
            this.btnContItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContItems.BackgroundImage")));
            this.btnContItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContItems.FlatAppearance.BorderSize = 0;
            this.btnContItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContItems.Location = new System.Drawing.Point(12, 293);
            this.btnContItems.Name = "btnContItems";
            this.btnContItems.Size = new System.Drawing.Size(167, 50);
            this.btnContItems.TabIndex = 1;
            this.btnContItems.Text = "Керування товарами";
            this.btnContItems.UseVisualStyleBackColor = false;
            this.btnContItems.Click += new System.EventHandler(this.btnContItems_Click);
            // 
            // btnContClients
            // 
            this.btnContClients.BackColor = System.Drawing.Color.Transparent;
            this.btnContClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContClients.BackgroundImage")));
            this.btnContClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContClients.FlatAppearance.BorderSize = 0;
            this.btnContClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContClients.Location = new System.Drawing.Point(12, 349);
            this.btnContClients.Name = "btnContClients";
            this.btnContClients.Size = new System.Drawing.Size(167, 50);
            this.btnContClients.TabIndex = 4;
            this.btnContClients.Text = "Керування клієнтами";
            this.btnContClients.UseVisualStyleBackColor = false;
            this.btnContClients.Click += new System.EventHandler(this.btnContClients_Click);
            // 
            // btnContWorkers
            // 
            this.btnContWorkers.BackColor = System.Drawing.Color.Transparent;
            this.btnContWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContWorkers.BackgroundImage")));
            this.btnContWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContWorkers.FlatAppearance.BorderSize = 0;
            this.btnContWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContWorkers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContWorkers.Location = new System.Drawing.Point(12, 237);
            this.btnContWorkers.Name = "btnContWorkers";
            this.btnContWorkers.Size = new System.Drawing.Size(167, 50);
            this.btnContWorkers.TabIndex = 5;
            this.btnContWorkers.Text = "Керування працівниками";
            this.btnContWorkers.UseVisualStyleBackColor = false;
            this.btnContWorkers.Click += new System.EventHandler(this.btnContWorkers_Click);
            // 
            // DirectorStarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Drugstore.Properties.Resources.StartImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnContWorkers);
            this.Controls.Add(this.btnContClients);
            this.Controls.Add(this.btnContItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorStarterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Стартова сторінка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContItems;
        private System.Windows.Forms.Button btnContClients;
        private System.Windows.Forms.Button btnContWorkers;
    }
}