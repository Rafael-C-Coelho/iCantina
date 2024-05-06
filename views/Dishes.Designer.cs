namespace iCantina.views
{
    partial class Dishes
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
            this.lblAvailableDishes = new System.Windows.Forms.Label();
            this.lblMeatDish = new System.Windows.Forms.Label();
            this.cmbBoxMeatDish = new System.Windows.Forms.ComboBox();
            this.lblFishDish = new System.Windows.Forms.Label();
            this.cmbBoxFishDish = new System.Windows.Forms.ComboBox();
            this.lblVegetarianDish = new System.Windows.Forms.Label();
            this.cmbBoxVegetarianDish = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAvailableDishes
            // 
            this.lblAvailableDishes.AutoSize = true;
            this.lblAvailableDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableDishes.Location = new System.Drawing.Point(38, 36);
            this.lblAvailableDishes.Name = "lblAvailableDishes";
            this.lblAvailableDishes.Size = new System.Drawing.Size(207, 29);
            this.lblAvailableDishes.TabIndex = 0;
            this.lblAvailableDishes.Text = "Available Dishes";
            // 
            // lblMeatDish
            // 
            this.lblMeatDish.AutoSize = true;
            this.lblMeatDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeatDish.Location = new System.Drawing.Point(39, 95);
            this.lblMeatDish.Name = "lblMeatDish";
            this.lblMeatDish.Size = new System.Drawing.Size(95, 20);
            this.lblMeatDish.TabIndex = 4;
            this.lblMeatDish.Text = "Meat Dish";
            // 
            // cmbBoxMeatDish
            // 
            this.cmbBoxMeatDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMeatDish.FormattingEnabled = true;
            this.cmbBoxMeatDish.Location = new System.Drawing.Point(43, 118);
            this.cmbBoxMeatDish.Name = "cmbBoxMeatDish";
            this.cmbBoxMeatDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxMeatDish.TabIndex = 5;
            this.cmbBoxMeatDish.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMeatDish_SelectedIndexChanged);
            // 
            // lblFishDish
            // 
            this.lblFishDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFishDish.AutoSize = true;
            this.lblFishDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishDish.Location = new System.Drawing.Point(39, 205);
            this.lblFishDish.Name = "lblFishDish";
            this.lblFishDish.Size = new System.Drawing.Size(90, 20);
            this.lblFishDish.TabIndex = 6;
            this.lblFishDish.Text = "Fish Dish";
            // 
            // cmbBoxFishDish
            // 
            this.cmbBoxFishDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBoxFishDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFishDish.FormattingEnabled = true;
            this.cmbBoxFishDish.Location = new System.Drawing.Point(43, 228);
            this.cmbBoxFishDish.Name = "cmbBoxFishDish";
            this.cmbBoxFishDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxFishDish.TabIndex = 7;
            // 
            // lblVegetarianDish
            // 
            this.lblVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVegetarianDish.AutoSize = true;
            this.lblVegetarianDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVegetarianDish.Location = new System.Drawing.Point(39, 312);
            this.lblVegetarianDish.Name = "lblVegetarianDish";
            this.lblVegetarianDish.Size = new System.Drawing.Size(144, 20);
            this.lblVegetarianDish.TabIndex = 8;
            this.lblVegetarianDish.Text = "Vegetarian Dish";
            // 
            // cmbBoxVegetarianDish
            // 
            this.cmbBoxVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBoxVegetarianDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxVegetarianDish.FormattingEnabled = true;
            this.cmbBoxVegetarianDish.Location = new System.Drawing.Point(43, 335);
            this.cmbBoxVegetarianDish.Name = "cmbBoxVegetarianDish";
            this.cmbBoxVegetarianDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxVegetarianDish.TabIndex = 9;
            // 
            // Dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.cmbBoxVegetarianDish);
            this.Controls.Add(this.lblVegetarianDish);
            this.Controls.Add(this.cmbBoxFishDish);
            this.Controls.Add(this.lblFishDish);
            this.Controls.Add(this.cmbBoxMeatDish);
            this.Controls.Add(this.lblMeatDish);
            this.Controls.Add(this.lblAvailableDishes);
            this.Name = "Dishes";
            this.Text = "Dishes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableDishes;
        private System.Windows.Forms.Label lblMeatDish;
        private System.Windows.Forms.ComboBox cmbBoxMeatDish;
        private System.Windows.Forms.Label lblFishDish;
        private System.Windows.Forms.ComboBox cmbBoxFishDish;
        private System.Windows.Forms.Label lblVegetarianDish;
        private System.Windows.Forms.ComboBox cmbBoxVegetarianDish;
    }
}