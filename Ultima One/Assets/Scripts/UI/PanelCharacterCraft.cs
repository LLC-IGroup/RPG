using UnityEngine;
using UnityEngine.UI;

public class PanelCharacterCraft : BasePanel {
    #region Fields
    [SerializeField] public GameObject recipeContent;
    [SerializeField] public GameObject craftContent;
    [SerializeField] public GameObject recipeCellPrefab;
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
        panelName = "PanelCharacterCraft";
        SetDrag(true);
    }
    override public void Start() {
        base.Start();
        UpdatePanel();

    }
    override public void UpdatePanel() {
        base.UpdatePanel();
        // Clear Content
        RemoveAllChildren(recipeContent);
        RemoveAllChildren(craftContent);
        // Create Recipe Cells
        foreach (RecipeCell cell in CharacterParam.recipeInventory.listRecipeCells) {
            GameObject recipeCell = Instantiate(recipeCellPrefab, recipeContent.transform);
            recipeCell.GetComponent<PanelRecipeCell>().SetParam(cell, this);
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