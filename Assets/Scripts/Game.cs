using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private BirdMover _birdMover;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GameOverScreen _gameOverScreen;
    [SerializeField] private PauseScreen _pauseScreen;
    [SerializeField] private RaitingScreen _raitingScreen;
    [SerializeField] private RaitingButton _raitingButton;

    private void Awake()
    {
        Screen.SetResolution(1080, 1920, true);

        _startScreen.Open();
        _gameOverScreen.Close();
        _pauseScreen.Close();
        _birdMover.SetTheBoolToFly(false);
        Time.timeScale = 0;
    }

    private void OnEnable()
    {
        _bird.Died += OnDied;
        _startScreen.PlayButtonClick += OnPlayButtonClick;
        _gameOverScreen.RestartButtonClick += OnRestartButtonClick;
        _pauseScreen.PauseButton += OnPauseButtonClick;
        _raitingScreen.CloseRaiting += OnCloseRaitingButtonClick;
        _raitingButton.RaitingButtonClick += OnRaitingButtonClick;
    }

    private void OnDisable()
    {
        _bird.Died -= OnDied;
        _startScreen.PlayButtonClick -= OnPlayButtonClick;
        _gameOverScreen.RestartButtonClick -= OnRestartButtonClick;
        _pauseScreen.PauseButton -= OnPauseButtonClick;
        _raitingScreen.CloseRaiting -= OnCloseRaitingButtonClick;
        _raitingButton.RaitingButtonClick -= OnRaitingButtonClick;
    }

    private void OnCloseRaitingButtonClick()
    {
        _raitingScreen.Close();
        _gameOverScreen.Open();
    }

    private void OnRaitingButtonClick()
    {
        _gameOverScreen.Close();
        _raitingScreen.Open();
    }

    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        _pauseScreen.Open();
        Time.timeScale = 1;
        _birdMover.SetTheBoolToFly(true);
    }

    private void OnRestartButtonClick()
    {
        _gameOverScreen.Close();
        _pauseScreen.Open();
        _bird.ResetPlayer();
        _pipeGenerator.ResetPool();
        Time.timeScale = 1;
        _birdMover.SetTheBoolToFly(true);
    }

    private void OnPauseButtonClick()
    {

        if (Time.timeScale == 1)
        { 
            _birdMover.SetTheBoolToFly(false);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            _birdMover.SetTheBoolToFly(true);
        }
    }

    private void OnDied()
    {
        _pauseScreen.Close();
        _gameOverScreen.Open();
        _birdMover.SetTheBoolToFly(false);
        Time.timeScale = 0;
    }
}
