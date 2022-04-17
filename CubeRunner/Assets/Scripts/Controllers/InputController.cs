using CubeRunner.Interfaces;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class InputController : IExecute
    {
        
        const string HORIZONTAL = "Horizontal";
        const string VERTICAL = "Vertical";
        
        private PlayerBase _player;

        public InputController(PlayerBase player)
        {
            _player = player;
        }
        
        public void Execute()
        {
            _player.Move(Input.GetAxis(HORIZONTAL),0.0f,Input.GetAxis(VERTICAL));
        }
    }
}