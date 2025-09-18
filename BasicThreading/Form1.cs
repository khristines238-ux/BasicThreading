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

namespace BasicThreading
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void frmBasicThread_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Before starting thread-";

            Thread threadA = new Thread(new ThreadStart(() => MyThreadClass.Thread1("Thread A")));
            Thread threadB = new Thread(new ThreadStart(() => MyThreadClass.Thread1("Thread B")));

            threadA.Start();
            threadB.Start();    

            threadA.Join();
            threadB.Join();

            lblStatus.Text = "-End of Thread-";
        }
    }
}