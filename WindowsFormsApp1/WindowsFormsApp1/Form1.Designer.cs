namespace WindowsFormsApp1
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
            System.Windows.Forms.Label 客戶編號Label;
            System.Windows.Forms.Label 公司名稱Label;
            System.Windows.Forms.Label 連絡人Label;
            System.Windows.Forms.Label 地址Label;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.p11dbDataSet = new WindowsFormsApp1.p11dbDataSet();
            this.客戶TableAdapter1 = new WindowsFormsApp1.p11dbDataSetTableAdapters.客戶TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.p11dbDataSetTableAdapters.TableAdapterManager();
            this.客戶BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶編號TextBox = new System.Windows.Forms.TextBox();
            this.公司名稱TextBox = new System.Windows.Forms.TextBox();
            this.連絡人TextBox = new System.Windows.Forms.TextBox();
            this.地址TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            客戶編號Label = new System.Windows.Forms.Label();
            公司名稱Label = new System.Windows.Forms.Label();
            連絡人Label = new System.Windows.Forms.Label();
            地址Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p11dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.p11dbDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // p11dbDataSet
            // 
            this.p11dbDataSet.DataSetName = "p11dbDataSet";
            this.p11dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 客戶TableAdapter1
            // 
            this.客戶TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.p11dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.客戶TableAdapter = this.客戶TableAdapter1;
            // 
            // 客戶BindingSource
            // 
            this.客戶BindingSource.DataMember = "客戶";
            this.客戶BindingSource.DataSource = this.p11dbDataSet;
            // 
            // 客戶編號Label
            // 
            客戶編號Label.AutoSize = true;
            客戶編號Label.Location = new System.Drawing.Point(74, 96);
            客戶編號Label.Name = "客戶編號Label";
            客戶編號Label.Size = new System.Drawing.Size(85, 18);
            客戶編號Label.TabIndex = 0;
            客戶編號Label.Text = "客戶編號:";
            // 
            // 客戶編號TextBox
            // 
            this.客戶編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "客戶編號", true));
            this.客戶編號TextBox.Location = new System.Drawing.Point(165, 93);
            this.客戶編號TextBox.Name = "客戶編號TextBox";
            this.客戶編號TextBox.Size = new System.Drawing.Size(100, 29);
            this.客戶編號TextBox.TabIndex = 1;
            // 
            // 公司名稱Label
            // 
            公司名稱Label.AutoSize = true;
            公司名稱Label.Location = new System.Drawing.Point(74, 131);
            公司名稱Label.Name = "公司名稱Label";
            公司名稱Label.Size = new System.Drawing.Size(85, 18);
            公司名稱Label.TabIndex = 2;
            公司名稱Label.Text = "公司名稱:";
            // 
            // 公司名稱TextBox
            // 
            this.公司名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "公司名稱", true));
            this.公司名稱TextBox.Location = new System.Drawing.Point(165, 128);
            this.公司名稱TextBox.Name = "公司名稱TextBox";
            this.公司名稱TextBox.Size = new System.Drawing.Size(100, 29);
            this.公司名稱TextBox.TabIndex = 3;
            // 
            // 連絡人Label
            // 
            連絡人Label.AutoSize = true;
            連絡人Label.Location = new System.Drawing.Point(74, 166);
            連絡人Label.Name = "連絡人Label";
            連絡人Label.Size = new System.Drawing.Size(67, 18);
            連絡人Label.TabIndex = 4;
            連絡人Label.Text = "連絡人:";
            // 
            // 連絡人TextBox
            // 
            this.連絡人TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "連絡人", true));
            this.連絡人TextBox.Location = new System.Drawing.Point(165, 163);
            this.連絡人TextBox.Name = "連絡人TextBox";
            this.連絡人TextBox.Size = new System.Drawing.Size(100, 29);
            this.連絡人TextBox.TabIndex = 5;
            // 
            // 地址Label
            // 
            地址Label.AutoSize = true;
            地址Label.Location = new System.Drawing.Point(74, 201);
            地址Label.Name = "地址Label";
            地址Label.Size = new System.Drawing.Size(49, 18);
            地址Label.TabIndex = 6;
            地址Label.Text = "地址:";
            // 
            // 地址TextBox
            // 
            this.地址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "地址", true));
            this.地址TextBox.Location = new System.Drawing.Point(165, 198);
            this.地址TextBox.Name = "地址TextBox";
            this.地址TextBox.Size = new System.Drawing.Size(100, 29);
            this.地址TextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(77, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(268, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(371, 322);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(客戶編號Label);
            this.Controls.Add(this.客戶編號TextBox);
            this.Controls.Add(公司名稱Label);
            this.Controls.Add(this.公司名稱TextBox);
            this.Controls.Add(連絡人Label);
            this.Controls.Add(this.連絡人TextBox);
            this.Controls.Add(地址Label);
            this.Controls.Add(this.地址TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p11dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private p11dbDataSet p11dbDataSet;
        private p11dbDataSetTableAdapters.客戶TableAdapter 客戶TableAdapter1;
        private p11dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource 客戶BindingSource;
        private System.Windows.Forms.TextBox 客戶編號TextBox;
        private System.Windows.Forms.TextBox 公司名稱TextBox;
        private System.Windows.Forms.TextBox 連絡人TextBox;
        private System.Windows.Forms.TextBox 地址TextBox;
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

