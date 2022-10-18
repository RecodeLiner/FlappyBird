using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatScene : MonoBehaviour
{
    private void OnEnable()
    {
        DefeatEvent.Instance.GameDefeated += OnDefeat;
    }

    private void OnDisable()
    {
        DefeatEvent.Instance.GameDefeated -= OnDefeat;
    }

    private void OnDefeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
