
namespace BuildingProgram.Forms
{
    public partial class TestForm : Form
    {
        bool siderbarExpand = true;
        bool reportCollapse = true;
        public TestForm()
        {
            InitializeComponent();
        }

        private void sidebar_Timer_Tick(object sender, EventArgs e)
        {
            if(siderbarExpand) {
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width) {
                    siderbarExpand = false;
                    sidebar_Timer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if(sideBar.Width == sideBar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    sidebar_Timer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebar_Timer.Start();
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            if(reportCollapse)
            {
                reportContainer.Height += 10;
                if(reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportCollapse = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if(reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportCollapse = true;
                    reportTimer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }
    }
}
