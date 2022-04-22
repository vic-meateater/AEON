using CubeRunner;
using CubeRunner.Controllers;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    [SerializeField] private PlayerBase _player;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _loosePanel;
    
    private UIController _uiController;
    private InputController _inputController;
    private PlayerController _playerController;
    private TimeController _timeController;
    

    private void Awake()
    {
        _timeController = new TimeController();
        _uiController = new UIController(_winPanel, _loosePanel, _timeController);
        _inputController = new InputController(_player);
        _playerController = new PlayerController(_player, _uiController);
    }

    
    private void FixedUpdate()
    {
        _inputController.Execute();
        
    }

    private void Update()
    {
        _timeController.Execute();
        _playerController.Execute();
        _uiController.Execute();
        
    }
}