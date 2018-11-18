using System;
using UnityEngine;

public class MainMenuController : BaseScene {
    #region Fields
    // Public
    [SerializeField] public GameObject panelMainMenu;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        OpenDefaultPanels();

    }
    override public void Start() {
        base.Start();
        panelMainMenu.GetComponent<PanelMainMenu>().buttonAccount.onClick.AddListener(this.OpenAccount);



        // Debug
        // SceneBuilder.LoadScene("Account", "LoadScreen");
    }
    #endregion
    #region Function
    // Public
    public void OpenDefaultPanels() {
        panelMainMenu = UIBuilder.OpenPanel("PanelMainMenu");
    }
    // Private
    private void OpenAccount() {
        SceneBuilder.LoadScene("Account", "LoadScreen");
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