using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class earlshields : MonoBehaviour
{
    private static string katherinegreenberg = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string trudyhughes;

    
    public static void nanmichaels()
    {
        string prefix = PlayerPrefs.GetString(katherinegreenberg, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        trudyhughes = PlayerPrefs.GetString(katherinegreenberg, "");
        urlPrefixInput.text = trudyhughes;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        trudyhughes = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(katherinegreenberg, trudyhughes);
        AudienceNetwork.AdSettings.SetUrlPrefix(trudyhughes);
    }

    public void AdViewScene()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void InterstitialAdScene()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void RewardedVideoAdScene()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
