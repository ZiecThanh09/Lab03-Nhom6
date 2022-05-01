namespace Lab03_Nhom6
{
    partial class Lab03_Bai03_Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnListen.Location = new System.Drawing.Point(711, 59);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(77, 37);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.Enabled = false;
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(12, 102);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(776, 336);
            this.lsvMessage.TabIndex = 1;
            this.lsvMessage.TabStop = false;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // Lab03_Bai03_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btnListen);
            this.Name = "Lab03_Bai03_Server";
            this.Text = "Lab03_Bai03_Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lab03_Bai03_Server_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView lsvMessage;
    }
}