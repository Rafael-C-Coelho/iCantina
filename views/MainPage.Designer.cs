namespace iCantina.views
{
    partial class MainPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnDishes = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProfessors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnStudents, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProfessors, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployees, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInvoices, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDishes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReservations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExtras, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFines, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnFines
            // 
            this.btnFines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnFines.Location = new System.Drawing.Point(519, 144);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(254, 135);
            this.btnFines.TabIndex = 5;
            this.btnFines.Text = "Fines";
            this.btnFines.UseVisualStyleBackColor = true;
            // 
            // btnExtras
            // 
            this.btnExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnExtras.Location = new System.Drawing.Point(261, 3);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(252, 135);
            this.btnExtras.TabIndex = 4;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            this.btnInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnInvoices.Location = new System.Drawing.Point(3, 144);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(252, 135);
            this.btnInvoices.TabIndex = 3;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnDishes
            // 
            this.btnDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnDishes.Location = new System.Drawing.Point(519, 3);
            this.btnDishes.Name = "btnDishes";
            this.btnDishes.Size = new System.Drawing.Size(254, 135);
            this.btnDishes.TabIndex = 2;
            this.btnDishes.Text = "Dishes";
            this.btnDishes.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnMenu.Location = new System.Drawing.Point(261, 144);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(252, 135);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menus";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnReservations
            // 
            this.btnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnReservations.Location = new System.Drawing.Point(3, 3);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(252, 135);
            this.btnReservations.TabIndex = 0;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnEmployees.Location = new System.Drawing.Point(519, 285);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(254, 138);
            this.btnEmployees.TabIndex = 6;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnProfessors
            // 
            this.btnProfessors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnProfessors.Location = new System.Drawing.Point(261, 285);
            this.btnProfessors.Name = "btnProfessors";
            this.btnProfessors.Size = new System.Drawing.Size(252, 138);
            this.btnProfessors.TabIndex = 7;
            this.btnProfessors.Text = "Professors";
            this.btnProfessors.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnStudents.Location = new System.Drawing.Point(3, 285);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(252, 138);
            this.btnStudents.TabIndex = 8;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnProfessors;
    }
}