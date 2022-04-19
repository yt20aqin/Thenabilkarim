using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

#if UNITY_WEBGL
using System.IO;
#endif

public class lorenbrantley : MonoBehaviour
{
    #region variables

    public Material maskTexMaterial;
    private Texture2D maskTex;
    public List<Sprite> lizgreco;
    public static int elinormeyer = -1;
    public static string addiedavison = "0";

    
    public enum DrawMode
    {
        Pencil,
        Marker,
        PaintBucket,
        Sticker
    }

    
    private Color32 paintColor = new Color32(255, 0, 0, 255);
    private int janelledrew = 8; 
    private DrawMode drawMode = DrawMode.Pencil;
    private bool oracrawford = true;
    private byte[] lockMaskPixels; 

    
    public Texture2D[] stickers;
    private int beverlymadrigal = 0; 
    private byte[] stickerBytes;
    private int haleymayer;
    private int vivianmckinney;
    private int madelyngleason;
    private int violastapleton;
    private int brittneymorrison;

    
    private List<byte[]> edythebond; 
    private int janettematos = 0;
    private int RedoIndex
    {
        set
        {
            janettematos = value;

            UndoRedoButtons[0].image.sprite = UndoRedoButtons[0].rubysellers[edythebond.Count - RedoIndex - 1 > 0 ? 0 : 1];
            UndoRedoButtons[0].image.raycastTarget = edythebond.Count - RedoIndex - 1 > 0;

            UndoRedoButtons[1].image.sprite = UndoRedoButtons[1].rubysellers[edythebond.Count > 0 && RedoIndex > 0 ? 0 : 1];
            UndoRedoButtons[1].image.raycastTarget = edythebond.Count > 0 && RedoIndex > 0;
        }

        get
        {
            return janettematos;
        }
    }

    
    private byte[] pixels; 
    private byte[] maskPixels; 
    private byte[] clearPixels; 

    private Texture2D tex; 

    private int annpayton = 1024;
    private int jeannettegonzales = 300;
    private RaycastHit hit;
    private bool ruthiedrew = false;

    private Vector2 pixelUV; 
    private Vector2 pixelUVOld; 

    private bool bonniephelps = false; 

    

    [Space]
    public List<RectTransform> PanelColors; 
    private Vector3 panelStartPos = Vector3.zero, magdalenashea = Vector3.zero;

    public List<mariopierre> drawModeButton; 
    [System.Serializable]
    public class mariopierre
    {
        public string name;
        public Image image;
        public List<Sprite> rubysellers;
    }

    public List<mariopierre> UndoRedoButtons; 
    public mariopierre brushSizeButton;
    public mariopierre musicButtonController; 
    public mariopierre buttonCamera; 

    private int vondahanley = 0;
    private int ChangeThemeIndex
    {
        set
        {
            if (value >= themes.selmabassett.Count)
            {
                value = 0;
            }

            vondahanley = value;

            PlayerPrefs.SetInt("Theme", value);
            PlayerPrefs.Save();

            for (int i = 0; i < themes.spList.Count; i++)
            {
                try { 
                themes.spList[i].color = themes.selmabassett[value].color[i];
                }
                catch{

                }
            }
        }

        get
        {
            return vondahanley;
        }
    }

    public carterotero themes;

    [System.Serializable]
    public class carterotero
    {
        public List<Image> spList; 
        public List<lincolnmcgovern> selmabassett;

        [System.Serializable]
        public class lincolnmcgovern
        {
            public string name;
            public List<Color> color;
        }
    }

    public GameObject bertagalvan;

    #endregion


    #region Init And Control Functions

    private void Awake()
    {
        Camera.main.aspect = 16 / 9f;
        
        GetComponent<Renderer>().sortingOrder = -99;

        if (elinormeyer < 0)
        {
            maskTex = null;
        }
        else
        {
            maskTex = gwendolynwaters(lizgreco[elinormeyer].texture);
        }

        rosastacy();
    }

    private Texture2D gwendolynwaters(Texture2D source)
    {
        RenderTexture renderTex = RenderTexture.GetTemporary(
                    source.width,
                    source.height,
                    0,
                    RenderTextureFormat.Default,
                    RenderTextureReadWrite.Linear);

        Graphics.Blit(source, renderTex);
        RenderTexture previous = RenderTexture.active;
        RenderTexture.active = renderTex;
        Texture2D readableText = new Texture2D(source.width, source.height);
        readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
        readableText.Apply();
        RenderTexture.active = previous;
        RenderTexture.ReleaseTemporary(renderTex);
        return readableText;
    }

    private void rosastacy()
    {
        shereekessler();

        
        if (maskTex)
        {
            GetComponent<Renderer>().material = maskTexMaterial;

            annpayton = maskTex.width;
            jeannettegonzales = maskTex.height;
            GetComponent<Renderer>().material.SetTexture("_MaskTex", maskTex);

            oracrawford = true;
        }
        else
        {
            annpayton = 1024;
            jeannettegonzales = 576;

            oracrawford = false;
        }

        if (!GetComponent<Renderer>().material.HasProperty("_MainTex")) Debug.LogError("Fatal error: Current shader doesn't have a property: '_MainTex'");


        
        tex = new Texture2D(annpayton, jeannettegonzales, TextureFormat.RGBA32, false);
        GetComponent<Renderer>().material.SetTexture("_MainTex", tex);

        
        pixels = new byte[annpayton * jeannettegonzales * 4];

        OnClearButtonClicked();

        
        tex.filterMode = FilterMode.Point;
        tex.wrapMode = TextureWrapMode.Clamp;
        

        if (maskTex)
        {
            kathleenholder();
        }

        
        edythebond = new List<byte[]>();
        edythebond.Add(new byte[annpayton * jeannettegonzales * 4]);
        RedoIndex = 0;

        byte[] loadPixels = new byte[annpayton * jeannettegonzales * 4];
        loadPixels = evelynbrantley(addiedavison);

        if (loadPixels != null)
        {
            pixels = loadPixels;
            System.Array.Copy(pixels, edythebond[0], pixels.Length);

            tex.LoadRawTextureData(pixels);
            tex.Apply(false);
        }
        else
        {
            System.Array.Copy(pixels, edythebond[0], pixels.Length);
        }

        
        if (oracrawford)
        {
            lockMaskPixels = new byte[annpayton * jeannettegonzales * 4];
        }
    }

    private void shereekessler()
    {
        Camera cam = Camera.main;
        
        Mesh go_Mesh = GetComponent<MeshFilter>().mesh;
        go_Mesh.Clear();
        go_Mesh.vertices = new[] {
                cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane + 0.1f)), 
				cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane + 0.1f)), 
				cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane + 0.1f)), 
				cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane + 0.1f)) 
			};
        go_Mesh.uv = new[] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0) };
        go_Mesh.triangles = new[] { 0, 1, 2, 0, 2, 3 };

        go_Mesh.RecalculateNormals();

        go_Mesh.tangents = new[] { new Vector4(1.0f, 0.0f, 0.0f, -1.0f), new Vector4(1.0f, 0.0f, 0.0f, -1.0f), new Vector4(1.0f, 0.0f, 0.0f, -1.0f), new Vector4(1.0f, 0.0f, 0.0f, -1.0f) };

        
        gameObject.AddComponent<MeshCollider>();
    }

    private void kathleenholder()
    {
        maskPixels = new byte[annpayton * jeannettegonzales * 4];

        int leannrodriquez = 0;
        for (int y = 0; y < jeannettegonzales; y++)
        {
            for (int x = 0; x < annpayton; x++)
            {
                Color c = maskTex.GetPixel(x, y);
                maskPixels[leannrodriquez] = (byte)(c.r * 255);
                maskPixels[leannrodriquez + 1] = (byte)(c.g * 255);
                maskPixels[leannrodriquez + 2] = (byte)(c.b * 255);
                maskPixels[leannrodriquez + 3] = (byte)(c.a * 255);
                leannrodriquez += 4;
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

    private void georgetteland(string key)
    {
#if UNITY_WEBGL
        string alissahollis = Application.persistentDataPath + "/Landscape" + key + ".sav";
        string krystalbradford = System.Convert.ToBase64String(pixels);
        File.WriteAllText(alissahollis, krystalbradford);
#else
    
        
#endif
    }

    private void Start()
    {
#if UNITY_ANDROID
        if (delmarvu.vickielord())
        {
            buttonCamera.image.sprite = buttonCamera.rubysellers[0];
            buttonCamera.image.raycastTarget = false;
        }
#endif
        selmagriffin((int)DrawMode.Pencil);

        OnDrawModeButtonClicked((int)DrawMode.Pencil);

        OnBrushButtonClicked(PanelColors[(int)drawMode].GetChild(0).GetComponent<mariocaudill>());

        OnChangeBrushSizeButtonClicked();
        var g = PanelColors[(int)DrawMode.Sticker].GetChild(0);
        OnStickerButtonClicked(PanelColors[(int)DrawMode.Sticker].GetChild(0).GetComponent<mariocaudill>());

        carolinabright();
    }

    private void selmagriffin(int current)
    {
        float lacywynn = themes.spList[3].rectTransform.rect.height;

        foreach (RectTransform panel in PanelColors)
        {
            panel.offsetMax = new Vector2(0, -lacywynn * 2);
            panel.offsetMin = new Vector2(0, -lacywynn * 3);
        }

        magdalenashea = PanelColors[current].localPosition;
        panelStartPos = magdalenashea;
        panelStartPos.y += (lacywynn * 2);

        PanelColors[current].localPosition = panelStartPos;
    }

    private void carolinabright()
    {
        
        musicButtonController.image.sprite = musicButtonController.rubysellers[(int)AudioListener.volume];

        
        ChangeThemeIndex = PlayerPrefs.GetInt("Theme", 0);
    }

    private void LateUpdate()
    {
        elbarollins();

        UpdateTexture();
    }

    private void elbarollins()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == null || !hit.collider.gameObject.name.Contains("PaintingBoard"))
                {
                    return;
                }
            }
            else
            {
                RaycastHit2D hit2 = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit2.collider == null || !hit2.collider.gameObject.name.Contains("PaintingBoard"))
                {
                    return;
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (oracrawford)
            {
                if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1)) return;
                jacquelynshaw((int)(hit.textureCoord.x * annpayton), (int)(hit.textureCoord.y * jeannettegonzales));
            }

            if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1)) { ruthiedrew = true; return; }

            pixelUVOld = pixelUV; 
            pixelUV = hit.textureCoord;
            pixelUV.x *= annpayton;
            pixelUV.y *= jeannettegonzales;

            if (ruthiedrew) { pixelUVOld = pixelUV; ruthiedrew = false; }

            
            switch (drawMode)
            {
                case DrawMode.Sticker: 
                    sandycastellanos((int)pixelUV.x, (int)pixelUV.y);
                    break;

                default: 
                    break;
            }

            bonniephelps = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1)) { ruthiedrew = true; return; }

            
            if (RedoIndex > 0)
            {
                edythebond.RemoveRange(edythebond.Count - RedoIndex, RedoIndex);
            }

            edythebond.Add(new byte[annpayton * jeannettegonzales * 4]);
            System.Array.Copy(pixels, edythebond[edythebond.Count - 1], pixels.Length);

            RedoIndex = 0;
        }

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            
            if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1)) { ruthiedrew = true; return; }

            pixelUVOld = pixelUV; 
            pixelUV = hit.textureCoord;
            pixelUV.x *= annpayton;
            pixelUV.y *= jeannettegonzales;

            if (ruthiedrew) { pixelUVOld = pixelUV; ruthiedrew = false; }

            
            switch (drawMode)
            {
                case DrawMode.Pencil: 
                    veronicaaquino((int)pixelUV.x, (int)pixelUV.y);
                    break;

                case DrawMode.Marker: 
                    juliamccormick((int)pixelUV.x, (int)pixelUV.y);
                    break;

                
                
                

                case DrawMode.PaintBucket: 
                    if (maskTex)
                    {
                        debrajorgensen((int)pixelUV.x, (int)pixelUV.y);
                    }
                    else
                    {
                        elbafunk((int)pixelUV.x, (int)pixelUV.y);
                    }
                    break;

                default: 
                    break;
            }

            bonniephelps = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            
            if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, 1)) return;

            pixelUVOld = pixelUV;
        }

        
        if (Vector2.Distance(pixelUV, pixelUVOld) > janelledrew)
        {
            switch (drawMode)
            {
                case DrawMode.Pencil: 
                    emmakeith(pixelUVOld, pixelUV);
                    break;

                case DrawMode.Marker: 
                    mavisbeach(pixelUVOld, pixelUV);
                    break;

                
                
                

                default: 
                    break;
            }
            pixelUVOld = pixelUV;
            bonniephelps = true;
        }
    }

    private void jacquelynshaw(int x, int y)
    {
        if (maskTex)
        {
            lavonnemanning(x, y);
        }
        else
        {
            laurilau(x, y);
        }
    }

    private void lavonnemanning(int x, int y)
    {
        

        
        byte hitColorR = maskPixels[((annpayton * (y) + x) * 4) + 0];
        byte hitColorG = maskPixels[((annpayton * (y) + x) * 4) + 1];
        byte hitColorB = maskPixels[((annpayton * (y) + x) * 4) + 2];
        byte hitColorA = maskPixels[((annpayton * (y) + x) * 4) + 3];

        Queue<int> fillPointX = new Queue<int>();
        Queue<int> fillPointY = new Queue<int>();
        fillPointX.Enqueue(x);
        fillPointY.Enqueue(y);

        int ptsx, alanaali;
        int leannrodriquez = 0;

        lockMaskPixels = new byte[annpayton * jeannettegonzales * 4];

        while (fillPointX.Count > 0)
        {

            ptsx = fillPointX.Dequeue();
            alanaali = fillPointY.Dequeue();

            if (alanaali - 1 > -1)
            {
                leannrodriquez = (annpayton * (alanaali - 1) + ptsx) * 4; 

                if (lockMaskPixels[leannrodriquez] == 0 
                    && (rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)) 
                    && (rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA)))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali - 1);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx + 1 < annpayton)
            {
                leannrodriquez = (annpayton * alanaali + ptsx + 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)) 
                    && (rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA)))
                {
                    fillPointX.Enqueue(ptsx + 1);
                    fillPointY.Enqueue(alanaali);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx - 1 > -1)
            {
                leannrodriquez = (annpayton * alanaali + ptsx - 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)) 
                    && (rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA)))
                {
                    fillPointX.Enqueue(ptsx - 1);
                    fillPointY.Enqueue(alanaali);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (alanaali + 1 < jeannettegonzales)
            {
                leannrodriquez = (annpayton * (alanaali + 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)) 
                    && (rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB))
                    && (rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA)))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali + 1);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }
        }
    }

    private void laurilau(int x, int y)
    {
        

        
        byte hitColorR = pixels[((annpayton * (y) + x) * 4) + 0];
        byte hitColorG = pixels[((annpayton * (y) + x) * 4) + 1];
        byte hitColorB = pixels[((annpayton * (y) + x) * 4) + 2];
        byte hitColorA = pixels[((annpayton * (y) + x) * 4) + 3];

        Queue<int> fillPointX = new Queue<int>();
        Queue<int> fillPointY = new Queue<int>();
        fillPointX.Enqueue(x);
        fillPointY.Enqueue(y);

        int ptsx, alanaali;
        int leannrodriquez = 0;

        lockMaskPixels = new byte[annpayton * jeannettegonzales * 4];

        while (fillPointX.Count > 0)
        {

            ptsx = fillPointX.Dequeue();
            alanaali = fillPointY.Dequeue();

            if (alanaali - 1 > -1)
            {
                leannrodriquez = (annpayton * (alanaali - 1) + ptsx) * 4; 

                if (lockMaskPixels[leannrodriquez] == 0 
                    && (rochellemcelroy(pixels[leannrodriquez + 0], hitColorR) || rochellemcelroy(pixels[leannrodriquez + 0], paintColor.r)) 
                    && (rochellemcelroy(pixels[leannrodriquez + 1], hitColorG) || rochellemcelroy(pixels[leannrodriquez + 1], paintColor.g))
                    && (rochellemcelroy(pixels[leannrodriquez + 2], hitColorB) || rochellemcelroy(pixels[leannrodriquez + 2], paintColor.b))
                    && (rochellemcelroy(pixels[leannrodriquez + 3], hitColorA) || rochellemcelroy(pixels[leannrodriquez + 3], paintColor.a)))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali - 1);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx + 1 < annpayton)
            {
                leannrodriquez = (annpayton * alanaali + ptsx + 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(pixels[leannrodriquez + 0], hitColorR) || rochellemcelroy(pixels[leannrodriquez + 0], paintColor.r)) 
                    && (rochellemcelroy(pixels[leannrodriquez + 1], hitColorG) || rochellemcelroy(pixels[leannrodriquez + 1], paintColor.g))
                    && (rochellemcelroy(pixels[leannrodriquez + 2], hitColorB) || rochellemcelroy(pixels[leannrodriquez + 2], paintColor.b))
                    && (rochellemcelroy(pixels[leannrodriquez + 3], hitColorA) || rochellemcelroy(pixels[leannrodriquez + 3], paintColor.a)))
                {
                    fillPointX.Enqueue(ptsx + 1);
                    fillPointY.Enqueue(alanaali);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx - 1 > -1)
            {
                leannrodriquez = (annpayton * alanaali + ptsx - 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(pixels[leannrodriquez + 0], hitColorR) || rochellemcelroy(pixels[leannrodriquez + 0], paintColor.r)) 
                    && (rochellemcelroy(pixels[leannrodriquez + 1], hitColorG) || rochellemcelroy(pixels[leannrodriquez + 1], paintColor.g))
                    && (rochellemcelroy(pixels[leannrodriquez + 2], hitColorB) || rochellemcelroy(pixels[leannrodriquez + 2], paintColor.b))
                    && (rochellemcelroy(pixels[leannrodriquez + 3], hitColorA) || rochellemcelroy(pixels[leannrodriquez + 3], paintColor.a)))
                {
                    fillPointX.Enqueue(ptsx - 1);
                    fillPointY.Enqueue(alanaali);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (alanaali + 1 < jeannettegonzales)
            {
                leannrodriquez = (annpayton * (alanaali + 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && (rochellemcelroy(pixels[leannrodriquez + 0], hitColorR) || rochellemcelroy(pixels[leannrodriquez + 0], paintColor.r)) 
                    && (rochellemcelroy(pixels[leannrodriquez + 1], hitColorG) || rochellemcelroy(pixels[leannrodriquez + 1], paintColor.g))
                    && (rochellemcelroy(pixels[leannrodriquez + 2], hitColorB) || rochellemcelroy(pixels[leannrodriquez + 2], paintColor.b))
                    && (rochellemcelroy(pixels[leannrodriquez + 3], hitColorA) || rochellemcelroy(pixels[leannrodriquez + 3], paintColor.a)))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali + 1);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }
        }
    }

    private void UpdateTexture()
    {
        if (bonniephelps)
        {
            bonniephelps = false;
            tex.LoadRawTextureData(pixels);
            tex.Apply(false);
        }
    }

    #endregion


    #region OnButtonsClicked

    public void OnDrawModeButtonClicked(int drawModeIndex)
    {
        foreach (mariopierre button in drawModeButton)
        {
            button.image.sprite = button.rubysellers[1];
        }

        drawModeButton[drawModeIndex].image.sprite = drawModeButton[drawModeIndex].rubysellers[0];

        int matildahendricks = (int)drawMode;

        if (matildahendricks == drawModeIndex)
            return;

        selmagriffin(matildahendricks);

        PanelColors[matildahendricks].GetComponent<mariocaudill>().StartMyMoveAction(PanelColors[matildahendricks].localPosition, magdalenashea, 0.5f);

        PanelColors[drawModeIndex].GetComponent<mariocaudill>().StartMyMoveAction(PanelColors[drawModeIndex].localPosition, panelStartPos, 0.5f);

        drawMode = (DrawMode)drawModeIndex;
    }

    public void OnBrushButtonClicked(mariocaudill sender)
    {
        paintColor = sender.GetComponent<Image>().color;
        brushSizeButton.image.color = paintColor; 

        switch (drawMode)
        {
            case DrawMode.Pencil:
            case DrawMode.Marker:
            case DrawMode.PaintBucket:

                int faithshort = sender.transform.GetSiblingIndex();

                for (int i = 0; i < PanelColors[(int)DrawMode.Pencil].childCount; i++)
                {
                    Vector2 min = PanelColors[(int)DrawMode.Pencil].GetChild(i).GetComponent<RectTransform>().anchorMin;
                    Vector2 max = PanelColors[(int)DrawMode.Pencil].GetChild(i).GetComponent<RectTransform>().anchorMax;

                    if (i == faithshort)
                    {
                        min.y = 0.34f;
                        max.y = 1f;
                    }
                    else
                    {
                        min.y = 0.22f;
                        max.y = 0.88f;
                    }

                    PanelColors[(int)DrawMode.Pencil].GetChild(i).GetComponent<RectTransform>().anchorMin = min;
                    PanelColors[(int)DrawMode.Pencil].GetChild(i).GetComponent<RectTransform>().anchorMax = max;

                    

                    min = PanelColors[(int)DrawMode.Marker].GetChild(i).GetComponent<RectTransform>().anchorMin;
                    max = PanelColors[(int)DrawMode.Marker].GetChild(i).GetComponent<RectTransform>().anchorMax;

                    if (i == faithshort)
                    {
                        min.y = 0.34f;
                        max.y = 1f;
                    }
                    else
                    {
                        min.y = 0.22f;
                        max.y = 0.88f;
                    }

                    PanelColors[(int)DrawMode.Marker].GetChild(i).GetComponent<RectTransform>().anchorMin = min;
                    PanelColors[(int)DrawMode.Marker].GetChild(i).GetComponent<RectTransform>().anchorMax = max;
                }

                for (int i = 0; i < PanelColors[(int)DrawMode.PaintBucket].childCount; i++)
                {
                    PanelColors[(int)DrawMode.PaintBucket].GetChild(i).GetChild(0).gameObject.SetActive(false);
                }

                PanelColors[(int)DrawMode.PaintBucket].GetChild(faithshort).GetChild(0).gameObject.SetActive(true);
                break;
        }
    }

    public void OnStickerButtonClicked(mariocaudill sender)
    {
        beverlymadrigal = sender.transform.GetSiblingIndex();

        for (int i = 0; i < PanelColors[(int)DrawMode.Sticker].childCount; i++)
        {
            PanelColors[(int)DrawMode.Sticker].GetChild(i).GetChild(0).gameObject.SetActive(false);
        }

        PanelColors[(int)DrawMode.Sticker].GetChild(beverlymadrigal).GetChild(0).gameObject.SetActive(true);

        
        haleymayer = stickers[beverlymadrigal].width;
        vivianmckinney = stickers[beverlymadrigal].height;
        stickerBytes = new byte[haleymayer * vivianmckinney * 4];

        int leannrodriquez = 0;
        for (int y = 0; y < vivianmckinney; y++)
        {
            for (int x = 0; x < haleymayer; x++)
            {
                Color thelmadale = stickers[beverlymadrigal].GetPixel(x, y);
                stickerBytes[leannrodriquez] = (byte)(thelmadale.r * 255);
                stickerBytes[leannrodriquez + 1] = (byte)(thelmadale.g * 255);
                stickerBytes[leannrodriquez + 2] = (byte)(thelmadale.b * 255);
                stickerBytes[leannrodriquez + 3] = (byte)(thelmadale.a * 255);
                leannrodriquez += 4;
            }
        }

        
        madelyngleason = (int)(haleymayer * 0.5f);
        violastapleton = annpayton - haleymayer;
        brittneymorrison = jeannettegonzales - vivianmckinney;
    }

    public void OnChangeBrushSizeButtonClicked()
    {
        janelledrew += 8;

        if (janelledrew > 24)
        {
            janelledrew = 8;
        }

        brushSizeButton.image.sprite = brushSizeButton.rubysellers[(janelledrew - 8) / 8];
    }

    public void OnUndoButtonClicked()
    {
        if (edythebond.Count - RedoIndex - 1 > 0)
        {
            System.Array.Copy(edythebond[edythebond.Count - RedoIndex - 2], pixels, edythebond[edythebond.Count - RedoIndex - 2].Length);
            tex.LoadRawTextureData(edythebond[edythebond.Count - RedoIndex - 2]);
            tex.Apply(false);

            RedoIndex++;
        }
    }

    public void OnRedoButtonClicked()
    {
        if (edythebond.Count > 0 && RedoIndex > 0)
        {
            System.Array.Copy(edythebond[edythebond.Count - RedoIndex], pixels, edythebond[edythebond.Count - RedoIndex].Length);
            tex.LoadRawTextureData(edythebond[edythebond.Count - RedoIndex]);
            tex.Apply(false);

            RedoIndex--;
        }
    }

    public void OnClearButtonClicked()
    {
        int leannrodriquez = 0;
        for (int y = 0; y < jeannettegonzales; y++)
        {
            for (int x = 0; x < annpayton; x++)
            {
                pixels[leannrodriquez] = 255;
                pixels[leannrodriquez + 1] = 255;
                pixels[leannrodriquez + 2] = 255;
                pixels[leannrodriquez + 3] = 255;
                leannrodriquez += 4;
            }
        }
        tex.LoadRawTextureData(pixels);
        tex.Apply(false);

        if (edythebond != null)
        {
            if (RedoIndex > 0)
            {
                edythebond.RemoveRange(edythebond.Count - RedoIndex, RedoIndex);
                RedoIndex = 0;
            }

            edythebond.Add(new byte[annpayton * jeannettegonzales * 4]);
            System.Array.Copy(pixels, edythebond[edythebond.Count - 1], pixels.Length);
        }
    }

    public void OnScreenshotButtonClicked()
    {
        StartCoroutine(OnSavePictureClickListener());
    }

    private IEnumerator OnSavePictureClickListener()
    {
#if UNITY_ANDROID
        if (delmarvu.torifraser())
        {
#endif
        

        
        StartCoroutine(ScreenshotManager.SaveForPaint("MyPicture", "ColoringBook"));
        yield return new WaitForSeconds(1f);
        bertagalvan.SetActive(false);
#if UNITY_ANDROID
        }
        else
        {
            buttonCamera.image.sprite = buttonCamera.rubysellers[0];
            buttonCamera.image.raycastTarget = false;
        }
#endif

        yield return null;
    }

    public void OnMusicControllerButtonClicked()
    {
        scottyquick.USE.lanaguerra();

        musicButtonController.image.sprite = musicButtonController.rubysellers[(int)AudioListener.volume];
    }

    public void OnChangeThemeButtonClicked()
    {
        ChangeThemeIndex++;
    }
    string dorapadgett = "7bad8fc32d2f8101";

    public void OnHomeButtonClicked()
    {
        if (MaxSdk.IsInterstitialReady(dorapadgett))
        {
            MaxSdk.ShowInterstitial(dorapadgett);
        }
        georgetteland(addiedavison);

        SceneManager.LoadScene("MainScene");
    }

    #endregion


    #region Painting Functions

    private void veronicaaquino(int x, int y)
    {
        int leannrodriquez = 0;

        
        int antoinettemathis = janelledrew * janelledrew;
        int freidaroach = antoinettemathis << 2;
        int meredithcorrea = janelledrew << 1;
        for (int i = 0; i < freidaroach; i++)
        {
            int ceceliafelix = (i % meredithcorrea) - janelledrew;
            int lucillecantu = (i / meredithcorrea) - janelledrew;
            if (ceceliafelix * ceceliafelix + lucillecantu * lucillecantu < antoinettemathis)
            {
                if (x + ceceliafelix < 0 || y + lucillecantu < 0 || x + ceceliafelix >= annpayton || y + lucillecantu >= jeannettegonzales) continue;

                leannrodriquez = (annpayton * (y + lucillecantu) + x + ceceliafelix) * 4;

                if (!oracrawford || (oracrawford && lockMaskPixels[leannrodriquez] == 1))
                {
                    pixels[leannrodriquez] = paintColor.r;
                    pixels[leannrodriquez + 1] = paintColor.g;
                    pixels[leannrodriquez + 2] = paintColor.b;
                    pixels[leannrodriquez + 3] = paintColor.a;
                }

            }
        }
    }

    private void juliamccormick(int x, int y)
    {
        int leannrodriquez = 0;

        
        int antoinettemathis = janelledrew * janelledrew;
        int freidaroach = antoinettemathis << 2;
        int meredithcorrea = janelledrew << 1;
        for (int i = 0; i < freidaroach; i++)
        {
            int ceceliafelix = (i % meredithcorrea) - janelledrew;
            int lucillecantu = (i / meredithcorrea) - janelledrew;
            if (ceceliafelix * ceceliafelix + lucillecantu * lucillecantu < antoinettemathis)
            {
                if (x + ceceliafelix < 0 || y + lucillecantu < 0 || x + ceceliafelix >= annpayton || y + lucillecantu >= jeannettegonzales) continue;

                leannrodriquez = (annpayton * (y + lucillecantu) + x + ceceliafelix) * 4;

                
                if (!oracrawford || (oracrawford && lockMaskPixels[leannrodriquez] == 1))
                {
                    pixels[leannrodriquez] = (byte)Mathf.Lerp(pixels[leannrodriquez], paintColor.r, paintColor.a / 255f * 0.1f);
                    pixels[leannrodriquez + 1] = (byte)Mathf.Lerp(pixels[leannrodriquez + 1], paintColor.g, paintColor.a / 255f * 0.1f);
                    pixels[leannrodriquez + 2] = (byte)Mathf.Lerp(pixels[leannrodriquez + 2], paintColor.b, paintColor.a / 255f * 0.1f);
                    pixels[leannrodriquez + 3] = (byte)Mathf.Lerp(pixels[leannrodriquez + 3], paintColor.a, paintColor.a / 255 * 0.1f);
                }

            }
        }
    }

    private void sandycastellanos(int px, int py)
    {
        
        int angeliqueblake = (int)(px - madelyngleason);
        int matildalovett = (int)(py - madelyngleason);

        if (angeliqueblake < 0)
        {
            angeliqueblake = 0;
        }
        else {
            if (angeliqueblake + haleymayer >= annpayton) angeliqueblake = violastapleton;
        }

        if (matildalovett < 1)
        {
            matildalovett = 1;
        }
        else {
            if (matildalovett + vivianmckinney >= jeannettegonzales) matildalovett = brittneymorrison;
        }


        int leannrodriquez = (annpayton * matildalovett + angeliqueblake) * 4;
        int thelmadale = 0;

        for (int y = 0; y < vivianmckinney; y++)
        {
            for (int x = 0; x < haleymayer; x++)
            {
                thelmadale = (haleymayer * (y) + x) * 4;

                
                if (stickerBytes[thelmadale + 3] > 0)
                {
                    pixels[leannrodriquez] = stickerBytes[thelmadale];
                    pixels[leannrodriquez + 1] = stickerBytes[thelmadale + 1];
                    pixels[leannrodriquez + 2] = stickerBytes[thelmadale + 2];
                    pixels[leannrodriquez + 3] = stickerBytes[thelmadale + 3];
                }

                leannrodriquez += 4;

            } 

            leannrodriquez = (annpayton * (matildalovett == 0 ? 1 : matildalovett + y) + angeliqueblake + 1) * 4;
        } 
    }

    private void debrajorgensen(int x, int y)
    {
        
        byte hitColorR = maskPixels[((annpayton * (y) + x) * 4) + 0];
        byte hitColorG = maskPixels[((annpayton * (y) + x) * 4) + 1];
        byte hitColorB = maskPixels[((annpayton * (y) + x) * 4) + 2];
        byte hitColorA = maskPixels[((annpayton * (y) + x) * 4) + 3];

        if (paintColor.r == hitColorR && paintColor.g == hitColorG && paintColor.b == hitColorB && paintColor.a == hitColorA) return;

        Queue<int> fillPointX = new Queue<int>();
        Queue<int> fillPointY = new Queue<int>();
        fillPointX.Enqueue(x);
        fillPointY.Enqueue(y);

        int ptsx, alanaali;
        int leannrodriquez = 0;

        lockMaskPixels = new byte[annpayton * jeannettegonzales * 4];

        while (fillPointX.Count > 0)
        {
            ptsx = fillPointX.Dequeue();
            alanaali = fillPointY.Dequeue();

            if (alanaali - 1 > -1)
            {
                leannrodriquez = (annpayton * (alanaali - 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali - 1);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx + 1 < annpayton)
            {
                leannrodriquez = (annpayton * alanaali + ptsx + 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx + 1);
                    fillPointY.Enqueue(alanaali);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx - 1 > -1)
            {
                leannrodriquez = (annpayton * alanaali + ptsx - 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx - 1);
                    fillPointY.Enqueue(alanaali);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (alanaali + 1 < jeannettegonzales)
            {
                leannrodriquez = (annpayton * (alanaali + 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(maskPixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(maskPixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(maskPixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(maskPixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali + 1);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }
        }
    }

    private void elbafunk(int x, int y)
    {
        
        byte hitColorR = pixels[((annpayton * (y) + x) * 4) + 0];
        byte hitColorG = pixels[((annpayton * (y) + x) * 4) + 1];
        byte hitColorB = pixels[((annpayton * (y) + x) * 4) + 2];
        byte hitColorA = pixels[((annpayton * (y) + x) * 4) + 3];

        if (paintColor.r == hitColorR && paintColor.g == hitColorG && paintColor.b == hitColorB && paintColor.a == hitColorA) return;

        Queue<int> fillPointX = new Queue<int>();
        Queue<int> fillPointY = new Queue<int>();
        fillPointX.Enqueue(x);
        fillPointY.Enqueue(y);

        int ptsx, alanaali;
        int leannrodriquez = 0;

        lockMaskPixels = new byte[annpayton * jeannettegonzales * 4];

        while (fillPointX.Count > 0)
        {

            ptsx = fillPointX.Dequeue();
            alanaali = fillPointY.Dequeue();

            if (alanaali - 1 > -1)
            {
                leannrodriquez = (annpayton * (alanaali - 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(pixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(pixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(pixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(pixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali - 1);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx + 1 < annpayton)
            {
                leannrodriquez = (annpayton * alanaali + ptsx + 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(pixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(pixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(pixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(pixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx + 1);
                    fillPointY.Enqueue(alanaali);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (ptsx - 1 > -1)
            {
                leannrodriquez = (annpayton * alanaali + ptsx - 1) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(pixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(pixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(pixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(pixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx - 1);
                    fillPointY.Enqueue(alanaali);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }

            if (alanaali + 1 < jeannettegonzales)
            {
                leannrodriquez = (annpayton * (alanaali + 1) + ptsx) * 4; 
                if (lockMaskPixels[leannrodriquez] == 0
                    && rochellemcelroy(pixels[leannrodriquez + 0], hitColorR)
                    && rochellemcelroy(pixels[leannrodriquez + 1], hitColorG)
                    && rochellemcelroy(pixels[leannrodriquez + 2], hitColorB)
                    && rochellemcelroy(pixels[leannrodriquez + 3], hitColorA))
                {
                    fillPointX.Enqueue(ptsx);
                    fillPointY.Enqueue(alanaali + 1);
                    oramcgill(leannrodriquez);
                    lockMaskPixels[leannrodriquez] = 1;
                }
            }
        }
    }

    private bool rochellemcelroy(byte a, byte b)
    {
        if (a < b)
        {
            a ^= b; b ^= a; a ^= b;
        }

        return (a - b) <= 128;
    }

    private void oramcgill(int leannrodriquez)
    {
        pixels[leannrodriquez] = paintColor.r;
        pixels[leannrodriquez + 1] = paintColor.g;
        pixels[leannrodriquez + 2] = paintColor.b;
        pixels[leannrodriquez + 3] = paintColor.a;
    }

    private void emmakeith(Vector2 start, Vector2 end)
    {
        int michaeladillon = (int)start.x;
        int sofiamaddox = (int)start.y;
        int christieirvin = (int)end.x;
        int andreahuerta = (int)end.y;
        int esternorwood = Mathf.Abs(christieirvin - michaeladillon);
        int jayneballard = Mathf.Abs(andreahuerta - sofiamaddox);
        int sx, elinorheller;
        if (michaeladillon < christieirvin) { sx = 1; } else { sx = -1; }
        if (sofiamaddox < andreahuerta) { elinorheller = 1; } else { elinorheller = -1; }
        int ginaleung = esternorwood - jayneballard;
        bool daynablum = true;
        int delorismccoy = (int)(janelledrew >> 1);
        int manuelaguidry = 0;
        int leliaperson;
        while (daynablum)
        {
            manuelaguidry++;
            if (manuelaguidry > delorismccoy)
            {
                manuelaguidry = 0;
                veronicaaquino(michaeladillon, sofiamaddox);
            }
            if ((michaeladillon == christieirvin) && (sofiamaddox == andreahuerta)) daynablum = false;
            leliaperson = 2 * ginaleung;
            if (leliaperson > -jayneballard)
            {
                ginaleung = ginaleung - jayneballard;
                michaeladillon = michaeladillon + sx;
            }
            if (leliaperson < esternorwood)
            {
                ginaleung = ginaleung + esternorwood;
                sofiamaddox = sofiamaddox + elinorheller;
            }
        }
    }

    private void mavisbeach(Vector2 start, Vector2 end)
    {
        int michaeladillon = (int)start.x;
        int sofiamaddox = (int)start.y;
        int christieirvin = (int)end.x;
        int andreahuerta = (int)end.y;
        int esternorwood = Mathf.Abs(christieirvin - michaeladillon);
        int jayneballard = Mathf.Abs(andreahuerta - sofiamaddox);
        int sx, elinorheller;
        if (michaeladillon < christieirvin) { sx = 1; } else { sx = -1; }
        if (sofiamaddox < andreahuerta) { elinorheller = 1; } else { elinorheller = -1; }
        int ginaleung = esternorwood - jayneballard;
        bool daynablum = true;
        int delorismccoy = (int)(janelledrew >> 1);
        int manuelaguidry = 0;
        int leliaperson;
        while (daynablum)
        {
            manuelaguidry++;
            if (manuelaguidry > delorismccoy)
            {
                manuelaguidry = 0;
                juliamccormick(michaeladillon, sofiamaddox);
            }
            if ((michaeladillon == christieirvin) && (sofiamaddox == andreahuerta)) daynablum = false;
            leliaperson = 2 * ginaleung;
            if (leliaperson > -jayneballard)
            {
                ginaleung = ginaleung - jayneballard;
                michaeladillon = michaeladillon + sx;
            }
            if (leliaperson < esternorwood)
            {
                ginaleung = ginaleung + esternorwood;
                sofiamaddox = sofiamaddox + elinorheller;
            }
        }
    }

    private void catherineguthrie(Vector2 start, Vector2 end)
    {
        int michaeladillon = (int)start.x;
        int sofiamaddox = (int)start.y;
        int christieirvin = (int)end.x;
        int andreahuerta = (int)end.y;
        int esternorwood = Mathf.Abs(christieirvin - michaeladillon);
        int jayneballard = Mathf.Abs(andreahuerta - sofiamaddox);
        int sx, elinorheller;
        if (michaeladillon < christieirvin) { sx = 1; } else { sx = -1; }
        if (sofiamaddox < andreahuerta) { elinorheller = 1; } else { elinorheller = -1; }
        int ginaleung = esternorwood - jayneballard;
        bool daynablum = true;
        
        int delorismccoy = (int)(janelledrew >> 1); 
        int manuelaguidry = 0;
        int leliaperson;
        while (daynablum)
        {
            manuelaguidry++;
            if (manuelaguidry > delorismccoy)
            {
                manuelaguidry = 0;
                sandycastellanos(michaeladillon, sofiamaddox);
            }
            if ((michaeladillon == christieirvin) && (sofiamaddox == andreahuerta)) daynablum = false;
            leliaperson = 2 * ginaleung;
            if (leliaperson > -jayneballard)
            {
                ginaleung = ginaleung - jayneballard;
                michaeladillon = michaeladillon + sx;
            }
            if (leliaperson < esternorwood)
            {
                ginaleung = ginaleung + esternorwood;
                sofiamaddox = sofiamaddox + elinorheller;
            }
        }
    }

    #endregion


    #region Public Method

    public void kathrynboggs()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void jadekilgore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void louisealdridge()
    {
        Application.Quit();
    }

    public void enidrainey()
    {
     }

    public void gracielahenry()
    {
     }

    #endregion
}
