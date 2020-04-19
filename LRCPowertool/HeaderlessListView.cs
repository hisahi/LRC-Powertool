using System.Windows.Forms;

namespace LRCPowertool
{
    public class HeaderlessListView : ListView
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= 0x4000; // LVS_NOCOLUMNHEADER
                return cp;
            }
        }
    }
}