namespace Email
{
    partial class compose
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RtbRecipient = new System.Windows.Forms.RichTextBox();
            this.RtbMessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RtbSubject = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnDraft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtbRecipient
            // 
            this.RtbRecipient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbRecipient.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbRecipient.Location = new System.Drawing.Point(113, 28);
            this.RtbRecipient.Multiline = false;
            this.RtbRecipient.Name = "RtbRecipient";
            this.RtbRecipient.Size = new System.Drawing.Size(250, 20);
            this.RtbRecipient.TabIndex = 1;
            this.RtbRecipient.Text = "";
            // 
            // RtbMessage
            // 
            this.RtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbMessage.Font = new System.Drawing.Font("Muli", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbMessage.Location = new System.Drawing.Point(43, 121);
            this.RtbMessage.Name = "RtbMessage";
            this.RtbMessage.Size = new System.Drawing.Size(538, 202);
            this.RtbMessage.TabIndex = 0;
            this.RtbMessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(43, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipient :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject :";
            // 
            // RtbSubject
            // 
            this.RtbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbSubject.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbSubject.Location = new System.Drawing.Point(103, 75);
            this.RtbSubject.Name = "RtbSubject";
            this.RtbSubject.Size = new System.Drawing.Size(260, 20);
            this.RtbSubject.TabIndex = 5;
            this.RtbSubject.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel2.Location = new System.Drawing.Point(43, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(43, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 1);
            this.panel3.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSend.FlatAppearance.BorderSize = 0;
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(506, 349);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // BtnDraft
            // 
            this.BtnDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDraft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDraft.FlatAppearance.BorderSize = 0;
            this.BtnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraft.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraft.ForeColor = System.Drawing.Color.White;
            this.BtnDraft.Location = new System.Drawing.Point(425, 349);
            this.BtnDraft.Name = "BtnDraft";
            this.BtnDraft.Size = new System.Drawing.Size(75, 23);
            this.BtnDraft.TabIndex = 7;
            this.BtnDraft.Text = "Draft";
            this.BtnDraft.UseVisualStyleBackColor = false;
            this.BtnDraft.Click += new System.EventHandler(this.BtnDraft_Click);
            // 
            // compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnDraft);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RtbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RtbRecipient);
            this.Controls.Add(this.RtbMessage);
            this.Name = "compose";
            this.Size = new System.Drawing.Size(624, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbRecipient;
        private System.Windows.Forms.RichTextBox RtbMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RtbSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnDraft;
    }
}
