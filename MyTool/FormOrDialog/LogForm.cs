using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool
{
    public partial class LogForm : Form
    {
        public LogForm(string logContent)
        {
            InitializeComponent();

            this.richTextBox.Text = logContent;
        }
    }
}
