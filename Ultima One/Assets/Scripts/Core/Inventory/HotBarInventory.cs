using System.Collections.Generic;
using UnityEngine;

public class HotBarInventory {
    #region Fields
    public List<HotBarCell> listHotBarCell;
    #endregion
    #region Unity Editor
    public void OnValidate() {

    }
    #endregion
    #region MonoBehaviour
    public void Awake() {

    }
    public void Start() {

    }
    #endregion
    #region Function
    // Constructor
    public HotBarInventory() {
        HotBarCell hotBarCell = null;
        listHotBarCell = new List<HotBarCell>();
        hotBarCell = new HotBarCell();
        hotBarCell.count = 0;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 1;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 2;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 3;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 4;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 5;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 6;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 7;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 8;
        listHotBarCell.Add(hotBarCell);
        hotBarCell = new HotBarCell();
        hotBarCell.count = 9;
        listHotBarCell.Add(hotBarCell);
    }
    // Public
    public HotBarCell GetHotBarCell(uint count) {
        foreach (HotBarCell hotBarCell in listHotBarCell)
            if (hotBarCell.count == count)
                return hotBarCell;
        return null;
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