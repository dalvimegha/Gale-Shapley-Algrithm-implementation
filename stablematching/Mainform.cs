using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace stablematching
{
    public partial class Mainform : Form
    {
        Form1 f1 = new Form1();
        Popcreateinputfiles p1 = new Popcreateinputfiles();
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnstablematching_Click(object sender, EventArgs e)
        {
            Global.runningtime = new List<double>();
            txtboxnvaluedisplay.Visible = false;
            label1.Visible = false;
           
            f1.TopLevel = false;
            f1.Activate();
            f1.Visible = true;
            Mainform mf = new Mainform();
            mf.Visible = false;
            panel1.Visible = true;
           // panel2.Visible = false;
            panel1.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
            
            



        }

        private void btnN10differentfiles_Click(object sender, EventArgs e)
        {
            txtboxnvaluedisplay.Visible = true;
            label1.Visible = true;
            
            label1.Text = "Running time in Milliseconds where input files n=10 and different input files";
          //  panel1.Visible = false;
          //  panel2.Visible = true;
           
            f1.Close();
            panel1.Controls.Add(txtboxnvaluedisplay);        

            Global.runningtime = new List<double>();
            StreamReader strreader=null;
            Stream str = null;
           // str = File.OpenRead(Environment.CurrentDirectory + "\\input_10.txt");
            f1=new Form1();
            string output = null;
            int filevalue = 1;
           
                int count = 0;
                while (count < 10)
                {
                    Global.inputvalN = "10_"+filevalue.ToString();
                    p1.btnOKClick(10);
                   
                    str = File.OpenRead(Directory.CreateDirectory(Environment.CurrentDirectory + "\\input_folder") + "\\input_10_" + filevalue + ".txt");
                    if (str != null)
                    {
               
                        strreader = new StreamReader(str);
                        Global.outputfilename = "input_10_" + filevalue + ".txt";
                        f1.filereader(strreader);
                        output += Global.runningtime[count].ToString()+Environment.NewLine;
                   
                        count++;
                        filevalue++;
                        str.Close();
                    }
                }
                    
                
                str.Close();
                txtboxnvaluedisplay.Text = output;
                Global.inputvalN = null;
         }

        private void btnN10samefiles_Click(object sender, EventArgs e)
        {
            txtboxnvaluedisplay.Visible = true;
            label1.Visible = true;
            label1.Text = "Running time in Milliseconds where input files n=10 and same input files";
           // panel1.Visible = false;
           
          //  panel2.Visible = true;
            f1.Close();
            panel1.Controls.Add(txtboxnvaluedisplay);
           // Global.inputvalN = Convert.ToString(10);
            Global.inputvalN = "10samefile";
            p1.btnOKClick(10);
           
            Global.runningtime = new List<double>();
            StreamReader strreader = null;
            Stream str = null;
          // str = File.OpenRead(Environment.CurrentDirectory + "\\input_10.txt");
            f1 = new Form1();
            string output = null;
           

                int count = 0;
                Global.outputfilename = "input_10_same_file.txt";
                
                while (count < 10)
                {
                    str = File.OpenRead(Directory.CreateDirectory(Environment.CurrentDirectory + "\\input_folder") + "\\input_10_same.txt");
                    if (str != null)
                    {

                    strreader = new StreamReader(str);
                    f1.filereader(strreader);
                    output += Global.runningtime[count].ToString() + Environment.NewLine;

                    count++;
                    str.Close();

                    }


                }
                
                txtboxnvaluedisplay.Text = output;
                Global.inputvalN = null;
            

        }

        private void btnN1510152050100values_Click(object sender, EventArgs e)
        {
            txtboxnvaluedisplay.Visible = true;
            label1.Visible = true;
            label1.Text = "Running time in Milliseconds where n=1,5,10,15,20,50,100 input files";
           // panel1.Visible = false;
           // panel2.Visible = true;
            f1.Close();
            panel1.Controls.Add(txtboxnvaluedisplay);        
            
           
            Global.runningtime = new List<double>();
            StreamReader strreader = null;
            Stream str = null;
           
           
            f1 = new Form1();
            string output = null;
            
            int[] inutval = new int[] { 1 ,5, 10, 15, 20, 50, 100 };
            int count = 0;
            while (count < 7)
            {
                Global.inputvalN = inutval[count].ToString();
                p1.btnOKClick(inutval[count]);
                str = File.OpenRead(Directory.CreateDirectory(Environment.CurrentDirectory + "\\input_folder") + "\\input_" + inutval[count] + ".txt");
                if (str != null)
                {

                    strreader = new StreamReader(str);
                    Global.outputfilename = "input_" + inutval[count] + ".txt";
                    f1.filereader(strreader);
                    output += Global.runningtime[count].ToString() + Environment.NewLine;

                    count++;
                    
                    str.Close();
                }
            }


            str.Close();
            txtboxnvaluedisplay.Text = output;

        }

       

        

        

       
    }
}
