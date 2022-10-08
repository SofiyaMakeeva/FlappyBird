using UnityEngine.Events;

public class GameOverScreen : DefaultScreen
{
    public event UnityAction RestartButtonClick;

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }
}
