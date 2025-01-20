namespace MultiRoblox
{
    internal static class MultiRoblox
    {
        static NotifyIcon? NotifyIcon;

        static void Main()
        {
            ContextMenuStrip ContextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            NotifyIcon = new NotifyIcon();
            NotifyIcon.Icon = new Icon(new MemoryStream(Properties.Resources.AppIcon));

            NotifyIcon.ContextMenuStrip = ContextMenuStrip;

            NotifyIcon.Text = "MultiRoblox";
            NotifyIcon.Visible = true;

            new Mutex(true, "ROBLOX_singletonMutex");

            Application.Run();
        }

        static void Exit(object? sender, EventArgs e)
        {
            NotifyIcon?.Dispose();
            Application.Exit();
        }
    }
}