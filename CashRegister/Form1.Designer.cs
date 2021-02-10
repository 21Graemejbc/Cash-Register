
namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalButton = new System.Windows.Forms.Button();
            this.cardInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.chargerLabel = new System.Windows.Forms.Label();
            this.chargerInput = new System.Windows.Forms.TextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.tenderInput = new System.Windows.Forms.TextBox();
            this.reorderButton = new System.Windows.Forms.Button();
            this.leftReceiptOutput = new System.Windows.Forms.Label();
            this.totalsOutput = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.Label();
            this.rightReceiptOutput = new System.Windows.Forms.Label();
            this.goodDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(16, 142);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(395, 38);
            this.totalButton.TabIndex = 0;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // cardInput
            // 
            this.cardInput.Location = new System.Drawing.Point(334, 58);
            this.cardInput.Name = "cardInput";
            this.cardInput.Size = new System.Drawing.Size(77, 20);
            this.cardInput.TabIndex = 1;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(334, 86);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(77, 20);
            this.phoneInput.TabIndex = 2;
            // 
            // cardLabel
            // 
            this.cardLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(12, 61);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(316, 20);
            this.cardLabel.TabIndex = 4;
            this.cardLabel.Text = "GTX 3080 Graphics Cards:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 86);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(316, 20);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Smartphones (Charger not Included)";
            // 
            // chargerLabel
            // 
            this.chargerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargerLabel.Location = new System.Drawing.Point(12, 114);
            this.chargerLabel.Name = "chargerLabel";
            this.chargerLabel.Size = new System.Drawing.Size(316, 20);
            this.chargerLabel.TabIndex = 8;
            this.chargerLabel.Text = "Phone Chargers";
            // 
            // chargerInput
            // 
            this.chargerInput.Location = new System.Drawing.Point(334, 114);
            this.chargerInput.Name = "chargerInput";
            this.chargerInput.Size = new System.Drawing.Size(77, 20);
            this.chargerInput.TabIndex = 7;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(15, 404);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(395, 38);
            this.receiptButton.TabIndex = 10;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(16, 328);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(395, 38);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderLabel
            // 
            this.tenderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderLabel.Location = new System.Drawing.Point(12, 302);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(75, 20);
            this.tenderLabel.TabIndex = 13;
            this.tenderLabel.Text = "Tender:";
            // 
            // tenderInput
            // 
            this.tenderInput.Location = new System.Drawing.Point(334, 302);
            this.tenderInput.Name = "tenderInput";
            this.tenderInput.Size = new System.Drawing.Size(77, 20);
            this.tenderInput.TabIndex = 12;
            // 
            // reorderButton
            // 
            this.reorderButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderButton.Location = new System.Drawing.Point(16, 450);
            this.reorderButton.Name = "reorderButton";
            this.reorderButton.Size = new System.Drawing.Size(394, 38);
            this.reorderButton.TabIndex = 15;
            this.reorderButton.Text = "New Order";
            this.reorderButton.UseVisualStyleBackColor = true;
            this.reorderButton.Click += new System.EventHandler(this.reorderButton_Click);
            // 
            // leftReceiptOutput
            // 
            this.leftReceiptOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftReceiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftReceiptOutput.Location = new System.Drawing.Point(428, 58);
            this.leftReceiptOutput.Name = "leftReceiptOutput";
            this.leftReceiptOutput.Size = new System.Drawing.Size(229, 249);
            this.leftReceiptOutput.TabIndex = 16;
            // 
            // totalsOutput
            // 
            this.totalsOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalsOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsOutput.Location = new System.Drawing.Point(16, 185);
            this.totalsOutput.Name = "totalsOutput";
            this.totalsOutput.Size = new System.Drawing.Size(395, 97);
            this.totalsOutput.TabIndex = 17;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divider.Location = new System.Drawing.Point(16, 287);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(394, 10);
            this.divider.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(334, 375);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(77, 20);
            this.changeOutput.TabIndex = 20;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.LightSkyBlue;
            this.banner.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner.Location = new System.Drawing.Point(-2, -1);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(809, 46);
            this.banner.TabIndex = 21;
            this.banner.Text = "Totally Legit Tech Inc.";
            this.banner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightReceiptOutput
            // 
            this.rightReceiptOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightReceiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightReceiptOutput.Location = new System.Drawing.Point(640, 58);
            this.rightReceiptOutput.Name = "rightReceiptOutput";
            this.rightReceiptOutput.Size = new System.Drawing.Size(148, 249);
            this.rightReceiptOutput.TabIndex = 22;
            this.rightReceiptOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // goodDayLabel
            // 
            this.goodDayLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodDayLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodDayLabel.Location = new System.Drawing.Point(428, 307);
            this.goodDayLabel.Name = "goodDayLabel";
            this.goodDayLabel.Size = new System.Drawing.Size(360, 181);
            this.goodDayLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.goodDayLabel);
            this.Controls.Add(this.rightReceiptOutput);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.totalsOutput);
            this.Controls.Add(this.leftReceiptOutput);
            this.Controls.Add(this.reorderButton);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.tenderInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.chargerLabel);
            this.Controls.Add(this.chargerInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.cardInput);
            this.Controls.Add(this.totalButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox cardInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label chargerLabel;
        private System.Windows.Forms.TextBox chargerInput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.TextBox tenderInput;
        private System.Windows.Forms.Button reorderButton;
        private System.Windows.Forms.Label leftReceiptOutput;
        private System.Windows.Forms.Label totalsOutput;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Label rightReceiptOutput;
        private System.Windows.Forms.Label goodDayLabel;
    }
}

