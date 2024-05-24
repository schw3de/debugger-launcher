using Godot;

public partial class Example : Node
{
    [Export]
    private Button _btnHitBreakpoint;

    public override void _Ready()
    {
        _btnHitBreakpoint.Pressed += OnbtnHitBreakpointPressed;
    }

    private void OnbtnHitBreakpointPressed()
    {
        GD.Print("Add Breakpoint here");
    }
}
