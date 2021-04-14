using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SimulationSystem sm = new SimulationSystem();

           
            
            /*
            for (int i = 0; i < sm.DayTypeDistributions.Count; i++)
            {
                string day_type = sm.DayTypeDistributions[i].DayType.ToString();
                string probability = sm.DayTypeDistributions[i].Probability.ToString();
                string CummProbability = sm.DayTypeDistributions[i].CummProbability.ToString();
                string range = (sm.DayTypeDistributions[i].MinRange).ToString() + '-' + (sm.DayTypeDistributions[i].MaxRange).ToString();
                if (dataGridView1.ColumnCount == 0)
                {
                    dataGridView1.Columns.Add("demand", "demand");
                    dataGridView1.Columns.Add("daytype", "daytype");
                    dataGridView1.Columns.Add("prob", "probabilty");
                    dataGridView1.Columns.Add("cum", "CummProbability");
                    dataGridView1.Columns.Add("rang", "Range");
                }

                dataGridView1.Rows.Add(new string[] { day_type, probability, CummProbability, range });

            }
            */
           /* textBox1.Text = SimulationSystem.txt;
            if (dataGridView1.ColumnCount == 0)
            {
              //  dataGridView1.Columns.Add("demand", "demand");


                dataGridView1.Columns.Add("daytype1", "daytype1");

                dataGridView1.Columns.Add("cum1", "CummProbability1");

                dataGridView1.Columns.Add("rang1", "Range1");

                dataGridView1.Columns.Add("daytype2", "daytype2");

                dataGridView1.Columns.Add("cum2", "CummProbability2");

                dataGridView1.Columns.Add("rang2", "Range2");
                dataGridView1.Columns.Add("daytype3", "daytype3");
                //   dataGridView1.Columns.Add("prob", "probabilty");
                dataGridView1.Columns.Add("cum3", "CummProbability3");

                dataGridView1.Columns.Add("rang3", "Range3");


            }

            for (int i = 0; i < sm.DemandDistributions.Count; i++)
            {
                int cel = 0;
               // string demand = sm.DemandDistributions[i].Demand.ToString();
              

                 string day_type;
                 string CummProbability;
                 string range;
                

                 //dataGridView1.Rows[i].Cells[cel].Value =demand;
                 cel += 1;
                for (int v = 0; v < sm.DemandDistributions[i].DayTypeDistributions.Count; v++)
                {
                     day_type = sm.DemandDistributions[i].DayTypeDistributions[v].DayType.ToString();
                    //string probability = sm.DemandDistributions[i].DayTypeDistributions[i].DayType.ToString();
                     CummProbability = sm.DemandDistributions[i].DayTypeDistributions[v].CummProbability.ToString();
                     range = (sm.DemandDistributions[i].DayTypeDistributions[v].MinRange).ToString() + '-' + (sm.DemandDistributions[i].DayTypeDistributions[v].MaxRange).ToString();


                    
                    
                    // dataGridView1.Rows[i].Cells[cel].Value= day_type;
                    //dataGridView1.Rows[i].Cells[cel+1].Value= CummProbability;
                    //dataGridView1.Rows[i].Cells[cel+2].Value= range;
                    cel+=3;

                    dataGridView1.Rows.Add(new string[] {  day_type,CummProbability, range });

                }

            }*/


           for (int i = 0; i < sm.SimulationTable.Count; i++)
            {
                string DayNo = sm.SimulationTable[i].DayNo.ToString();

                string RandomNewsDayType = sm.SimulationTable[i].RandomNewsDayType.ToString();

                string NewsDayType = sm.SimulationTable[i].NewsDayType.ToString();

                string randomdem = sm.SimulationTable[i].RandomDemand.ToString();

                string demand = sm.SimulationTable[i].Demand.ToString();
                string RevenueProfit = sm.SimulationTable[i].SalesProfit.ToString();
                string LostProfit = sm.SimulationTable[i].LostProfit.ToString();
                if (sm.SimulationTable[i].LostProfit == 0)
                    LostProfit = "_";
                string ScrapProfit = sm.SimulationTable[i].ScrapProfit.ToString();
                if (sm.SimulationTable[i].ScrapProfit == 0)
                    ScrapProfit = "_";
                string DailyNetProfit = sm.SimulationTable[i].DailyNetProfit.ToString();

                if (dataGridView1.ColumnCount == 0)
                {
                    dataGridView1.Columns.Add("Day", "Day");
                    dataGridView1.Columns.Add("Random Digits for Type of NewsDayType", "Random Digits for Type of NewsDayType");
                    dataGridView1.Columns.Add("Type of Newsday", "Type of Newsday");
                    dataGridView1.Columns.Add("Random Digits for Demand", "Random Digits for Demand");
                    dataGridView1.Columns.Add("Demand", "Demand");
                    dataGridView1.Columns.Add("Revenue From Sales", "Revenue From Sales");
                    dataGridView1.Columns.Add("Lost profit  From Excess Profit", "Lost profit  From Excess Profit");
                    dataGridView1.Columns.Add("Salvage From Sales Of Scrap", "Salvage From Sales Of Scrap");
                    dataGridView1.Columns.Add("Daily Profit", "Daily Profit");
                }

                dataGridView1.Rows.Add(new string[] {DayNo,RandomNewsDayType,NewsDayType,randomdem,demand,RevenueProfit,LostProfit,ScrapProfit,DailyNetProfit });
                string testingResult = TestingManager.Test(sm, Constants.FileNames.TestCase1);
                MessageBox.Show(testingResult);
            }
        }
        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
