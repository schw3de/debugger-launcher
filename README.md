<img src="icon.png"
     alt="Debugger Launcher Icon"
     style="margin-left: 10px;" />

![Godot 4](https://camo.githubusercontent.com/1dc90d5170f2b1ea584278c222af4a5002336aab8765eaa8beca24f16e0bea00/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2d476f646f74253230342d3235306137383f7374796c653d666c6174266c6f676f3d676f646f74656e67696e65266c6f676f436f6c6f723d7768697465266c6162656c436f6c6f723d323530613738)

# Debugger Launcher

The DebuggerLauncher is a convenient plugin for the **Godot Engine 4.x**, designed to enhance debugging processes for developers using **C#** with **Visual Studio** (*Visual Studio Code* is not supported). It integrates directly into the Godot editor by adding a toggle button to the toolbar. This button allows developers to toggle whether the Visual Studio Debugger should be attached when launching the game. By simplifying the process of connecting the debugger, this plugin makes it much easier for developers to start debugging their game directly from the Godot editor, streamlining the development and troubleshooting process.

## 📝 Installation
1. Go to the [release tab](https://github.com/schw3de/debugger-launcher/releases) and download the latest version (`debugger-launcher-x.x.x.zip`).
2. Install the plugin via the AssetLib tab (`AssetLib -> Import`).
3. Build the solution
4. Activate the plugin
5. Move the `VisualStudioLauncher` autoload entry to the first position (`Project Settings -> Autoload`). This ensures that you will be able to debug your Autoload scripts

## 🔧 How to use it
If the plugin has been installed successfully, you should see the Debugger Launcher icon in the Godot editor toolbar.

<img src="docs/debuggerlauncher_toolbar.png"
     alt="Debugger Launcher Icon"
     style="margin-left: 10px;" />

Whenever you start the game, you can choose the Visual Studio solution and the debugger will get attached. You can also press cancel if you do not want to step into the debugger.

<img src="docs/choose_just_in_time_debugger.png"
     alt="Debugger Launcher Icon"
     style="margin-left: 10px;" />

If you don't want the *Choose Just-In-Time Debugger* window to appear, you can toggle the button in the Godot editor.

<img src="docs/debuggerlauncher_toolbar_deactivated.png"
     alt="Debugger Launcher Icon"
     style="margin-left: 10px;" />
