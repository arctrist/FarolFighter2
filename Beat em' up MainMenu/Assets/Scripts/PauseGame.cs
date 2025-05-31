using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject MenuPausa;

    private bool isPaused = false; // Optional but useful

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            botonPausa.SetActive(false);
            MenuPausa.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            botonPausa.SetActive(true);
            MenuPausa.SetActive(false);
            isPaused = false;
        }
    }

    public void Volver()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        MenuPausa.SetActive(false);
        isPaused = false;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }
}