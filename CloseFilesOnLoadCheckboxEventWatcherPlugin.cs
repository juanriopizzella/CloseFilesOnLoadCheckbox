//Developed for Navisworks 2021, targetting the 4.7.2 .NET Framework

using System.Windows.Forms;
using Autodesk.Navisworks.Api.Plugins;
using Autodesk.Navisworks.Api.Controls;

namespace CloseFilesOnLoadCheckbox
{
    [Plugin("CloseFilesOnLoadCheckbox", "juanriopizzella", DisplayName = "Close Files On Load Checkbox")]
    public class CloseFilesOnLoadCheckboxEventWatcherPlugin : EventWatcherPlugin
    {
        public override void OnLoaded()
        {
            if (!ApplicationControl.CloseFileAfterLoad)
            {
                ApplicationControl.CloseFileAfterLoad = true;

                MessageBox.Show(
                    "Since the 'Close NWC/NWD files on load' checkbox was identified to be unchecked while opening Manage 2021, it has now been automatically ticked." +
                    "\n" + "\n" +
                    "You can manually access the Options Editor to revert this action, but take into consideration that after doing this you may be blocking the overwriting of appended NWC files." +
                    "\n" + "\n"+ "\n" +
                    ""
                    );
            }
        }

        public override void OnUnloading()
        {
        }
    }
}
