using UnityEngine;
using UnityEngine.UI;

public class PanelNPCDialogCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Text textDialog;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        // Set Params
        isDrag = true;
        base.Awake();

    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public void SetParam(DialogNode dialogNode) {
        textDialog.text = dialogNode.dialogText;
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