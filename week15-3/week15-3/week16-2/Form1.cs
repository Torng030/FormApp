using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace week16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RecordData()
        {
            toolStripTextBox1.Text = "第" + (書籍BindingSource.Position + 1).ToString()
                + "筆，共" + 書籍BindingSource.Count.ToString() + "筆";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);
            RecordData();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.RemoveAt(書籍BindingSource.Position);
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.EndEdit();
                書籍TableAdapter.Update(_p11_1dbDataSet);
                MessageBox.Show("資料更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 第一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveFirst();
            RecordData();
        }

        private void 上一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MovePrevious();
            RecordData();
        }

        private void 下一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveNext();
            RecordData();
        }

        private void 最後一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveLast();
            RecordData();
        }
    }
}
