using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheInterface._30._11._22
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        
        // Array of interface IShape
        IShape[] shape = new IShape[100];

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    interface IShape
    {
        string Color(string color);
        int FrameThickness(); // Scope   
    }

    interface Ikodkod
    {
        void GetKodkod();

         int Kodkod { get; set; }

    }

    internal class Rectangle : IShape , Ikodkod
    {

        

        // Function From IShape
        public string Color(string color)
        {
            return color;
        }

        // Function From IShape
        public int FrameThickness()
        {
            return length * width;
        }

        // Function And Property From Ikodkod
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 4;
        }


        //Constructor
        public Rectangle(int _Length, int _Width)
        {
            Length = _Length;
            Width = _Width;
        }

        // Personal Properties
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        
    }

    internal class  Circle : IShape
    {
        private double PI = 3.14;

        public double _PI { get { return PI; } }

        // Function From IShape
        public string Color(string color)
        {
            return color;
        }
        // Function From IShape
        public int FrameThickness()
        {
            
                return (int)(2 * PI * radius); 
        }
        // Personal Properties
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //Constructor
        public Circle(int radius)
        {
            this.radius = radius;
        }
    }


    internal class Ellipse : Circle
    {
        //Constructor
        public Ellipse(int radius,int s_radius):base(radius)
        {
            this.S_radius = s_radius;
        }


        private int s_radius;
        public int S_radius
        {
            get { return s_radius; }
            set { s_radius = value; }
        }
        // Personal Function Similar To Function In Parent Circle
        public int FrameThickness()
        {
            return (int)(S_radius * Radius * _PI);
        }
        // Personal Function
        public void roll()
        {
            MessageBox.Show("round shape");
        }
    }

    internal class Triangle : IShape, Ikodkod
    {
        // Function From IShape
        public string Color(string color)
        {
            return color;
        }

        // Function From IShape
        public int FrameThickness()
        {
            return (int)((tbase * theigh) / 2);
        }


        //Constructor
        public Triangle(int Base , int Heigh)
        {
            tbase = Base;
            theigh = Heigh;
        }

        //Personal Propertise And Functions

        private int tbase;

        public int Tbase
        {
            get { return tbase; }
            set { tbase = value; }
        }

        private int theigh;

        public int Theigh
        {
            get { return theigh; }
            set { theigh = value; }
        }

        

        // Function And Property From Ikodkod
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 3;
        }

    }

    internal class Moon : IShape, Ikodkod
    {

        //Constructor

        public Moon(int Distance)
        {
            distanceBetweenTipsOfTheMoon = Distance;
        }

        private double PI = 3.14;

        // Function From IShape
        public string Color(string color)
        {
            return color;
        }
        // Function From IShape
        public int FrameThickness()
        {
            return (int)(distanceBetweenTipsOfTheMoon * PI);
        }

        //Personal
        private int distanceBetweenTipsOfTheMoon;

        public int DistanceBetweenTipsOfTheMoon
        {
            get { return distanceBetweenTipsOfTheMoon; }
            set { distanceBetweenTipsOfTheMoon = value; }
        }
        // Function And Property From Ikodkod
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 2;
        }

    }
}
