using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void changeScene(int indexNewScene) {
        SceneManager.LoadScene(indexNewScene);   
    }


    public void Update()
    {
        int temp = SceneManager.GetActiveScene().buildIndex;

        if (temp == 1) //escena del juego
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                changeScene(2); //Escena Final
            }
        }
    }

}
