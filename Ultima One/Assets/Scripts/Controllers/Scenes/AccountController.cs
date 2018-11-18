using System;
using UnityEngine;
using UnityEngine.UI;

public class AccountController : BaseScene {
    #region Fields
    [SerializeField] public GameObject panelAccountControl;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();
        
    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Param

    }
    override public void Start() {
        base.Start();
        OpenDefaultPanels();
        panelAccountControl.GetComponent<PanelAccountControl>().buttonBack.onClick.AddListener(this.BackButton);
        panelAccountControl.GetComponent<PanelAccountControl>().buttonCreate.onClick.AddListener(this.CreateButton);
        panelAccountControl.GetComponent<PanelAccountControl>().buttonStart.onClick.AddListener(this.StartButton);

    }
    #endregion
    #region Function
    // Public
    public void OpenDefaultPanels() {
        panelAccountControl = UIBuilder.OpenPanel("PanelAccountControl");
                                                                                         
    }
    // Private
    private void StartButton() {

    }
    private void CreateButton() {
        // Open Create New Character Scene
        SceneBuilder.LoadScene("NewCharacter", "LoadScreen");
    }
    private void BackButton() {
        SceneBuilder.LoadScene("MainMenu", "LoadScreen");
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