using UnityEngine;
using UnityEngine.SceneManagement;

public class chestergabriel : MonoBehaviour
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

    public void lynnettemcguire()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
