using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText;

    public TMP_Text PlayerScoreText => _playerScoreText;
}
