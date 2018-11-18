using UnityEngine;
using UnityEngine.UI;

public class PanelMainMenu : BasePanel {
    #region Fields
    [SerializeField] public Button buttonAccount;
    [SerializeField] public Button buttonOptons;
    [SerializeField] public Button buttonExit;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();
        // Set Params
        panelName = "PanelMainMenu";
        SetDrag(false);
    }
    override public void Start() {
        base.Start();

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