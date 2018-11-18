using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterQuest : BasePanel {
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
        panelName = "PanelCharacterQuest";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content

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