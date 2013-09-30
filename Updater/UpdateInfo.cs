using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdateInfo : Form
    {
        internal UpdateInfo(IUpdater applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();
            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;
            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersions.Text = String.Format("Current Version: {0}\nUpdate Version: {1}", applicationInfo.ApplicationAssembly.GetName().Version.ToString(), updateInfo.Version.ToString());
            this.txtDescription.Text = updateInfo.Description;
        }
    }
}
