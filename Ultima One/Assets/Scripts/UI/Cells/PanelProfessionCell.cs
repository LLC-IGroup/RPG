using UnityEngine;
using UnityEngine.UI;

public class PanelProfessionCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Button buttonUp;
    [SerializeField] public Button buttonCancle;
    [SerializeField] public Button buttonDown;
    [SerializeField] public Text professionName;
    [SerializeField] public Text professionLvl;
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
    public void SetParam(ProfessionCell cell) {
        base.SetParam(cell, null);
        ProfessionCell professionCell = cell;
        professionName.text = professionCell.profession.professionName;
        professionLvl.text = professionCell.profession.lvl.ToString();




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