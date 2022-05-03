
namespace Lab03_Nhom6
{
    partial class Lab03_Bai03
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
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.btnOpenClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenServer.Location = new System.Drawing.Point(299, 190);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(156, 52);
            this.btnOpenServer.TabIndex = 0;
            this.btnOpenServer.TabStop = false;
            this.btnOpenServer.Text = "Open TCP Server";
            this.btnOpenServer.UseVisualStyleBackColor = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // btnOpenClient
            // 
            this.btnOpenClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenClient.Location = new System.Drawing.Point(299, 270);
            this.btnOpenClient.Name = "btnOpenClient";
            this.btnOpenClient.Size = new System.Drawing.Size(156, 52);
            this.btnOpenClient.TabIndex = 0;
            this.btnOpenClient.TabStop = false;
            this.btnOpenClient.Text = "Open TCP Client";
            this.btnOpenClient.UseVisualStyleBackColor = true;
            this.btnOpenClient.Click += new System.EventHandler(this.btnOpenClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(201, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "20521909_Diệc Thành";
            // 
            // Lab03_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenClient);
            this.Controls.Add(this.btnOpenServer);
            this.Name = "Lab03_Bai03";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenServer;
        private System.Windows.Forms.Button btnOpenClient;
        private System.Windows.Forms.Label label1;
    }
}

