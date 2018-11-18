using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelAction : BasePanel {
    #region Fields
    // Public
    [SerializeField] public Text textTitle;
    [SerializeField] public Slider slider;
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
        panelName = "PanelAction";
        SetDrag(false);
    }
    override public void Start() {
        base.Awake();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();

    }
    public void SetTimer(float actionCast) => slider.value = actionCast;
    public void SetTitle(string textTitle) => this.textTitle.text = textTitle;
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