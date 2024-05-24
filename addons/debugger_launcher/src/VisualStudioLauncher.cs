#if TOOLS
using Godot;
using System.Diagnostics;

namespace schw3de.GodotLovesCSharp.plugins.DebuggerLauncher
{
    public partial class VisualStudioLauncher : Node
    {
        public override void _Ready()
        {
            var debuggerLauncherSettings = ResourceLoader.Load<DebuggerLauncherSettings>("res://addons/debugger_launcher/debugger_launcher_settings.tres");

            if (debuggerLauncherSettings.LaunchVisualStudioLauncher)
            {
                Debugger.Launch();
            }
        }
    }
}
#endif