﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

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

        private String GetModifierText(uint modifierBits)
        {
            uint win = (uint)SuKey.ModifierKeys.Win;
            uint alt = (uint)SuKey.ModifierKeys.Alt;
            uint ctrl = (uint)SuKey.ModifierKeys.Control;
            uint shift = (uint)SuKey.ModifierKeys.Shift;

            StringBuilder sb = new StringBuilder();
            bool empty = true;
            if ((modifierBits & win) != 0)
            {
                empty = false;
                sb.Append(Properties.Resources.ModifierWin);
            }

            if ((modifierBits & alt) != 0)
            {
                if (empty)
                {
                    empty = false;
                }
                else
                {
                    sb.Append("+");
                }
                sb.Append(Properties.Resources.ModifierAlt);
            }

            if ((modifierBits & ctrl) != 0)
            {
                if (empty)
                {
                    empty = false;
                }
                else
                {
                    sb.Append("+");
                }
                sb.Append(Properties.Resources.ModifierCtrl);
            }

            if ((modifierBits & shift) != 0)
            {
                if (empty)
                {
                    empty = false;
                }
                else
                {
                    sb.Append("+");
                }
                sb.Append(Properties.Resources.ModifierShift);
            }

            return sb.ToString();
        }

        public String getKeyText(uint key)
        {
            return Enum.ToObject(typeof(Keys), key).ToString();
        }

        public SuKeyApp()
        {
            uint modifier=Properties.Settings.Default.Modifier;
            uint key = Properties.Settings.Default.Key;
            Version version = Assembly.GetEntryAssembly().GetName().Version;

            // Create a tray menu
            trayMenu = new ContextMenu();
            string shortCutKey = "("+GetModifierText(modifier) + "+" + getKeyText(key)+")";
            trayMenu.MenuItems.Add(String.Format(Properties.Resources.TrayMenuItemSwitch,shortCutKey), OnSwitch);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add(Properties.Resources.TrayMenuItemExit, OnExit);

            // Create a tray icon
            trayIcon = new NotifyIcon();
            trayIcon.Text = String.Format(Properties.Resources.TrayIconText,version);
            trayIcon.MouseDoubleClick += new MouseEventHandler(OnSwitch);
            
            // Use a custom icon
            trayIcon.Icon = new Icon(typeof(SuKeyApp), "icon.ico"); 
            
            // Register a global hot key
            hook = new KeyboardHook();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(OnSwitch);

            hook.RegisterHotKey(modifier, key);

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
