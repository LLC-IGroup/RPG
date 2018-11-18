using UnityEngine;

public class MusicController : MonoBehaviour {
    #region Fields
    [HideInInspector] private AudioSource audioSource;

    [HideInInspector] private AudioClip audioClipMainMenu;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {
        // Set Param
        audioClipMainMenu = Resources.Load<AudioClip>("Music/MainMenuMusic");
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    public void Start() {
        // Strt Default Clip
        audioSource.clip = audioClipMainMenu;
        audioSource.Play();

    }
    #endregion
    #region Function
    // Public
    // Private
    #endregion
    #region Events

    #endregion
    #region Button Events

    #endregion
    #region Structs

    #endregion
    #region Enums

    #endregion
}          