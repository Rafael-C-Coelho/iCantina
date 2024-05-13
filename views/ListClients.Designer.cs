namespace iCantina.views
{
  partial class ListClients
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
			this.lblClient = new System.Windows.Forms.Label();
			this.lstBoxClients = new System.Windows.Forms.ListBox();
			this.txtBoxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.timerDataSourceListBox = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblClient
			// 
			this.lblClient.AutoSize = true;
			this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClient.Location = new System.Drawing.Point(11, 9);
			this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(74, 26);
			this.lblClient.TabIndex = 19;
			this.lblClient.Text = "Client";
			this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstBoxClients
			// 
			this.lstBoxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBoxClients.FormattingEnabled = true;
			this.lstBoxClients.Location = new System.Drawing.Point(16, 82);
			this.lstBoxClients.Name = "lstBoxClients";
			this.lstBoxClients.Size = new System.Drawing.Size(384, 225);
			this.lstBoxClients.TabIndex = 20;
			this.lstBoxClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxClients_MouseDoubleClick);
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxSearch.Location = new System.Drawing.Point(16, 56);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(384, 20);
			this.txtBoxSearch.TabIndex = 21;
			this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(13, 40);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(41, 13);
			this.lblSearch.TabIndex = 22;
			this.lblSearch.Text = "Search";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(325, 9);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 23;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// timerDataSourceListBox
			// 
			this.timerDataSourceListBox.Enabled = true;
			this.timerDataSourceListBox.Interval = 1000;
			this.timerDataSourceListBox.Tick += new System.EventHandler(this.timerDataSourceListBox_Tick);
			// 
			// ListClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 323);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.lstBoxClients);
			this.Controls.Add(this.lblClient);
			this.Name = "ListClients";
			this.Text = "ListClients";
			this.Load += new System.EventHandler(this.ListClients_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblClient;
    private System.Windows.Forms.ListBox lstBoxClients;
    private System.Windows.Forms.TextBox txtBoxSearch;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Timer timerDataSourceListBox;
  }
}
