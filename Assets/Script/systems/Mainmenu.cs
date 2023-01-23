using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void First()
    {
        SceneManager.LoadScene(1);
    }
    public void Second()
    {
        SceneManager.LoadScene(2);
    }
    public void Third()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame ()
   {
      Debug.Log("Quit Bye Bye");
      Application.Quit();
   }
}
