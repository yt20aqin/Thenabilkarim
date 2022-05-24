using UnityEngine;
using UnityEngine.SceneManagement;

public class merrillgilbert : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void jessicabutts()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
