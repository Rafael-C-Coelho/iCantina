namespace iCantina.views
{
    partial class DishDetails
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
			this.lblDish = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.rdoBtnFish = new System.Windows.Forms.RadioButton();
			this.rdoBtnMeat = new System.Windows.Forms.RadioButton();
			this.txtBoxName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblType = new System.Windows.Forms.Label();
			this.rdobtnVegetarian = new System.Windows.Forms.RadioButton();
			this.txtBoxDescription = new System.Windows.Forms.TextBox();
			this.chBoxActive = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDish
			// 
			this.lblDish.AutoSize = true;
			this.lblDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDish.Location = new System.Drawing.Point(56, 7);
			this.lblDish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDish.Name = "lblDish";
			this.lblDish.Size = new System.Drawing.Size(60, 26);
			this.lblDish.TabIndex = 0;
			this.lblDish.Text = "Dish";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(58, 114);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(95, 17);
			this.lblDescription.TabIndex = 51;
			this.lblDescription.Text = "Description:";
			// 
			// rdoBtnFish
			// 
			this.rdoBtnFish.AutoSize = true;
			this.rdoBtnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoBtnFish.Location = new System.Drawing.Point(171, 83);
			this.rdoBtnFish.Margin = new System.Windows.Forms.Padding(2);
			this.rdoBtnFish.Name = "rdoBtnFish";
			this.rdoBtnFish.Size = new System.Drawing.Size(56, 21);
			this.rdoBtnFish.TabIndex = 48;
			this.rdoBtnFish.TabStop = true;
			this.rdoBtnFish.Text = "Fish";
			this.rdoBtnFish.UseVisualStyleBackColor = true;
			// 
			// rdoBtnMeat
			// 
			this.rdoBtnMeat.AutoSize = true;
			this.rdoBtnMeat.Checked = true;
			this.rdoBtnMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoBtnMeat.Location = new System.Drawing.Point(106, 83);
			this.rdoBtnMeat.Margin = new System.Windows.Forms.Padding(2);
			this.rdoBtnMeat.Name = "rdoBtnMeat";
			this.rdoBtnMeat.Size = new System.Drawing.Size(61, 21);
			this.rdoBtnMeat.TabIndex = 47;
			this.rdoBtnMeat.TabStop = true;
			this.rdoBtnMeat.Text = "Meat";
			this.rdoBtnMeat.UseVisualStyleBackColor = true;
			// 
			// txtBoxName
			// 
			this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxName.Location = new System.Drawing.Point(106, 54);
			this.txtBoxName.Name = "txtBoxName";
			this.txtBoxName.Size = new System.Drawing.Size(438, 20);
			this.txtBoxName.TabIndex = 42;
			this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(58, 54);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 17);
			this.lblName.TabIndex = 41;
			this.lblName.Text = "Name";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCreate, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 190);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 30);
			this.tableLayoutPanel1.TabIndex = 40;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(401, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(196, 24);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(202, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(193, 24);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(193, 24);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.Location = new System.Drawing.Point(58, 85);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(44, 17);
			this.lblType.TabIndex = 45;
			this.lblType.Text = "Type";
			// 
			// rdobtnVegetarian
			// 
			this.rdobtnVegetarian.AutoSize = true;
			this.rdobtnVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdobtnVegetarian.Location = new System.Drawing.Point(231, 83);
			this.rdobtnVegetarian.Margin = new System.Windows.Forms.Padding(2);
			this.rdobtnVegetarian.Name = "rdobtnVegetarian";
			this.rdobtnVegetarian.Size = new System.Drawing.Size(105, 21);
			this.rdobtnVegetarian.TabIndex = 53;
			this.rdobtnVegetarian.TabStop = true;
			this.rdobtnVegetarian.Text = "Vegetarian";
			this.rdobtnVegetarian.UseVisualStyleBackColor = true;
			// 
			// txtBoxDescription
			// 
			this.txtBoxDescription.Location = new System.Drawing.Point(61, 134);
			this.txtBoxDescription.Name = "txtBoxDescription";
			this.txtBoxDescription.Size = new System.Drawing.Size(483, 20);
			this.txtBoxDescription.TabIndex = 54;
			this.txtBoxDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// chBoxActive
			// 
			this.chBoxActive.AutoSize = true;
			this.chBoxActive.Checked = true;
			this.chBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chBoxActive.Location = new System.Drawing.Point(61, 161);
			this.chBoxActive.Name = "chBoxActive";
			this.chBoxActive.Size = new System.Drawing.Size(56, 17);
			this.chBoxActive.TabIndex = 55;
			this.chBoxActive.Text = "Active";
			this.chBoxActive.UseVisualStyleBackColor = true;
			// 
			// DishDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 220);
			this.Controls.Add(this.chBoxActive);
			this.Controls.Add(this.txtBoxDescription);
			this.Controls.Add(this.rdobtnVegetarian);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.rdoBtnFish);
			this.Controls.Add(this.rdoBtnMeat);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.txtBoxName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblDish);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "DishDetails";
			this.Text = "CreateDishes";
			this.Load += new System.EventHandler(this.CreateDishes_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDish;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rdoBtnFish;
        private System.Windows.Forms.RadioButton rdoBtnMeat;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rdobtnVegetarian;
    private System.Windows.Forms.TextBox txtBoxDescription;
    private System.Windows.Forms.CheckBox chBoxActive;
  }
}