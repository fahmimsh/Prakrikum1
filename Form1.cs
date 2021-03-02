using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Graphic_user_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
/*Data satu */
            chart1.Series[0].Name = "Data 1";
            chart1.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Red;
            chart1.Legends[0].Docking =
                System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
/*Data dua*/
            chart1.Series[1].Name = "Data 2";
            chart1.Series[1].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 5;
            chart1.Series[1].Color = Color.Yellow;
            chart1.Legends[0].Docking =
                System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
/*Data tiga*/
            chart1.Series[2].Name = "Data 3";
            chart1.Series[2].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].BorderWidth = 5;
            chart1.Series[2].Color = Color.Blue;
            chart1.Legends[0].Docking =
                System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
                Mulai.Text = "Berhenti";
            else
                Mulai.Text = "Mulai"; 
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //variable
            double interval = Convert.ToDouble(numericUpDown1.Value); // convert chart to double float = max 32bit data double = max 64bit data
            double amplitude1 = Convert.ToDouble(numericUpDown2.Value);
            double frecquency1 = Convert.ToDouble(numericUpDown3.Value);
            double amplitude2 = Convert.ToDouble(numericUpDown4.Value);
            double frecquency2 = Convert.ToDouble(numericUpDown5.Value);
            double amplitude3 = Convert.ToDouble(numericUpDown6.Value);
            double frecquency3 = Convert.ToDouble(numericUpDown7.Value);
            //data rendom >> 
            double y1 = amplitude1 * Math.Sin(2 * Math.PI * frecquency1 * time);
            double y2 = amplitude2 * Math.Sin(2 * Math.PI * frecquency2 * time);
            double y3 = amplitude3 * Math.Sin(2 * Math.PI * frecquency3 * time);
            if (chart1.Series[0].Points.Count > 80)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
            }
            chart1.Series[0].Points.AddY(y1);
            chart1.Series[1].Points.AddY(y2);
            chart1.Series[2].Points.AddY(y3);
            time += interval*0.001;
        }
        private double time = 0.0;
/*        private double amplitude1 = 50.0;
        private double amplitude2 = 10.0;
          private double amplitude3 = 30.0;*/
/*        private double frecquency = 2.0;*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(y1);*/
        }
    }
}
