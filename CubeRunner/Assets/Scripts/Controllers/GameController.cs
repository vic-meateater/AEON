using CubeRunner;
using CubeRunner.Controllers;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    [SerializeField] private PlayerBase _player;
    [SerializeField] private Canvas _canvas;
    
    private UIController _uiController;
    private InputController _inputController;
    private PlayerController _playerController;
    private TimeController _timeController;
    

    private void Awake()
    {
        _uiController = new UIController(_canvas);
        _inputController = new InputController(_player);
        _playerController = new PlayerController(_player, _uiController);
        _timeController = new TimeController();
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