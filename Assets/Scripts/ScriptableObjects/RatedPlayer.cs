using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Rated Player/Create New Player", order = 51)]
public class RatedPlayer : ScriptableObject
{
    [SerializeField] private Texture _icon;
    [SerializeField] private string _name;
    [SerializeField] private string _score;

    public Texture Icon => _icon;
    public string Name => _name;
    public string Score => _score;
}
