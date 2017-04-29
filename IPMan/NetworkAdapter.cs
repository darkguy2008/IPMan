using System;
using System.Management;

namespace IPMan
{
    public class NetworkAdapter
    {
        protected NetworkManagement nm;
        protected ManagementObject moConfig;
        protected ManagementObject moAdapter;

        public string Caption { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool DHCPEnabled { get; set; }

        public string IPAddress { get; set; }
        public string Submask { get; set; }
        public string Gateway { get; set; }

        public event EventHandler Changed;

        public void Blank()
        {
            IPAddress = string.Empty;
            Submask = string.Empty;
            Gateway = string.Empty;
        }

        public NetworkAdapter(NetworkManagement n, ManagementObject mConfig, ManagementObject mAdapter)
        {
            nm = n;
            Blank();
            Update(mConfig, mAdapter);
        }

        public void Update(ManagementObject mCfg, ManagementObject mAdap)
        {
            moConfig = mCfg;
            moAdapter = mAdap;
            Caption = (string)moConfig["Caption"];
            Description = (string)moConfig["Description"];
            DHCPEnabled = (bool)moConfig["DHCPEnabled"];

            string[] ip = (string[])moConfig.GetPropertyValue("IPAddress");
            string[] sub = (string[])moConfig.GetPropertyValue("IPSubnet");
            string[] gw = (string[])moConfig.GetPropertyValue("DefaultIPGateway");

            bool newEnabled = (bool)moConfig["IPEnabled"];
            string newIPAddress = ip != null ? ip[0] : string.Empty;
            string newSubmask = sub != null ? sub[0] : string.Empty;
            string newGateway = gw != null ? gw[0] : string.Empty;

            if (newIPAddress.ToLowerInvariant().Trim() != IPAddress.ToLowerInvariant().Trim() ||
                newSubmask.ToLowerInvariant().Trim() != Submask.ToLowerInvariant().Trim() ||
                newGateway.ToLowerInvariant().Trim() != Gateway.ToLowerInvariant().Trim() ||
                newEnabled != Enabled)
                Changed?.Invoke(this, null);

            IPAddress = newIPAddress;
            Submask = newSubmask;
            Gateway = newGateway;
            Enabled = newEnabled;
        }

        public void EnableDHCP()
        {
            if (!Enabled)
                return;
            try
            {
                ManagementBaseObject setIP;
                ManagementBaseObject newIP = moConfig.GetMethodParameters("EnableDHCP");
                setIP = moConfig.InvokeMethod("EnableDHCP", null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetIPAddress(string ip, string submask)
        {
            if (!Enabled)
                return;
            try
            {
                ManagementBaseObject setIP;
                ManagementBaseObject newIP = moConfig.GetMethodParameters("EnableStatic");
                newIP["IPAddress"] = new string[] { ip };
                newIP["SubnetMask"] = new string[] { submask };
                setIP = moConfig.InvokeMethod("EnableStatic", newIP, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetGateway(string gateway)
        {
            if (!Enabled)
                return;
            try
            {
                ManagementBaseObject setGateway;
                ManagementBaseObject newGateway = moConfig.GetMethodParameters("SetGateways");
                newGateway["DefaultIPGateway"] = new string[] { gateway };
                newGateway["GatewayCostMetric"] = new int[] { 1 };
                setGateway = moConfig.InvokeMethod("SetGateways", newGateway, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetDNS(string dns)
        {
            if (!Enabled)
                return;
            try
            {
                ManagementBaseObject newDNS = moConfig.GetMethodParameters("SetDNSServerSearchOrder");
                newDNS["DNSServerSearchOrder"] = dns.Split(',');
                ManagementBaseObject setDNS = moConfig.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetWINS(string primaryWINS, string secondaryWINS)
        {
            if (!Enabled)
                return;
            try
            {
                ManagementBaseObject setWINS;
                ManagementBaseObject wins = moConfig.GetMethodParameters("SetWINSServer");
                wins.SetPropertyValue("WINSPrimaryServer", primaryWINS);
                wins.SetPropertyValue("WINSSecondaryServer", secondaryWINS);
                setWINS = moConfig.InvokeMethod("SetWINSServer", wins, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Enable()
        {
            try
            {
                ManagementBaseObject args = moAdapter.GetMethodParameters("Enable");
                moAdapter.InvokeMethod("Enable", args, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Disable()
        {
            try
            {
                ManagementBaseObject args = moAdapter.GetMethodParameters("Disable");
                moAdapter.InvokeMethod("Disable", args, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
