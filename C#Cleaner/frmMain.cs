using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Cleaner
{
    public partial class frmMain : Form
    {
        private static readonly string LOCAL_APP_DATA_PATH = Environment.SpecialFolder.LocalApplicationData.GetPath();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            FillAppsListBox();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                String.Format("The following directories will be permanently deleted:\n{0}", lstApps.SelectedItems.ToLines()),
                "Warning",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    foreach (var item in lstApps.SelectedItems)
                    {
                        Directory.Delete(GetFullPath(item), true);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                }
                finally
                {
                    FillAppsListBox();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillAppsListBox();
        }

        private void lstApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUninstall.Enabled = (lstApps.SelectedIndices.Count > 0);
        }

        private static string GetFullPath(object path)
        {
            return String.Format("{0}\\{1}", LOCAL_APP_DATA_PATH, path);
        }

        private void FillAppsListBox()
        {
            lstApps.Items.Clear();
            lstApps.Items.AddRange(Directory.EnumerateDirectories(LOCAL_APP_DATA_PATH).Select(Path.GetFileName).ToArray());
        }
    }

    static class Extensions
    {
        internal static string GetPath(this Environment.SpecialFolder specialFolder)
        {
            return Environment.GetFolderPath(specialFolder);
        }

        internal static string ToLines(this ListBox.SelectedObjectCollection objs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in objs)
            {
                sb.AppendLine(s);
            }
            return sb.ToString();
        }
    }
}
