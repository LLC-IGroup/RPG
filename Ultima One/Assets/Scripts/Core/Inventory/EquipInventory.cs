using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipInventory {
    #region Fields
    public List<EquipCell> listEqupCells;
    #endregion
    #region Function
    // Constructor
    public EquipInventory() {
        EquipCell equipCell = null;
        listEqupCells = new List<EquipCell>();
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.AMULET;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.ARMOR;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.BELT;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.BOOTS;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.CLOAK;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.GLOVES;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.HELMET;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.PANTS;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.PET;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.RING;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.RING;
        equipCell.count = 1;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.WEAPON;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.WEAPON;
        equipCell.count = 1;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.TOOL;
        equipCell.count = 0;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.TOOL;
        equipCell.count = 1;
        listEqupCells.Add(equipCell);
        equipCell = new EquipCell();
        equipCell.equipType = BaseItem.ItemType.TOOL;
        equipCell.count = 2;
        listEqupCells.Add(equipCell);
    }
    // Public
    public EquipCell GetCellByType(BaseItem.ItemType equipType, int count) {
        foreach (EquipCell equipCell in listEqupCells)
            if (equipCell.equipType == equipType &&
                equipCell.count == count)
                return equipCell;
        return null;
    }
    public List<BaseCell> GetCellListByType(BaseItem.ItemType equipType) {
        List<BaseCell> list = new List<BaseCell>();
        foreach (EquipCell equipCell in listEqupCells)
            if (equipCell.equipType == equipType)
                list.Add(equipCell);
        return list;
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