namespace SuKey.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.chkGlobalEnabled = new System.Windows.Forms.CheckBox();
            this.ChkModWin = new System.Windows.Forms.CheckBox();
            this.ChkModCtrl = new System.Windows.Forms.CheckBox();
            this.ChkModAlt = new System.Windows.Forms.CheckBox();
            this.ChkModShift = new System.Windows.Forms.CheckBox();
            this.boxKey = new System.Windows.Forms.ComboBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkGlobalEnabled
            // 
            this.chkGlobalEnabled.AutoSize = true;
            this.chkGlobalEnabled.Checked = true;
            this.chkGlobalEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGlobalEnabled.Location = new System.Drawing.Point(13, 13);
            this.chkGlobalEnabled.Name = "chkGlobalEnabled";
            this.chkGlobalEnabled.Size = new System.Drawing.Size(131, 17);
            this.chkGlobalEnabled.TabIndex = 0;
            this.chkGlobalEnabled.Text = "Enable global hotkey?";
            this.chkGlobalEnabled.UseVisualStyleBackColor = true;
            this.chkGlobalEnabled.CheckedChanged += new System.EventHandler(this.chkGlobalEnabled_CheckedChanged);
            // 
            // ChkModWin
            // 
            this.ChkModWin.AutoSize = true;
            this.ChkModWin.Location = new System.Drawing.Point(3, 3);
            this.ChkModWin.Name = "ChkModWin";
            this.ChkModWin.Size = new System.Drawing.Size(66, 17);
            this.ChkModWin.TabIndex = 1;
            this.ChkModWin.Text = "Win Key";
            this.ChkModWin.UseVisualStyleBackColor = true;
            // 
            // ChkModCtrl
            // 
            this.ChkModCtrl.AutoSize = true;
            this.ChkModCtrl.Location = new System.Drawing.Point(3, 26);
            this.ChkModCtrl.Name = "ChkModCtrl";
            this.ChkModCtrl.Size = new System.Drawing.Size(62, 17);
            this.ChkModCtrl.TabIndex = 2;
            this.ChkModCtrl.Text = "Ctrl Key";
            this.ChkModCtrl.UseVisualStyleBackColor = true;
            // 
            // ChkModAlt
            // 
            this.ChkModAlt.AutoSize = true;
            this.ChkModAlt.Location = new System.Drawing.Point(3, 49);
            this.ChkModAlt.Name = "ChkModAlt";
            this.ChkModAlt.Size = new System.Drawing.Size(59, 17);
            this.ChkModAlt.TabIndex = 3;
            this.ChkModAlt.Text = "Alt Key";
            this.ChkModAlt.UseVisualStyleBackColor = true;
            // 
            // ChkModShift
            // 
            this.ChkModShift.AutoSize = true;
            this.ChkModShift.Location = new System.Drawing.Point(3, 72);
            this.ChkModShift.Name = "ChkModShift";
            this.ChkModShift.Size = new System.Drawing.Size(68, 17);
            this.ChkModShift.TabIndex = 4;
            this.ChkModShift.Text = "Shift Key";
            this.ChkModShift.UseVisualStyleBackColor = true;
            // 
            // boxKey
            // 
            this.boxKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.boxKey.FormattingEnabled = true;
            this.boxKey.Location = new System.Drawing.Point(106, 3);
            this.boxKey.Name = "boxKey";
            this.boxKey.Size = new System.Drawing.Size(121, 21);
            this.boxKey.TabIndex = 5;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(78, 6);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 6;
            this.keyLabel.Text = "Key";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxKey);
            this.panel1.Controls.Add(this.ChkModShift);
            this.panel1.Controls.Add(this.ChkModAlt);
            this.panel1.Controls.Add(this.keyLabel);
            this.panel1.Controls.Add(this.ChkModCtrl);
            this.panel1.Controls.Add(this.ChkModWin);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 107);
            this.panel1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 181);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkGlobalEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGlobalEnabled;
        private System.Windows.Forms.CheckBox ChkModWin;
        private System.Windows.Forms.CheckBox ChkModCtrl;
        private System.Windows.Forms.CheckBox ChkModAlt;
        private System.Windows.Forms.CheckBox ChkModShift;
        private System.Windows.Forms.ComboBox boxKey;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}