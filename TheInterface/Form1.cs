namespace TheInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnReset.Visible = false;
        }

        public enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToFile_Click(object sender, EventArgs e)
        {
           
            string strAllData = "\n"+ txtName.Text + ", " + txtAge.Text + ", " + txtDay.Text ;
            
            string fileName = "winformEx.txt";
            File.AppendAllText(fileName, strAllData);
            //File.AppendAllText(fileName, a.ToString());
           // File.AppendAllText(fileName, b.ToString());
            //File.AppendAllText(fileName, c.ToString());
            //File.AppendAllText(fileName, d.ToString());
            //File.AppendAllText(fileName, e.ToString());
            // StreamWriter sw = File.AppendText(fileName);
            //File.AppendText(fileName).WriteLine(strAllData);
            //sw.WriteLine(strAllData);
            //sw.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkDays day;
   
            string fileName = "winformEx.txt";
            string[] fileData = File.ReadAllLines(fileName);


            day = (WorkDays)Enum.Parse(typeof(WorkDays), fileData[0].Split(", ")[2]);


            label1.Text = fileData[0].Split(", ")[0];
            label2.Text = fileData[0].Split(", ")[1];
            label3.Text = day.ToString();
            txtAge.Text = label2.Text;
            txtDay.Text = day.ToString();
            txtName.Text= label1.Text;


        }

        IItem[] itemsArr = new IItem[5];
        public static int index = 0;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            IItem iitem = new Cola();
        }

        private void BtnCola_Click(object sender, EventArgs e)
        {
            Cola can = new Cola();
            if(index< itemsArr.Length)
            {
                itemsArr[index] = can;
                index++;
            }

            if(index==itemsArr.Length)
            {
                btnReset.Visible = true;
            }
         

        }

        private void BtnKinly_Click(object sender, EventArgs e)
        {
            Kinly can = new Kinly();
            if (index < itemsArr.Length)
            {
                itemsArr[index] = can;
                index++;
            }
            if (index == itemsArr.Length)
            {
                btnReset.Visible = true;
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < itemsArr.Length; i++)
            {
                if (itemsArr[i] != null)
                { 
                    MessageBox.Show(itemsArr[i].getPrice().ToString());
                }
                else
                {
                    MessageBox.Show("the array is empty");
                }
            }
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            index = 0;
            for (int i = 0; i < itemsArr.Length; i++)
            {
                itemsArr[i] = null;
            }

            btnReset.Visible = false;
        }
    }
}