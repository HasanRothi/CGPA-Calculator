using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace summer16_CgpaCalculator
{
    public partial class Form1 : Form
    {
        double at=0,al=0,cnt=0,cnl=0,ass=0,toc=0,iom=0,c=0,result=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You get : " ,x.ToString() );
           // MessageBox.Show(x.ToString());
            if (c == 0)
            {
                result = (at + al + cnt + cnl + ass + toc + iom) / 14.5;
            }
            else
            {
                result = (at + al + cnt + cnl + ass + toc + iom + c) / 16.0;
            }
           
            //Cgpa & Grade
            if (result == 4.0) { MessageBox.Show(result.ToString(), "A+"); }
            else if (result >=3.75) { MessageBox.Show(result.ToString(), "A"); }
            else if (result >= 3.50) { MessageBox.Show(result.ToString(), "A-"); }
            else if (result >= 3.25) { MessageBox.Show(result.ToString(), "B+"); }
            else if (result >= 3.00) { MessageBox.Show(result.ToString(), "B"); }
            else if (result >= 2.75) { MessageBox.Show(result.ToString(), "B-"); }
            else if (result >= 2.50) { MessageBox.Show(result.ToString(), "C+"); }
            else if (result >= 2.25) { MessageBox.Show(result.ToString(), "C"); }
            else if (result >= 2.00) { MessageBox.Show(result.ToString(), "D"); }
            else { MessageBox.Show(result.ToString(), "F"); } 

            //Next messeage box.
            if (at == 0 || al == 0 || cnt == 0 || cnl == 0 || ass == 0 || toc == 0 || iom == 0 || c==-1 )
            {
                MessageBox.Show("Not Good,You failed.\n\n\tBest wish for next time\n");
            }
            else
            {
                if (result == 4) { MessageBox.Show("Congratulation !!!\n You are Super."); }
                else MessageBox.Show("Congratulation !!!");        
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                at = 4.0; //A+
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                at=3.75;//A
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                at =3.50;//A-
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                at=3.25;//B+
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                at= 3.00;//B
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                at=2.75;//B-
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                at=2.50;//C+
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                at=2.25;//C
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                at=2.0;//D
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                at=0.0;
            }
             at *= 3.0;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                al = 4.0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                al = 3.75;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                al = 3.50;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                al = 3.25;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                al = 3.00;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                al = 2.75;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                al = 2.50;
            }
            else if (comboBox2.SelectedIndex == 7)
            {
                al = 2.25;//C
            }
            else if (comboBox2.SelectedIndex == 8)
            {
                al = 2.0;//D
            }
            else if (comboBox2.SelectedIndex == 9)
            {
                al = 0.0;
            }
            al *= 1.5;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                cnt = 4.0;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                cnt = 3.75;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
               cnt = 3.50;
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                cnt = 3.25;
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                cnt = 3.00;
            }
            else if (comboBox3.SelectedIndex == 5)
            {
                cnt = 2.75;
            }
            else if (comboBox3.SelectedIndex == 6)
            {
                cnt = 2.50;
            }
            else if (comboBox3.SelectedIndex == 7)
            {
                cnt = 2.25;//C
            }
            else if (comboBox3.SelectedIndex == 8)
            {
                cnt = 2.0;//D
            }
            else if (comboBox3.SelectedIndex == 9)
            {
                cnt = 0.0;
            }
             cnt *= 3.0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                cnl = 4.0;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                cnl= 3.75;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                cnl = 3.50;
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                cnl = 3.25;
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                cnl = 3.00;
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                cnl = 2.75;
            }
            else if (comboBox4.SelectedIndex == 6)
            {
                cnl = 2.50;
            }
            else if (comboBox4.SelectedIndex == 7)
            {
                cnl = 2.25;//C
            }
            else if (comboBox4.SelectedIndex == 8)
            {
                cnl = 2.0;//D
            }
            else if (comboBox4.SelectedIndex == 9)
            {
                cnl = 0;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                toc = 4.0;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                toc = 3.75;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                toc = 3.50;
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                toc = 3.25;
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                toc = 3.00;
            }
            else if (comboBox5.SelectedIndex == 5)
            {
                toc = 2.75;
            }
            else if (comboBox5.SelectedIndex == 6)
            {
                toc = 2.50;
            }
            else if (comboBox5.SelectedIndex == 7)
            {
                toc = 2.25;//C
            }
            else if (comboBox5.SelectedIndex == 8)
            {
                toc = 2.0;//D
            }
            else if (comboBox5.SelectedIndex == 9)
            {
                toc = 0.0;
            }
            toc *= 2.0;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
               ass = 4.0;
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                ass = 3.75;
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                ass = 3.50;
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                ass = 3.25;
            }
            else if (comboBox6.SelectedIndex == 4)
            {
                ass = 3.00;
            }
            else if (comboBox6.SelectedIndex == 5)
            {
                ass = 2.75;
            }
            else if (comboBox6.SelectedIndex == 6)
            {
                ass = 2.50;
            }
            else if (comboBox6.SelectedIndex == 7)
            {
                ass = 2.25;//C
            }
            else if (comboBox6.SelectedIndex == 8)
            {
                ass = 2.0;//D
            }
            else if (comboBox6.SelectedIndex == 9)
            {
                ass = 0;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                iom = 4.0;
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                iom = 3.75;
            }
            else if (comboBox7.SelectedIndex == 2)
            {
                iom = 3.50;
            }
            else if (comboBox7.SelectedIndex == 3)
            {
                iom = 3.25;
            }
            else if (comboBox7.SelectedIndex == 4)
            {
                iom = 3.00;
            }
            else if (comboBox7.SelectedIndex == 5)
            {
                iom = 2.75;
            }
            else if (comboBox7.SelectedIndex == 6)
            {
                iom = 2.50;
            }
            else if (comboBox7.SelectedIndex == 7)
            {
                iom = 2.25;//C
            }
            else if (comboBox7.SelectedIndex == 8)
            {
                iom = 2.0;//D
            }
            else if (comboBox7.SelectedIndex == 9)
            {
                iom = 0.0;
            }
             iom *= 3.0;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                c= 4.0;
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                c = 3.75;
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                c = 3.50;
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                c = 3.25;
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                c= 3.00;
            }
            else if (comboBox8.SelectedIndex == 5)
            {
               c = 2.75;
            }
            else if (comboBox8.SelectedIndex == 6)
            {
               c = 2.50;
            }
            else if (comboBox8.SelectedIndex == 7)
            {
                c = 2.25;//C
            }
            else if (comboBox8.SelectedIndex == 8)
            {
                c = 2.0;//D
            }
            else if (comboBox8.SelectedIndex == 9)
            {
                c = 0.0;
            }
            if (c == 0.0) { c = -1; }
            else c *= 1.5;
           
        }

     

       
    }
}
