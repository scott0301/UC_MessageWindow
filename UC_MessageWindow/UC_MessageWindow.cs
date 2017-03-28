using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_MessageWindow
{
    public partial class UC_BACKPANEL: UserControl
    {
        public UC_BACKPANEL()
        {
            InitializeComponent();
        }

        public void InsertMessage(string msg)
        {
            string strTime = string.Format("[{0:00}-{1:00}|{2:00}:{3:00}:{4:00}:{5:000}] ", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);

            this.Invoke(new MethodInvoker(delegate
            {
                RICH_MESSAGE_WINDOW.AppendText(strTime + msg + System.Environment.NewLine);
                RICH_MESSAGE_WINDOW.ScrollToCaret();
            }));
        }

        public void Clear()
        {
            RICH_MESSAGE_WINDOW.Clear();
        }

        public void SetSize(int w, int h)
        {
            this.Size = new Size(w, h);
            RICH_MESSAGE_WINDOW.Size = new Size(w, h);
        }



    }
}
