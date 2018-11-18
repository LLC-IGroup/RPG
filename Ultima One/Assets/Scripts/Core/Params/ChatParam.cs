using System.Collections.Generic;
using UnityEngine;

public class ChatParam {
    #region Fields
    static public List<string> listMSG;
    #endregion
    #region Function
    static public void InitChat() {
        listMSG = new List<string>();

    }
    // Public
    static public void AddMSG(string msg) {
        listMSG.Add(msg);
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