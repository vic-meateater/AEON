using CubeRunner.Interfaces;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class PlayerController : IExecute
    {
        const int FINISH_LAYER = 8;
        const int FAIL_LAYER = 9;
        
        private PlayerBase _player;
        private UIController _ui;

        public PlayerController(PlayerBase player, UIController ui)
        {
            _player = player;
            _ui = ui;
            _player.OnLevelObjectContact += OnLevelObjectContact;
        }

        private void OnLevelObjectContact(Collider obj)
        {
            if (obj.gameObject.layer == FINISH_LAYER)
            {
                _ui.OnWinCanvasEnabled = true;
                Time.timeScale = 0f;
                Debug.Log("FINISH!!!");
            }
            if (obj.gameObject.layer == FAIL_LAYER)
            {
                _ui.OnLooseCanvasEnabled = true;
                Time.timeScale = 0f;
                GameObject.Destroy(obj);
                Debug.Log("--------------------------------FAIL!!!");
            }
        }
        
        public void Execute()
        {

        }
    }
}