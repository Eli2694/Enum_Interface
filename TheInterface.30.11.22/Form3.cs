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
        // Function That Check Who Has More Kodkodim
        

        IShape[] shape = new IShape[100];
    }

    interface IShape
    {
        string Color(string color);
        int FrameThickness(); // Scope   
    }

    interface Ikodkod
    {
        void Kodkod();

         int kodkod { get; set; }

    }

    internal class Rectangle : IShape , Ikodkod
    {
        public string Color(string color)
        {
            return color;
        }

        public int FrameThickness()
        {
            return length * width;
        }

        public int kodkod { get { return kodkod; } set { kodkod = value; } }
        public void Kodkod()
        {
            kodkod = 4;
        }

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
        public string Color(string color)
        {
            return color;
        }

        public int FrameThickness()
        {
            
                return (int)(2 * PI * radius); 
        }

        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }


    internal class Ellipse : Circle
    {

        private int s_radius;
        public int S_radius
        {
            get { return s_radius; }
            set { s_radius = value; }
        }

        public int FrameThickness()
        {
            return (int)(S_radius * Radius * _PI);
        }

        public void roll()
        {
            MessageBox.Show("round shape");
        }
    }

    internal class Triangle : IShape, Ikodkod
    {
        public string Color(string color)
        {
            return color;
        }

        public int FrameThickness()
        {
            return (int)((tbase * theigh) / 2);
        }

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

        public int kodkod { get { return kodkod; } set { kodkod = value; } }
        public void Kodkod()
        {
            kodkod = 3;
        }

    }

    internal class Moon : IShape, Ikodkod
    {
        private double PI = 3.14;
        public string Color(string color)
        {
            return color;
        }
        public int FrameThickness()
        {
            return (int)(distanceBetweenTipsOfTheMoon * PI);
        }

        private int distanceBetweenTipsOfTheMoon;

        public int DistanceBetweenTipsOfTheMoon
        {
            get { return distanceBetweenTipsOfTheMoon; }
            set { distanceBetweenTipsOfTheMoon = value; }
        }

        public int kodkod { get { return kodkod; } set { kodkod = value; } }
        public void Kodkod()
        {
            kodkod = 2;
        }

    }
}
