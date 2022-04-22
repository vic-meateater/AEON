using CubeRunner.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CubeRunner.Controllers
{
    public sealed class InputController : IExecute
    {
        
        const string HORIZONTAL = "Horizontal";
        const string VERTICAL = "Vertical";
        const float Y_AXIS = 0.0f;
        
        private PlayerBase _player;
        private KeyCode _toMainMenuPress = KeyCode.Escape;

        public InputController(PlayerBase player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            _player.Move(Input.GetAxis(HORIZONTAL),Y_AXIS,Input.GetAxis(VERTICAL));
            if (Input.GetKeyDown(_toMainMenuPress))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}