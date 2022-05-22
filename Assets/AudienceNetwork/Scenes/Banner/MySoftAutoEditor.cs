using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class MySoftAutoEditor: MonoBehaviour
{


   
 
    [MenuItem("AssetDatabase/Mysoft Auto Editor")]
    static void renameclasses()
    {
        AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Banner/AdViewScene.cs", "renepatel.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Interstitial/InterstitialAdScene.cs", "jamalwatkins.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/RewardedVideo/RewardedVideoAdScene.cs", "montyrosario.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Settings/SettingsScene.cs", "bertvasquez.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/BaseScene.cs", "zacharycooley.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/merrillakins.cs", "lincolncoker.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/normancrenshaw.cs", "armandolanier.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/wilfredwilliams.cs", "xavieraguirre.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/AdsManager.cs", "clydepope.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/boydwhitley.cs", "mosesramsey.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/holliscarson.cs", "rileycorbett.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/LoadNoti.cs", "erniemartin.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/PushNoti.cs", "dwaynedougherty.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/saulenriquez.cs", "andrewhagan.cs");
AssetDatabase.RenameAsset("Assets/SplashScene.cs", "coreybenjamin.cs");


    }

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
