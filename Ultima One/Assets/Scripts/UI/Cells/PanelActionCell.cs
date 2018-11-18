using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelActionCell : BaseCellPanel {
    #region Fields
    // Action
    [HideInInspector] static public Action<ActionCellParam> ActionCell;
    // Public
    [SerializeField] public Text textActionName;
    // Private
    [HideInInspector] private string actionName;
    [HideInInspector] private GameObject target;
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
        GetComponent<Button>().onClick.AddListener(this.ActionClick);
    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public void SetParam(string actionName, GameObject target) {
        this.actionName = actionName;
        this.target = target;
        textActionName.text = actionName;
    }
    // Private
    private void ActionClick() {
        ActionCellParam actionCellParam = new ActionCellParam();
        if (target.GetComponent<BaseSceneObject>() != null) {
            actionCellParam.actionName = actionName;
            actionCellParam.sceneObject = target.GetComponent<BaseSceneObject>();
        }
        if (target.GetComponent<BaseNPC>() != null) {
            actionCellParam.actionName = actionName;
            actionCellParam.NPC = target.GetComponent<BaseNPC>();
        }
        // Action
        ActionCell?.Invoke(actionCellParam);
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