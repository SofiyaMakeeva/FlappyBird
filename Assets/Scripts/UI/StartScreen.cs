using UnityEngine.Events;

public class StartScreen : DefaultScreen
{
    public event UnityAction PlayButtonClick;

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }
}
