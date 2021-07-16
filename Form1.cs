using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace memory_allocation_program
{
    public partial class Form1 : Form
    {
        public static Memory memory1;
        public class Memory
        {
            public List<string> doesntfit = new List<string>();
            public bool reset = false;
            public int resetnum = 0;
            public string[] outputName = new string[100];
            public int[] outputStart = new int[100];
            public int[] outputEnd = new int[100];
            public bool messageshow = true;
            public int indexofkarim = 0;
            public int numberofsegments;
            public string[] holes = new string[100];
            public int[] starthole = new int[100];
            public int[] endhole = new int[100];
            public string[] segmentname = new string[100];
            public int[] segmentsize = new int[100];
            public string[] segments = new string[100];
            public int[] segmentstart = new int[100];
            public int[] segmentend = new int[100];
            public string[] newsegments = new string[100];
            public int[] newsegmentstart = new int[100];
            public int[] newsegmentend = new int[100];
            public bool[] holeplaces = new bool[100];
            public bool[] lastholeplaces = new bool[100];
            public string[] order = new string[200];
            public int[] start = new int[100];
            public int[] end = new int[100];
            public string[] lastorder = new string[200];
            public int[] laststart = new int[100];
            public int[] lastend = new int[100];
            public bool[] holecompleted = new bool[100];
            public bool[] fit = new bool[100];
            public bool[] segmentfit = new bool[100];
            public int[] p = new int[100];
            public int[] oldp = new int[100];
            public int[] newp = new int[100];
            public int[] pindex = new int[100];
            public int[] lastp = new int[100];
            public int lastindex = 0;
            public int memsize;
            public int num;//no of holes
            public int n;//no of process    we don't need to creat it inside class we can take it from GUI (not used any where inside class)
            public int indexofpro = 0;// we can creat it outside class but global and increment it till ----> (n)
            public int indexofsegment = 0; //incremented with all segment to reach end of segment in last pro
            public int indexofholes = 0;
            public int lastcount = 0;
            public void resetdata()
            {
                reset = false;
                resetnum = 0;
                Array.Clear(outputName, 0, outputName.Length);
                Array.Clear(outputStart, 0, outputStart.Length);

                Array.Clear(outputEnd, 0, outputEnd.Length);

                Array.Clear(holes, 0, holes.Length);

                Array.Clear(starthole, 0, starthole.Length);
                Array.Clear(endhole, 0, endhole.Length);
                Array.Clear(segmentname, 0, segmentname.Length);
                Array.Clear(segmentsize, 0, segmentsize.Length);
                Array.Clear(segments, 0, segments.Length);
                Array.Clear(segmentstart, 0, segmentstart.Length);
                Array.Clear(segmentend, 0, segmentend.Length);
                Array.Clear(newsegments, 0, newsegments.Length);
                Array.Clear(newsegmentstart, 0, newsegmentstart.Length);
                Array.Clear(newsegmentend, 0, newsegmentend.Length);
                Array.Clear(holeplaces, 0, holeplaces.Length);

                Array.Clear(lastholeplaces, 0, lastholeplaces.Length);

                Array.Clear(order, 0, order.Length);

                Array.Clear(start, 0, start.Length);

                Array.Clear(end, 0, end.Length);
                Array.Clear(lastorder, 0, lastorder.Length);
                Array.Clear(laststart, 0, laststart.Length);
                Array.Clear(lastend, 0, lastend.Length);
                Array.Clear(holecompleted, 0, holecompleted.Length);
                Array.Clear(fit, 0, fit.Length);
                Array.Clear(segmentfit, 0, segmentfit.Length);
                Array.Clear(p, 0, p.Length);

                Array.Clear(oldp, 0, oldp.Length);
                Array.Clear(newp, 0, newp.Length);
                Array.Clear(pindex, 0, pindex.Length);
                Array.Clear(lastp, 0, lastp.Length);
                Array.Clear(segmentfit, 0, segmentfit.Length);
                indexofkarim = 0;
                numberofsegments = 0;
                lastindex = 0;
                memsize = 0;
                num = 0;//no of holes
                n = 0;//no of process    we don't need to creat it inside class we can take it from GUI (not used any where inside class)
                indexofpro = 0;// we can creat it outside class but global and increment it till ----> (n)
                indexofsegment = 0; //incremented with all segment to reach end of segment in last pro
                indexofholes = 0;
                lastcount = 0;
            }
            public void initializeholes()
            {

                int thole;
                string temphole;
                for (var i = 0; i < num; i++)
                {
                    for (var j = i + 1; j < num; j++)
                    {
                        if (starthole[i] > starthole[j])
                        {
                            thole = starthole[i];
                            starthole[i] = starthole[j];
                            starthole[j] = thole;

                            thole = endhole[i];
                            endhole[i] = endhole[j];
                            endhole[j] = thole;

                            temphole = holes[i];
                            holes[i] = holes[j];
                            holes[j] = temphole;


                        }
                    }
                }
            }
            void helpedFunction(int s)
            {
                int newindex = 0;
                for (int i = 0; i < s; i++)
                {
                    if (segmentfit[i] == true)
                    {
                        newsegments[newindex] = segments[i];
                        newsegmentstart[newindex] = segmentstart[i];
                        newsegmentend[newindex] = segmentend[i];
                        newp[newindex] = oldp[i];  //test 
                        newindex++;
                    }
                    else
                    {
                        continue;
                    }
                }


                //testing
                int t;
                string temp;
                // bool flagtemp;
                for (var i = 0; i < newindex; i++)
                {
                    for (var j = i + 1; j < newindex; j++)
                    {
                        if (newsegmentstart[i] > newsegmentstart[j])
                        {
                            t = newsegmentstart[i];
                            newsegmentstart[i] = newsegmentstart[j];
                            newsegmentstart[j] = t;

                            t = newsegmentend[i];
                            newsegmentend[i] = newsegmentend[j];
                            newsegmentend[j] = t;

                            t = newp[i];
                            newp[i] = newp[j];
                            newp[j] = t;

                            temp = newsegments[i];
                            newsegments[i] = newsegments[j];
                            newsegments[j] = temp;

                            /*flagtemp = segmentfit[i];
                            segmentfit[i] = segmentfit[j];
                            segmentfit[j] = flagtemp;*/
                        }
                    }
                }

                //testing algorithm
                int index = 0;
                int l_index = 0;
                int r_index = 0;
                while (l_index < num && r_index < newindex)
                {
                    if (starthole[l_index] <= newsegmentstart[r_index])
                    {
                        start[index] = starthole[l_index];
                        end[index] = start[index] + (endhole[l_index] - starthole[l_index]);
                        order[index] = holes[l_index];
                        holeplaces[index] = true;
                        l_index++;
                        index++;
                    }
                    else
                    {
                        start[index] = newsegmentstart[r_index];
                        end[index] = start[index] + (newsegmentend[r_index] - newsegmentstart[r_index]);
                        order[index] = newsegments[r_index];
                        holeplaces[index] = false;
                        //lastfit[index] = segmentfit[r_index];
                        pindex[index] = newp[r_index];
                        r_index++;
                        index++;
                    }
                }

                // Copy the remaining elements of either the left or the right half.
                while (l_index < num)
                {
                    start[index] = starthole[l_index];
                    end[index] = start[index] + (endhole[l_index] - starthole[l_index]);
                    order[index] = holes[l_index];
                    holeplaces[index] = true;
                    l_index++;
                    index++;
                }
                while (r_index < newindex)
                {
                    start[index] = newsegmentstart[r_index];
                    end[index] = start[index] + (newsegmentend[r_index] - newsegmentstart[r_index]);
                    order[index] = newsegments[r_index];
                    holeplaces[index] = false;
                    //lastfit[index] = segmentfit[r_index];
                    pindex[index] = newp[r_index];
                    r_index++;
                    index++;
                }

                //printing

                int movingindex = 0;
                bool finish = false;
                if (start[0] != 0)
                {
                    lastorder[0] = "Old process";
                    laststart[0] = 0;
                    lastend[0] = start[0];
                    lastp[0] = 1000;
                    lastholeplaces[0] = false;
                    lastindex++;
                }
                while (finish == false)
                {

                    lastorder[lastindex] = order[movingindex];
                    laststart[lastindex] = start[movingindex];
                    lastend[lastindex] = end[movingindex];
                    lastholeplaces[lastindex] = holeplaces[movingindex];

                    if (lastholeplaces[lastindex] == false)
                    {
                        lastp[lastindex] = pindex[movingindex];

                    }
                    lastindex++;
                    movingindex++;
                    if (movingindex != index)
                    {
                        if (start[movingindex] != end[movingindex - 1])
                        {
                            lastorder[lastindex] = "Old process";
                            laststart[lastindex] = end[movingindex - 1];
                            lastend[lastindex] = start[movingindex];
                            lastholeplaces[lastindex] = false;
                            lastp[lastindex] = 1000;
                            lastindex++;
                        }
                    }
                    if (movingindex == index)
                    {
                        finish = true;
                        //break;
                    }

                }
                if (lastend[lastindex - 1] != memsize)
                {
                    lastorder[lastindex] = "Old process";
                    laststart[lastindex] = end[movingindex - 1];
                    lastend[lastindex] = memsize;
                    lastp[lastindex] = 1000;
                    lastindex++;
                }
                for (int i = 0; i < lastindex; i++)
                {
                    if (laststart[i] == lastend[i])
                    {
                        continue;
                    }
                    //Console.WriteLine(lastorder[i] + "  " + laststart[i] + "  " + lastend[i]);
                    outputEnd[lastcount] = lastend[i];
                    outputStart[lastcount] = laststart[i];
                    outputName[lastcount] = lastorder[i];
                    //Console.WriteLine(outputName[lastcount] + "  " + outputStart[lastcount] + "  " + outputEnd[lastcount]);
                    lastcount++;
                }
                //Console.WriteLine(lastcount);

            }
            public void FFit()
            {

                /* string nameofsegment;
                 int indexofsegment = 0;
                 for (int i = 0; i < n; i++)
                 {
                     //nameofsegment = null;
                     processes[i] = "P" + i;
                     Console.WriteLine("input number of segments of process " + processes[i] + ":");
                     numofsegments[i] = Convert.ToInt32(Console.ReadLine());
                     for (int j = 0; j < numofsegments[i]; j++)
                     {
                         //the problem is from here
                         Console.WriteLine("input name of segment:");
                         nameofsegment = Console.ReadLine();
                         segmentname[indexofsegment] = "P" + i + ":" + nameofsegment;
                         //to here
                         Console.WriteLine("input size of segment:");
                         segmentsize[indexofsegment] = Convert.ToInt32(Console.ReadLine());
                         p[indexofsegment] = i;
                         fit[indexofsegment] = true;
                         indexofsegment++;
                     }
                 }*/
                // int processnum = 0;
                int segmentnum = 0;
                bool completed = false;
                int s = 0;
                while (completed == false)
                {
                    for (int k = 0; k < num; k++)
                    {
                        if (segmentsize[segmentnum] <= (endhole[k] - starthole[k]))
                        {
                            segmentstart[s] = starthole[k];
                            segmentend[s] = segmentstart[s] + segmentsize[segmentnum];

                            segments[s] = segmentname[segmentnum];
                            oldp[s] = p[segmentnum]; //test
                            segmentfit[s] = fit[segmentnum];
                            if (segmentfit[s] == true)
                            {
                                starthole[k] = starthole[k] + segmentsize[segmentnum];
                            }

                            s++;
                            segmentnum++;

                            break;
                        }
                        else
                        {
                            if (k == num - 1)
                            {
                                //Console.WriteLine("process p" + p[segmentnum] + " does not fit");
                                doesntfit.Add(Convert.ToString(p[segmentnum]));
                                //fit[segmentnum] = false;
                                for (var j = 0; j < indexofsegment; j++)
                                {
                                    if (p[j] == p[segmentnum])
                                    {
                                        fit[j] = false;
                                        if (j < s)
                                        {
                                            segmentfit[j] = false;
                                            for (int i = 0; i < num; i++)
                                            {
                                                if (segmentend[j] == starthole[i])
                                                {
                                                    starthole[i] = starthole[i] - (segmentend[j] - segmentstart[j]);
                                                    break;
                                                }
                                                //heref
                                            }
                                        }
                                    }
                                }

                                segmentnum++;
                                //break;
                            }
                        }

                    }
                    if (segmentnum == indexofsegment)
                    {
                        completed = true;
                        //break;
                    }
                }
                helpedFunction(s);
            }
            public void BFit()
            {
                int min;
                int segmentnum = 0;
                bool completed = false;
                int s = 0;
                while (completed == false)
                {
                    min = 10000000;
                    int minholeindex = 100;
                    for (int k = 0; k < num; k++)
                    {
                        if ((endhole[k] - starthole[k] < min) && (segmentsize[segmentnum] <= (endhole[k] - starthole[k])))
                        {
                            min = endhole[k] - starthole[k];
                            minholeindex = k;
                        }
                    }
                    if (min == 10000000)
                    {
                        //Console.WriteLine("process p" + p[segmentnum] + " does not fit");
                        //fit[segmentnum] = false;
                        doesntfit.Add(Convert.ToString(p[segmentnum]));
                        for (var j = 0; j < indexofsegment; j++)
                        {
                            if (p[j] == p[segmentnum])
                            {
                                fit[j] = false;
                                if (j < s)
                                {
                                    segmentfit[j] = false;
                                    for (int i = 0; i < num; i++)
                                    {
                                        if (segmentend[j] == starthole[i])
                                        {
                                            starthole[i] = starthole[i] - (segmentend[j] - segmentstart[j]);
                                            break;
                                        }
                                        //heref
                                    }
                                }
                            }
                        }

                        segmentnum++;
                        //break;
                    }
                    else
                    {
                        segmentstart[s] = starthole[minholeindex];
                        segmentend[s] = segmentstart[s] + segmentsize[segmentnum];

                        segments[s] = segmentname[segmentnum];
                        oldp[s] = p[segmentnum]; //test
                        segmentfit[s] = fit[segmentnum];
                        if (segmentfit[s] == true)
                        {
                            starthole[minholeindex] = starthole[minholeindex] + segmentsize[segmentnum];
                        }

                        s++;
                        segmentnum++;
                    }
                    if (segmentnum == indexofsegment)
                    {
                        completed = true;
                        //break;
                    }

                }
                helpedFunction(s);
            }
            public void WFit()
            {
                int segmentnum = 0;
                bool completed = false;
                int s = 0;
                int max;
                while (completed == false)
                {
                    max = -10;
                    int maxholeindex = 100;
                    for (int k = 0; k < num; k++)
                    {
                        if ((endhole[k] - starthole[k] > max) && (segmentsize[segmentnum] <= (endhole[k] - starthole[k])))
                        {
                            max = endhole[k] - starthole[k];
                            maxholeindex = k;
                        }
                    }
                    if (max == -10)
                    {
                        //Console.WriteLine("process p" + p[segmentnum] + " does not fit");
                        //fit[segmentnum] = false;
                        doesntfit.Add(Convert.ToString(p[segmentnum]));
                        for (var j = 0; j < indexofsegment; j++)
                        {
                            if (p[j] == p[segmentnum])
                            {
                                fit[j] = false;
                                if (j < s)
                                {
                                    segmentfit[j] = false;

                                    for (int i = 0; i < num; i++)
                                    {
                                        if (segmentend[j] == starthole[i])
                                        {
                                            starthole[i] = starthole[i] - (segmentend[j] - segmentstart[j]);
                                            break;
                                        }
                                        //heref
                                    }
                                }
                            }
                        }

                        segmentnum++;
                        //break;
                    }
                    else
                    {
                        segmentstart[s] = starthole[maxholeindex];
                        segmentend[s] = segmentstart[s] + segmentsize[segmentnum];

                        segments[s] = segmentname[segmentnum];
                        oldp[s] = p[segmentnum]; //test
                        segmentfit[s] = fit[segmentnum];
                        if (segmentfit[s] == true)
                        {
                            starthole[maxholeindex] = starthole[maxholeindex] + segmentsize[segmentnum];
                        }

                        s++;
                        segmentnum++;
                    }

                    if (segmentnum == indexofsegment)
                    {
                        completed = true;
                        //break;
                    }


                }
                helpedFunction(s);
            }
            public void Deallocation(string ans, int value)
            {
                if (ans == "allocated")
                {
                    int processindex = value;
                    for (int i = 0; i < lastindex; i++)
                    {
                        if (lastholeplaces[i] == false && lastp[i] == processindex)
                        {
                            if (i != 0 && lastholeplaces[i - 1] == true)
                            {
                                lastend[i - 1] = lastend[i];
                                laststart[i] = lastend[i];
                            }
                            else if (i != (lastindex - 1) && lastholeplaces[i + 1] == true)
                            {
                                laststart[i + 1] = laststart[i];
                                lastend[i] = laststart[i];
                            }
                            else if ((i != 0 && lastholeplaces[i - 1] == false) && (i != (lastindex - 1) && lastholeplaces[i + 1] == false))
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                /*laststart[lastindex] = start[movingindex];
                                lastend[lastindex] = end[movingindex];
                                lastindex++;*/
                                num++;
                            }
                            else if (i == 0 && lastholeplaces[i + 1] == true)  //test
                            {
                                laststart[i + 1] = laststart[i];
                                lastend[i] = laststart[i];
                            }
                            else if (i == 0)  //test
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                /*laststart[lastindex] = start[movingindex];
                                lastend[lastindex] = end[movingindex];
                                lastindex++;*/
                                num++;
                            }

                            else if (i == (lastindex - 1))
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                /*laststart[lastindex] = start[movingindex];
                                lastend[lastindex] = end[movingindex];
                                lastindex++;*/
                                num++;
                            }
                        }
                    }
                }
                if (ans == "old")
                {
                    int oldaddress = value;
                    for (int i = 0; i < lastindex; i++)
                    {
                        if (laststart[i] == oldaddress && lastp[i] == 1000)
                        {
                            if (i != 0 && lastholeplaces[i - 1] == true)
                            {
                                lastend[i - 1] = lastend[i];
                                laststart[i] = lastend[i];
                            }
                            else if (i != (lastindex - 1) && lastholeplaces[i + 1] == true)
                            {
                                laststart[i + 1] = laststart[i];
                                lastend[i] = laststart[i];
                            }
                            else if ((i != 0 && lastholeplaces[i - 1] == false) && (i != (lastindex - 1) && lastholeplaces[i + 1] == false))
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                num++;
                            }
                            else if (i == 0 && lastholeplaces[i + 1] == true)  //test
                            {
                                laststart[i + 1] = laststart[i];
                                lastend[i] = laststart[i];
                            }
                            else if (i == 0)  //test
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                num++;
                            }

                            else if (i == (lastindex - 1))
                            {
                                lastorder[i] = "Hole" + num;
                                lastholeplaces[i] = true;
                                num++;
                            }
                            break;
                        }
                    }
                }

                //for(int i = 0;i<lastindex; i++)
                //{
                //    if(i != lastindex - 1)
                //    {
                //        if(lastholeplaces[i] == true && lastholeplaces[i+1]==true)
                //        {
                //            lastend[i] = lastend[i + 1];
                //            laststart[i + 1] = lastend[i + 1];
                //            lastholeplaces[i + 1] = false;
                //        }

                //    }
                //}

                Array.Clear(outputName, 0, outputName.Length);
                Array.Clear(outputStart, 0, outputStart.Length);
                Array.Clear(outputEnd, 0, outputEnd.Length);
                List<string> tempName = new List<string>();
                List<int> tempStart = new List<int>();
                List<int> tempEnd = new List<int>();



                lastcount = 0;
                int tempcount = 0;
                //string temp0;
                //string temp1;
                for (int i = 0; i < lastindex; i++)
                {
                    if (laststart[i] == lastend[i])
                    {
                        continue;
                    }
                    tempEnd.Add(lastend[i]);
                    tempStart.Add(laststart[i]);
                    tempName.Add(lastorder[i]);
                }
                //for (int i = 0; i < tempcount; i++)
                //{
                //    if(i!=tempcount)
                //    {
                //        temp0 = tempName[i];
                //        temp1 = tempName[i + 1];
                //        if(temp0[0]=='H'&&temp1[0]=='H')
                //        {
                //            tempEnd[i] = tempEnd[i + 1];
                //            tempStart[i + 1] = tempEnd[i + 1];
                //        }
                //    }
                //    outputName[lastcount] = tempName[i];
                //    outputStart[lastcount] = tempStart[i];
                //    outputEnd[lastcount] = tempEnd[i];
                //    lastcount++;
                //}
                tempcount = 0;
                string temp0;
                string temp1;
                for (int i = 0; i < tempName.Count(); i++)
                {

                    if (i != tempName.Count() - 1)
                    {
                        temp0 = tempName[i];
                        temp1 = tempName[i + 1];
                        if (temp0[0] == 'H' && temp1[0] == 'H')
                        {
                            tempEnd[i] = tempEnd[i + 1];
                            tempName.RemoveAt(i + 1);
                            tempStart.RemoveAt(i + 1);
                            tempEnd.RemoveAt(i + 1);
                            i--;
                        }
                        else
                        {
                            outputName[tempcount] = tempName[i];
                            outputStart[tempcount] = tempStart[i];
                            outputEnd[tempcount] = tempEnd[i];
                            tempcount++;

                        }
                    }
                    else
                    {
                        outputName[tempcount] = tempName[i];
                        outputStart[tempcount] = tempStart[i];
                        outputEnd[tempcount] = tempEnd[i];
                        tempcount++;
                    }

                }
                lastcount = tempcount;


                /*for (int i = 0; i < lastindex; i++)
                {
                    if (laststart[i] == lastend[i])
                    {
                        continue;
                    }
                    outputEnd[lastcount] = lastend[i];
                    outputStart[lastcount] = laststart[i];
                    outputName[lastcount] = lastorder[i];
                    lastcount++;
                }*/

            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void totalMemory_TextChanged(object sender, EventArgs e)
        {

        }

        private void holesNumberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(totalMemory.Text);
                if(firstFit.Checked == false && bestFit.Checked == false && worstFit.Checked == false)
                {
                    MessageBox.Show("Please Choose Algorithm Type!");
                }
                else if (size <= 0)
                {
                    MessageBox.Show("Total Memory Size Can't be Zero or Less!");
                    totalMemory.Text = "";
                    numberOfHoles.Text = "";

                }
                //else if (Convert.ToInt32(numberOfHoles.Text) == 0)
                //{
                //    MessageBox.Show("No Holes. You Can Only Plot!");
                //    memory1.num = 0;
                //    memory1.n = 0;
                //    memory1.holes[memory1.indexofholes] = "Hole " + memory1.indexofholes;
                //    memory1.starthole[memory1.indexofholes] = 0;
                //    memory1.endhole[memory1.indexofholes] = 0;
                //    memory1.holecompleted[memory1.indexofholes] = false;
                //    plot.Enabled = true;
                //    holesNumberBTN.Enabled = false;
                //    totalMemory.Enabled = false;
                //    numberOfHoles.Enabled = false;

                //}
                else
                {
                    memory1.memsize = size;
                    size = Convert.ToInt32(numberOfHoles.Text); 
                    if (size <= 0)
                    {
                        MessageBox.Show("Number of Holes Can't be Zero or Less!");
                        totalMemory.Text = "";
                        numberOfHoles.Text = "";
                    }
                    //else if(size == 0)
                    //{
                    //    memory1.num = size;
                    //    MessageBox.Show("No Holes So No Processes Allowed. You Can Only Plot The Memory!");
                    //    holesNumberBTN.Enabled = false;
                    //    totalMemory.Enabled = false;
                    //    numberOfHoles.Enabled = false;
                    //    plot.Enabled = true;

                    //    memory1.holes[memory1.indexofholes] = "Hole " + memory1.indexofholes;
                    //    memory1.starthole[memory1.indexofholes] = 0;
                    //    memory1.endhole[memory1.indexofholes] = 0;
                    //    memory1.holecompleted[memory1.indexofholes] = false;

                    //}
                    else
                    {
                        memory1.num = size;
                        if (firstFit.Checked)
                        {
                            firstFit.ForeColor = Color.Gray;
                            bestFit.Enabled = false;
                            bestFit.ForeColor = Color.Gray;
                            worstFit.Enabled = false;
                            worstFit.ForeColor = Color.Gray;
                        }
                        if (bestFit.Checked)
                        {
                            firstFit.Enabled = false;
                            firstFit.ForeColor = Color.Gray;
                            bestFit.ForeColor = Color.Gray;
                            worstFit.Enabled = false;
                            worstFit.ForeColor = Color.Gray;
                        }
                        if (worstFit.Checked)
                        {
                            firstFit.Enabled = false;
                            firstFit.ForeColor = Color.Gray;
                            bestFit.Enabled = false;
                            bestFit.ForeColor = Color.Gray;
                            worstFit.ForeColor = Color.Gray;
                        }
                        holesNumberBTN.Enabled = false;
                        totalMemory.Enabled = false;
                        numberOfHoles.Enabled = false;
                        if (memory1.messageshow)
                            MessageBox.Show("Now Enter Holes starting Adress and size!");
                        startAdressOfHole.Enabled = true;
                        holeSize.Enabled = true;
                        holeAddBTN.Enabled = true;
                    }
                }
            }

                    
            catch
            {
                MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                totalMemory.Text = "";
                numberOfHoles.Text = "";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            memory1 = new Memory();


        }

        private void holeAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(holeSize.Text) <= 0)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                    startAdressOfHole.Text = "";
                    holeSize.Text = "";
                }
                else if(Convert.ToInt32(startAdressOfHole.Text) < 0)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only!");
                    startAdressOfHole.Text = "";
                    holeSize.Text = "";
                }
                else
                {
                    memory1.holes[memory1.indexofholes] = "Hole " + memory1.indexofholes;
                    memory1.starthole[memory1.indexofholes] = Convert.ToInt32(startAdressOfHole.Text);
                    memory1.endhole[memory1.indexofholes] = memory1.starthole[memory1.indexofholes] + Convert.ToInt32(holeSize.Text);
                    memory1.holecompleted[memory1.indexofholes] = false;
                    memory1.indexofholes++;
                    if (memory1.indexofholes == memory1.num)
                    {
                        holeAddBTN.Enabled = false;
                        startAdressOfHole.Enabled = false;
                        holeSize.Enabled = false;
                        if (memory1.messageshow)
                            MessageBox.Show("Now Enter Number of Processes!");

                        processNumber.Enabled = true;
                        ProcessNumberBTN.Enabled = true;
                    }
                    if (memory1.indexofholes != memory1.num)
                    {
                        startAdressOfHole.Text = "";
                        holeSize.Text = "";
                        indexOfHole.Text = Convert.ToString(memory1.indexofholes);
                        indexOfHole1.Text = Convert.ToString(memory1.indexofholes);
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                startAdressOfHole.Text = "";
                holeSize.Text = "";
            }
            
        }

        private void ProcessNumberBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(processNumber.Text) <= 0)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                    processNumber.Text = "";
                }
                else
                {
                    memory1.n = Convert.ToInt32(processNumber.Text);
                    ProcessNumberBTN.Enabled = false;
                    processNumber.Enabled = false;
                    if (memory1.messageshow)
                        MessageBox.Show("Now Enter Number of Segments of This Process!");
                    numberOfSegments.Enabled = true;
                    numberOfSegmentsBTN.Enabled = true;
                }
                

            }
            catch
            {
                MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                processNumber.Text = "";
            }
        }

        private void numberOfSegmentsBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(numberOfSegments.Text) <= 0)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                    numberOfSegments.Text = "";
                }
                else
                {
                    memory1.numberofsegments = Convert.ToInt32(numberOfSegments.Text);
                    numberOfSegmentsBTN.Enabled = false;
                    numberOfSegments.Enabled = false;
                    segmentName.Text = "";
                    segmentName.Enabled = true;
                    segmentSize.Text = "";
                    segmentSize.Enabled = true;
                    segmentAddBTN.Enabled = true;
                    if (memory1.messageshow)
                        MessageBox.Show("Now Enter Name and Size of This segment!");
                    segmentName.Enabled = true;
                    segmentSize.Enabled = true;
                    segmentAddBTN.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                numberOfSegments.Text = "";
            }
        }

        private void segmentAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(segmentSize.Text) <= 0)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                    segmentSize.Text = "";
                }
                else
                {
                    memory1.segmentname[memory1.indexofsegment] = "P" + memory1.indexofpro + ":" + segmentName.Text;
                    memory1.segmentsize[memory1.indexofsegment] = Convert.ToInt32(segmentSize.Text);
                    memory1.fit[memory1.indexofsegment] = true;
                    memory1.p[memory1.indexofsegment] = memory1.indexofpro;
                    memory1.indexofsegment++;
                    memory1.indexofkarim++;
                    if ((memory1.indexofpro == (memory1.n - 1)) && memory1.indexofkarim == memory1.numberofsegments)
                    {
                        segmentAddBTN.Enabled = false;
                        segmentSize.Enabled = false;
                        segmentName.Enabled = false;
                        numberOfSegmentsBTN.Enabled = false;
                        if (memory1.messageshow)
                            MessageBox.Show("Now Press Plot To Show the Memory!");
                        plot.Enabled = true;
                    }
                    else if (memory1.indexofkarim == memory1.numberofsegments)
                    {
                        memory1.indexofpro++;
                        memory1.indexofkarim = 0;
                        segmentAddBTN.Enabled = false;
                        numberOfSegmentsBTN.Enabled = true;
                        numberOfSegments.Text = "";
                        segmentSize.Enabled = false;
                        segmentName.Enabled = false;
                        indexOfProcess.Text = Convert.ToString(memory1.indexofpro);
                        numberOfSegments.Enabled = true;
                        indexOfProcess1.Text = Convert.ToString(memory1.indexofpro);
                        indexOfSegment.Text = "0";
                    }
                    else
                    {
                        segmentSize.Text = "";
                        segmentName.Text = "";
                        indexOfSegment.Text = Convert.ToString(memory1.indexofkarim);
                    }
                }
            }

            

            catch
            {
                MessageBox.Show("Please Enter Positive Numbers Only Bigger than Zero!");
                segmentSize.Text = "";
            }
        }

        private void resetFields_Click(object sender, EventArgs e)
        {
            totalMemory.Text = "";
            numberOfHoles.Text = "";
            startAdressOfHole.Text = "";
            holeSize.Text = "";
            processNumber.Text = "";
            numberOfSegments.Text = "";
            segmentName.Text = "";
            segmentSize.Text = "";
            firstFit.Checked = false;
            firstFit.Enabled = true;
            bestFit.Checked = false;
            bestFit.Enabled = true;
            worstFit.Checked = false;
            worstFit.Enabled = true;
            firstFit.ForeColor = Color.White;
            bestFit.ForeColor = Color.White;
            worstFit.ForeColor = Color.White;
            holesNumberBTN.Enabled = true;
            holeAddBTN.Enabled = true;
            ProcessNumberBTN.Enabled = true;
            numberOfSegmentsBTN.Enabled = true;
            segmentAddBTN.Enabled = true;
            totalMemory.Enabled = true;
            numberOfHoles.Enabled = true;
            startAdressOfHole.Enabled = true;
            holeSize.Enabled = true;
            processNumber.Enabled = true;
            numberOfSegments.Enabled = true;
            segmentName.Enabled = true;
            segmentSize.Enabled = true;
            indexOfHole.Text = "0";
            indexOfHole1.Text = "0";
            indexOfProcess.Text = "0";
            indexOfSegment.Text = "0";
            indexOfProcess1.Text = "0";
            memory1.messageshow = false;
            memory1.indexofkarim = 0;
            memory1.indexofpro = 0;
            memory1.indexofsegment = 0;
            memory1.indexofholes = 0;
        }

        private void plot_Click(object sender, EventArgs e)
        {
            memory1.initializeholes();
            if (firstFit.Checked)
            {
                memory1.FFit();
            }
            if (bestFit.Checked)
            {
                memory1.BFit();
            }
            if (worstFit.Checked)
            {
                memory1.WFit();
            }

            if(memory1.doesntfit.Count > 0)
            {
                string fitoutput = "Process ";
                for(int i=0; i< memory1.doesntfit.Count; i++)
                { 
                    if(i == memory1.doesntfit.Count -1)
                        fitoutput = fitoutput + memory1.doesntfit[i] + " ";
                    else
                        fitoutput = fitoutput + memory1.doesntfit[i] + ", ";
                }
                MessageBox.Show(fitoutput + "Doesn't Fit");
            }



            int sum = 0;
            System.Windows.Forms.DataVisualization.Charting.Series[] series = new System.Windows.Forms.DataVisualization.Charting.Series[memory1.lastcount];
            chart1.ChartAreas[0].AxisY.IsReversed = true;
            chart1.ChartAreas[0].AxisX.LineColor = chart1.BackColor;
            chart1.ChartAreas[0].AxisY.LineColor = chart1.BackColor;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.CustomLabels.Clear();
            chart1.ChartAreas[0].AxisY.CustomLabels.Add(-100, 100, "0");
            int holeCounter = 0;
            for (int i = 0; i < memory1.lastcount; i++)
            {
                series[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                series[i].ChartArea = "ChartArea1";
                series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                series[i].Legend = "Legend1";

                //series[i].Font = new System.Drawing.Font("Times", 6f);
                //chart1.ChartAreas[0].AxisY.TitleForeColor = Color.Red;
                //chart1.ChartAreas[0].AxisX.InterlacedColor = Color.Red;
                //series[i].LabelForeColor = Color.Red;
                if (memory1.outputName[i][0] == 'H')
                {
                    memory1.outputName[i] = "Hole" + holeCounter++;
                }
                series[i].Name = $"{i}";
                if (chart1.Series.Count() > i)
                {
                    chart1.Series[$"{i}"].Points.AddXY("Process", (memory1.outputEnd[i] - memory1.outputStart[i]));
                    chart1.Series[$"{i}"].Label = memory1.outputName[i];
                }
                else
                {
                    chart1.Series.Add(series[i]);
                    chart1.Series[$"{i}"].Points.AddXY("Process", (memory1.outputEnd[i] - memory1.outputStart[i]));
                    chart1.Series[$"{i}"].Label = memory1.outputName[i];
                }
                sum += (memory1.outputEnd[i] - memory1.outputStart[i]);
                chart1.ChartAreas[0].AxisY.CustomLabels.Add(sum - ((memory1.outputEnd[i] - memory1.outputStart[i]) / 2), sum + (memory1.outputEnd[i] - memory1.outputStart[i]) - ((memory1.outputEnd[i] - memory1.outputStart[i]) / 2), Convert.ToString(sum));

            }

            plot.Enabled = false;
            resetFields.Enabled = false;
            allocated.Enabled = true;
            old.Enabled = true;
            resetFieldsDeallocation.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose Algorithm Type and Enter Memory Size and Number of Holes then Press Add!");
            holeAddBTN.Enabled = false;
            startAdressOfHole.Enabled = false;
            holeSize.Enabled = false;
            processNumber.Enabled = false;
            ProcessNumberBTN.Enabled = false;
            numberOfSegments.Enabled = false;
            numberOfSegmentsBTN.Enabled = false;
            segmentName.Enabled = false;
            segmentSize.Enabled = false;
            segmentAddBTN.Enabled = false;
            plot.Enabled = false;
            plotDeallocation.Enabled = false;
            startadressdeallocation.Enabled = false;
            processindexdeallocation.Enabled = false;
            allocated.Enabled = false;
            old.Enabled = false;
            resetFieldsDeallocation.Enabled = false;
        }

        private void programReset_Click(object sender, EventArgs e)
        {
            totalMemory.Text = "";
            numberOfHoles.Text = "";
            startAdressOfHole.Text = "";
            holeSize.Text = "";
            processNumber.Text = "";
            numberOfSegments.Text = "";
            segmentName.Text = "";
            segmentSize.Text = "";
            firstFit.Checked = false;
            firstFit.Enabled = true;
            bestFit.Checked = false;
            bestFit.Enabled = true;
            worstFit.Checked = false;
            worstFit.Enabled = true;
            firstFit.ForeColor = Color.White;
            bestFit.ForeColor = Color.White;
            worstFit.ForeColor = Color.White;
            holesNumberBTN.Enabled = true;
            holeAddBTN.Enabled = true;
            ProcessNumberBTN.Enabled = true;
            numberOfSegmentsBTN.Enabled = true;
            segmentAddBTN.Enabled = true;
            totalMemory.Enabled = true;
            numberOfHoles.Enabled = true;
            startAdressOfHole.Enabled = true;
            holeSize.Enabled = true;
            processNumber.Enabled = true;
            numberOfSegments.Enabled = true;
            segmentName.Enabled = true;
            segmentSize.Enabled = true;
            indexOfHole.Text = "0";
            indexOfHole1.Text = "0";
            indexOfProcess.Text = "0";
            indexOfSegment.Text = "0";
            indexOfProcess1.Text = "0";
            memory1.messageshow = false;
            memory1.indexofkarim = 0;
            memory1.indexofpro = 0;
            memory1.indexofsegment = 0;
            memory1.indexofholes = 0;
            holeAddBTN.Enabled = false;
            startAdressOfHole.Enabled = false;
            holeSize.Enabled = false;
            processNumber.Enabled = false;
            ProcessNumberBTN.Enabled = false;
            numberOfSegments.Enabled = false;
            numberOfSegmentsBTN.Enabled = false;
            segmentName.Enabled = false;
            segmentSize.Enabled = false;
            segmentAddBTN.Enabled = false;
            plot.Enabled = false;
            memory1.reset = true;
            foreach (var serieses in chart1.Series)
            {
                serieses.Points.Clear();
            }
            memory1.resetnum++;
            memory1.resetdata();
            resetFields.Enabled = true;
        }

        private void disableMessages_Click(object sender, EventArgs e)
        {
            memory1.messageshow = !memory1.messageshow;
            if (!memory1.messageshow)
                disableMessages.Text = "Messages Disabled";
            else
                disableMessages.Text = "Messages Enabled";
        }

        private void processindexdeallocation_TextChanged(object sender, EventArgs e)
        {
            if ((processindexdeallocation.Text != "") && (processindexdeallocation.Text != "NO"))
                plotDeallocation.Enabled = true;
            else
                plotDeallocation.Enabled = false;
        }

        private void startadressdeallocation_TextChanged(object sender, EventArgs e)
        {
            if ((startadressdeallocation.Text != "") && (startadressdeallocation.Text != "NO"))
                plotDeallocation.Enabled = true;
            else
                plotDeallocation.Enabled = false;
        }

        private void allocated_CheckedChanged(object sender, EventArgs e)
        {
            startadressdeallocation.Text = "NO";
            processindexdeallocation.Text = "";
            processindexdeallocation.Enabled = true;
            startadressdeallocation.Enabled = false;
        }

        private void old_CheckedChanged(object sender, EventArgs e)
        {
            processindexdeallocation.Text = "NO";
            startadressdeallocation.Text = "";
            startadressdeallocation.Enabled = true;
            processindexdeallocation.Enabled = false;
        }

        private void resetFieldsDeallocation_Click(object sender, EventArgs e)
        {
            allocated.Checked = false;
            old.Checked = false;
            processindexdeallocation.Enabled = false;
            processindexdeallocation.Text = "";
            startadressdeallocation.Enabled = false;
            startadressdeallocation.Text = "";
            allocated.Enabled = true;
            old.Enabled = true;
        }

        private void plotDeallocation_Click(object sender, EventArgs e)
        {
            try
            {
                //if( Convert.ToInt32(processindexdeallocation.Text) < 0 && processindexdeallocation.Text != "NO")
                //{
                //    MessageBox.Show("Please Enter Positive Numbers Only! allo");
                //    processindexdeallocation.Text = "";
                   
                //}
                //else if(Convert.ToInt32(startadressdeallocation.Text) < 0 && startadressdeallocation.Text != "NO")
                //{
                //    MessageBox.Show("Please Enter Positive Numbers Only! old");
                //    startadressdeallocation.Text = "";
                //}
                //else
                //{
                    if (allocated.Checked)
                        memory1.Deallocation("allocated", Convert.ToInt32(processindexdeallocation.Text));
                    else if (old.Checked)
                        memory1.Deallocation("old", Convert.ToInt32(startadressdeallocation.Text));

                    int sum = 0;
                    System.Windows.Forms.DataVisualization.Charting.Series[] series = new System.Windows.Forms.DataVisualization.Charting.Series[memory1.lastcount];
                    chart1.ChartAreas[0].AxisY.IsReversed = true;
                    chart1.ChartAreas[0].AxisX.LineColor = chart1.BackColor;
                    chart1.ChartAreas[0].AxisY.LineColor = chart1.BackColor;
                    chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
                    chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
                    chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                    chart1.Series.Clear();
                    chart1.ChartAreas[0].AxisY.CustomLabels.Clear();
                    chart1.ChartAreas[0].AxisY.CustomLabels.Add(-100, 100, "0");
                    int holeCounter = 0;
                    for (int i = 0; i < memory1.lastcount; i++)
                    {

                        series[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                        series[i].ChartArea = "ChartArea1";
                        series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                        series[i].Legend = "Legend1";
                        series[i].Name = $"{i}";
                        if (memory1.outputName[i][0] == 'H')
                        {
                            memory1.outputName[i] = "Hole" + holeCounter++;
                        }
                        if (chart1.Series.Count() > i)
                        {
                            chart1.Series[$"{i}"].Points.AddXY("Process", (memory1.outputEnd[i] - memory1.outputStart[i]));
                            chart1.Series[$"{i}"].Label = memory1.outputName[i];
                        }
                        else
                        {
                            chart1.Series.Add(series[i]);
                            chart1.Series[$"{i}"].Points.AddXY("Process", (memory1.outputEnd[i] - memory1.outputStart[i]));
                            chart1.Series[$"{i}"].Label = memory1.outputName[i];

                        }
                        sum += (memory1.outputEnd[i] - memory1.outputStart[i]);
                        chart1.ChartAreas[0].AxisY.CustomLabels.Add(sum - ((memory1.outputEnd[i] - memory1.outputStart[i]) / 2), sum + (memory1.outputEnd[i] - memory1.outputStart[i]) - ((memory1.outputEnd[i] - memory1.outputStart[i]) / 2), Convert.ToString(sum));
                    }
                    plotDeallocation.Enabled = false;
                    resetFieldsDeallocation.Enabled = true;
                    allocated.Enabled = false;
                    old.Enabled = false;
                    startadressdeallocation.Enabled = false;
                    processindexdeallocation.Enabled = false;
                //}
            }

            catch
            {
                if (allocated.Checked)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only! allo");
                    processindexdeallocation.Text = "";
                }
                else if (old.Checked)
                {
                    MessageBox.Show("Please Enter Positive Numbers Only! old");
                    startadressdeallocation.Text = "";
                }
                    
            }
        }
    }
}
