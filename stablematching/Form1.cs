using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Windows;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;




namespace stablematching
{
    public partial class Form1 : Form
    {

        /*Initialization of lists for men women and their prefernce lists */
        #region initialization
        List<string> womenslist;
        List<string> menslist;
        List<List<string>> menpriority ;
        List<List<string>> womenpriority;
        List<List<string>> set;
        List<List<string>> stable;
        StreamWriter w = null;
        ArrayList freehusband;
        OpenFileDialog openfiledb;
        Stopwatch stwat = new Stopwatch();
        int n = 0;
        StreamReader r = null;
        string line;
        string[] first;
        string[] second;
        bool i;
        int m;
        int mencount;
        int mencounttest;
        string outputfilename;
        bool check = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
           
        }
       
        /*Summary: browse click is a function to browse the file from 
         required location and read the file line by line .IT also calls
         the function Match_Click and displays the men and women who are involved in this 
         matching*/
        private void browse_Click(object sender, EventArgs e)
        {
             menslist= new List<string>();
             womenslist = new List<string>();
             menpriority = new List<List<string>>();
             womenpriority = new List<List<string>>();

             txtboxdisplayfilerestults.ResetText();
             testtextbox.ResetText();
             txttimer.ResetText();
             openfiledb = new OpenFileDialog();
         
            freehusband = new ArrayList();
            set = new List<List<string>>();
           
            Stream mystream = null;
           
            openfiledb.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            if (openfiledb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = openfiledb.OpenFile()) != null)
                    {

                        txtboxfile.Text=openfiledb.FileName;
                        stwat.Start();
                        check = true;
                        r = new StreamReader(mystream);
                        Global.outputfilename = openfiledb.SafeFileName;
                      
                        filereader(r);
                        #region commentedcode
                        //    while (r.EndOfStream != true)
                        //    {
                        //        line = r.ReadLine();
                               
                        //        if (i ==false)
                        //        {
                        //            n = Convert.ToInt32(line);
                        //            i=true;
                        //        }
                        //        else if (string.IsNullOrEmpty(line.ToString()))
                        //        {
                        //            m = 0;
                        //        }
                        //        else
                        //        {
                        //            first = line.Split(':');
                        //            second = first[1].Split(',');
                        //                if (mencounttest == n)
                        //                {
                                           
                        //                    mencounttest = n-1;
                        //                    womenslist.Add(first[0]);

                        //                    womenpriority.Add(new List<string>());
                        //                   for (int linecount = 0; linecount < second.Count(); linecount++)
                        //                   {
                        //                       womenpriority[m].Add(second[linecount]);
                        //                    mencount++;
                        //                   }
                        //                }
                        //                else
                        //                {
                        //                    menslist.Add(first[0]);
                        //                    freehusband.Add(first[0]);
                        //                    menpriority.Add(new List<string>());
                        //                    for (int linecount = 0; linecount < second.Count(); linecount++)
                        //                    {
                        //                        menpriority[m].Add(second[linecount]);
                        //                    }
                                           
                        //                }
                        //                m++;
                        //                mencounttest++;

                        //            }

                        //}
                        #endregion
                        mystream.Close();
                       
                        //Match_Click(sender, e);
                        #region commentedcode
                        //for (int q = 0; q < menslist.Count; q++)
                            //{
                            //    display = menslist[q].ToString()+ "    " + womenslist[q].ToString();
                                
                            //    txtboxdisplayfilerestults.AppendText(display.ToString() + "\n"+Environment.NewLine);
                                
                            //}

                            

                      //  txtboxdisplayfilerestults.Clear();
                        //display = null;
                        //menslist = null;
                        //womenslist = null;
                        //menpriority = null;
                        //womenpriority = null;
                        #endregion

                    }
                }
                catch (Exception ex)
                {
                  txtboxdisplayfilerestults.Text = "File dosent contain expected format of data";
                }

            }
        }
        public void filereader(StreamReader mystream)
        {

            stwat.Start();
            menslist = new List<string>();
            womenslist = new List<string>();
            menpriority = new List<List<string>>();
            womenpriority = new List<List<string>>();
            freehusband = new ArrayList();
            set = new List<List<string>>();
            bool i = false;

            int m = 0;

            int mencount = 1;
            int mencounttest = 0;
            
            
            
            while (mystream.EndOfStream != true)
            {
                line = mystream.ReadLine();

                if (i == false)
                {
                    n = Convert.ToInt32(line);
                    i = true;
                }
                else if (string.IsNullOrEmpty(line.ToString()))
                {
                    m = 0;
                }
                else
                {
                    first = line.Split(':');
                    second = first[1].Split(',');
                    if (mencounttest == n)
                    {

                        mencounttest = n - 1;
                        womenslist.Add(first[0]);

                        womenpriority.Add(new List<string>());
                        for (int linecount = 0; linecount < second.Count(); linecount++)
                        {
                            womenpriority[m].Add(second[linecount]);
                            mencount++;
                        }
                    }
                    else
                    {
                        menslist.Add(first[0]);
                        freehusband.Add(first[0]);
                        menpriority.Add(new List<string>());
                        for (int linecount = 0; linecount < second.Count(); linecount++)
                        {
                            menpriority[m].Add(second[linecount]);
                        }

                    }
                    m++;
                    mencounttest++;

                }

            }
           

            Match_Click();
        }

        /*Summary : Match_click function runs the algorithm to match men
         with women based on both men and womens priority list*/
        private void Match_Click()
        {
           
            ArrayList husband = new ArrayList();
            string display = null;
            string result = null;
            string filename = "result_" + Global.outputfilename;
            //w = new StreamWriter("C:\\Users\\DELL\\Documents\\Visual Studio 2010\\Projects\\stablematching\\Output Files\\"+filename+".txt");
            w = new StreamWriter(Directory.CreateDirectory(Environment.CurrentDirectory + "\\output_folder") + "\\" + filename + ".txt");
            bool test = false;
            int count = 0;
            int test1=0;
            //Start algorithm to stable match the men and women
            try
            {
                while (freehusband.Count > 0)
                {
                    for (int j = 0; j < menslist.Count; j++)
                    {
                        if (freehusband.Contains(menslist[j]))
                        {

                            for (int i = 0; i < menpriority[j].Count; i++)
                            {

                                string s = menpriority[j].ElementAt(i);
                                int value1 = womenslist.IndexOf(s);
                                if (husband.Contains(menpriority[j].ElementAt(i)))
                                {
                                    int s1 = husband.IndexOf(menpriority[j].ElementAt(i));
                                    string m = menslist[s1];

                                    if (womenpriority[value1].IndexOf(menslist[j]) < womenpriority[value1].IndexOf(m))
                                    {
                                        for (int k = 0; k < set.Count; k++)
                                        {
                                            if (set[k].Contains(m))
                                                set.RemoveAt(k);
                                        }

                                        count = count - 1;
                                        // husband.RemoveAt(s1);
                                        husband[s1] = 0;
                                        freehusband.Add(menslist[s1]);
                                        //husband.Add(0);
                                       
                                        set.Add(new List<string>());
                                        set[count].Add(menslist[j]);
                                        // husband.Add(menpriority[j].ElementAt(i));
                                        if (husband.Count < j+1)
                                        {
                                            test1++;
                                            husband.Add(menpriority[j].ElementAt(i));
                                        }
                                        else
                                        {
                                            husband[j] = menpriority[j].ElementAt(i);
                                            test = true;
                                        }
                                        //  husband.Add(menslist[j]);
                                        set[count].Add(womenslist[value1]);
                                        i = menpriority[j].Count;
                                        freehusband.Remove(menslist[j]);
                                        count++;


                                    }
                                }
                                else
                                {
                                    set.Add(new List<string>());

                                    set[count].Add(menslist[j]);
                                    if (test == true || husband.Count >= n)
                                    {
                                        if (!String.IsNullOrEmpty(husband[j].ToString()) && Convert.ToInt32(husband[j]) == 0)
                                            husband[j] = menpriority[j].ElementAt(i);
                                    }
                                    else
                                    {
                                        husband.Add(menpriority[j].ElementAt(i));
                                    }
                                    // husband.Add(menslist[j]);
                                    set[count].Add(womenslist[value1]);
                                    i = menpriority[j].Count;
                                    freehusband.Remove(menslist[j]);
                                    count++;
                                }
                            }
                        }
                       else
                        {
                       
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                txtboxdisplayfilerestults.Text = "Files doesnt contain required format of Data";
            }
            /*end of algorithm of stable matching of men and women */
            #region commentedcode
            //stwat.Stop();
            //TimeSpan ts = stwat.Elapsed;
            //// string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            //txttimer.Text = Convert.ToString(ts.Duration());
            #endregion
         
                result = "Output of the Stable Matching Problem" + Environment.NewLine + Environment.NewLine;
                display = "Input/Names of men and women in the matrix" + Environment.NewLine + Environment.NewLine;
                for (int l = 0; l < set.Count; l++)
                {
                    result = result + set[l][0].ToString() + " engaged to " + set[l][1].ToString() + "\n" + Environment.NewLine;
                    display = display + menslist[l].ToString() + "    " + womenslist[l].ToString() + "\n" + Environment.NewLine;
                    w.WriteLine(set[l][0] + "-" + set[l][1]);
                }

           
           

            
           /* stops the timer and shows the elapsed time to run the algorithm and write the ouptut to files*/

            stwat.Stop();
           // txttimer.Text = stwat.Elapsed.TotalSeconds.ToString()+"seconds";
            txttimer.Text = stwat.Elapsed.TotalMilliseconds.ToString() + "milliseconds";
           // Global.runningtime.Add(stwat.Elapsed.TotalSeconds);
            Global.runningtime.Add(stwat.Elapsed.TotalMilliseconds);
            stwat.Reset();
            checkstablematch();

         
                for (int m = 0; m < stable.Count; m++)
                {
                    w.WriteLine(stable[m][0].ToString() + "-" + stable[m][1].ToString() + Environment.NewLine);
                    result = result + "unstable matching between follwoing pairs";
                    result = result + stable[m][0].ToString() + "-" + stable[m][1].ToString() + Environment.NewLine;
                }
                if (stable.Count == 0)
                    result = result + Environment.NewLine + "stable matching between pairs";
                testtextbox.AppendText(result);
                txtboxdisplayfilerestults.AppendText(display.ToString());
            
            w.Close();
        }

        private void btncreateinputfiles_Click(object sender, EventArgs e)
        {
            Popcreateinputfiles popup = new Popcreateinputfiles();
            
            DialogResult popupresult = popup.ShowDialog();
            if (popupresult == DialogResult.OK)
            {
                int val = Convert.ToInt16(popup.txtNvalue.Text);
                Global.inputvalN = val.ToString();
                popup.btnOKClick(val);
                popup.Close();
               
               
            }
            else if(popupresult ==DialogResult.Cancel)
            {
                popup.Close();
            }
            
        }
        private void checkstablematch()
        {
           // set.OrderBy(menslist);
            stable = new List<List<string>>();
            set = set.OrderBy(menslist=>menslist[0]).ToList();
            String[] newmen = new String[n];
            for (int i = 0; i < set.Count; i++)
            {
                string valuemen = set[i][0];
                string valuewomen = set[i][1];
                int indexmen = menslist.IndexOf(valuemen);
                int indexwomen = womenslist.IndexOf(valuewomen);
                if (menpriority[indexmen].IndexOf(valuewomen) > 0)
                {
                    for (int j = 0; j < (menpriority[indexmen].IndexOf(valuewomen) - 1); j++)
                    {
                        //var value = (from men in set
                        //            where womenslist[0] == men[1]
                        //            select men);
                        string value=null;
                        List<string> s1 = new List<string>();
                        foreach(List<string> s in set)
                        {
                            if (menpriority[indexmen][j] == s[1])
                            {
                                value = s[0];
                                s1.Add(s[0]);
                                s1.Add(s[1]);
                                break;
                            }
                        }

                        if (womenpriority[womenslist.IndexOf(menpriority[indexmen][j])].IndexOf(valuemen) < womenpriority[womenslist.IndexOf(menpriority[indexmen][j])].IndexOf(value))
                        {
                            stable.Add(set[j]);
                            stable.Add(s1);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxdisplayfilerestults.Clear();
            testtextbox.Clear();
            txttimer.Clear();
        }

      

         
    }
}

