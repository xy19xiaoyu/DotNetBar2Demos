using DevComponents.DotNetBar;

namespace SuperGridDemo
{
    public partial class DemoGridArchitecture : Office2007Form
    {
        public DemoGridArchitecture()
        {
            InitializeComponent();

            // Set the sample description text

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoArchitecture.rtf");
        }
    }
}