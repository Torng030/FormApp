namespace week15_2
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
            this._p11_1dbDataSet = new week15_2._p11_1dbDataSet();
            this.書籍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書籍TableAdapter = new week15_2._p11_1dbDataSetTableAdapters.書籍TableAdapter();
            this.tableAdapterManager = new week15_2._p11_1dbDataSetTableAdapters.TableAdapterManager();
            this.書號TextBox = new System.Windows.Forms.TextBox();
            this.書名TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.數量TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            書號Label = new System.Windows.Forms.Label();
            書名Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            數量Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = week15_2._p11_1dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.書籍TableAdapter = this.書籍TableAdapter;
            // 
            // 書號Label
            // 
            書號Label.AutoSize = true;
            書號Label.Location = new System.Drawing.Point(58, 63);
            書號Label.Name = "書號Label";
            書號Label.Size = new System.Drawing.Size(49, 18);
            書號Label.TabIndex = 0;
            書號Label.Text = "書號:";
            // 
            // 書號TextBox
            // 
            this.書號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書號", true));
            this.書號TextBox.Location = new System.Drawing.Point(113, 60);
            this.書號TextBox.Name = "書號TextBox";
            this.書號TextBox.Size = new System.Drawing.Size(136, 29);
            this.書號TextBox.TabIndex = 1;
            // 
            // 書名Label
            // 
            書名Label.AutoSize = true;
            書名Label.Location = new System.Drawing.Point(58, 98);
            書名Label.Name = "書名Label";
            書名Label.Size = new System.Drawing.Size(49, 18);
            書名Label.TabIndex = 2;
            書名Label.Text = "書名:";
            // 
            // 書名TextBox
            // 
            this.書名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "書名", true));
            this.書名TextBox.Location = new System.Drawing.Point(113, 95);
            this.書名TextBox.Name = "書名TextBox";
            this.書名TextBox.Size = new System.Drawing.Size(136, 29);
            this.書名TextBox.TabIndex = 3;
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(58, 133);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(49, 18);
            單價Label.TabIndex = 4;
            單價Label.Text = "單價:";
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(113, 130);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(136, 29);
            this.單價TextBox.TabIndex = 5;
            // 
            // 數量Label
            // 
            數量Label.AutoSize = true;
            數量Label.Location = new System.Drawing.Point(58, 168);
            數量Label.Name = "數量Label";
            數量Label.Size = new System.Drawing.Size(49, 18);
            數量Label.TabIndex = 6;
            數量Label.Text = "數量:";
            // 
            // 數量TextBox
            // 
            this.數量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍BindingSource, "數量", true));
            this.數量TextBox.Location = new System.Drawing.Point(113, 165);
            this.數量TextBox.Name = "數量TextBox";
            this.數量TextBox.Size = new System.Drawing.Size(136, 29);
            this.數量TextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "第一筆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "上一筆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "下一筆";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "最末筆";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "新增";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(131, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "刪除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(221, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "更新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(309, 283);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "結束";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(書號Label);
            this.Controls.Add(this.書號TextBox);
            this.Controls.Add(書名Label);
            this.Controls.Add(this.書名TextBox);
            this.Controls.Add(單價Label);
            this.Controls.Add(this.單價TextBox);
            this.Controls.Add(數量Label);
            this.Controls.Add(this.數量TextBox);
            this.Name = "Form1";
            this.Text = "按鈕版";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}

