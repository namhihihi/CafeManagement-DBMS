namespace CafeManagementDBMS
{
    partial class BillsManagementForm
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
            this.plQLHD = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMahd = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.plQLHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // plQLHD
            // 
            this.plQLHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plQLHD.Controls.Add(this.label2);
            this.plQLHD.Controls.Add(this.lbMaKH);
            this.plQLHD.Controls.Add(this.label1);
            this.plQLHD.Controls.Add(this.lbMahd);
            this.plQLHD.Controls.Add(this.label37);
            this.plQLHD.Location = new System.Drawing.Point(-44, -14);
            this.plQLHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plQLHD.Name = "plQLHD";
            this.plQLHD.Size = new System.Drawing.Size(1581, 278);
            this.plQLHD.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(582, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Khách Hàng :";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbMaKH.Location = new System.Drawing.Point(903, 112);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(135, 46);
            this.lbMaKH.TabIndex = 20;
            this.lbMaKH.Text = "MAKH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(582, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // lbMahd
            // 
            this.lbMahd.AutoSize = true;
            this.lbMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbMahd.Location = new System.Drawing.Point(843, 178);
            this.lbMahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMahd.Name = "lbMahd";
            this.lbMahd.Size = new System.Drawing.Size(138, 46);
            this.lbMahd.TabIndex = 18;
            this.lbMahd.Text = "MAHD";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label37.Location = new System.Drawing.Point(582, 39);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(382, 46);
            this.label37.TabIndex = 17;
            this.label37.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(-44, 273);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(1581, 664);
            this.dgvCTHD.TabIndex = 29;
            // 
            // BillsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 947);
            this.Controls.Add(this.plQLHD);
            this.Controls.Add(this.dgvCTHD);
            this.Name = "BillsManagementForm";
            this.Text = "BillsManagementForm";
            this.plQLHD.ResumeLayout(false);
            this.plQLHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plQLHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMahd;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView dgvCTHD;
    }
}