namespace Email
{
    partial class DetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Sender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAction = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Recipient = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.ActionForm = new Email.compose();
            this.Body = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 53);
            this.panel1.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Muli Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Window;
            this.Title.Location = new System.Drawing.Point(20, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(53, 26);
            this.Title.TabIndex = 12;
            this.Title.Text = "Title";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(570, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Sender
            // 
            this.Sender.AutoSize = true;
            this.Sender.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sender.Location = new System.Drawing.Point(80, 74);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(36, 15);
            this.Sender.TabIndex = 35;
            this.Sender.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "From:";
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnAction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAction.FlatAppearance.BorderSize = 0;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAction.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.Color.White;
            this.BtnAction.Location = new System.Drawing.Point(492, 404);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(75, 23);
            this.BtnAction.TabIndex = 33;
            this.BtnAction.Text = "Action";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Muli", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.Time.Location = new System.Drawing.Point(533, 152);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(34, 13);
            this.Time.TabIndex = 31;
            this.Time.Text = "2h ago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Message:";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(80, 114);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(36, 15);
            this.Subject.TabIndex = 29;
            this.Subject.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Subject:";
            // 
            // Recipient
            // 
            this.Recipient.AutoSize = true;
            this.Recipient.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipient.Location = new System.Drawing.Point(80, 94);
            this.Recipient.Name = "Recipient";
            this.Recipient.Size = new System.Drawing.Size(36, 15);
            this.Recipient.TabIndex = 27;
            this.Recipient.Text = "From:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 94);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(23, 15);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "To:";
            // 
            // ActionForm
            // 
            this.ActionForm.BackColor = System.Drawing.Color.White;
            this.ActionForm.Location = new System.Drawing.Point(-17, 55);
            this.ActionForm.Name = "ActionForm";
            this.ActionForm.Size = new System.Drawing.Size(624, 397);
            this.ActionForm.TabIndex = 36;
            this.ActionForm.Visible = false;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Body.Location = new System.Drawing.Point(28, 174);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(36, 15);
            this.Body.TabIndex = 37;
            this.Body.Text = "From:";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 451);
            this.Controls.Add(this.ActionForm);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Recipient);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label Sender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Recipient;
        private System.Windows.Forms.Label lbl1;
        private compose ActionForm;
        private System.Windows.Forms.Label Body;
    }
}