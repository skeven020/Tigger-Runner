using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botão : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Sair()
    {
        Application.Quit();
    }
}