using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniPomodoro
{
    public partial class Msg : Form
    {
        string msgTitle = "";
        string msgSubTitle = "";
        string msg = "";
        string msgFooter = "";
        public Msg()
        {

            InitializeComponent();
        }

        private void Msg_Load(object sender, EventArgs e)
        {
            lblMsgTitle.Text = msgTitle;
            lblSubTitle.Text = msgSubTitle;
            lblMsg.Text = msg;
            lblMsgFooter.Text = msgFooter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            // this.Dispose();
        }
        public void SetMsgContent(string msgTitle,string msgSubTitle,string msg,string msgFooter)
        {
            this.msg = msg;
            this.msgTitle = msgTitle;
            this.msgSubTitle = msgSubTitle;
            this.msgFooter = msgFooter;
        }
    }
}
