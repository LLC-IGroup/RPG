using System;
using System.Xml;
using UnityEngine;

public class RecipeBuilder : BaseBuilder {
    #region Fields
    // Private
    static private XmlDocument XMLDoc = new XmlDocument();
    static private XmlElement XMLRoot;
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
    // Public
    // Static
    static public Recipe GetRecipeByName(string recipeName) {
        if (XMLRoot == null) {
            XMLDoc.Load("Assets/XML/Recipes.xml");
            XMLRoot = XMLDoc.DocumentElement;
        }
        // Get All Resipes
        XmlNodeList rootNodes = XMLRoot.GetElementsByTagName("Recipe");
        foreach (XmlNode recipeNode in rootNodes) {
            XmlNodeList recipeNodes = recipeNode.ChildNodes;
            foreach (XmlNode node in recipeNodes) {
                // Get Recope By Name
                if (node.Name.Equals("Name") &&
                    node.InnerText.Equals(recipeName)) {
                    return GetRecipe(recipeNode);
                }
            }
        }
        return null;
    }
    // Private
    private static Recipe GetRecipe(XmlNode recopeNode) {
        Recipe recipe = new Recipe();
        foreach (XmlNode node in recopeNode.ChildNodes) {
            switch (node.Name) {
                case "Name":
                recipe.name = node.InnerText;
                break;
                case "GameName":
                recipe.gameName = node.InnerText;
                break;
                case "Description":
                recipe.description = node.InnerText;
                break;
                case "IconName":
                recipe.iconName = node.InnerText;
                break;
                case "CraftItem":
                recipe.craftItem = node.InnerText;
                break;
                case "AddExp":
                uint.TryParse(node.InnerText, out recipe.addExp);
                break;

                case "ItemInventory":
                recipe.itemInventory = GetItemInventory(node);
                break;
            }
        }
        return recipe;
    }
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