namespace BasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB= new Thread(new ThreadStart(MyThreadClass.Thread1));

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End of Thread-";    

        }
    }
}
