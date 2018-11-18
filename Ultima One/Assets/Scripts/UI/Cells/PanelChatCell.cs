using UnityEngine;
using UnityEngine.UI;

public class PanelChatCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Text textMsg;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        base.OnValidate();

    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        base.Awake();

    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public void SetParam(ChatCell chatCell, BasePanel rootPanel) {
        base.SetParam(chatCell, rootPanel);
        textMsg.text = chatCell.msg;
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
