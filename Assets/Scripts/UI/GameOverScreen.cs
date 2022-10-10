using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : DefaultScreen
{
    public CanvasGroup GameOverCanvasGroup => CanvasGroup;

    public event UnityAction RestartButtonClick;
    public event UnityAction ExitButtonClick;

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }

    protected override void OnExitButtonClick()
    {
        ExitButtonClick?.Invoke();
    }
}
