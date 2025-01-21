using System.Runtime.InteropServices;

namespace MultiRoblox
{
    internal class ContextMenu
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        NotifyIcon? NotifyIcon;
        About? About;

        public ContextMenu()
        {
            ContextMenuStrip ContextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Items.Add(new ToolStripMenuItem("About", null, ShowAbout));
            ContextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            NotifyIcon = new NotifyIcon();
            NotifyIcon.Icon = Properties.Resources.AppIcon;

            NotifyIcon.ContextMenuStrip = ContextMenuStrip;

            NotifyIcon.Text = "MultiRoblox";
            NotifyIcon.Visible = true;
        }

        void Exit(object? sender, EventArgs e)
        {
            NotifyIcon?.Dispose();
            Application.Exit();
        }

        void ShowAbout(object? sender, EventArgs e)
        {
            if (About == null || About.IsDisposed)
            {
                About = new About();

                int useDarkMode = 1;
                DwmSetWindowAttribute(About.Handle, 20, ref useDarkMode, sizeof(int));

                About.Show();
            }
            else
            {
                About.BringToFront();
                About.Activate();
            }
        }
    }
}
