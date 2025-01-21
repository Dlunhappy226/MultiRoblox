using System.Runtime.InteropServices;

namespace MultiRoblox
{
    internal static class MultiRoblox
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        static NotifyIcon? NotifyIcon;
        static About? About;
        static void Main()
        {
            if (Mutex.TryOpenExisting("MultiRoblox_singletonMutex", out var _))
            {
                MessageBox.Show("MultiRoblox already running.", "MultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            if (Mutex.TryOpenExisting("ROBLOX_singletonMutex", out var _))
            {
                MessageBox.Show("Roblox already running. Please run MultiRoblox before starting Roblox.", "MultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            ContextMenuStrip ContextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Items.Add(new ToolStripMenuItem("About", null, ShowAbout));
            ContextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            NotifyIcon = new NotifyIcon();
            NotifyIcon.Icon = Properties.Resources.AppIcon;

            NotifyIcon.ContextMenuStrip = ContextMenuStrip;

            NotifyIcon.Text = "MultiRoblox";
            NotifyIcon.Visible = true;

            new Mutex(true, "MultiRoblox_singletonMutex");
            new Mutex(true, "ROBLOX_singletonMutex");

            Application.Run();
        }

        static void Exit(object? sender, EventArgs e)
        {
            NotifyIcon?.Dispose();
            Application.Exit();
        }

        static void ShowAbout(object? sender, EventArgs e)
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