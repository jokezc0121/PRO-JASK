using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Traps : MonoBehaviour
{
    public GameObject PanelFinJuego;
    void Start()
    {
    
    }
    void Update()
    {
        if (Input.anyKeyDown && PanelFinJuego.activeSelf)
        {
            PanelFinJuego.SetActive(false);
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PanelFinJuego.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
