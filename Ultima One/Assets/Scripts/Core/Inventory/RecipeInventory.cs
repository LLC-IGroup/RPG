using System.Collections.Generic;
using UnityEngine;

public class RecipeInventory {
    #region Fields
    public List<RecipeCell> listRecipeCells;
    #endregion
    #region Function
    // Constructor
    public RecipeInventory() {
        listRecipeCells = new List<RecipeCell>();

    }
    // Public
    public void AddRecipe(Recipe recipe) {
        foreach (RecipeCell cell in listRecipeCells)
            if (cell.recipe.name == recipe.name)
                return;
        RecipeCell recipeCell = new RecipeCell();
        recipeCell.recipe = recipe;
        listRecipeCells.Add(recipeCell);
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