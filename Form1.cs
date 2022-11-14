using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Alterador_de_IP
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void ChkGM_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkGM.Checked)
            {
                RbGEM.Visible = true;// Exibir Rb GEM
                RbOnix.Visible = true;// Exibir Rb Onix 
            } else
            {
                RbGEM.Visible = false;
                RbOnix.Visible = false;

            }
        }

        private void ChkVW_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVW.Checked)
            {
                RbMBQ.Visible = true;
                RbUP.Visible = true;
            } else
            {
                RbMBQ.Visible = false;
                RbUP.Visible = false;
            }
        }

        private void ChkNissan_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNissan.Checked)

            {
                RbVersa.Visible = true;
                RbFrontier.Visible = true;

            } else
            {
                RbVersa.Visible = false;
                RbFrontier.Visible = false;
            }

        }

        private void RbGEM_CheckedChanged(object sender, EventArgs e)
        {
            if (RbGEM.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-GEM.BAT");
            }
            else { }
        }

        private void RbOnix_CheckedChanged(object sender, EventArgs e)
        {
             if (RbOnix.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-GM.BAT");
            }
            else { }
        }

        private void RbMBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMBQ.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-MQB.BAT");
            }
            else { }

        }

        private void RbUP_CheckedChanged(object sender, EventArgs e)
        {
            if (RbUP.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-UP.BAT");
            }
            else { }
        }

        private void RbVersa_CheckedChanged(object sender, EventArgs e)
        {
            if (RbVersa.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-PROJMQB.BAT");
            }
            else { }
        }

        private void RbFrontier_CheckedChanged(object sender, EventArgs e)
        {
            if (RbFrontier.Checked)
            {
                Process.Start(@"C:\Users\Thamara\Desktop\Leni Panos\IP-GSI\IP-Robo.BAT");
            }
            else { }
        }
    }
}
