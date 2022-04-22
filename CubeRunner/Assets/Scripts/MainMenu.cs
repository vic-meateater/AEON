using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _btnPlay;
    [SerializeField] private Button _btnScores;

    private void Awake()
    {
        _btnPlay.onClick.AddListener(StartGame);
        _btnScores.onClick.AddListener(ShowScores);
    }
    
    private void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    
    private void ShowScores()
    {
        throw new System.NotImplementedException();
    }
}
