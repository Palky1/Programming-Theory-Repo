using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void Play_BTN_Clicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
}
