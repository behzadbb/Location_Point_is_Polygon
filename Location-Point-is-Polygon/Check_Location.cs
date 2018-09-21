using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_Point_is_Polygon
{
    public partial class Check_Location : Form
    {
        public Check_Location()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            string[] inputs = new string[2];
            string input = "35.849489,50.933733";
            List<Double> lat_array = new List<Double>();
            List<Double> long_array = new List<Double>();
            if (radioButton1.Checked)
                input = radioButton1.Text;
            if (radioButton2.Checked)
                input = radioButton2.Text;
            if (radioButton3.Checked)
                input = textBox1.Text.Replace(" ", "");

            List<String> polygon = new List<String>();
            polygon.Add("35.821114,50.989954");
            polygon.Add("35.825722,50.978295");
            polygon.Add("35.82758,50.978978");
            polygon.Add("35.831516,50.97916");
            polygon.Add("35.831442,50.981937");
            polygon.Add("35.828785,50.985305");
            polygon.Add("35.832709,50.986519");
            polygon.Add("35.831652,50.988992");
            polygon.Add("35.834087,50.990327");
            polygon.Add("35.833288,50.991587");
            polygon.Add("35.831565,50.99318");
            polygon.Add("35.829855,50.993923");
            polygon.Add("35.830421,50.996078");
            polygon.Add("35.835206,51.002071");
            polygon.Add("35.836045,51.002795");
            polygon.Add("35.847171,51.012425");
            polygon.Add("35.847932,51.013399");
            polygon.Add("35.846703,51.016647");
            polygon.Add("35.842578,51.019967");
            polygon.Add("35.84173,51.027148");
            polygon.Add("35.831635,51.033498");
            polygon.Add("35.829003,51.02722");
            polygon.Add("35.828184,51.02325");
            polygon.Add("35.825434,51.019316");
            polygon.Add("35.830145,51.019172");
            polygon.Add("35.830935,50.998675");

            foreach (string s in polygon)
            {
                string[] sp = s.Split(',');
                lat_array.Add(Convert.ToDouble(sp[0]));
                long_array.Add(Convert.ToDouble(sp[1]));
            }

            inputs = (input.Split(','));

            bool res = Feasibility.Feasibility_Check(
                double.Parse(inputs[0]),
                double.Parse(inputs[1]),
                lat_array,
                long_array);
            if (res)
                MessageBox.Show("Yes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
