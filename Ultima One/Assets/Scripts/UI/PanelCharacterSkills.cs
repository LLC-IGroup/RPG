using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterSkills : BasePanel {
    #region Fields
    [SerializeField] public GameObject activeSkillContent;
    [SerializeField] public GameObject passiveSkillContent;
    [SerializeField] public GameObject emotionSkillContent;
    [SerializeField] public GameObject skillCellPrefab;
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
        panelName = "PanelCharacterSkills";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content
        RemoveAllChildren(activeSkillContent);
        RemoveAllChildren(passiveSkillContent);
        RemoveAllChildren(emotionSkillContent);
        // Create Cell Panel
        foreach (SkillCell skillCell in CharacterParam.skillInventory.listSkillCells) {
            switch (skillCell.skill.skillType) {
                case BaseSkill.SkillType.ACTIVE:
                GameObject activeCellPanel = Instantiate(skillCellPrefab, activeSkillContent.transform);
                activeCellPanel.GetComponent<PanelSkillCell>().SetParam(skillCell, this);
                break;
                case BaseSkill.SkillType.PASIVE:
                GameObject passiveCellPanel = Instantiate(skillCellPrefab, passiveSkillContent.transform);
                passiveCellPanel.GetComponent<PanelSkillCell>().SetParam(skillCell, this);
                break;
                case BaseSkill.SkillType.EMOTION:
                GameObject emotionCellPanel = Instantiate(skillCellPrefab, emotionSkillContent.transform);
                emotionSkillContent.GetComponent<PanelSkillCell>().SetParam(skillCell, this);
                break;
            }
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