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

    //Structure for mouser coordinates and number of pixels
    public struct DrawingData
    {
        public Point m_pCoor;
        public int m_iPixels;

        //Constructor
        public DrawingData(Point sCoor, int sPixels)
        {
            m_pCoor = sCoor;
            m_iPixels = sPixels;
        }

    }
    public partial class Form1 : Form
    {

        //Global Variables
        static Random rnd = new Random();
        static CDrawer drawSpace = new CDrawer(800, 600, false);
        static object temp;
        static int numPixels = 100;

        public Form1()
        {
            InitializeComponent();
        }

        //If user adjust the track bar for iteration adjustments
        private void UI_TrackBar_NumberOfIterations_Scroll(object sender, EventArgs e)
        {
            numPixels = UI_TrackBar_NumberOfIterations.Value; //Sends scroll bar value to global variable
        }
        //When Timer tick occurs
        private void UI_Timer1_Tick(object sender, EventArgs e)
        {
            Point coor;
            //Periodically check mouse in drawer window
            if (drawSpace.GetLastMouseLeftClickScaled(out coor))
            {
                //Create new thread

                //Apply method 
                DrawingData newData = new DrawingData(coor, numPixels);
                temp = newData; // Box
                Wanderer(temp); //pass to wanderer method


            }

        }
        ///////////////////////////////////////////////Method\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /************************************************************************************************
         * Method: Wanderer()
         * Effect: Receives an object of strucure when thread is started. A random color will be chosen,
         *         and will draw pixels based on a random direction/velocity.
         * **********************************************************************************************/
        public static void Wanderer(object holder)
        {

            Color drawingColor = RandColor.GetColor(); //Holds random color for drawing
            int initialVelocity = 1;                   //Initial Starting Velocity
            int updateVelocity = rnd.Next(-1, 1);      //Adjusts value of starting velocity randomly between -1 an 1


        }
    }
}
