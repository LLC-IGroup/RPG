using UnityEngine;
using UnityEngine.UI;

public class PanelCreateStep3 : BasePanel {
    #region Fields

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
        panelName = "PanelCreateStep3";
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