using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IPMan
{
    public partial class frmMain : Form
    {
        bool quit = false;
        bool isWorking = false;
        string chosenAdapter = string.Empty;
        NetworkManagement nm = new NetworkManagement();

        private void lnkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hello there!
            // While this app is open-source and you are free to modify it as you please
            // and remove this (hopefully not) nag text, please consider donating at least
            // once, it'll help me to pay for expenses, food, beer, coffee, and all that
            // stuff that keeps us alive and, in my case, motivated to keep making great 
            // apps like this one. Thanks! ^_^ -DARKGuy
            Process.Start("https://darkguy2008.github.io/IPMan/");
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbAdapter.SelectedIndex == -1)
                return;
            NetworkAdapter adapter = (NetworkAdapter)cbAdapter.SelectedItem;
            adapter.Blank();
            chosenAdapter = adapter.Caption;
            isWorking = true;
            if (!String.IsNullOrEmpty(txIP.Text))
                adapter.SetIPAddress(txIP.Text, txMask.Text);
            if (!String.IsNullOrEmpty(txGateway.Text))
                adapter.SetGateway(txGateway.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.appIcon;
            nIcon.Icon = Properties.Resources.appIcon;
            LoadAdapters();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void nIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            quit = true;
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2017 darkguy2008 @ github");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Visible)
                Hide();
            else
                Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (quit)
                return;
            e.Cancel = true;
            Hide();
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            if (Visible)
                RefreshUI();
        }

        private void cbAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            if (cbAdapter.SelectedIndex == -1)
            {
                lbIP.Text = "N/A";
                lbMask.Text = "N/A";
                lbGateway.Text = "N/A";
                SetUIState(null);
                return;
            }
            nm.Refresh();
            NetworkAdapter adapter = (NetworkAdapter)cbAdapter.SelectedItem;
            lbIP.Text = adapter.IPAddress;
            lbMask.Text = adapter.Submask;
            lbGateway.Text = adapter.Gateway;
            btnToggle.Text = adapter.Enabled ? "Disabl&e" : "&Enable";
            SetUIState(adapter);
        }

        private void SetUIState(NetworkAdapter adapter)
        {
            bool state = adapter == null ? false : adapter.Enabled;
            if (isWorking)
                state = false;
            txIP.Enabled = state;
            txMask.Enabled = state;
            txGateway.Enabled = state;
            btnDHCP.Enabled = state;
            btnOk.Enabled = state;
            btnToggle.Enabled = isWorking ? state : true;
        }

        private void LoadAdapters()
        {
            cbAdapter.SelectedIndex = -1;
            cbAdapter.Items.Clear();
            foreach (NetworkAdapter adapter in nm.Adapters)
            {
                cbAdapter.Items.Add(adapter);
                adapter.Changed += (object sender, EventArgs e) =>
                {
                    NetworkAdapter a = (NetworkAdapter)sender;
                    if (a.Caption == chosenAdapter)
                    {
                        isWorking = false;
                        chosenAdapter = string.Empty;
                    }
                };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            nm.Refresh();
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            if (cbAdapter.SelectedIndex == -1)
                return;
            NetworkAdapter adapter = (NetworkAdapter)cbAdapter.SelectedItem;
            adapter.Blank();
            chosenAdapter = adapter.Caption;
            isWorking = true;
            adapter.EnableDHCP();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (cbAdapter.SelectedIndex == -1)
                return;
            NetworkAdapter adapter = (NetworkAdapter)cbAdapter.SelectedItem;
            adapter.Blank();
            chosenAdapter = adapter.Caption;
            isWorking = true;
            if (adapter.Enabled)
                adapter.Disable();
            else
                adapter.Enable();
        }
    }
}
