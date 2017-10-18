namespace CWORK_Var2_VendingMachine
{
    partial class RefundCashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundCashForm));
            this.lblGrivnaRefund = new System.Windows.Forms.Label();
            this.labelKopRefund = new System.Windows.Forms.Label();
            this.buttonRefundUserCash = new System.Windows.Forms.Button();
            this.textBoxGrn = new System.Windows.Forms.TextBox();
            this.textBoxKop = new System.Windows.Forms.TextBox();
            this.labelRefundInfo = new System.Windows.Forms.Label();
            this.buttonNoRefundUserCash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrivnaRefund
            // 
            this.lblGrivnaRefund.AutoSize = true;
            this.lblGrivnaRefund.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrivnaRefund.Location = new System.Drawing.Point(12, 67);
            this.lblGrivnaRefund.Name = "lblGrivnaRefund";
            this.lblGrivnaRefund.Size = new System.Drawing.Size(64, 19);
            this.lblGrivnaRefund.TabIndex = 0;
            this.lblGrivnaRefund.Text = "Гривны:";
            // 
            // labelKopRefund
            // 
            this.labelKopRefund.AutoSize = true;
            this.labelKopRefund.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKopRefund.Location = new System.Drawing.Point(12, 130);
            this.labelKopRefund.Name = "labelKopRefund";
            this.labelKopRefund.Size = new System.Drawing.Size(71, 19);
            this.labelKopRefund.TabIndex = 1;
            this.labelKopRefund.Text = "Копейки:";
            // 
            // buttonRefundUserCash
            // 
            this.buttonRefundUserCash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefundUserCash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefundUserCash.Location = new System.Drawing.Point(175, 199);
            this.buttonRefundUserCash.Name = "buttonRefundUserCash";
            this.buttonRefundUserCash.Size = new System.Drawing.Size(75, 23);
            this.buttonRefundUserCash.TabIndex = 2;
            this.buttonRefundUserCash.Text = "Вернуть!";
            this.buttonRefundUserCash.UseVisualStyleBackColor = true;
            this.buttonRefundUserCash.Click += new System.EventHandler(this.RefundUserCash_Click);
            // 
            // textBoxGrn
            // 
            this.textBoxGrn.Location = new System.Drawing.Point(115, 66);
            this.textBoxGrn.Name = "textBoxGrn";
            this.textBoxGrn.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrn.TabIndex = 3;
            // 
            // textBoxKop
            // 
            this.textBoxKop.Location = new System.Drawing.Point(115, 129);
            this.textBoxKop.Name = "textBoxKop";
            this.textBoxKop.Size = new System.Drawing.Size(100, 20);
            this.textBoxKop.TabIndex = 4;
            // 
            // labelRefundInfo
            // 
            this.labelRefundInfo.AutoSize = true;
            this.labelRefundInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRefundInfo.Location = new System.Drawing.Point(28, 9);
            this.labelRefundInfo.Name = "labelRefundInfo";
            this.labelRefundInfo.Size = new System.Drawing.Size(207, 19);
            this.labelRefundInfo.TabIndex = 5;
            this.labelRefundInfo.Text = "Введите сумму для возврата";
            // 
            // buttonNoRefundUserCash
            // 
            this.buttonNoRefundUserCash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNoRefundUserCash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNoRefundUserCash.Location = new System.Drawing.Point(16, 199);
            this.buttonNoRefundUserCash.Name = "buttonNoRefundUserCash";
            this.buttonNoRefundUserCash.Size = new System.Drawing.Size(75, 23);
            this.buttonNoRefundUserCash.TabIndex = 6;
            this.buttonNoRefundUserCash.Text = "Выйти";
            this.buttonNoRefundUserCash.UseVisualStyleBackColor = true;
            this.buttonNoRefundUserCash.Click += new System.EventHandler(this.buttonNoRefundUserCash_Click);
            // 
            // RefundCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 234);
            this.Controls.Add(this.buttonNoRefundUserCash);
            this.Controls.Add(this.labelRefundInfo);
            this.Controls.Add(this.textBoxKop);
            this.Controls.Add(this.textBoxGrn);
            this.Controls.Add(this.buttonRefundUserCash);
            this.Controls.Add(this.labelKopRefund);
            this.Controls.Add(this.lblGrivnaRefund);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RefundCashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RefundCashForm";
            this.Load += new System.EventHandler(this.RefundCashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrivnaRefund;
        private System.Windows.Forms.Label labelKopRefund;
        private System.Windows.Forms.Button buttonRefundUserCash;
        private System.Windows.Forms.TextBox textBoxGrn;
        private System.Windows.Forms.TextBox textBoxKop;
        private System.Windows.Forms.Label labelRefundInfo;
        private System.Windows.Forms.Button buttonNoRefundUserCash;
    }
}