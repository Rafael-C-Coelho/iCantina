namespace iCantina.views
{
    partial class Menus
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.cmbBoxDishType = new System.Windows.Forms.ComboBox();
            this.lblDishType = new System.Windows.Forms.Label();
            this.lblMeatDish = new System.Windows.Forms.Label();
            this.cmbBoxMeatDish = new System.Windows.Forms.ComboBox();
            this.lblFishDish = new System.Windows.Forms.Label();
            this.cmbBoxFishDish = new System.Windows.Forms.ComboBox();
            this.lblVegetarianDish = new System.Windows.Forms.Label();
            this.cmbBoxVegetarianDish = new System.Windows.Forms.ComboBox();
            this.chBoxMeatNotAvailable = new System.Windows.Forms.CheckBox();
            this.chBoxFishNotAvailable = new System.Windows.Forms.CheckBox();
            this.chBoxVegetarianNotAvailable = new System.Windows.Forms.CheckBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.chListBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(24, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(77, 29);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // cmbBoxDishType
            // 
            this.cmbBoxDishType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDishType.FormattingEnabled = true;
            this.cmbBoxDishType.Items.AddRange(new object[] {
            "Almoço ",
            "Jantar"});
            this.cmbBoxDishType.Location = new System.Drawing.Point(29, 73);
            this.cmbBoxDishType.Name = "cmbBoxDishType";
            this.cmbBoxDishType.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxDishType.TabIndex = 1;
            // 
            // lblDishType
            // 
            this.lblDishType.AutoSize = true;
            this.lblDishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishType.Location = new System.Drawing.Point(25, 50);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(185, 20);
            this.lblDishType.TabIndex = 2;
            this.lblDishType.Text = "Select the type of meal:";
            // 
            // lblMeatDish
            // 
            this.lblMeatDish.AutoSize = true;
            this.lblMeatDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeatDish.Location = new System.Drawing.Point(25, 121);
            this.lblMeatDish.Name = "lblMeatDish";
            this.lblMeatDish.Size = new System.Drawing.Size(95, 20);
            this.lblMeatDish.TabIndex = 3;
            this.lblMeatDish.Text = "Meat Dish";
            // 
            // cmbBoxMeatDish
            // 
            this.cmbBoxMeatDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMeatDish.FormattingEnabled = true;
            this.cmbBoxMeatDish.Location = new System.Drawing.Point(29, 144);
            this.cmbBoxMeatDish.Name = "cmbBoxMeatDish";
            this.cmbBoxMeatDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxMeatDish.TabIndex = 4;
            // 
            // lblFishDish
            // 
            this.lblFishDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFishDish.AutoSize = true;
            this.lblFishDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishDish.Location = new System.Drawing.Point(25, 220);
            this.lblFishDish.Name = "lblFishDish";
            this.lblFishDish.Size = new System.Drawing.Size(90, 20);
            this.lblFishDish.TabIndex = 5;
            this.lblFishDish.Text = "Fish Dish";
            // 
            // cmbBoxFishDish
            // 
            this.cmbBoxFishDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBoxFishDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFishDish.FormattingEnabled = true;
            this.cmbBoxFishDish.Location = new System.Drawing.Point(29, 243);
            this.cmbBoxFishDish.Name = "cmbBoxFishDish";
            this.cmbBoxFishDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxFishDish.TabIndex = 6;
            // 
            // lblVegetarianDish
            // 
            this.lblVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVegetarianDish.AutoSize = true;
            this.lblVegetarianDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVegetarianDish.Location = new System.Drawing.Point(25, 314);
            this.lblVegetarianDish.Name = "lblVegetarianDish";
            this.lblVegetarianDish.Size = new System.Drawing.Size(144, 20);
            this.lblVegetarianDish.TabIndex = 7;
            this.lblVegetarianDish.Text = "Vegetarian Dish";
            // 
            // cmbBoxVegetarianDish
            // 
            this.cmbBoxVegetarianDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBoxVegetarianDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxVegetarianDish.FormattingEnabled = true;
            this.cmbBoxVegetarianDish.Location = new System.Drawing.Point(29, 337);
            this.cmbBoxVegetarianDish.Name = "cmbBoxVegetarianDish";
            this.cmbBoxVegetarianDish.Size = new System.Drawing.Size(437, 24);
            this.cmbBoxVegetarianDish.TabIndex = 8;
            // 
            // chBoxMeatNotAvailable
            // 
            this.chBoxMeatNotAvailable.AutoSize = true;
            this.chBoxMeatNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxMeatNotAvailable.Location = new System.Drawing.Point(29, 174);
            this.chBoxMeatNotAvailable.Name = "chBoxMeatNotAvailable";
            this.chBoxMeatNotAvailable.Size = new System.Drawing.Size(129, 24);
            this.chBoxMeatNotAvailable.TabIndex = 9;
            this.chBoxMeatNotAvailable.Text = "Not Available";
            this.chBoxMeatNotAvailable.UseVisualStyleBackColor = true;
            // 
            // chBoxFishNotAvailable
            // 
            this.chBoxFishNotAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBoxFishNotAvailable.AutoSize = true;
            this.chBoxFishNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxFishNotAvailable.Location = new System.Drawing.Point(29, 273);
            this.chBoxFishNotAvailable.Name = "chBoxFishNotAvailable";
            this.chBoxFishNotAvailable.Size = new System.Drawing.Size(129, 24);
            this.chBoxFishNotAvailable.TabIndex = 10;
            this.chBoxFishNotAvailable.Text = "Not Available";
            this.chBoxFishNotAvailable.UseVisualStyleBackColor = true;
            // 
            // chBoxVegetarianNotAvailable
            // 
            this.chBoxVegetarianNotAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBoxVegetarianNotAvailable.AutoSize = true;
            this.chBoxVegetarianNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxVegetarianNotAvailable.Location = new System.Drawing.Point(29, 367);
            this.chBoxVegetarianNotAvailable.Name = "chBoxVegetarianNotAvailable";
            this.chBoxVegetarianNotAvailable.Size = new System.Drawing.Size(129, 24);
            this.chBoxVegetarianNotAvailable.TabIndex = 11;
            this.chBoxVegetarianNotAvailable.Text = "Not Available";
            this.chBoxVegetarianNotAvailable.UseVisualStyleBackColor = true;
            // 
            // lblExtras
            // 
            this.lblExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(496, 247);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(63, 20);
            this.lblExtras.TabIndex = 12;
            this.lblExtras.Text = "Extras";
            // 
            // chListBoxExtras
            // 
            this.chListBoxExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chListBoxExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chListBoxExtras.FormattingEnabled = true;
            this.chListBoxExtras.Items.AddRange(new object[] {
            "Extra 1",
            "Extra 2",
            "Extra 3"});
            this.chListBoxExtras.Location = new System.Drawing.Point(500, 270);
            this.chListBoxExtras.Name = "chListBoxExtras";
            this.chListBoxExtras.Size = new System.Drawing.Size(111, 136);
            this.chListBoxExtras.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(500, 18);
            this.monthCalendar1.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 416);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.chListBoxExtras);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.chBoxVegetarianNotAvailable);
            this.Controls.Add(this.chBoxFishNotAvailable);
            this.Controls.Add(this.chBoxMeatNotAvailable);
            this.Controls.Add(this.cmbBoxVegetarianDish);
            this.Controls.Add(this.lblVegetarianDish);
            this.Controls.Add(this.cmbBoxFishDish);
            this.Controls.Add(this.lblFishDish);
            this.Controls.Add(this.cmbBoxMeatDish);
            this.Controls.Add(this.lblMeatDish);
            this.Controls.Add(this.lblDishType);
            this.Controls.Add(this.cmbBoxDishType);
            this.Controls.Add(this.lblMenu);
            this.Name = "Menus";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox cmbBoxDishType;
        private System.Windows.Forms.Label lblDishType;
        private System.Windows.Forms.Label lblMeatDish;
        private System.Windows.Forms.ComboBox cmbBoxMeatDish;
        private System.Windows.Forms.Label lblFishDish;
        private System.Windows.Forms.ComboBox cmbBoxFishDish;
        private System.Windows.Forms.Label lblVegetarianDish;
        private System.Windows.Forms.ComboBox cmbBoxVegetarianDish;
        private System.Windows.Forms.CheckBox chBoxMeatNotAvailable;
        private System.Windows.Forms.CheckBox chBoxFishNotAvailable;
        private System.Windows.Forms.CheckBox chBoxVegetarianNotAvailable;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.CheckedListBox chListBoxExtras;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}