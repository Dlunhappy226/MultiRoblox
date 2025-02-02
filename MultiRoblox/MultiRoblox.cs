namespace MultiRoblox
{
    internal static class MultiRoblox
    {
        static ContextMenu? ContextMenu;

        static void Main()
        {
            if (CheckIfRunning())
            {
                Application.Exit();
                return;
            }

            Update update = new Update();
            bool isUpdate = update.CheckUpdate();
            if (isUpdate)
            {
                DialogResult userChoice = MessageBox.Show("New version available. Do you want to update?",
                    "MultiRoblox",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (userChoice == DialogResult.Yes)
                {
                    update.UpdatetoNewVersion();
                    return;
                }
            }

            new ContextMenu();

            new Mutex(true, "MultiRoblox_singletonMutex");
            new Mutex(true, "ROBLOX_singletonMutex");

            Application.Run();
        }

        static bool CheckIfRunning()
        {
            if (Mutex.TryOpenExisting("MultiRoblox_singletonMutex", out var _))
            {
                MessageBox.Show("MultiRoblox is already running.", "MultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (Mutex.TryOpenExisting("ROBLOX_singletonMutex", out var _))
            {
                MessageBox.Show("Roblox is already running. Please run MultiRoblox before starting Roblox.",
                    "MultiRoblox",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}