using UnityEngine;

public class rustygamble : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static rustygamble USE;

    private AudioSource rociorussell;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            rociorussell = transform.GetChild(0).GetComponent<AudioSource>();

            lucyhaynes();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void lucyhaynes()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void lucillemedeiros()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void rosalindanorwood(AudioClip clip)
    {
        rociorussell.PlayOneShot(clip);
    }
}
