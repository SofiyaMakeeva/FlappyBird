using UnityEngine.Events;

public class PauseScreen : DefaultScreen
{
    public event UnityAction PauseButton;

    protected override void OnButtonClick()
    {
        PauseButton?.Invoke();
    }
}
