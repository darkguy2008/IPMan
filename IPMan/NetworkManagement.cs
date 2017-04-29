using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace IPMan
{
    public class NetworkManagement
    {
        ManagementClass objMCConfig;
        ManagementClass objMCAdapter;
        ManagementObjectCollection objMOCConfig;
        ManagementObjectCollection objMOCAdapter;

        public List<NetworkAdapter> Adapters;

        public NetworkManagement()
        {
            Refresh();
        }

        public void Refresh()
        {
            objMCConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            objMCAdapter = new ManagementClass("Win32_NetworkAdapter");
            objMOCConfig = objMCConfig.GetInstances();
            objMOCAdapter = objMCAdapter.GetInstances();

            if (Adapters == null)
            {
                Adapters = new List<NetworkAdapter>();
                foreach (ManagementObject obj in objMOCConfig.Cast<ManagementObject>())
                    Adapters.Add(new NetworkAdapter(this, obj, objMOCAdapter.Cast<ManagementObject>().Where(x => x["Caption"].ToString().ToLowerInvariant().Trim() == obj["Caption"].ToString().ToLowerInvariant().Trim()).SingleOrDefault()));
            }
            else
            {
                foreach (ManagementObject obj in objMOCConfig.Cast<ManagementObject>())
                    foreach (NetworkAdapter adapter in Adapters)
                        if (adapter.Caption.ToLowerInvariant().Trim() == obj["Caption"].ToString().ToLowerInvariant().Trim())
                            adapter.Update(obj, objMOCAdapter.Cast<ManagementObject>().Where(x => x["Caption"].ToString().ToLowerInvariant().Trim() == obj["Caption"].ToString().ToLowerInvariant().Trim()).SingleOrDefault());
            }
        }
    }
}
