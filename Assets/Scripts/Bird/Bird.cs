using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private BirdMover _birdMover;
    private int _score;

    public event UnityAction Died;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _birdMover = GetComponent<BirdMover>();
    }

    public void ResetPlayer()
    {
        _birdMover.ResetBird();

        _score = 0;
        ScoreChanged?.Invoke(_score);
    }

    public void Die()
    {
        Died?.Invoke();
    }

    public void AddScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }
}
