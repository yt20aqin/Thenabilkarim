using UnityEngine;
using UnityEngine.UI;

public class randolphtate : MonoBehaviour
{
    public Camera cameraObj;
    public clarkconklin coloringMenu, paintingMenu;

    [System.Serializable]
    public class clarkconklin
    {
        public GameObject kelseyfitzgerald;
        public Color color;
        public Image image;
        public Sprite eldachu;
        public Sprite christianrice;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
        PlayerPrefs.SetInt("isPainting", 0);
        PlayerPrefs.Save();

        OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting",  0);
        PlayerPrefs.Save();

        paintingMenu.kelseyfitzgerald.SetActive(isPainting);
        coloringMenu.kelseyfitzgerald.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.eldachu : paintingMenu.christianrice;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.eldachu : coloringMenu.christianrice;
    }

    public void helenaguerra()
    {
       
    }
}
