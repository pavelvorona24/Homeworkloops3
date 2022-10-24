namespace Homeworkloops3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iresult;
            int iCounter, strEnd, inumber;
            double itotal;
            strEnd = 0;

            lblOutput.Items.Clear();
            inumber = Convert.ToInt32(n1.Text);
            iCounter = strEnd;
            itotal = inumber;
            while (itotal <= 1000000)
            {
                
                iresult = "Year number  " + iCounter.ToString() + " = " + itotal.ToString();
                itotal = (itotal * 1.08);
                lblOutput.Items.Add(iresult);
                iCounter = iCounter + 1; 

                lblOutput.Text = itotal.ToString();
            }
        }
    }
}
