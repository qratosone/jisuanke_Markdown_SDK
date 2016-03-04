namespace jisuanke_Markdown_SDK
{
    partial class frmRead
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(24, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(162, 48);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(249, 35);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTag.Location = new System.Drawing.Point(24, 114);
            this.lblTag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(42, 25);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "tag";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(162, 128);
            this.txtTag.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(249, 35);
            this.txtTag.TabIndex = 3;
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitle.AutoSize = true;
            this.btnTitle.Location = new System.Drawing.Point(438, 56);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(256, 114);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.Text = "添加标题";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // txtRead
            // 
            this.txtRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRead.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRead.Location = new System.Drawing.Point(24, 254);
            this.txtRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRead.Size = new System.Drawing.Size(960, 614);
            this.txtRead.TabIndex = 5;
            this.txtRead.Text = "在此输入阅读课内容";
            this.txtRead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRead_KeyUp);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.AutoSize = true;
            this.btnRead.Location = new System.Drawing.Point(706, 56);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(256, 114);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "添加阅读课";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 922);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRead";
            this.Text = "添加阅读课";
            this.Load += new System.EventHandler(this.frmRead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button btnRead;
    }
}