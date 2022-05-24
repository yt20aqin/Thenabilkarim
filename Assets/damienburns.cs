using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class damienburns : MonoBehaviour
{

    int rochelleleon;
    AsyncOperation progress = null;
    Image progressBar;
    float jolenebeck = 0;
    string jamiybarra;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + octavioweston.angelinehilliard.ToString());
        if (octavioweston.angelinehilliard)
        {
            jamiybarra = "NotiSc";
        }
        else
        {
            jamiybarra = fredhuddleston.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            rochelleleon = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            rochelleleon = 0;
        }
        rochelleleon++;
        PlayerPrefs.SetInt("appStartedNumber", rochelleleon);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (jolenebeck < 5)
        {
            jolenebeck += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + octavioweston.angelinehilliard.ToString());
        if (octavioweston.angelinehilliard)
        {
            jamiybarra = "NotiSc";
        }
        else
        {
            jamiybarra = fredhuddleston.Homenamescene;
        }
        SceneManager.LoadScene(jamiybarra);
    }

}
