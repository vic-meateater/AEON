using System;
using CubeRunner.Interfaces;
using Unity.VisualScripting;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class PlayerController : IExecute
    {
        const int FINISH_LAYER = 8;
        
        private PlayerBase _player;

        public PlayerController(PlayerBase player)
        {
            _player = player;
            
            _player.OnLevelObjectContact += OnLevelObjectContact;
        }

        private void OnLevelObjectContact(Collider obj)
        {
            if (obj.gameObject.layer == FINISH_LAYER) Debug.Log("FINISH!!!");
        }
        
        public void Execute()
        {
            if (_player.transform.position.y < 0) Debug.Log("Падааааем");
        }
    }
}