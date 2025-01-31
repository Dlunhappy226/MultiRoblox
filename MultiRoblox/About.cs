using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiRoblox
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            VersionLabel.Text = Assembly.GetExecutingAssembly().GetName().Version!.ToString()[..^2];
        }

        private void GithubLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Dlunhappy226/MultiRoblox",
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }
    }
}
