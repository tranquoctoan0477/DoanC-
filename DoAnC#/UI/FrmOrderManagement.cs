using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.UI
{
    public partial class FrmOrderManagement : Form
    {
        FrmDSMon GoiMon;
        public FrmOrderManagement()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) 
            {
                pandropGoiMon.Height += 10;
                if(pandropGoiMon.Height >= 172)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }
            else 
            {
                pandropGoiMon.Height -= 10;
                if (pandropGoiMon.Height <= 54)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            if(GoiMon == null)
            {
                GoiMon = new FrmDSMon();
                GoiMon.FormClosed += GoiMon_FormColsed;
                GoiMon.MdiParent = this;
                GoiMon.Show();
            }
            else 
            {
                GoiMon.Activate(); 
            }
        }
        private void GoiMon_FormColsed(object sender, EventArgs e)
        {
            GoiMon = null;
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
                flowpanMenuChucNang.Width -= 10;   
                if(flowpanMenuChucNang.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    
                }
            }
            else
            {
                flowpanMenuChucNang.Width += 10;
                if (flowpanMenuChucNang.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void PictbMenuHamperger_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
