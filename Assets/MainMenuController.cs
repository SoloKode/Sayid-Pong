using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame (){
        SceneManager.LoadScene(1);
    }
    public void OpenAuthor(){
        Debug.Log("Created by Sayid");
    }
}
