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
    // Add In Form2.cs And Not In Form2.Designer.cs
    interface Iitem
    {
        // method without body
        int GetPrice();
        string getName();
    }

    internal class Cola : Iitem
    {
        // implementation of methods inside interface
        public int GetPrice()
        {
            return 10;
        }

        public string getName()
        {
            return "Cola";
        }
    }

    internal class Kinly : Iitem
    {
        // implementation of methods inside interface
        public int GetPrice()
        {
            return 11;
        }

        public string getName()
        {
            return "Kinly";
        }
    
    }

    public partial class Form2 : Form
    {
        //variable
        Iitem[] itemArr = new Iitem[5]; // array of Interaface
        public int countItems = 0;

        //constructor
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Iitem item = new Cola();
        }


        private void Cola_Click(object sender, EventArgs e)
        {
            if(countItems < 6)
            {
                itemArr[countItems] = new Cola();
                countItems++;
            }

        }

        private void Kinly_Click(object sender, EventArgs e)
        {
            if (countItems < 6)
            {
                itemArr[countItems] = new Kinly();
                countItems++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countItems; i++)
            {
                // No need to check if itemArr[i] is Cola or Kinly
                // itemArr[i] contains instance of Cola or Kinly
                // because itemArr[i] contains instance of Cola or Kinly it will know who's functions to use. 
                MessageBox.Show(itemArr[i].GetPrice().ToString() + " " + itemArr[i].getName());
            }
        }
    }
}
