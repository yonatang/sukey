using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SuKey
{
    public class SuKeyApp : Form
    {
        [STAThread]
        public static void Main()
        {
            Application.Run(new SuKeyApp());
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private KeyboardHook hook;

        public SuKeyApp()
        {
            // Create a tray menu
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Switch (Win+S)", OnSwitch);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon
            trayIcon = new NotifyIcon();
            trayIcon.Text = "SuKey\nDoubleclick to switch user";
            trayIcon.MouseDoubleClick += new MouseEventHandler(OnSwitch);

            // Use a custom icon
            Icon i = new Icon(typeof(SuKeyApp), "icon.ico");
            trayIcon.Icon = i;

            // Register a global hot key
            hook = new KeyboardHook();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(OnSwitch);

            hook.RegisterHotKey(Properties.Settings.Default.Modifier, Properties.Settings.Default.Key);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnSwitch(object sender, EventArgs e)
        {
            Switcher.Switch();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }

    }
}
