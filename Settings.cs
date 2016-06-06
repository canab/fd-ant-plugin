using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace AntPlugin
{
    [Serializable]
    public class Settings
    {
        private const String DEFAULT_ANT_PATH = "";
        private const String DEFAULT_ADD_ARGS = "";
        
        private String antPath = DEFAULT_ANT_PATH;
        private String addArgs = DEFAULT_ADD_ARGS;

        [DisplayName("Path to Ant")]
        [Description("Path to Ant installation dir")]
        [DefaultValue(DEFAULT_ANT_PATH)]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public String AntPath
        {
            get { return antPath; }
            set { antPath = value; }
        }

        [DisplayName("Additional Arguments")]
        [Description("More parameters to add to the Ant call (e.g. -inputhandler <classname>)")]
        [DefaultValue(DEFAULT_ANT_PATH)]
        public String AddArgs
        {
            get { return addArgs; }
            set { addArgs = value; }
        }
    }
}