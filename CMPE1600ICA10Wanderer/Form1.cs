using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.IO;

namespace CMPE1600ICA10Wanderer
{
    public partial class Form1 : Form
    {
        //Global Variables
        CDrawer drawSpace = new CDrawer(800,600,false);
        
        public Form1()
        {
            InitializeComponent();
        }

        //If user adjust the track bar for iteration adjustments
        private void UI_TrackBar_NumberOfIterations_Scroll(object sender, EventArgs e)
        {
            
        }
        //When Timer tick occurs
        private void UI_Timer1_Tick(object sender, EventArgs e)
        {
            Point coor;
            //Periodically check mouse in drawer window
            if(drawSpace.GetLastMouseLeftClickScaled( out coor))
            {
                //Start point for drawing
            }

        }
    }
}
