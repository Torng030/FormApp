using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍TableAdapter.Fill(this._p11_1dbDataSet.書籍);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.AddNew();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);  
            } 
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            書籍BindingSource.RemoveAt(書籍BindingSource.Position);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                書籍BindingSource.EndEdit();
                書籍TableAdapter.Update(_p11_1dbDataSet);
                MessageBox.Show("資料更新成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
