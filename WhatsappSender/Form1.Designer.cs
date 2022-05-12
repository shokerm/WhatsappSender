namespace WhatsappSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.browserBtn = new System.Windows.Forms.Button();
            this.appBtn = new System.Windows.Forms.Button();
            this.numberTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "WhatsApp Sender";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // browserBtn
            // 
            this.browserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browserBtn.Location = new System.Drawing.Point(2, 216);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(217, 52);
            this.browserBtn.TabIndex = 3;
            this.browserBtn.Text = "שלח בדפדפן";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // appBtn
            // 
            this.appBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appBtn.Location = new System.Drawing.Point(529, 216);
            this.appBtn.Name = "appBtn";
            this.appBtn.Size = new System.Drawing.Size(217, 52);
            this.appBtn.TabIndex = 2;
            this.appBtn.Text = "שלח באפליקציה";
            this.appBtn.UseVisualStyleBackColor = true;
            this.appBtn.Click += new System.EventHandler(this.appBtn_Click);
            // 
            // numberTxb
            // 
            this.numberTxb.Location = new System.Drawing.Point(204, 140);
            this.numberTxb.Name = "numberTxb";
            this.numberTxb.Size = new System.Drawing.Size(201, 27);
            this.numberTxb.TabIndex = 1;
            this.numberTxb.TextChanged += new System.EventHandler(this.numberTxb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 135);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "מספר טלפון:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(227, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "ללא צורך בשמירת המספר";
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Location = new System.Drawing.Point(301, 248);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(122, 20);
            this.signature.TabIndex = 6;
            this.signature.Text = "By Moshe Shoker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(747, 271);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTxb);
            this.Controls.Add(this.appBtn);
            this.Controls.Add(this.browserBtn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsAppSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button browserBtn;
        private Button appBtn;
        private TextBox numberTxb;
        private Label label2;
        private Label label3;
        private Label signature;
    }
}