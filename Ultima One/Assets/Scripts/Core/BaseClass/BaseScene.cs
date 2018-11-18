using UnityEngine;

public class BaseScene : MonoBehaviour {
    #region Fields
    // Private 
    [SerializeField] public GameObject characterPrefab;
    [SerializeField] public GameObject musicController;
    #endregion
    #region Unity Editor
    virtual public void OnValidate() {


    }
    #endregion
    #region MonoBehaviour
    virtual public void Awake() {
        // Set Params
        musicController = GameObject.Find("MusicController");
        ChatParam.InitChat();
    }
    virtual public void Start() {
        
    }
    #endregion
    #region Function
    // Constructor
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