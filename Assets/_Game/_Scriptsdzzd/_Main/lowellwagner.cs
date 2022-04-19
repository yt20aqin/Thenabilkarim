using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor;

#if UNITY_WEBGL
using System.IO;
#endif

public class lowellwagner : MonoBehaviour
{
    public string gwenmorris = "ColoringList";

    [Space]
    public bool amyreynolds;

    
    public float briannamorton = 512;
    public float dorisharmon = 288;
    public float spacing = -50;

    [Space]
    public bool terrafields;
    public GameObject jacquelynfrazier;
    public GameObject sheryldoty;

    private List<float> traciemcginnis;
    private float lydiaphan;
    private Vector3 augustamcghee;
    private bool brookemcgowan;
    private float raquellatham = 0.1f;
    private float evaolvera = 1.2f;
    private float dollieblevins = 1.2f;
    private List<GameObject> joannaott;
    private bool latanyamassey;
    private int mattieabel;
    private int ernaseymour = 0;

    private int annpayton = 1024;
    private int jeannettegonzales = 576;

    private void Awake()
    {
        brookemcgowan = false;
        latanyamassey = false;

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => {
            
        };
        string part1 = "LVMxil1GcF_Ravh5gH_xKbVh4WJxxH0EB7m1";
        string part2 = "PTt2309K1aVcRIHkkacr6dzm6oNP";
        string part3 = "-NJwHGGARatLan-EvNF-LM";
        MaxSdk.SetSdkKey(part1+ part2 + part3);
        MaxSdk.InitializeSdk();
        pattigilliam();
        ernaseymour = PlayerPrefs.GetInt(gwenmorris, 0);
      

        

        
        if (GetComponent<GridLayoutGroup>().cellSize == Vector2.zero)
        {
            Vector2 cellSize = new Vector2(briannamorton, dorisharmon);
            GetComponent<GridLayoutGroup>().cellSize = cellSize;
        }
        else
        {
            briannamorton = GetComponent<GridLayoutGroup>().cellSize.x;
            dorisharmon = GetComponent<GridLayoutGroup>().cellSize.y;
        }

        
        transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(briannamorton, dorisharmon);

        if (amyreynolds)
        {
            transform.parent.GetComponent<ScrollRect>().horizontal = true;
            transform.parent.GetComponent<ScrollRect>().vertical = false;

            
            if (GetComponent<GridLayoutGroup>().spacing == Vector2.zero)
            {
                Vector2 spacingVector = new Vector2(spacing, 0);
                GetComponent<GridLayoutGroup>().spacing = spacingVector;
            }
            else
            {
                if (GetComponent<GridLayoutGroup>().spacing.x != 0)
                    spacing = GetComponent<GridLayoutGroup>().spacing.x;
            }

            GetComponent<GridLayoutGroup>().startAxis = GridLayoutGroup.Axis.Vertical;
            GetComponent<GridLayoutGroup>().constraint = GridLayoutGroup.Constraint.FixedRowCount;
            GetComponent<GridLayoutGroup>().constraintCount = 1;
            lydiaphan = (briannamorton + spacing) / 2;
        }
        else
        {
            transform.parent.GetComponent<ScrollRect>().horizontal = false;
            transform.parent.GetComponent<ScrollRect>().vertical = true;

            if (GetComponent<GridLayoutGroup>().spacing == Vector2.zero)
            {
                Vector2 spacingVector = new Vector2(0, spacing);
                GetComponent<GridLayoutGroup>().spacing = spacingVector;
            }
            else
            {
                if (GetComponent<GridLayoutGroup>().spacing.y != 0)
                    spacing = GetComponent<GridLayoutGroup>().spacing.y;
            }

            GetComponent<GridLayoutGroup>().startAxis = GridLayoutGroup.Axis.Horizontal;
            GetComponent<GridLayoutGroup>().constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            GetComponent<GridLayoutGroup>().constraintCount = 1;
            lydiaphan = (dorisharmon + spacing) / 2;
        }

        traciemcginnis = new List<float>();
        joannaott = new List<GameObject>();

        
        foreach (Transform penelopethomson in transform)
            joannaott.Add(penelopethomson.gameObject);

        
        if (amyreynolds)
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(joannaott.Count * briannamorton + (joannaott.Count - 1) * spacing, dorisharmon);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(GetComponent<RectTransform>().sizeDelta.x - 2 * spacing, GetComponent<RectTransform>().anchoredPosition.y);

            float estellalane = GetComponent<RectTransform>().sizeDelta.x / 2 - briannamorton / 2;
            traciemcginnis.Add(estellalane);

            
            joannaott[0].transform.localScale = new Vector3(evaolvera, evaolvera, 1);
			
            for (int i = 1; i < joannaott.Count; i++)
            {
                estellalane -= briannamorton + spacing;
                traciemcginnis.Add(estellalane);
				
                
                joannaott[i].transform.localScale = new Vector3(dollieblevins, dollieblevins, 1);
            }
        }
        else
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(briannamorton, joannaott.Count * dorisharmon + (joannaott.Count - 1) * spacing);
            GetComponent<RectTransform>().anchoredPosition = new Vector2(GetComponent<RectTransform>().anchoredPosition.x, -(GetComponent<RectTransform>().sizeDelta.y - 2 * spacing));

            float estellalane = GetComponent<RectTransform>().sizeDelta.y / 2 - dorisharmon / 2;
            traciemcginnis.Add(estellalane);

            
            joannaott[0].transform.localScale = new Vector3(evaolvera, evaolvera, 1);
			
            for (int i = 1; i < joannaott.Count; i++)
            {
                estellalane -= dorisharmon + spacing;
                traciemcginnis.Add(estellalane);
				
                
                joannaott[i].transform.localScale = new Vector3(dollieblevins, dollieblevins, 1);
            }
        }

        rachaelwashington(ernaseymour);

        leannsexton();
    }

 









private void rachaelwashington(int num)
    {
        int delorescrouch = 0;
        if (traciemcginnis.Count >= num)
        {
            delorescrouch = traciemcginnis.Count - 1;

        }
        else
        {
            delorescrouch = num;
        }
        if (amyreynolds)
        {
             
            augustamcghee = new Vector3(traciemcginnis[delorescrouch], 0, 0);
        }
        else
        {
            delorescrouch = traciemcginnis.Count - 1 - delorescrouch;
            augustamcghee = new Vector3(0, traciemcginnis[delorescrouch], 0);
        }

        mattieabel = delorescrouch;
        transform.localPosition = augustamcghee;
        brookemcgowan = true;
    }

    private void leannsexton()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            byte[] loadPixels = new byte[annpayton * jeannettegonzales * 4];
            loadPixels = evelynbrantley(gwenmorris + i.ToString());

            if (loadPixels != null)
            {
                Texture2D tex = new Texture2D(annpayton, jeannettegonzales, TextureFormat.RGBA32, false);
                tex.filterMode = FilterMode.Point;
                tex.wrapMode = TextureWrapMode.Clamp;
                tex.LoadRawTextureData(loadPixels);
                tex.Apply(false);

                transform.GetChild(i).GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0, 0, annpayton, jeannettegonzales), Vector2.zero, 100);
            }
        }
    }

    private byte[] evelynbrantley(string key)
    {
#if UNITY_WEBGL
        string alissahollis = Application.persistentDataPath + "/Landscape" + key + ".sav";
        if (File.Exists(alissahollis))
        {
            return System.Convert.FromBase64String(File.ReadAllText(alissahollis));
        }
        else
        {
            return null;
        }
#else
        if (PlayerPrefs.HasKey(key))
        {
            return System.Convert.FromBase64String(PlayerPrefs.GetString(key));
        }
        else
        {
            return null;
        }
#endif
    }

    
    private void tommiereyna()
    {
        for (int i = 0; i < traciemcginnis.Count; i++)
        {
            if (amyreynolds)
            {
                if (transform.localPosition.x > traciemcginnis[i] - lydiaphan - 1 && transform.localPosition.x <= traciemcginnis[i] + lydiaphan)
                {
                    augustamcghee = new Vector3(traciemcginnis[i], 0, 0);
                    brookemcgowan = true;
                    mattieabel = i;
                    break;
                }
            }
            else
            {
                if (transform.localPosition.y > traciemcginnis[i] - lydiaphan - 1 && transform.localPosition.y <= traciemcginnis[i] + lydiaphan)
                {
                    augustamcghee = new Vector3(0, traciemcginnis[i], 0);
                    brookemcgowan = true;
                    mattieabel = joannaott.Count - i - 1;
                    break;
                }
            }
        }
    }

    private void jadethomson()
    {
        for (int i = 0; i < traciemcginnis.Count; i++)
        {
            if (amyreynolds)
            {
                if (transform.localPosition.x > traciemcginnis[i] - lydiaphan - 1 && transform.localPosition.x <= traciemcginnis[i] + lydiaphan)
                {
                    mattieabel = i;
                    break;
                }
            }
            else
            {
                if (transform.localPosition.y > traciemcginnis[i] - lydiaphan - 1 && transform.localPosition.y <= traciemcginnis[i] + lydiaphan)
                {
                    mattieabel = joannaott.Count - i - 1;
                    break;
                }
            }
        }
    }

    
    private IEnumerator laurelmackey()
    {
        yield return new WaitForSeconds(0.4f);
        latanyamassey = false;
    }

    public void janetteprice()
    {
        if (amyreynolds)
        {
            if (mattieabel > 0 && !latanyamassey)
            {
                
                latanyamassey = true;

                mattieabel -= 1;
                augustamcghee = new Vector3(traciemcginnis[mattieabel], transform.localPosition.y, 0);
                brookemcgowan = true;

                StartCoroutine(laurelmackey());
            }
        }
        else
        {
            if (mattieabel > 0 && !latanyamassey)
            {
                
                latanyamassey = true;
				
                mattieabel -= 1;
                augustamcghee = new Vector3(transform.localPosition.x, traciemcginnis[joannaott.Count - mattieabel - 1], 0);
                brookemcgowan = true;
				
                StartCoroutine(laurelmackey());
            }
        }
    }

    public void annettegreen()
    {
        if (amyreynolds)
        {
            if (mattieabel < traciemcginnis.Count - 1 && !latanyamassey)
            {
                
                latanyamassey = true;

                mattieabel += 1;
                augustamcghee = new Vector3(traciemcginnis[mattieabel], transform.localPosition.y, 0);
                brookemcgowan = true;

                StartCoroutine(laurelmackey());
            }
        }
        else
        {
            if (mattieabel < joannaott.Count - 1 && !latanyamassey)
            {
                
                latanyamassey = true;
				
                mattieabel += 2;
                augustamcghee = new Vector3(transform.localPosition.x, traciemcginnis[joannaott.Count - mattieabel], 0);
                brookemcgowan = true;
				
                StartCoroutine(laurelmackey());
            }
        }
    }

    private void antoinettepiper(GameObject button)
    {
        if (!terrafields)
            return;
        Color c = button.GetComponent<Image>().color;
        c = new Color(1, 1, 1, 1);
        button.GetComponent<Image>().color = c;
        

        button.GetComponent<Button>().interactable = true;
    }

    private void leeannforbes(GameObject button)
    {
        if (!terrafields)
            return;
        Color c = button.GetComponent<Image>().color;
        c = new Color(1, 1, 1, 0.3f);
        button.GetComponent<Image>().color = c;
        
		
        button.GetComponent<Button>().interactable = false;
    }

    private void LateUpdate()
    {
        
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButton(0)) && !latanyamassey)
        {
            jadethomson();
            augustamcghee = transform.localPosition;
        }

        
        if (amyreynolds)
        {
            if (!brookemcgowan && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.x) >= 0f && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.x) < 100f)
            {
                tommiereyna();
            }
            else
            {
                jadethomson();
            }
        }
        else
        {
            if (!brookemcgowan && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.y) >= 0f && Mathf.Abs(transform.parent.GetComponent<ScrollRect>().velocity.y) < 100f)
            {
                tommiereyna();
            }
            else
            {
                jadethomson();
            }
        }

        
        if (amyreynolds)
        {
            if (mattieabel == 0)
            {
                float adeleburks = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x - lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;

                if (adeleburks <= dollieblevins || adeleburks > evaolvera)
                    adeleburks = dollieblevins;

                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);

                joannaott[mattieabel + 1].transform.localScale = new Vector3(adeleburks, adeleburks, 1);
            }
            else if (mattieabel == joannaott.Count - 1)
            {
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float taylorbarr = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x + lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;

                if (taylorbarr <= dollieblevins || taylorbarr > evaolvera)
                    taylorbarr = dollieblevins;

                joannaott[mattieabel - 1].transform.localScale = new Vector3(taylorbarr, taylorbarr, 1);
                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);
            }
            else
            {
                float adeleburks = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x - lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float taylorbarr = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] - transform.localPosition.x + lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;
				
                if (adeleburks <= dollieblevins || adeleburks > evaolvera)
                    adeleburks = dollieblevins;

                if (taylorbarr <= dollieblevins || taylorbarr > evaolvera)
                    taylorbarr = dollieblevins;

                joannaott[mattieabel - 1].transform.localScale = new Vector3(taylorbarr, taylorbarr, 1);
                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);
                joannaott[mattieabel + 1].transform.localScale = new Vector3(adeleburks, adeleburks, 1);
            }
        }
        else
        {
            if (mattieabel == 0)
            {
                float adeleburks = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y - lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;
				
                if (adeleburks <= dollieblevins || adeleburks > evaolvera)
                    adeleburks = dollieblevins;

                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);
                joannaott[mattieabel + 1].transform.localScale = new Vector3(adeleburks, adeleburks, 1);
            }
            else if (mattieabel == joannaott.Count - 1)
            {
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float taylorbarr = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y + lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;
				
                if (taylorbarr <= dollieblevins || taylorbarr > evaolvera)
                    taylorbarr = dollieblevins;

                joannaott[mattieabel - 1].transform.localScale = new Vector3(taylorbarr, taylorbarr, 1);
                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);
            }
            else
            {
                float adeleburks = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y - lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float soniakendall = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);
                float taylorbarr = Mathf.Abs(Mathf.Abs(traciemcginnis[mattieabel] + transform.localPosition.y + lydiaphan * 2) * (evaolvera - dollieblevins) / Mathf.Abs(lydiaphan * 2) - evaolvera);

                if (soniakendall <= dollieblevins || soniakendall > evaolvera)
                    soniakendall = dollieblevins;
				
                if (adeleburks <= dollieblevins || adeleburks > evaolvera)
                    adeleburks = dollieblevins;
				
                if (taylorbarr <= dollieblevins || taylorbarr > evaolvera)
                    taylorbarr = dollieblevins;

                joannaott[mattieabel - 1].transform.localScale = new Vector3(taylorbarr, taylorbarr, 1);
                joannaott[mattieabel].transform.localScale = new Vector3(soniakendall, soniakendall, 1);
                joannaott[mattieabel + 1].transform.localScale = new Vector3(adeleburks, adeleburks, 1);
            }
        }

        
        if (brookemcgowan)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, augustamcghee, raquellatham);

            if (Vector3.Distance(transform.localPosition, augustamcghee) < 1f)
            {
                transform.localPosition = augustamcghee;
                transform.parent.GetComponent<ScrollRect>().velocity = new Vector3(0, 0, 0);
                brookemcgowan = false;

                for (int i = 0; i < joannaott.Count; i++)
                {
                    if (i != mattieabel)
                        joannaott[i].transform.localScale = new Vector3(dollieblevins, dollieblevins, 1);
                }

            }
        }

        if (amyreynolds)
        {
            
            if (transform.localPosition.x > traciemcginnis[traciemcginnis.Count - 1] - spacing / 2)
            {
                antoinettepiper(sheryldoty);
            }
            else
            {
                leeannforbes(sheryldoty);
            }

            if (transform.localPosition.x < traciemcginnis[0] + spacing / 2)
            {
                antoinettepiper(jacquelynfrazier);
            }
            else
            {
                leeannforbes(jacquelynfrazier);
            }
        }
        else
        {
            
            if (transform.localPosition.y > traciemcginnis[traciemcginnis.Count - 1] - spacing / 2)
            {
                antoinettepiper(jacquelynfrazier);
            }
            else
            {
                leeannforbes(jacquelynfrazier);
            }
			
            if (transform.localPosition.y < traciemcginnis[0] + spacing / 2)
            {
                antoinettepiper(sheryldoty);
            }
            else
            {
                leeannforbes(sheryldoty);
            }
        }
    }


    string dorapadgett = "7bad8fc32d2f8101";
    int claudinealonso;

    public void pattigilliam()
    {
        
        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        
        LoadInterstitial();
    }

    private void LoadInterstitial()
    {
        MaxSdk.LoadInterstitial(dorapadgett);
    }

    private void OnInterstitialLoadedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo)
    {
        

        
        claudinealonso = 0;
    }

    private void OnInterstitialLoadFailedEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo)
    {
        
        

        claudinealonso++;
        double retryDelay = System.Math.Pow(2, System.Math.Min(6, claudinealonso));

        Invoke("LoadInterstitial", (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialAdFailedToDisplayEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        
        LoadInterstitial();
    }

    private void OnInterstitialClickedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialHiddenEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo)
    {
        
        LoadInterstitial();
    }

    public void corrinecornell(int index)
    {
        if (MaxSdk.IsInterstitialReady(dorapadgett))
        {
            MaxSdk.ShowInterstitial(dorapadgett);
        }
       
        PlayerPrefs.SetInt(gwenmorris, index);
        PlayerPrefs.Save();
        try
        {
            int g = transform.childCount;
            if (transform.GetChild(index).childCount > 0)
            {
                lorenbrantley.elinormeyer = index;
            }
            else
            {
                lorenbrantley.elinormeyer = -1;
            }
        }
        catch
        {
            lorenbrantley.elinormeyer = -1;

        }



        lorenbrantley.addiedavison = gwenmorris + index.ToString();
        SceneManager.LoadScene("PaintScene");
    }
}
