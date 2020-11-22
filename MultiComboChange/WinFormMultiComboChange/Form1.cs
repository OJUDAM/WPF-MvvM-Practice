using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyData;

namespace WinFormMultiComboChange
{
    public partial class Form1 : Form
    {
        private Data data;
        public Form1()
        {
            InitializeComponent();

            data = new Data();

            this.Load += Form1_Load;
            cbxDiv.SelectedValueChanged += cbxDiv_SelectedValueChanged;
            cbxComCd.SelectedValueChanged += cbxComCd_SelectedValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxDiv.DataSource = data.GetAllDivCom().ToList();
            cbxDiv.ValueMember = "DivCd";
            cbxDiv.DisplayMember = "DivNm";
        }

        private void cbxDiv_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxComCd.DataSource = data.FindComCode(cbxDiv.SelectedValue.ToString()).ToList();
            cbxComCd.ValueMember = "ComCd";
            cbxComCd.DisplayMember = "ComCdNm";
        }

        private void cbxComCd_SelectedValueChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "[" + cbxComCd.SelectedValue + ":" + cbxComCd.Text + "]";
        }
    }
}
