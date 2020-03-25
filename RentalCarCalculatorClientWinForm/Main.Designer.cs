namespace RentalCarCalculatorClientWinForm
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGResult = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCarQty = new System.Windows.Forms.TextBox();
            this.CbModel = new System.Windows.Forms.ComboBox();
            this.TbDaysQty = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGviewMasterData = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbRentCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbCarNumber = new System.Windows.Forms.TextBox();
            this.TbModelName = new System.Windows.Forms.TextBox();
            this.TbModelYear = new System.Windows.Forms.TextBox();
            this.TbSeriesName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGviewMasterData)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1648, 708);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.DGResult);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 407);
            this.panel4.TabIndex = 6;
            // 
            // DGResult
            // 
            this.DGResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGResult.Location = new System.Drawing.Point(0, 0);
            this.DGResult.Name = "DGResult";
            this.DGResult.RowHeadersWidth = 51;
            this.DGResult.RowTemplate.Height = 24;
            this.DGResult.Size = new System.Drawing.Size(760, 407);
            this.DGResult.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TbCarQty);
            this.panel2.Controls.Add(this.CbModel);
            this.panel2.Controls.Add(this.TbDaysQty);
            this.panel2.Controls.Add(this.BtnSubmit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 301);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent Cars";
            // 
            // TbCarQty
            // 
            this.TbCarQty.Location = new System.Drawing.Point(156, 145);
            this.TbCarQty.Name = "TbCarQty";
            this.TbCarQty.Size = new System.Drawing.Size(164, 22);
            this.TbCarQty.TabIndex = 3;
            // 
            // CbModel
            // 
            this.CbModel.FormattingEnabled = true;
            this.CbModel.Location = new System.Drawing.Point(156, 108);
            this.CbModel.Name = "CbModel";
            this.CbModel.Size = new System.Drawing.Size(372, 24);
            this.CbModel.TabIndex = 2;
            // 
            // TbDaysQty
            // 
            this.TbDaysQty.Location = new System.Drawing.Point(156, 68);
            this.TbDaysQty.Name = "TbDaysQty";
            this.TbDaysQty.Size = new System.Drawing.Size(173, 22);
            this.TbDaysQty.TabIndex = 0;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(63, 226);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(257, 29);
            this.BtnSubmit.TabIndex = 2;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Model";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(760, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 708);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DGviewMasterData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 407);
            this.panel5.TabIndex = 15;
            // 
            // DGviewMasterData
            // 
            this.DGviewMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGviewMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGviewMasterData.Location = new System.Drawing.Point(0, 0);
            this.DGviewMasterData.Name = "DGviewMasterData";
            this.DGviewMasterData.RowHeadersWidth = 51;
            this.DGviewMasterData.RowTemplate.Height = 24;
            this.DGviewMasterData.Size = new System.Drawing.Size(888, 407);
            this.DGviewMasterData.TabIndex = 0;
            this.DGviewMasterData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGviewMasterData_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TbId);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.BtnDelete);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.BtnUpdate);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.BtnInsert);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.TbRentCost);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.TbCarNumber);
            this.panel6.Controls.Add(this.TbModelName);
            this.panel6.Controls.Add(this.TbModelYear);
            this.panel6.Controls.Add(this.TbSeriesName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(888, 301);
            this.panel6.TabIndex = 14;
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(314, 195);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(70, 22);
            this.TbId.TabIndex = 9;
            this.TbId.Text = "1";
            this.TbId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cars Master Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Car Number";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(268, 249);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 29);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Series Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(168, 249);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 29);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Rent Cost";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(72, 249);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 29);
            this.BtnInsert.TabIndex = 10;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Model Year";
            // 
            // TbRentCost
            // 
            this.TbRentCost.Location = new System.Drawing.Point(144, 195);
            this.TbRentCost.Name = "TbRentCost";
            this.TbRentCost.Size = new System.Drawing.Size(164, 22);
            this.TbRentCost.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Model Name";
            // 
            // TbCarNumber
            // 
            this.TbCarNumber.Location = new System.Drawing.Point(144, 154);
            this.TbCarNumber.Name = "TbCarNumber";
            this.TbCarNumber.Size = new System.Drawing.Size(164, 22);
            this.TbCarNumber.TabIndex = 7;
            // 
            // TbModelName
            // 
            this.TbModelName.Location = new System.Drawing.Point(144, 38);
            this.TbModelName.Name = "TbModelName";
            this.TbModelName.Size = new System.Drawing.Size(164, 22);
            this.TbModelName.TabIndex = 4;
            // 
            // TbModelYear
            // 
            this.TbModelYear.Location = new System.Drawing.Point(144, 112);
            this.TbModelYear.Name = "TbModelYear";
            this.TbModelYear.Size = new System.Drawing.Size(164, 22);
            this.TbModelYear.TabIndex = 6;
            // 
            // TbSeriesName
            // 
            this.TbSeriesName.Location = new System.Drawing.Point(144, 75);
            this.TbSeriesName.Name = "TbSeriesName";
            this.TbSeriesName.Size = new System.Drawing.Size(164, 22);
            this.TbSeriesName.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 708);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGviewMasterData)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCarQty;
        private System.Windows.Forms.ComboBox CbModel;
        private System.Windows.Forms.TextBox TbDaysQty;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGviewMasterData;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TbCarNumber;
        private System.Windows.Forms.TextBox TbModelYear;
        private System.Windows.Forms.TextBox TbSeriesName;
        private System.Windows.Forms.TextBox TbModelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbRentCost;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.DataGridView DGResult;
    }
}

