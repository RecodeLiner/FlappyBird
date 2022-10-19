using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverView : Initable<GameOverModel>
{
    [SerializeField] private RectTransform gameOverMenu;
    
    private void Awake()
    {
        Init(GameOverSetup.Model);
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
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1; 
    }
}
