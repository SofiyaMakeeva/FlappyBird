using UnityEngine.Events;

public class RaitingScreen : DefaultScreen
{
    public event UnityAction CloseRaiting;

    protected override void OnButtonClick()
    {
        CloseRaiting?.Invoke();
    }
}
