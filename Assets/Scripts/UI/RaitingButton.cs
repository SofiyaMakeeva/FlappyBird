using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RaitingButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    public event UnityAction RaitingButtonClick;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        RaitingButtonClick?.Invoke();
    }
}
