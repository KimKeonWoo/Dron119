using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare; // 1

namespace testCam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // 변수선언(Variable)
        private Ojw.CStream m_CStream = new Ojw.CStream();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            m_CStream.Start_MJpeg(lbDisp, "192.168.20.6", 8081, 320, 240);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_CStream.Stop();
        }
    }
}
