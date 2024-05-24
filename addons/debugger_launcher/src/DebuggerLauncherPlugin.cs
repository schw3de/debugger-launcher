#if TOOLS
using Godot;

namespace schw3de.GodotLovesCSharp.plugins.DebuggerLauncher
{
    [Tool]
    public partial class DebuggerLauncherPlugin : EditorPlugin
    {
        private const string BasePluginPath = "res://addons/debugger_launcher";

        private TextureButton _btnDebugger { get; set; }

        public override void _EnterTree()
        {
            _btnDebugger = GD.Load<PackedScene>($"{BasePluginPath}/debugger_launcher_button.tscn").Instantiate<TextureButton>();
            _btnDebugger.Toggled += OnBtnDebuggerToggled;
            AddControlToContainer(CustomControlContainer.Toolbar, _btnDebugger);
            AddAutoloadSingleton(nameof(VisualStudioLauncher), $"{BasePluginPath}/src/VisualStudioLauncher.cs");
        }

        private void OnBtnDebuggerToggled(bool launchVisualStudiLauncher)
        {
            ResourceSaver.Save(
                new DebuggerLauncherSettings
                {
                    LaunchVisualStudioLauncher = launchVisualStudiLauncher
                },
                $"{BasePluginPath}/debugger_launcher_settings.tres");
        }

        public override void _ExitTree()
        {
            RemoveControlFromContainer(CustomControlContainer.Toolbar, _btnDebugger);
            RemoveAutoloadSingleton(nameof(VisualStudioLauncher));
        }
    }
}
#endif
