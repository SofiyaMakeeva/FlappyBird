using UnityEngine;
using UnityEngine.Events;

public class StartScreen : DefaultScreen
{
    public CanvasGroup StartCanvasGroup => CanvasGroup;

    public event UnityAction PlayButtonClick;
    public event UnityAction ExitButtonClick;

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }

    protected override void OnExitButtonClick()
    {
        ExitButtonClick?.Invoke();
    }
}
