using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterLvL : BasePanel {
    #region Fields
    [SerializeField] public Slider slider;
    [SerializeField] public Text textCurrentExp;
    [SerializeField] public Text textMaxExp;
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
        panelName = "CharacterLvL";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Set Exp Text
        textCurrentExp.text = CharacterParam.param.exp.ToString();
        textMaxExp.text = LvLTable.GetMaxExp(CharacterParam.param.lvl).ToString();
        // Set Slider
        float percent = LvLTable.GetMaxExp(CharacterParam.param.lvl) / 100;
        float doneTime = LvLTable.GetMaxExp(CharacterParam.param.lvl) - CharacterParam.param.exp;
        slider.value = 1 - (doneTime / percent) / 100;
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