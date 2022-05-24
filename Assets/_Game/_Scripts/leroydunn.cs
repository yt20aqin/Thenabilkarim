using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class leroydunn : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool bertiebyers = false;




    void Update()
    {
        if (brianajoyner.Length > 0 && !bertiebyers)
        {
            bertiebyers = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + laurameade);

            if (laurameade.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(sheliawhitehead(kristinabillings, image));
                return;
            }
            else if (sheliatorres.Length > 0)
            {
                fredhuddleston.Instance.ShowApplovin();
            }
            else if (reneeriddle.Length > 0)
            {
                fredhuddleston.Instance.ShowInterstitialfb();
            }
            else if (johnsmith.Length > 0)
            {
                fredhuddleston.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(fredhuddleston.Homenamescene);

        }
    }

    string reneeriddle = "";
    string kristinabillings = "";
    string sheliatorres = "";
    string johnsmith = "";
    string laurameade = "";
    string brianajoyner = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(fredhuddleston.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              reneeriddle = snapshot.Child("NotiFbads").Value.ToString();
              kristinabillings = snapshot.Child("NotiImg").Value.ToString();
              sheliatorres = snapshot.Child("NotiLovin").Value.ToString();
              johnsmith = snapshot.Child("NotiUnityads").Value.ToString();
              johnsmith = snapshot.Child("NotiUnityads").Value.ToString();
              laurameade = snapshot.Child("NotiUrl").Value.ToString();
              brianajoyner = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived kristinabillings " + kristinabillings);
              UnityEngine.Debug.Log("XReceived laurameade " + laurameade);

          }
      });

    }

    public void angelicaharrison()
    {
        Application.OpenURL(laurameade);

    }

    UnityWebRequest www;
    IEnumerator sheliawhitehead(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
