using UnityEngine;
using UnityEngine.UI;

public class PanelRecipeCell : BaseCellPanel {
    #region Fields
    [SerializeField] public Text textRecipeName;
    [SerializeField] public Image imageInnerIcon;
    #endregion
    #region Unity Editor
    override public void OnValidate() {
        
    }
    #endregion
    #region MonoBehaviour
    override public void Awake() {
        
    }
    override public void Start() {
        
    }
    #endregion
    #region Function
    // Public
    public void SetParam(RecipeCell recipeCell, BasePanel rootPanel) {
        base.SetParam(recipeCell, rootPanel);
        textRecipeName.text = recipeCell.recipe.name;
        imageInnerIcon.sprite = Resources.Load<Sprite>("Icons/" + recipeCell.recipe.iconName);
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