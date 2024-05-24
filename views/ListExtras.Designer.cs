namespace iCantina.views
{
  partial class ListExtras
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.lstBoxExtras = new System.Windows.Forms.ListBox();
			this.txtBoxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblDishes = new System.Windows.Forms.Label();
			this.timerDataSourceLstBoxExtras = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Location = new System.Drawing.Point(298, 22);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 29;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lstBoxExtras
			// 
			this.lstBoxExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBoxExtras.FormattingEnabled = true;
			this.lstBoxExtras.Location = new System.Drawing.Point(33, 113);
			this.lstBoxExtras.Name = "lstBoxExtras";
			this.lstBoxExtras.Size = new System.Drawing.Size(341, 186);
			this.lstBoxExtras.TabIndex = 28;
			this.lstBoxExtras.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxExtras_DoubleClick);
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Location = new System.Drawing.Point(33, 73);
			this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(341, 20);
			this.txtBoxSearch.TabIndex = 27;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(30, 54);
			this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(59, 17);
			this.lblSearch.TabIndex = 26;
			this.lblSearch.Text = "Search";
			// 
			// lblDishes
			// 
			this.lblDishes.AutoSize = true;
			this.lblDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDishes.Location = new System.Drawing.Point(29, 17);
			this.lblDishes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDishes.Name = "lblDishes";
			this.lblDishes.Size = new System.Drawing.Size(80, 26);
			this.lblDishes.TabIndex = 25;
			this.lblDishes.Text = "Extras";
			// 
			// timerDataSourceLstBoxExtras
			// 
			this.timerDataSourceLstBoxExtras.Enabled = true;
			this.timerDataSourceLstBoxExtras.Interval = 1000;
			this.timerDataSourceLstBoxExtras.Tick += new System.EventHandler(this.timerDataSourceLstBoxExtras_Tick);
			// 
			// ListExtras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 328);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.lstBoxExtras);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.lblDishes);
			this.Name = "ListExtras";
			this.Text = "ListExtras";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.ListBox lstBoxExtras;
    private System.Windows.Forms.TextBox txtBoxSearch;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.Label lblDishes;
    private System.Windows.Forms.Timer timerDataSourceLstBoxExtras;
  }
}