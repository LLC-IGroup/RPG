using UnityEngine;
using UnityEngine.UI;

public class PanelChat : BasePanel {
    #region Fields
    [SerializeField] public GameObject chatContent;
    [SerializeField] public GameObject chatCellPrefab;
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
        panelName = "PanelChat";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();
    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content
        RemoveAllChildren(chatContent);
        // Create Chat Cells
        foreach (string msg in ChatParam.listMSG) {
            GameObject cell = Instantiate(chatCellPrefab, chatContent.transform);
            ChatCell chatCell = new ChatCell();
            chatCell.msg = msg;
            cell.GetComponent<PanelChatCell>().SetParam(chatCell, this);
        }
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