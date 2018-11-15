namespace program2
{
    partial class ToHTMLForm
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
            this.textBoxXml = new System.Windows.Forms.TextBox();
            this.textBoxXslt = new System.Windows.Forms.TextBox();
            this.textBoxHtml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxXml
            // 
            this.textBoxXml.Location = new System.Drawing.Point(134, 13);
            this.textBoxXml.Name = "textBoxXml";
            this.textBoxXml.Size = new System.Drawing.Size(314, 25);
            this.textBoxXml.TabIndex = 0;
            this.textBoxXml.Text = "..\\..\\..\\orders.xml";
            // 
            // textBoxXslt
            // 
            this.textBoxXslt.Location = new System.Drawing.Point(134, 45);
            this.textBoxXslt.Name = "textBoxXslt";
            this.textBoxXslt.Size = new System.Drawing.Size(314, 25);
            this.textBoxXslt.TabIndex = 1;
            this.textBoxXslt.Text = "..\\..\\..\\orders.xslt";
            // 
            // textBoxHtml
            // 
            this.textBoxHtml.Location = new System.Drawing.Point(134, 77);
            this.textBoxHtml.Name = "textBoxHtml";
            this.textBoxHtml.Size = new System.Drawing.Size(314, 25);
            this.textBoxHtml.TabIndex = 2;
            this.textBoxHtml.Text = "..\\..\\..\\orders.html";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "xml文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "xslt文件路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "html文件路径：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToHTMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHtml);
            this.Controls.Add(this.textBoxXslt);
            this.Controls.Add(this.textBoxXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ToHTMLForm";
            this.Text = "请输入文件路径";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXml;
        private System.Windows.Forms.TextBox textBoxXslt;
        private System.Windows.Forms.TextBox textBoxHtml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}