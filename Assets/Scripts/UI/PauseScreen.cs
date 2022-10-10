using UnityEngine;
using UnityEngine.Events;

public class PauseScreen : DefaultScreen
{
    public event UnityAction PauseButton;
    public event UnityAction ExitButtonClick;
    public BirdMover birdMover;

    protected override void OnButtonClick()
    {
        PauseButton?.Invoke();
    }

    protected override void OnExitButtonClick()
    {
        ExitButtonClick?.Invoke();
    }
}
