using UnityEngine;

public class LvLTable {
    #region Fields
    static private uint startCount = 100;
    #endregion
    #region Function
    // Public
    static public uint GetMaxExp(uint lvl) {
        uint result = 0;
        result = startCount * lvl;
        return result;
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