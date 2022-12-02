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

        // Counter of array
        public int arrCounter = 0;
        public int ResultCount = 0;
        public int SumOfKodkods = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(Rectangle.Checked)
            {
                shape[arrCounter] = new Rectangle(int.Parse(R_Width.Text), int.Parse(R_Heigh.Text));
                shape[arrCounter].GetKodkod();
                arrCounter++;
                Rectangle.Checked = false;
            }

            if (Circle.Checked)
            {
                shape[arrCounter] = new Circle(int.Parse(Radius.Text));
                shape[arrCounter].GetKodkod();
                arrCounter++;
                Circle.Checked = false;
            }

            if (Ellipse.Checked)
            {
                shape[arrCounter] = new Ellipse(int.Parse(Radius.Text),int.Parse(El_Radius.Text));
                shape[arrCounter].GetKodkod();
                arrCounter++;
                Ellipse.Checked = false;
            }

            if (Triangle.Checked)
            {
                shape[arrCounter] = new Triangle(int.Parse(Tr_Base.Text), int.Parse(Tr_Heigh.Text));
                shape[arrCounter].GetKodkod();
                arrCounter++;
                Triangle.Checked = false;
            }

            if (Moon.Checked)
            {
                shape[arrCounter] = new Moon(int.Parse(Distance.Text));
                shape[arrCounter].GetKodkod();
                arrCounter++;
                Moon.Checked = false;
            }


        }

        private void ShowResults_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrCounter; i++)
            {
                if(i == ResultCount)
                {
                    SumOfKodkods = SumOfKodkods + shape[ResultCount].Kodkod;
                    ResultCount++;
                }
                
            }

            L_KodkodSum.Text ="Sum Of Kodkods:" + " " + SumOfKodkods.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrCounter; i++)
            {
                if (shape[i] != null)
                {
                    shape[i] = null;
                }
                
            }
            arrCounter = 0;
            ResultCount = 0;
            SumOfKodkods = 0;
            L_KodkodSum.Text = "Sum Of Kodkods: 0";

        }

        private void Moon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ellipse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Circle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    interface IShape
    {
        string Color(string color);
        int FrameThickness(); // Scope   
        void GetKodkod();
        public int Kodkod { get; set; }

    }

    

    internal class Rectangle : IShape 
    {

        //Constructor
        public Rectangle(int _Length, int _Width)
        {
            Length = _Length;
            Width = _Width;
        }


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

        // Function From IShape
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 4;
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

        //Constructor
        public Circle(int Radius)
        {
            radius = Radius;
        }


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

        private double PI = 3.14;

        public double _PI { get { return PI; } }



        // Function From IShape
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 0;
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

    internal class Triangle : IShape
    {

        //Constructor
        public Triangle(int Base, int Heigh)
        {
            tbase = Base;
            theigh = Heigh;
        }

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

        // Function From IShape
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 3;
        }

    }

    internal class Moon : IShape
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
        // Function From IShape
        public int Kodkod { get; set; }
        public void GetKodkod()
        {
            Kodkod = 2;
        }

    }
}
