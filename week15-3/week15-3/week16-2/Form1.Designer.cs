namespace week16_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 書號Label;
            System.Windows.Forms.Label 書名Label;
            System.Windows.Forms.Label 單價Label;
            System.Windows.Forms.Label 數量Label;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._p11_1dbDataSet = new week16_2._p11_1dbDataSet();
            this.書籍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書籍TableAdapter = new week16_2._p11_1dbDataSetTableAdapters.書籍TableAdapter();
            this.tableAdapterManager = new week16_2._p11_1dbDataSetTableAdapters.TableAdapterManager();
            this.書號TextBox = new System.Windows.Forms.TextBox();
            this.書名TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.數量TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.瀏覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最後一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            書號Label = new System.Windows.Forms.Label();
            書名Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            數量Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 書號Label
            // 
            書號Label.AutoSize = true;
            書號Label.Location = new System.Drawing.Point(45, 90);
            書號Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            書號Label.Name = "書號Label";
            書號Label.Size = new System.Drawing.Size(49, 18);
            書號Label.TabIndex = 0;
            書號Label.Text = "書號:";
            // 
            // 書名Label
            // 
            書名Label.AutoSize = true;
            書名Label.Location = new System.Drawing.Point(45, 132);
            書名Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            書名Label.Name = "書名Label";
            書名Label.Size = new System.Drawing.Size(49, 18);
            書名Label.TabIndex = 2;
            書名Label.Text = "書名:";
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(45, 174);
            單價Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(49, 18);
            單價Label.TabIndex = 4;
            單價Label.Text = "單價:";
            // 
            // 數量Label
            // 
            數量Label.AutoSize = true;
            數量Label.Location = new System.Drawing.Point(45, 216);
            數量Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            數量Label.Name = "數量Label";
            數量Label.Size = new System.Drawing.Size(49, 18);
            數量Label.TabIndex = 6;
            數量Label.Text = "數量:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this._p11_1dbDataSet;
            this.bindingSource1.Position = 0;
            // 
            // _p11_1dbDataSet
            // 
            this._p11_1dbDataSet.DataSetName = "_p11_1dbDataSet";
            this._p11_1dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 書籍BindingSource
            // 
            this.書籍BindingSource.DataMember = "書籍";
            this.書籍BindingSource.DataSource = this._p11_1dbDataSet;
            // 
            // 書籍TableAdapter
            // 
            this.書籍TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = week16_2._p11_1dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.書籍TableAdapter = this.書籍TableAdapter;
            // 
            // 書號TextBox
            // 
            this.書號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書號", true));
            this.書號TextBox.Location = new System.Drawing.Point(102, 86);
            this.書號TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.書號TextBox.Name = "書號TextBox";
            this.書號TextBox.Size = new System.Drawing.Size(148, 29);
            this.書號TextBox.TabIndex = 1;
            // 
            // 書名TextBox
            // 
            this.書名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書名", true));
            this.書名TextBox.Location = new System.Drawing.Point(102, 128);
            this.書名TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.書名TextBox.Name = "書名TextBox";
            this.書名TextBox.Size = new System.Drawing.Size(148, 29);
            this.書名TextBox.TabIndex = 3;
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(102, 170);
            this.單價TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(148, 29);
            this.單價TextBox.TabIndex = 5;
            // 
            // 數量TextBox
            // 
            this.數量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "數量", true));
            this.數量TextBox.Location = new System.Drawing.Point(102, 212);
            this.數量TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.數量TextBox.Name = "數量TextBox";
            this.數量TextBox.Size = new System.Drawing.Size(148, 29);
            this.數量TextBox.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.瀏覽ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 瀏覽ToolStripMenuItem
            // 
            this.瀏覽ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一筆ToolStripMenuItem,
            this.上一筆ToolStripMenuItem,
            this.下一筆ToolStripMenuItem,
            this.最後一筆ToolStripMenuItem});
            this.瀏覽ToolStripMenuItem.Name = "瀏覽ToolStripMenuItem";
            this.瀏覽ToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.瀏覽ToolStripMenuItem.Text = "瀏覽";
            // 
            // 第一筆ToolStripMenuItem
            // 
            this.第一筆ToolStripMenuItem.Name = "第一筆ToolStripMenuItem";
            this.第一筆ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.第一筆ToolStripMenuItem.Text = "第一筆";
            this.第一筆ToolStripMenuItem.Click += new System.EventHandler(this.第一筆ToolStripMenuItem_Click);
            // 
            // 上一筆ToolStripMenuItem
            // 
            this.上一筆ToolStripMenuItem.Name = "上一筆ToolStripMenuItem";
            this.上一筆ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.上一筆ToolStripMenuItem.Text = "上一筆";
            this.上一筆ToolStripMenuItem.Click += new System.EventHandler(this.上一筆ToolStripMenuItem_Click);
            // 
            // 下一筆ToolStripMenuItem
            // 
            this.下一筆ToolStripMenuItem.Name = "下一筆ToolStripMenuItem";
            this.下一筆ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.下一筆ToolStripMenuItem.Text = "下一筆";
            this.下一筆ToolStripMenuItem.Click += new System.EventHandler(this.下一筆ToolStripMenuItem_Click);
            // 
            // 最後一筆ToolStripMenuItem
            // 
            this.最後一筆ToolStripMenuItem.Name = "最後一筆ToolStripMenuItem";
            this.最後一筆ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.最後一筆ToolStripMenuItem.Text = "最後一筆";
            this.最後一筆ToolStripMenuItem.Click += new System.EventHandler(this.最後一筆ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(148, 30);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 315);
            this.Controls.Add(書號Label);
            this.Controls.Add(this.書號TextBox);
            this.Controls.Add(書名Label);
            this.Controls.Add(this.書名TextBox);
            this.Controls.Add(單價Label);
            this.Controls.Add(this.單價TextBox);
            this.Controls.Add(數量Label);
            this.Controls.Add(this.數量TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "選單版";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private _p11_1dbDataSet _p11_1dbDataSet;
        private System.Windows.Forms.BindingSource 書籍BindingSource;
        private _p11_1dbDataSetTableAdapters.書籍TableAdapter 書籍TableAdapter;
        private _p11_1dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox 書號TextBox;
        private System.Windows.Forms.TextBox 書名TextBox;
        private System.Windows.Forms.TextBox 單價TextBox;
        private System.Windows.Forms.TextBox 數量TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 瀏覽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最後一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

