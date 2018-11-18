using UnityEngine;

public class Profession {
    #region Fields
    public string professionName;
    public float lvl;
    public ProfessionParam professionParam;
    #endregion
    #region Function
    // Constructor
    public Profession(string professionName) {
        this.professionName = professionName;
        lvl = 0f;
        professionParam = ProfessionParam.UP;
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
    public enum ProfessionParam {
        UP,
        CANCLE,
        DOWN
    }
    #endregion
}        