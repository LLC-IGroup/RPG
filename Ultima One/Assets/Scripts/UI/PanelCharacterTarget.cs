using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterTarget : BasePanel {
    #region Fields
    [SerializeField] public Text textTergetName;
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
        panelName = "PanelCharacterTarget";
        SetDrag(false);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();

    }
    #endregion
    #region Function
    // Constructor
    // Public
    public void SetParam(BaseSceneObject sceneObject) {
        // Set Target Name
        textTergetName.text = sceneObject.sceneObjectName;



    }
    public void SetParam(BaseNPC baseNPC) {
        // Set Target Name
        textTergetName.text = baseNPC.NPCParam.privateParams.name;

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