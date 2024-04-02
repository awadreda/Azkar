using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter =0;

        private void timer1_Tick(object sender, EventArgs e)
       {
            notifyIcon1.Icon = SystemIcons.Application;

            clsAZKARlogic.FireNotfiy(notifyIcon1,  ref timer1);
        }


         public  void RefrashAzarList()
        {
            dataGridView1.DataSource = clsAZKARlogic.GetAzkarList();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
          notifyIcon1.Icon = SystemIcons.Application;
            clsAZKARlogic.FireNotfiy(notifyIcon1, ref timer1);
        }




        private void btnNudSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
               clsAZKARlogic.setTheTimer(nudTimerDurration, ref clsAZKARlogic.TimerDurration, ref timer1);



            }


        }

        private void nudTimerDurration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrashAzarList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefrashAzarList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clsAZKARlogic.AddZekir(txtAddNew.Text))
            {
                MessageBox.Show("Saved", "info", MessageBoxButtons.OK);
            }
            else
                {

                MessageBox.Show("Not Saved", "info", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if( !(txtIDForDelete.Text == ""))
            {
                if(MessageBox.Show("are you sure ?","confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
                {

                if(clsAZKARlogic.DeleteZekir(Convert.ToInt16(txtIDForDelete.Text)))
                    {
                        MessageBox.Show("was Deleted ", "ifo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ;
                

                }
                else
                    {
                        MessageBox.Show("  Wasn't Deleted ", "ifo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ;
                    }
                }

            }
            else
                    {
                MessageBox.Show("  Enter the ID", "ifo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ;
            }

        }



        //private void testTimer_Tick(object sender, EventArgs e)
        //{
        //    counter++;
        //    lblConter.Text = counter.ToString();

        //}
    }
}
