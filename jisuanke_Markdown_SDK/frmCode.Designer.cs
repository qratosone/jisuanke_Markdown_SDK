namespace jisuanke_Markdown_SDK
{
    partial class frmCode
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
            this.btnTitle = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.txtTips = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitle.Location = new System.Drawing.Point(858, 30);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(268, 114);
            this.btnTitle.TabIndex = 9;
            this.btnTitle.Text = "添加标题";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTag.Location = new System.Drawing.Point(117, 110);
            this.txtTag.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(660, 35);
            this.txtTag.TabIndex = 8;
            // 
            // lblTag
            // 
            this.lblTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTag.Location = new System.Drawing.Point(19, 110);
            this.lblTag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(42, 25);
            this.lblTag.TabIndex = 7;
            this.lblTag.Text = "tag";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTitle.Location = new System.Drawing.Point(117, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(660, 35);
            this.txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(19, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "标题";
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.Location = new System.Drawing.Point(1172, 32);
            this.btnCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(256, 114);
            this.btnCode.TabIndex = 10;
            this.btnCode.Text = "添加代码课";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(30, 284);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(1442, 273);
            this.txtCode.TabIndex = 11;
            this.txtCode.Text = "添加代码";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // txtGuide
            // 
            this.txtGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuide.Location = new System.Drawing.Point(30, 569);
            this.txtGuide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGuide.Multiline = true;
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuide.Size = new System.Drawing.Size(699, 195);
            this.txtGuide.TabIndex = 12;
            this.txtGuide.Text = "添加引导";
            this.txtGuide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGuide_KeyUp);
            // 
            // txtTips
            // 
            this.txtTips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTips.Location = new System.Drawing.Point(728, 569);
            this.txtTips.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTips.Multiline = true;
            this.txtTips.Name = "txtTips";
            this.txtTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTips.Size = new System.Drawing.Size(744, 195);
            this.txtTips.TabIndex = 13;
            this.txtTips.Text = "添加提示";
            this.txtTips.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTips_KeyUp);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 180);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 24);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "当前状态";
            // 
            // frmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 779);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.txtGuide);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCode";
            this.Text = "添加代码课";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtGuide;
        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.Label lblStatus;
    }
}