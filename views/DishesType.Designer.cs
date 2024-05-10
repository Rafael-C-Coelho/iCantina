﻿namespace iCantina.views
{
    partial class DishesType
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
            this.lblMeatDish = new System.Windows.Forms.Label();
            this.lblTypeDish = new System.Windows.Forms.Label();
            this.rdoBtnMeat = new System.Windows.Forms.RadioButton();
            this.rdoBtnFish = new System.Windows.Forms.RadioButton();
            this.rdoBtnVegetarian = new System.Windows.Forms.RadioButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.chBoxActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMeatDish
            // 
            this.lblMeatDish.AutoSize = true;
            this.lblMeatDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeatDish.Location = new System.Drawing.Point(107, 118);
            this.lblMeatDish.Name = "lblMeatDish";
            this.lblMeatDish.Size = new System.Drawing.Size(0, 20);
            this.lblMeatDish.TabIndex = 18;
            // 
            // lblTypeDish
            // 
            this.lblTypeDish.AutoSize = true;
            this.lblTypeDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDish.Location = new System.Drawing.Point(43, 53);
            this.lblTypeDish.Name = "lblTypeDish";
            this.lblTypeDish.Size = new System.Drawing.Size(184, 32);
            this.lblTypeDish.TabIndex = 17;
            this.lblTypeDish.Text = "Type of Dish";
            // 
            // rdoBtnMeat
            // 
            this.rdoBtnMeat.AutoSize = true;
            this.rdoBtnMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnMeat.Location = new System.Drawing.Point(49, 119);
            this.rdoBtnMeat.Name = "rdoBtnMeat";
            this.rdoBtnMeat.Size = new System.Drawing.Size(71, 24);
            this.rdoBtnMeat.TabIndex = 24;
            this.rdoBtnMeat.TabStop = true;
            this.rdoBtnMeat.Text = "Meat";
            this.rdoBtnMeat.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFish
            // 
            this.rdoBtnFish.AutoSize = true;
            this.rdoBtnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnFish.Location = new System.Drawing.Point(179, 119);
            this.rdoBtnFish.Name = "rdoBtnFish";
            this.rdoBtnFish.Size = new System.Drawing.Size(66, 24);
            this.rdoBtnFish.TabIndex = 25;
            this.rdoBtnFish.TabStop = true;
            this.rdoBtnFish.Text = "Fish";
            this.rdoBtnFish.UseVisualStyleBackColor = true;
            // 
            // rdoBtnVegetarian
            // 
            this.rdoBtnVegetarian.AutoSize = true;
            this.rdoBtnVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnVegetarian.Location = new System.Drawing.Point(296, 118);
            this.rdoBtnVegetarian.Name = "rdoBtnVegetarian";
            this.rdoBtnVegetarian.Size = new System.Drawing.Size(120, 24);
            this.rdoBtnVegetarian.TabIndex = 26;
            this.rdoBtnVegetarian.TabStop = true;
            this.rdoBtnVegetarian.Text = "Vegetarian";
            this.rdoBtnVegetarian.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 146);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 20);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(236, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(49, 169);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(459, 137);
            this.txtBoxDescription.TabIndex = 29;
            // 
            // chBoxActive
            // 
            this.chBoxActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBoxActive.AutoSize = true;
            this.chBoxActive.Checked = true;
            this.chBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxActive.Location = new System.Drawing.Point(49, 312);
            this.chBoxActive.Name = "chBoxActive";
            this.chBoxActive.Size = new System.Drawing.Size(77, 24);
            this.chBoxActive.TabIndex = 30;
            this.chBoxActive.Text = "Active";
            this.chBoxActive.UseVisualStyleBackColor = true;
            // 
            // DishesType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.chBoxActive);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rdoBtnVegetarian);
            this.Controls.Add(this.rdoBtnFish);
            this.Controls.Add(this.rdoBtnMeat);
            this.Controls.Add(this.lblMeatDish);
            this.Controls.Add(this.lblTypeDish);
            this.Name = "DishesType";
            this.Text = "DishesType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMeatDish;
        private System.Windows.Forms.Label lblTypeDish;
        private System.Windows.Forms.RadioButton rdoBtnMeat;
        private System.Windows.Forms.RadioButton rdoBtnFish;
        private System.Windows.Forms.RadioButton rdoBtnVegetarian;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.CheckBox chBoxActive;
    }
}