using System.Collections.Generic;
using UnityEngine;

public class SkillInventory {
    #region Fields
    public List<SkillCell> listSkillCells;
    #endregion
    #region Function
    // Constructor
    public SkillInventory() {
        listSkillCells = new List<SkillCell>();
    }
    // Public
    public void AddSkill(BaseSkill baseSkill) {
        foreach (SkillCell cell in listSkillCells) {
            if (cell.skill.name == baseSkill.name)
                return;
        }
        SkillCell skillCell = new SkillCell();
        skillCell.skill = baseSkill;
        listSkillCells.Add(skillCell);
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