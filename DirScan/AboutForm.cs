using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace DirPoll
{
    public partial class AboutForm : MetroForm
    {
        public AboutForm()
        {
            InitializeComponent();

            _txtHelp.Text = Globals.AppName + "\r\n"
                + "**BRIEF" + "\r\n"
                + "The purpose of Dirscan is to scan directories for changes and execute a batch program  ." 
                + "\r\n\r\n"
                + "**SETUP" + "\r\n"
                + "Click the Gear icon to go into settings.  From there click the '...' to select folders you wish to watch.  "
                + "Click 'Add' to add the folder to the list of folders.  "
                + "You may also optionally search for files and folders based on regular expressions in the '.*' fields.  " 
                + "Uncheck the checkboxes to avoid scanning for files or folders at all.  "
                + "Poll frequency determines how often the filesystem is scanned.  It defaults to 100ms (very fast).  "
                + "Exec Shell Command will execute a shell command when ANY matching folder is changed, added, or removed.  "
                + "(In the future this will be more customizable).  "
                + "Remaining options are pretty self explanatory.  "
                + "\r\n\r\n"
                + "**RUNNING" + "\r\n"
                + "Click the Play button on the main screen to start polling." + Environment.NewLine
                + "Click Play (pause) to stop polling." + Environment.NewLine
                + "Note you can't change settings when the app is polling." + Environment.NewLine
                + "File Changes will be displayed with +,-,~ identifiers next to them." + Environment.NewLine
                + "+ = file/folder added." + Environment.NewLine
                + "- = file/folder removed." + Environment.NewLine
                + "~ = file/folder changed." + Environment.NewLine
                + "To execute a script on file change make sure to type the script file in the settings dialog." + Environment.NewLine
                ;

            _txtText.Text = Globals.AppName + " v" + Globals.Version + "\r\n"
                + "Directory Watcher and Scanner App" + "\r\n"
                + "Notifies you when contents of a directory have changed, in realtime." + "\r\n"
                + "\r\n"
                + "**Author:Derek Page (Armor Monkey Software)" + "\r\n"
                + "**License: MIT License" + "\r\n"
                + "\r\n"
                + "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, " +
                "EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF " +
                "MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. " +
                "IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, " +
                "DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE" +
                ", ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER " +
                "DEALINGS IN THE SOFTWARE.";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            _lblVersion.Text = "v" + Globals.Version;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _txtText_Click(object sender, EventArgs e)
        {

        }

        private void _txtHelp_Enter(object sender, EventArgs e)
        {
            ActiveControl = _btnClose;
        }
    }
}
