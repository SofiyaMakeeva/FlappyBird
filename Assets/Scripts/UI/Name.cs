using TMPro;
using UnityEngine;

public class Name : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerName;

    public TMP_Text PlayerName => _playerName;
}
