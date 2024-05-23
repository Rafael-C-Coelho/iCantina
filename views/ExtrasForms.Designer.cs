namespace iCantina.views
{
    partial class ExtrasForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExtras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescriptionExtras = new System.Windows.Forms.TextBox();
            this.textBoxPriceExtras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxActiveExtras = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extras";
            // 
            // buttonExtras
            // 
            this.buttonExtras.Location = new System.Drawing.Point(335, 621);
            this.buttonExtras.Name = "buttonExtras";
            this.buttonExtras.Size = new System.Drawing.Size(220, 55);
            this.buttonExtras.TabIndex = 2;
            this.buttonExtras.Text = "Submit";
            this.buttonExtras.UseVisualStyleBackColor = true;
            this.buttonExtras.Click += new System.EventHandler(this.buttonExtras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // textBoxDescriptionExtras
            // 
            this.textBoxDescriptionExtras.Location = new System.Drawing.Point(217, 212);
            this.textBoxDescriptionExtras.Name = "textBoxDescriptionExtras";
            this.textBoxDescriptionExtras.Size = new System.Drawing.Size(518, 31);
            this.textBoxDescriptionExtras.TabIndex = 4;
            // 
            // textBoxPriceExtras
            // 
            this.textBoxPriceExtras.Location = new System.Drawing.Point(217, 414);
            this.textBoxPriceExtras.Name = "textBoxPriceExtras";
            this.textBoxPriceExtras.Size = new System.Drawing.Size(518, 31);
            this.textBoxPriceExtras.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // checkBoxActiveExtras
            // 
            this.checkBoxActiveExtras.AutoSize = true;
            this.checkBoxActiveExtras.Checked = true;
            this.checkBoxActiveExtras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveExtras.Location = new System.Drawing.Point(71, 517);
            this.checkBoxActiveExtras.Name = "checkBoxActiveExtras";
            this.checkBoxActiveExtras.Size = new System.Drawing.Size(103, 29);
            this.checkBoxActiveExtras.TabIndex = 7;
            this.checkBoxActiveExtras.Text = "Active";
            this.checkBoxActiveExtras.UseVisualStyleBackColor = true;
            // 
            // ExtrasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 734);
            this.Controls.Add(this.checkBoxActiveExtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPriceExtras);
            this.Controls.Add(this.textBoxDescriptionExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExtras);
            this.Controls.Add(this.label1);
            this.Name = "ExtrasForms";
            this.Text = "Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescriptionExtras;
        private System.Windows.Forms.TextBox textBoxPriceExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxActiveExtras;
    }
}