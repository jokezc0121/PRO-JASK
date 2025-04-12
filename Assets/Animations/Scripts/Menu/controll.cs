using UnityEngine;
using UnityEngine.SceneManagement;

public class controll : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void volver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
