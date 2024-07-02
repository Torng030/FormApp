using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RecordData()
        {
            label1.Text = "第" + (書籍BindingSource.Position + 1).ToString()
                + "第,共" + 書籍BindingSource.Count.ToString() + "筆";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);
            label1.Text = "";
            RecordData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveFirst();
            RecordData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MovePrevious();
            RecordData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveNext();
            RecordData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            書籍BindingSource.MoveLast();
            RecordData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.AddNew();
                RecordData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            書籍BindingSource.RemoveAt(書籍BindingSource.Position);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.EndEdit();
                書籍TableAdapter.Update(_p11_1dbDataSet);
                MessageBox.Show("資料更新成功");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
