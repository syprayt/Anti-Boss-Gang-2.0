using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
 
public class RewardedAdsButton : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    private string GAME_ID; //replace with your gameID from dashboard. note: will be different for each platform.
    private const string REWARDED_VIDEO_PLACEMENT = "Rewarded_Android";

    private bool testMode = false;

    //utility wrappers for debuglog
    public delegate void DebugEvent(string msg);
    public static event DebugEvent OnDebugLog;
    public Button showRewardedBtn;
    [SerializeField] string _androidGameId = "5218873";
    [SerializeField] string _iOSGameId = "5218872";
    public Shop sh;
    public Levels lv;
    public NeverEnd ne;
    public Boss_Defeat df;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            showRewardedBtn.onClick.AddListener(ShowRewardedAd);
        }
    }
    public void FixedUpdate()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2 && lv.continie == true && lv.wol == true)
        {
            showRewardedBtn.onClick.AddListener(ShowRewardedAd);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4 && ne.continie == true && ne.wol == true)
        {
            showRewardedBtn.onClick.AddListener(ShowRewardedAd);
        }
        if (SceneManager.GetActiveScene().buildIndex == 5 && df.continie == true && df.wol == true)
        {
            showRewardedBtn.onClick.AddListener(ShowRewardedAd);
        }
    }
    public void Awake()
    {
        Initialize();
        LoadRewardedAd();
    }

    public void Initialize()
    {
#if UNITY_IOS
            GAME_ID = _iOSGameId;
#elif UNITY_ANDROID
        GAME_ID = _androidGameId;
#elif UNITY_EDITOR
            GAME_ID = _androidGameId; //Only for testing the functionality in the Editor
#endif
        if (Advertisement.isSupported)
        {
            DebugLog(Application.platform + " supported by Advertisement");
        }
        Advertisement.Initialize(GAME_ID, testMode, this);
    }
    public void LoadRewardedAd()
    {
        Advertisement.Load(REWARDED_VIDEO_PLACEMENT, this);
    }

    public void ShowRewardedAd()
    {
        Advertisement.Show(REWARDED_VIDEO_PLACEMENT, this);
    }

    #region Interface Implementations
    public void OnInitializationComplete()
    {
        DebugLog("Init Success");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        DebugLog($"Init Failed: [{error}]: {message}");
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        DebugLog($"Load Success: {placementId}");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        DebugLog($"Load Failed: [{error}:{placementId}] {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        DebugLog($"OnUnityAdsShowFailure: [{error}]: {message}");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        DebugLog($"OnUnityAdsShowStart: {placementId}");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        DebugLog($"OnUnityAdsShowClick: {placementId}");
    }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        DebugLog($"OnUnityAdsShowComplete: [{showCompletionState}]: {placementId}");
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            sh.rw = true;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            lv.cont = true;
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            ne.cont = true;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            df.cont = true;
        }
    }
    #endregion

    public void OnGameIDFieldChanged(string newInput)
    {
        GAME_ID = newInput;
    }

    public void ToggleTestMode(bool isOn)
    {
        testMode = isOn;
    }

    //wrapper around debug.log to allow broadcasting log strings to the UI
    void DebugLog(string msg)
    {
        OnDebugLog?.Invoke(msg);
        Debug.Log(msg);
    }
}
