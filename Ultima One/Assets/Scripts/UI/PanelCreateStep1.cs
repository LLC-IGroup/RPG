using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreateStep1 : BasePanel {
    #region Fields
    // Public
    [SerializeField] public InputField inputFieldName;
    [SerializeField] public Toggle toggleMale;
    [SerializeField] public Toggle toggleFemale;

    [HideInInspector] public PrivateParam.CharacterSex characterSex;
    // Private

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
        panelName = "PanelCreateStep1";
        SetDrag(false);
        toggleMale.onValueChanged.AddListener(this.MaleSelect);
        toggleFemale.onValueChanged.AddListener(this.FemaleSelect);

    }
    override public void Start() {
        base.Start();

    }
    #endregion
    #region Function
    // Public
    public bool IsPanelValid() {
        if (inputFieldName.text.Length < 2)
            return false;
        if (characterSex == PrivateParam.CharacterSex.NONE)
            return false;
        return true;
    }
    // Private
    private void FemaleSelect(bool arg) {
        if (arg) {
            toggleMale.isOn = false;
            toggleFemale.isOn = true;
            characterSex = PrivateParam.CharacterSex.FEMALE;
        }
    }
    private void MaleSelect(bool arg) {
        if (arg) {
            toggleFemale.isOn = false;
            toggleMale.isOn = true;
            characterSex = PrivateParam.CharacterSex.MALE;
        }
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