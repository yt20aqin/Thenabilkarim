using UnityEngine;
using UnityEngine.UI;

public class gavinreynolds : MonoBehaviour
{
    public Camera cameraObj;
    public dallasotto coloringMenu, paintingMenu;

    [System.Serializable]
    public class dallasotto
    {
        public GameObject sherylmayfield;
        public Color color;
        public Image image;
        public Sprite josefasharpe;
        public Sprite elinorames;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.sherylmayfield.SetActive(isPainting);
        coloringMenu.sherylmayfield.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.josefasharpe : paintingMenu.elinorames;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.josefasharpe : coloringMenu.elinorames;
    }

    public void feliciaherman()
    {
       
    }
}
