using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class MessageBox_confirmation : Form
    {
        public String Message;
        public MessageBox_confirmation(string Message)
        {
            InitializeComponent();
            this.Message = Message;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MessageBox_confirmation_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = this.Message;
        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
