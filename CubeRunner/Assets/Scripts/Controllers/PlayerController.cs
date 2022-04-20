using System;
using CubeRunner.Interfaces;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class PlayerController : IExecute
    {
        const int FINISH_LAYER = 8;
        const int FAIL_LAYER = 9;
        
        private PlayerBase _player;
        private UIController _canvas;

        public PlayerController(PlayerBase player, UIController canvas)
        {
            _player = player;
            _canvas = canvas;
            
            _player.OnLevelObjectContact += OnLevelObjectContact;
        }

        private void OnLevelObjectContact(Collider obj)
        {
            if (obj.gameObject.layer == FINISH_LAYER) Debug.Log("FINISH!!!");
            if (obj.gameObject.layer == FAIL_LAYER)
            {
                _canvas.OnCanvasEnabled = true;
                Time.timeScale = 0;
                Debug.Log("--------------------------------FAIL!!!");
            }
        }
        
        
        public void Execute()
        {

        }
    }
}