namespace iCantina.views
{
    partial class ListDishes
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
            this.components = new System.ComponentModel.Container();
            this.lblDishes = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearchDishes = new System.Windows.Forms.TextBox();
            this.lstBoxDishes = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.timerDataSourceLstBoxDishes = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDishes
            // 
            this.lblDishes.AutoSize = true;
            this.lblDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishes.Location = new System.Drawing.Point(29, 9);
            this.lblDishes.Name = "lblDishes";
            this.lblDishes.Size = new System.Drawing.Size(107, 32);
            this.lblDishes.TabIndex = 0;
            this.lblDishes.Text = "Dishes";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(31, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtBoxSearchDishes
            // 
            this.txtBoxSearchDishes.Location = new System.Drawing.Point(35, 77);
            this.txtBoxSearchDishes.Name = "txtBoxSearchDishes";
            this.txtBoxSearchDishes.Size = new System.Drawing.Size(453, 22);
            this.txtBoxSearchDishes.TabIndex = 2;
            this.txtBoxSearchDishes.TextChanged += new System.EventHandler(this.txtBoxSearchDishes_TextChanged);
            // 
            // lstBoxDishes
            // 
            this.lstBoxDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxDishes.FormattingEnabled = true;
            this.lstBoxDishes.ItemHeight = 16;
            this.lstBoxDishes.Location = new System.Drawing.Point(35, 127);
            this.lstBoxDishes.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxDishes.Name = "lstBoxDishes";
            this.lstBoxDishes.Size = new System.Drawing.Size(453, 244);
            this.lstBoxDishes.TabIndex = 21;
            this.lstBoxDishes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxDishes_MouseDoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(388, 15);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // timerDataSourceLstBoxDishes
            // 
            this.timerDataSourceLstBoxDishes.Enabled = true;
            this.timerDataSourceLstBoxDishes.Interval = 1000;
            this.timerDataSourceLstBoxDishes.Tick += new System.EventHandler(this.timerDataSourceLstBoxDishes_Tick);
            // 
            // Dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 395);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstBoxDishes);
            this.Controls.Add(this.txtBoxSearchDishes);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDishes);
            this.Name = "Dishes";
            this.Text = "Dishes";
            this.Load += new System.EventHandler(this.Dishes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDishes;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearchDishes;
        private System.Windows.Forms.ListBox lstBoxDishes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Timer timerDataSourceLstBoxDishes;
    }
}