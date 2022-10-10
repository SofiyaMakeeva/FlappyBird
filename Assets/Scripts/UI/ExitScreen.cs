using UnityEngine;
using UnityEngine.Events;

public class ExitScreen : DefaultScreen
{
    public event UnityAction Canceled;

    protected override void OnButtonClick()
    {
        Canceled?.Invoke();
    }

    protected override void OnExitButtonClick()
    {
        Application.Quit();
    }
}
