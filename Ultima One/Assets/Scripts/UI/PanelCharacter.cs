using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCharacter : BasePanel {
    #region Fields
    [SerializeField] public PanelEquipCell[] equipCellArray;

    [SerializeField] public Text textStrength;
    [SerializeField] public Text textAgility;
    [SerializeField] public Text textIntellec;
    [SerializeField] public Text textStamina;
    [SerializeField] public Text textBody;

    [SerializeField] public Text textCrushing;
    [SerializeField] public Text textStabbing;
    [SerializeField] public Text textCutting;
    [SerializeField] public Text textArrow;
    [SerializeField] public Text textFire;
    [SerializeField] public Text textWhoter;
    [SerializeField] public Text textEarth;
    [SerializeField] public Text textAir;
    [SerializeField] public Text textDeath;
    [SerializeField] public Text textPoison;

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
        panelName = "PanelCharacter";
        SetDrag(true);

    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    #endregion
    #region Function
    override public void UpdatePanel() {
        base.UpdatePanel();
        foreach (PanelEquipCell panelEquipmentCell in equipCellArray) {
            EquipCell equipCell = CharacterParam.equipInventory.GetCellByType(panelEquipmentCell.equipType, panelEquipmentCell.count);
            if (equipCell != null) {
                panelEquipmentCell.SetParam(equipCell, this);
            }
        }
        // Text Update
        textStrength.text = CharacterParam.abilitys.strength.ToString();
        textAgility.text = CharacterParam.abilitys.agility.ToString();
        textIntellec.text = CharacterParam.abilitys.intellect.ToString();
        textStamina.text = CharacterParam.abilitys.stamina.ToString();
        textBody.text = CharacterParam.abilitys.body.ToString();

        textCrushing.text = CharacterParam.resistance.сrushing.ToString();
        textStabbing.text = CharacterParam.resistance.stabbing.ToString();
        textCutting.text = CharacterParam.resistance.cutting.ToString();
        textArrow.text = CharacterParam.resistance.arrow.ToString();
        textFire.text = CharacterParam.resistance.fire.ToString();
        textWhoter.text = CharacterParam.resistance.water.ToString();
        textEarth.text = CharacterParam.resistance.earth.ToString();
        textAir.text = CharacterParam.resistance.air.ToString();
        textDeath.text = CharacterParam.resistance.death.ToString();
        textPoison.text = CharacterParam.resistance.poison.ToString();

    }
    override public void ClosePanel() {
        base.ClosePanel();

    }
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