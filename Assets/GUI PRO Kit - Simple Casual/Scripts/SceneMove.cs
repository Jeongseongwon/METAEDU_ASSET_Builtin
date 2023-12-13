using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void Fishing()
    {
        SceneManager.LoadScene("Forest Demo Scene");
    }

    public void Cafe()
    {
        SceneManager.LoadScene("Cafe");
    }
}
