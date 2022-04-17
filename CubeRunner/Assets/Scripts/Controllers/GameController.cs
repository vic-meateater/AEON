using CubeRunner;
using CubeRunner.Controllers;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private PlayerBase _player;
    
    private InputController _inputController;

    void Awake()
    {
        _inputController = new InputController(_player);
    }
    
    void Update()
    {
        _inputController.Execute();
    }
}