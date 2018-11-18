using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory {
    #region Fields
    public List<ItemCell> listItemCells;
    public float maxVolume;
    public float maxMass;
    #endregion
    #region Function
    // Constructor
    public ItemInventory(float volume, float mass) {
        listItemCells = new List<ItemCell>();
        maxVolume = volume;
        maxMass = mass;
    }
    // Public
    public float GetCurrentVolume() {
        float result = 0f;
        foreach (ItemCell itemCell in listItemCells)
            result += itemCell.item.volume * itemCell.count;
        return result;
    }
    public float GetCurrentMass() {
        float result = 0f;
        foreach (ItemCell itemCell in listItemCells)
            result += itemCell.item.mass * itemCell.count;
        return result;
    }
    public void RemoveItem(BaseItem item) {
        foreach (ItemCell itemCell in listItemCells) {
            if (itemCell.item.name == item.name &&
                itemCell.item.quality == item.quality) {
                if (itemCell.count > 1) {
                    itemCell.count--;
                } else
                    listItemCells.Remove(itemCell);
                break;
            }
        }
    }
    public bool AddItem(BaseItem item) {
        // Chek Volume and Mass
        if ((GetCurrentVolume() + item.volume) > maxVolume ||
            (GetCurrentMass() + item.mass) > maxMass)
            return false;
        // Add Item
        if (!item.stuck) {
            ItemCell newCell = new ItemCell();
            newCell.item = item;
            newCell.count = 1;
            listItemCells.Add(newCell);
        } else {
            foreach (ItemCell itemCell in listItemCells) {
                if (itemCell.item.name == item.name &&
                    itemCell.count < itemCell.item.maxStuck &&
                    itemCell.item.quality == item.quality) {
                    itemCell.count++;
                    return true;
                }
            }
            ItemCell newCell = new ItemCell();
            newCell.item = item;
            newCell.count = 1;
            listItemCells.Add(newCell);
        }
        return true;
    }
    public bool IsAdd(BaseItem item) {
        if (item.volume + GetCurrentVolume() > maxVolume ||
            item.mass + GetCurrentMass() > maxMass) {
            return false;
        }
        return true;
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