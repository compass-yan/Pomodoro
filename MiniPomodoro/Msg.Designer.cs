namespace MiniPomodoro
{
    partial class Msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg));
            this.lblMsgTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblMsgFooter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsgTitle
            // 
            this.lblMsgTitle.AutoSize = true;
            this.lblMsgTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsgTitle.Location = new System.Drawing.Point(32, 28);
            this.lblMsgTitle.Name = "lblMsgTitle";
            this.lblMsgTitle.Size = new System.Drawing.Size(93, 30);
            this.lblMsgTitle.TabIndex = 0;
            this.lblMsgTitle.Text = "title";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(480, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTitle.Font = new System.Drawing.Font("宋体", 9F);
            this.lblSubTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(231, 45);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "SubTitle";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("宋体", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsg.Location = new System.Drawing.Point(103, 70);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(420, 54);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "msg";
            // 
            // lblMsgFooter
            // 
            this.lblMsgFooter.AutoSize = true;
            this.lblMsgFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsgFooter.Font = new System.Drawing.Font("宋体", 8F);
            this.lblMsgFooter.Location = new System.Drawing.Point(0, 0);
            this.lblMsgFooter.Name = "lblMsgFooter";
            this.lblMsgFooter.Size = new System.Drawing.Size(56, 16);
            this.lblMsgFooter.TabIndex = 2;
            this.lblMsgFooter.Text = "footer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsgFooter);
            this.panel1.Location = new System.Drawing.Point(92, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 46);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSubTitle);
            this.panel2.Location = new System.Drawing.Point(350, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 45);
            this.panel2.TabIndex = 4;
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 243);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMsgTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Msg";
            this.Text = "番茄钟";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Msg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblMsgFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}