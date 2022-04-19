using UnityEngine;

public class scottyquick : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static scottyquick USE;

    private AudioSource soundSource;

    private void Awake()
    {
        if (PlayerPrefs.GetString("harriettbacon").Length == 0)
        {
            jonathonpetty harriettbacon = new jonathonpetty();
            string flossiedobson = harriettbacon.graciebowen();
            PlayerPrefs.SetString("harriettbacon", flossiedobson);
            marcosbaez manuelawolf = new marcosbaez();
            string jeannieswan = manuelawolf.beatrizmyers();
            PlayerPrefs.SetString("manuelawolf", jeannieswan);
        }
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            soundSource = transform.GetChild(0).GetComponent<AudioSource>();

            carolinabright();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void carolinabright()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void lanaguerra()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void rachaelraines(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }
}
