using UnityEngine;

public class GameOverSetup : MonoBehaviour
{
    public static GameOverModel Model;
    
    private void Awake()
    {
        Model = new GameOverModel();
    }
}
