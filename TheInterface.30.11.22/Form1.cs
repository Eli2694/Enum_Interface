namespace TheInterface._30._11._22
{


    public partial class Form1 : Form
    {
        //Enumeration
        private enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will create a file named winFile.txt
            // at the specified location 
            StreamWriter sw = new StreamWriter(@"C:\Users\User\source\repos\TheInterface.30.11.22\TheInterface.30.11.22\winFile.txt",true);

            // write to file
            sw.WriteLine("{0},{1},{2} ", textBox3.Text, textBox2.Text, textBox1.Text);

            //sw.WriteLine("name: {0},", textBox3.Text);
            //sw.WriteLine("day: {0},", textBox2.Text);
            //sw.WriteLine("age: {0},",textBox1.Text);

            // reset textBox
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            // To close the stream
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\User\source\repos\TheInterface.30.11.22\TheInterface.30.11.22\winFile.txt";

            // C# program to read from a file
            // using StreamReader Class

            // Takinga a new input stream i.e. 
            // winFile.txt and opens it
            StreamReader sr = new StreamReader(path);

            //validate if the file exists
            if(File.Exists(path))
            {
                //create array of string
                string[] strArr;
                // To read line from input stream
                string strLine = sr.ReadLine();
                if(strLine != null)
                {
                    // Split string to array of strings by ','
                    strArr = strLine.Split(',');
                    //declare variable of type WorkDays!! (enum)
                    WorkDays workDay; 
                    //Converting String To Enum
                    workDay = (WorkDays)Enum.Parse(typeof(WorkDays), strArr[1]);

                    //Insert in textBox
                    textBox3.Text = strArr[0];
                    textBox2.Text = workDay.ToString();
                    textBox1.Text = strArr[2];  
                }
            }
        
            // to close the stream
            sr.Close();

        }
    }
}