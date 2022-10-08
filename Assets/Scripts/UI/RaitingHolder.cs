using UnityEngine;
using UnityEngine.UI;

public class RaitingHolder : MonoBehaviour
{
    [SerializeField] private Transform _raitingHolderPosition;
    [SerializeField] private GameObject _playerCard;
    [SerializeField] private RatedPlayer[] _cardsScriptableObjects;
    [SerializeField] private GameObject[] _playerCards;

    private string _name;
    private string _score;
    private Texture _icon;

    private void Start()
    {
        _playerCards = new GameObject[_cardsScriptableObjects.Length];

        for (int i = 0; i < _playerCards.Length; i++)
        {
            CreateCard(i);
        }
    }

    private void CreateCard(int index)
    {
        var card = Instantiate(_playerCard, _raitingHolderPosition);

        _playerCards[index] = card;

        _name = _cardsScriptableObjects[index].Name;
        _score = _cardsScriptableObjects[index].Score;
        _icon = _cardsScriptableObjects[index].Icon;

        card.GetComponentInChildren<RawImage>().texture = _icon;
        card.GetComponentInChildren<Name>().PlayerName.text = _name;
        card.GetComponentInChildren<ScoreText>().PlayerScoreText.text = _score;
    }
}
