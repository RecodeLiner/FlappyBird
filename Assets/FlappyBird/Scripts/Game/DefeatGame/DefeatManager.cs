using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatManager : MonoBehaviour
{
    private void OnEnable()
    {
        DefeatTrigger.DefeatGame += OnDefeat;
    }

    private void OnDisable()
    {
        DefeatTrigger.DefeatGame -= OnDefeat;
    }

    private void OnDefeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
