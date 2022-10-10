using UnityEngine;
using UnityEngine.UI;

public abstract class DefaultScreen : MonoBehaviour
{
    [SerializeField] protected CanvasGroup CanvasGroup;
    [SerializeField] protected Button PlayButton;
    [SerializeField] protected Button ExitButton;

    private void OnEnable()
    {
        PlayButton.onClick.AddListener(OnButtonClick);
        ExitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        PlayButton.onClick.RemoveListener(OnButtonClick);
        ExitButton.onClick.RemoveListener(OnExitButtonClick);
    }

    public void Open()
    {
        CanvasGroup.alpha = 1;
        CanvasGroup.interactable = true;
        CanvasGroup.blocksRaycasts = true;
    }

    public void Close()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;
        CanvasGroup.blocksRaycasts = false;
    }

    protected abstract void OnButtonClick();

    protected abstract void OnExitButtonClick();
}
