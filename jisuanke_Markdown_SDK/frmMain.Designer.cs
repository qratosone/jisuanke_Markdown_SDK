namespace jisuanke_Markdown_SDK
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.AcceptsReturn = true;
            this.txtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEditor.Location = new System.Drawing.Point(15, 133);
            this.txtEditor.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(1449, 497);
            this.txtEditor.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.Location = new System.Drawing.Point(46, 24);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(134, 84);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(220, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 84);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.AutoSize = true;
            this.btnRead.Location = new System.Drawing.Point(1241, 37);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(150, 84);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "添加阅读课";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files(*.txt)|*.txt|Markdown Files(*.md)|*.md";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Markdown Files(*.md)|*.md";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(386, 24);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 84);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.AutoSize = true;
            this.btnCode.Location = new System.Drawing.Point(1045, 37);
            this.btnCode.Margin = new System.Windows.Forms.Padding(6);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(150, 84);
            this.btnCode.TabIndex = 5;
            this.btnCode.Text = "添加代码课";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Location = new System.Drawing.Point(548, 24);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 84);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Version 0.5";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Jisuanke Markdown Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
    }
}

