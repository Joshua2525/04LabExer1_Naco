using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naco_Threads
{
    public partial class BasicThread : Form
    {

        private Thread ThreadA = new Thread(MyThreadClass.Thread1);
        private Thread ThreadB = new Thread(MyThreadClass.Thread1);

        public BasicThread()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "- End of Thread -";

        }
    }
}
    

