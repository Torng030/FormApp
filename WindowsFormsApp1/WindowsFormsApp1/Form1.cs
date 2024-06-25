using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.p11dbDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RecordData()
        {
            label1.Text= "第" + (客戶BindingSource.Position + 1).ToString()
                + "第,共" + 客戶BindingSource.Count.ToString() + "筆";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.客戶TableAdapter1.Fill(this.p11dbDataSet.客戶);
            label1.Text = "";
            RecordData();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            客戶BindingSource.MoveFirst();
            RecordData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            客戶BindingSource.MovePrevious();
            RecordData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            客戶BindingSource.MoveNext();
            RecordData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            客戶BindingSource.MoveLast();
            RecordData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                客戶BindingSource.AddNew();
                RecordData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            客戶BindingSource.RemoveAt(客戶BindingSource.Position);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                客戶BindingSource.EndEdit();
                客戶TableAdapter1.Update(p11dbDataSet);
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
