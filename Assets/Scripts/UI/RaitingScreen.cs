using UnityEngine.Events;

public class RaitingScreen : DefaultScreen
{
    public event UnityAction CloseRaiting;
    public event UnityAction ExitButtonClick;

    protected override void OnButtonClick()
    {
        CloseRaiting?.Invoke();
    }

    protected override void OnExitButtonClick()
    {
        ExitButtonClick?.Invoke();
    }
}
