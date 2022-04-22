using CubeRunner.Interfaces;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace CubeRunner.Controllers
{
    public sealed class UIController : IExecute
    {

        
        private GameObject _loosePanel;
        private GameObject _winPanel;
        private TimeController _timeController;
        private Text _timer;


        private bool _onCanvasEnabled = false;
        public bool OnWinCanvasEnabled { get; set; }
        public bool OnLooseCanvasEnabled { get; set; }
        
        

        public UIController(GameObject winPanel, GameObject loosePanel, TimeController timeController)
        {
            _winPanel = winPanel;
            _loosePanel = loosePanel;
            _timeController = timeController;
            _timer = _winPanel.gameObject.transform.Find("Timer").GetComponent<Text>();
        }
        private void CanvasUpdate()
        {

            if (OnWinCanvasEnabled)
            {
                _timer.text = _timeController.GetTime.ToString("F");
                _onCanvasEnabled = OnWinCanvasEnabled;
                _winPanel.gameObject.SetActive(_onCanvasEnabled);
            }
            if (OnLooseCanvasEnabled)
            {
                _onCanvasEnabled = OnLooseCanvasEnabled;
                _loosePanel.gameObject.SetActive(_onCanvasEnabled);
            }

        }

        public void Execute()
        {
            CanvasUpdate();
        }
    }
}
