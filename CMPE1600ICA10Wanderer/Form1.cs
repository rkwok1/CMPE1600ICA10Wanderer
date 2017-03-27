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
using System.Threading;

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
        Point getPoint = new Point();
        Point lastPoint = new Point();
        //Scale
        

        public Form1()
        {
            InitializeComponent();
            
        }
        //When the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //If user adjust the track bar for iteration adjustments
        private void UI_TrackBar_NumberOfIterations_Scroll(object sender, EventArgs e)
        {
            numPixels = UI_TrackBar_NumberOfIterations.Value; //Sends scroll bar value to global variable
        }
        //When Timer tick occurs
        private void UI_Timer1_Tick(object sender, EventArgs e)
        {
            drawSpace.GetLastMouseLeftClickScaled(out getPoint);
            //Periodically check mouse in drawer window
            if (getPoint != lastPoint && getPoint.X >= 0)
            {
                lastPoint = getPoint;
                //Create new thread

                //Apply method 
                DrawingData newData = new DrawingData(getPoint, numPixels);
                Wanderer((object)newData); //pass to wanderer method


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
            DrawingData info = (DrawingData)(holder);     //Unboxes structure
            Color drawingColor = RandColor.GetColor();    //Holds random color for drawing
            Point newPoint = info.m_pCoor;
            drawSpace.SetBBScaledPixel(info.m_pCoor.X, info.m_pCoor.Y, drawingColor);
            drawSpace.Render();
            

            //Draw pixels 
            for (int i = 0; i < info.m_iPixels ; i++)
            {
                newPoint.X += rnd.Next(-1, 2);
                newPoint.Y += rnd.Next(-1,2);
                newPoint.X = (newPoint.X < 0) ? 0 : newPoint.X;
                newPoint.Y = (newPoint.Y < 0) ? 0 : newPoint.Y;
                newPoint.X = (newPoint.X > 799) ? 799 : newPoint.X;
                newPoint.Y = (newPoint.Y > 599) ? 599 : newPoint.Y;

                drawSpace.SetBBScaledPixel(newPoint.X,newPoint.Y, drawingColor);
                Thread.Sleep(1);
                drawSpace.Render();
            }
            
            
             //lock gdi drawer during loop

        }
       

       
    }
}
