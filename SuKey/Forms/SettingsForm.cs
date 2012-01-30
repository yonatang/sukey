using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuKey.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Array arr=Enum.GetValues(typeof(Keys));
            Array.Sort(arr);
            foreach (Keys o in arr){
                boxKey.Items.Add(o);
            }
            
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            uint modifier = Properties.Settings.Default.Modifier;
            ChkModAlt.Checked = ((modifier & (uint)SuKey.ModifierKeys.Alt) != 0);
            ChkModWin.Checked = ((modifier & (uint)SuKey.ModifierKeys.Win) != 0);
            ChkModCtrl.Checked = ((modifier & (uint)SuKey.ModifierKeys.Control) != 0);
            ChkModShift.Checked = ((modifier & (uint)SuKey.ModifierKeys.Shift) != 0);

            Keys key = (Keys)Enum.ToObject(typeof(Keys), Properties.Settings.Default.Key);
            boxKey.SelectedValue=key;
            boxKey.ValueMember = key.ToString();
            boxKey.Text = key.ToString();
        }
        private void chkGlobalEnabled_CheckedChanged(object sender, EventArgs e)
        {
            bool enable=chkGlobalEnabled.Checked;
            ChkModAlt.Enabled=enable;
            ChkModWin.Enabled=enable;
            ChkModCtrl.Enabled=enable;
            ChkModShift.Enabled=enable;
            boxKey.Enabled=enable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
           
    }
}
