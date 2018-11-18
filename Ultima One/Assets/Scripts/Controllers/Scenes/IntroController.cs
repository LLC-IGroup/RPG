using UnityEngine;
using UnityEngine.UI;

public class IntroController : MonoBehaviour {
    #region Fields
    [SerializeField] public Image imageLogo;
    [SerializeField] public GameObject panelGameName;
    #endregion
    #region Unity Editor
    public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    public void Awake() {

    }
    public void Start() {
        // Set Param
        Invoke("CloseLogo", 4);
        
    }
    public void Update() {
        // Skip Intro
        if (Input.GetButtonUp("Cancel")) {
            SceneBuilder.LoadScene("MainMenu", "LoadScreen");
        }
    }
    #endregion
    #region Function
    // Public
    // Private
    private void CloseLogo() {
        imageLogo.gameObject.SetActive(false);
        panelGameName.SetActive(true);
    }
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