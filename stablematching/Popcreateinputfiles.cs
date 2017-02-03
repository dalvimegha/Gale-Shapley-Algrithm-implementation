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
    public partial class Popcreateinputfiles : Form
    {
        StreamWriter wr;
         List<List<int>> prefernce;
         Random r;
         int n;
         int countofcall;
         
        // List<List<int>> prefernce;
        public Popcreateinputfiles()
        {
            InitializeComponent();
        }

        private List<List<int>> call(int inputvalue)
        {
            
            if(!string.IsNullOrEmpty(txtNvalue.Text))
            n = Convert.ToInt32(txtNvalue.Text);
            else
            n = inputvalue;
            
           int numbers;
           // List<List<int>> prefernce = new List<List<int>>();
           prefernce = new List<List<int>>();
            HashSet<int> val = new HashSet<int>();
            r = new Random();
            int count = 0;
           // wr = new StreamWriter(Environment.CurrentDirectory + "//inputfile.txt");
          //  wr.Write(n + Environment.NewLine);
            int ival = 0;
            for (int i = 0; i < n; i++)
            {
                count = 0;
               
                if (countofcall == 0)
                {
                   
                    prefernce.Add(new List<int>());
                    while (prefernce[i].Count < n)
                    {

                        numbers = r.Next(n);
                        if (prefernce[i].Contains(numbers + 1)) ;
                        else prefernce[i].Add(numbers + 1);
                        count++;
                    }
                }
                //else
                //{
                //    prefernce.Add(new List<int>());
                //    ival = prefernce.Count();
                //    while (ival > 0)
                //    {
                       
                //        int z = r.Next(prefernce.Count);
                //        if (prefernce[i].Contains(z + 1)) ;
                //        else 
                //        {
                //            ival--;
                //            prefernce[i].Add(prefernce[z][ival]);
                //        }

                //    }
                //}
                
            }
            return(prefernce);
        }

        public void btnOKClick(int intvalue)
        {
            
             countofcall = 0;
             List<List<int>> preferncemen = new List<List<int>>();
             string filenameinput;
            
             preferncemen = call(intvalue);
             countofcall++;
             if (Global.inputvalN.Contains("_"))
                 filenameinput = "input_" + Global.inputvalN + ".txt";
             else if (Global.inputvalN.Contains("10samefile"))
                 filenameinput = "input_" + n + "_same.txt";
             else
                 filenameinput = "input_" + n + ".txt";
            
           wr = new StreamWriter(Directory.CreateDirectory(Environment.CurrentDirectory + "\\input_folder") +"//"+filenameinput);
           // wr.Write(txtNvalue.Text + Environment.NewLine);
           wr.Write(n + Environment.NewLine);

            for (int i = 0; i < preferncemen.Count; i++)
            {
                wr.Write("m_" + (i+1) + ":");
                for (int j = 0; j < preferncemen.Count; j++)
                {
                    wr.Write("w_" + preferncemen[i][j]);
                    if(j != (preferncemen.Count -1))
                    wr.Write(",");
                }
                
                wr.Write(Environment.NewLine);
            }
            List<List<int>> preferncewomen = new List<List<int>>();
            
            wr.Write(Environment.NewLine);
            int ival = 0;
            for (int k = 0; k < preferncemen.Count; k++)
            {
                preferncewomen.Add(new List<int>());
                ival = preferncemen.Count();
                ival = ival - 1;
                while (ival >= 0)
                {
                    // ival--;
                   
                    int z = r.Next(preferncemen.Count);
                    int result = preferncemen[k][z];
                    if (preferncewomen[k].Contains(result)) ;
                    else
                    {
                        preferncewomen[k].Add(result);
                        ival--;
                    }
                      

                }
            }

            
            for (int i = 0; i < preferncewomen.Count; i++)
            {
                wr.Write("w_" + (i+1) + ":");
                for (int j = 0; j < preferncewomen.Count; j++)
                {
                    wr.Write("m_" + preferncewomen[i][j]);
                    if (j != (preferncewomen.Count - 1))
                        wr.Write(",");
                }
                wr.Write(Environment.NewLine);
            }
            wr.Close();
          
            }


       
}
}
           

        

       
    

