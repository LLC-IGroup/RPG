using System;
using UnityEngine;

public class CharacterBuilder : BaseBuilder {
    #region Fields

    #endregion
    #region Function
    // Public
    public static void CreateNewCharacter(NewCharacterController.CreateCharacterParams createParams) {
        CharacterParam.SetDefault();
        // Set Start Scene
        CharacterParam.param.sceneName = "SandBox";
        // Set Character Sex 
        CharacterParam.privateParams.sex = createParams.sex;
        switch (createParams.sex) {
            /// Male Setup
            case PrivateParam.CharacterSex.MALE:
            CharacterParam.param.moveSpeed = 3.3f;
            // Set Crit Param
            CharacterParam.param.critChance = 0;
            CharacterParam.param.critPower = 10;
            // HP
            CharacterParam.privateParams.maxHP = 130;
            CharacterParam.param.HP = CharacterParam.privateParams.maxHP;
            // MP
            CharacterParam.privateParams.maxMP = 100;
            CharacterParam.param.MP = CharacterParam.privateParams.maxMP;
            // Energy
            CharacterParam.privateParams.maxEnergy = 100;
            CharacterParam.param.energy = CharacterParam.privateParams.maxEnergy;
            // Hunger
            CharacterParam.privateParams.maxHunger = 100;
            CharacterParam.param.hunger = CharacterParam.privateParams.maxHunger;
            // Abylitys
            CharacterParam.abilitys.stamina = 9;
            CharacterParam.abilitys.body = 10;
            CharacterParam.abilitys.agility = 9;
            CharacterParam.abilitys.strength = 10;



            break;
            /// Female Setup
            case PrivateParam.CharacterSex.FEMALE:
            CharacterParam.param.moveSpeed = 3.7f;
            // Set Crit Param
            CharacterParam.param.critChance = 10;
            CharacterParam.param.critPower = 0;
            // HP
            CharacterParam.privateParams.maxHP = 100;
            CharacterParam.param.HP = CharacterParam.privateParams.maxHP;
            // MP
            CharacterParam.privateParams.maxMP = 130;
            CharacterParam.param.MP = CharacterParam.privateParams.maxMP;
            // Energy
            CharacterParam.privateParams.maxEnergy = 100;
            CharacterParam.param.energy = CharacterParam.privateParams.maxEnergy;
            // Hunger
            CharacterParam.privateParams.maxHunger = 100;
            CharacterParam.param.hunger = CharacterParam.privateParams.maxHunger;
            // Abylitys
            CharacterParam.abilitys.stamina = 10;
            CharacterParam.abilitys.body = 9;
            CharacterParam.abilitys.agility = 10;
            CharacterParam.abilitys.strength = 9;



            break;
        }
        // Abylitys
        CharacterParam.abilitys.intellect = 10;

        
        
        
        
        

        // Add Start Items
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("CottunCap"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("CottonShirt"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("CottunBoots"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("CottunCloak"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("GoldAmulet"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("GoldRing"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("LeatherBelt"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("LeatherGloves"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("LeatherPants"));

        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronAxe"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronHammer"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronKnife"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronNeedle"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronPickaxe"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronPliers"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronSaw"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronScissors"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronShovel"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("IronSickle"));

        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("BandageBelt"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("BandageBelt"));
        CharacterParam.itemInventory.AddItem(ItemBuilder.GetItemByName("BandageBelt"));

        // Add Base Skills
        CharacterParam.skillInventory.AddSkill(SkillBuilder.GetSkillByName("BaseAttack"));
        // Add Base Recipes
        CharacterParam.recipeInventory.AddRecipe(RecipeBuilder.GetRecipeByName("Bandage"));



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