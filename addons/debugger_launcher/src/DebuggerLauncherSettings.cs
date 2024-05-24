#if TOOLS
using Godot;

namespace schw3de.GodotLovesCSharp.plugins.DebuggerLauncher
{
    public partial class DebuggerLauncherSettings : Resource
    {
        [Export]
        public bool LaunchVisualStudioLauncher { get; set; }
    }
}
#endif
