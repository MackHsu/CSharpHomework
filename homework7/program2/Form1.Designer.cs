namespace program2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonDiserialize = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReviseOrder = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearchByID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttomSearchByProductName = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSearchByClientName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSearchByMoney = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDiserialize
            // 
            this.buttonDiserialize.Location = new System.Drawing.Point(13, 28);
            this.buttonDiserialize.Name = "buttonDiserialize";
            this.buttonDiserialize.Size = new System.Drawing.Size(145, 50);
            this.buttonDiserialize.TabIndex = 0;
            this.buttonDiserialize.Text = "从xml文件导入订单列表";
            this.buttonDiserialize.UseVisualStyleBackColor = true;
            this.buttonDiserialize.Click += new System.EventHandler(this.buttonDiserialize_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(13, 84);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(145, 25);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "添加新订单";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(13, 116);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(145, 25);
            this.buttonDeleteOrder.TabIndex = 2;
            this.buttonDeleteOrder.Text = "删除订单";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "操作：";
            // 
            // buttonReviseOrder
            // 
            this.buttonReviseOrder.Location = new System.Drawing.Point(13, 147);
            this.buttonReviseOrder.Name = "buttonReviseOrder";
            this.buttonReviseOrder.Size = new System.Drawing.Size(145, 25);
            this.buttonReviseOrder.TabIndex = 5;
            this.buttonReviseOrder.Text = "修改订单";
            this.buttonReviseOrder.UseVisualStyleBackColor = true;
            this.buttonReviseOrder.Click += new System.EventHandler(this.buttonReviseOrder_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(13, 179);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(145, 50);
            this.buttonSerialize.TabIndex = 6;
            this.buttonSerialize.Text = "将订单导出为xml文件并退出";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.orderServiceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(736, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "订单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "商品名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ClientName";
            this.Column3.HeaderText = "客户名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Money";
            this.Column4.HeaderText = "金额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // orderServiceBindingSource
            // 
            this.orderServiceBindingSource.DataSource = typeof(program2.OrderService);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSerialize);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReviseOrder);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDeleteOrder);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddOrder);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDiserialize);
            this.splitContainer1.Panel2MinSize = 125;
            this.splitContainer1.Size = new System.Drawing.Size(912, 281);
            this.splitContainer1.SplitterDistance = 736;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonViewAll);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSearchByMoney);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSearchByClientName);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.buttomSearchByProductName);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSearchByID);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(912, 410);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "订单号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 25);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Location = new System.Drawing.Point(661, 4);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(144, 25);
            this.buttonSearchByID.TabIndex = 2;
            this.buttonSearchByID.Text = "按订单号查询";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品名：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(573, 25);
            this.textBox2.TabIndex = 4;
            // 
            // buttomSearchByProductName
            // 
            this.buttomSearchByProductName.Location = new System.Drawing.Point(661, 29);
            this.buttomSearchByProductName.Name = "buttomSearchByProductName";
            this.buttomSearchByProductName.Size = new System.Drawing.Size(144, 25);
            this.buttomSearchByProductName.TabIndex = 5;
            this.buttomSearchByProductName.Text = "按商品名查询";
            this.buttomSearchByProductName.UseVisualStyleBackColor = true;
            this.buttomSearchByProductName.Click += new System.EventHandler(this.buttomSearchByProductName_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 56);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(573, 25);
            this.textBox3.TabIndex = 6;
            // 
            // buttonSearchByClientName
            // 
            this.buttonSearchByClientName.Location = new System.Drawing.Point(661, 56);
            this.buttonSearchByClientName.Name = "buttonSearchByClientName";
            this.buttonSearchByClientName.Size = new System.Drawing.Size(144, 25);
            this.buttonSearchByClientName.TabIndex = 7;
            this.buttonSearchByClientName.Text = "按客户名查询";
            this.buttonSearchByClientName.UseVisualStyleBackColor = true;
            this.buttonSearchByClientName.Click += new System.EventHandler(this.buttonSearchByClientName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "客户名：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 83);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(573, 25);
            this.textBox4.TabIndex = 9;
            // 
            // buttonSearchByMoney
            // 
            this.buttonSearchByMoney.Location = new System.Drawing.Point(661, 83);
            this.buttonSearchByMoney.Name = "buttonSearchByMoney";
            this.buttonSearchByMoney.Size = new System.Drawing.Size(144, 25);
            this.buttonSearchByMoney.TabIndex = 10;
            this.buttonSearchByMoney.Text = "过滤小额订单";
            this.buttonSearchByMoney.UseVisualStyleBackColor = true;
            this.buttonSearchByMoney.Click += new System.EventHandler(this.buttonSearchByMoney_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "金额：";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(812, 4);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(86, 104);
            this.buttonViewAll.TabIndex = 12;
            this.buttonViewAll.Text = "显示全部订单";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 410);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "订单管理器";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderServiceBindingSource;
        private System.Windows.Forms.Button buttonDiserialize;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReviseOrder;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearchByMoney;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearchByClientName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttomSearchByProductName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchByID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonViewAll;
    }
}

