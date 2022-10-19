using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverView : Initable<GameOverModel>
{
    [SerializeField] private RectTransform gameOverMenu;
    [SerializeField] private GameOverSetup resolver;
    [SerializeField] private GameObject pauseButton; 

    private void Awake()
    {
        resolver.Resolve(this);
    }
    
    public override void OnInitedEnable()
    {
        Model.GameOver += ShowGameOverMenu;
    }
    
    public override void OnInitedDisable()
    {
        Model.GameOver -= ShowGameOverMenu; 
    }

    private void ShowGameOverMenu()
    {
        gameOverMenu.gameObject.SetActive(true);
        pauseButton.SetActive(false);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
