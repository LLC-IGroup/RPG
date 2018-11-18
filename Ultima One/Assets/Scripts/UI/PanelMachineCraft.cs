using UnityEngine;
using UnityEngine.UI;

public class PanelMachineCraft : BasePanel {
    #region Fields
    [SerializeField] public GameObject recipeContent;
    [SerializeField] public GameObject craftContent;
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
        panelName = "PanelMachineCraft";
        SetDrag(true);

    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        RemoveAllChildren(recipeContent);
        RemoveAllChildren(craftContent);

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