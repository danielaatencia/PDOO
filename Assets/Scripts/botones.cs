using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateMenu : MonoBehaviour
{
    public void CargarNivel()
    {
        SceneManager.LoadScene("tower 2");
    }

    public void AlMenu()
    {
        SceneManager.LoadScene("menu");
    }

}
