using System.Collections;
using System.Collections.Generic;
using CubeRunner.Interfaces;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class UIController : IExecute
    {
        private const string LOOSE_CANVAS = "Loose";
        
        private Canvas _canvas;

        private Canvas[] _canvaces;
        private bool _onCanvasEnabled = false;
        public bool OnCanvasEnabled { get; set; }
        
        

        public UIController(Canvas canvas)
        {
            _canvas = canvas;
            _canvaces = _canvas.gameObject.GetComponentsInChildren<Canvas>();
        }
        private void CanvasUpdate()
        {
            _onCanvasEnabled = OnCanvasEnabled;
            for (var i = 0; i <= _canvaces.Length; i++)
            {
                if (_canvaces[i].name == LOOSE_CANVAS)
                {
                    _canvaces[i].gameObject.SetActive(_onCanvasEnabled);
                }
            }
            
            //_canvas.gameObject.SetActive(_onCanvasEnabled);

        }

        public void Execute()
        {
            CanvasUpdate();
        }
    }
}
