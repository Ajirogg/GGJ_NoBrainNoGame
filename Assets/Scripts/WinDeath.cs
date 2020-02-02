using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDeath : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Backend back;
    public GameObject Win;
    public GameObject Loose;
    public GameObject Calpin;
    public GameObject gamebutton;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoButt()
    {
        back.NewPatient();
        Win.SetActive(false);
        Loose.SetActive(false);
        Calpin.SetActive(true);
        gamebutton.SetActive(true);
    }

    public void Home()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
          Application.Quit();
#endif
    }
}
