using UnityEngine;
using UnityEngine.UI;

public class PanelDialogActionCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Text textAction;
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
        isDrag = false;
        
        
    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public void SetParam(DialogAction dialogAction) {
        // Set Text
        textAction.text = dialogAction.actionName;
    }
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