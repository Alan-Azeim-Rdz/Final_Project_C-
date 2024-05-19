namespace Final_Project_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Curp;

        }

        private void BtnDataSave_Click(object sender, EventArgs e)
        {

            String Brithday_Date = DataTimeBrithdayDate.Text;
            //MessageBox.Show(Brithday_Date);

            if (!(Brithday_Date == null))
            {
                LstBxData.Items.Add(TxtName.Text);
                LstBxData.Items.Add(TxtLastNamePaternal.Text);
                LstBxData.Items.Add(TxtLastNameMother.Text);
                LstBxData.Items.Add(Brithday_Date);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerateCurp_Click(object sender, EventArgs e)
        {
            String Brithday_Date = DataTimeBrithdayDate.Text;
            Curp_Create curp = new Curp_Create(TxtName.Text,TxtLastNamePaternal.Text,TxtLastNameMother.Text,Brithday_Date);
            MessageBox.Show(curp.ToString());

            TxtCurp.
        }
    }
}
