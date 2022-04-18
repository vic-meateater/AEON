using CubeRunner;
using CubeRunner.Controllers;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    [SerializeField] private PlayerBase _player;
    
    private InputController _inputController;
    private PlayerController _playerController;
    private TimeController _timeController;

    private void Awake()
    {
        _inputController = new InputController(_player);
        _playerController = new PlayerController(_player);
        _timeController = new TimeController();
    }

    
    private void FixedUpdate()
    {
        _inputController.Execute();
        _timeController.Execute();
    }

    private void Update()
    {
        _playerController.Execute();
        
    }
}