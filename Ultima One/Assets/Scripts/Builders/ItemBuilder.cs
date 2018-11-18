using System;
using System.Xml;
using UnityEngine;

sealed public class ItemBuilder {
    #region Fields
    // Private
    static private XmlDocument XMLDoc = new XmlDocument();
    static private XmlElement XMLRoot;
    #endregion
    #region Function
    // Static
    static public BaseItem GetItemByName(string itemName) {
        if (XMLRoot == null) {
            XMLDoc.Load("Assets/XML/Items.xml");
            XMLRoot = XMLDoc.DocumentElement;
        }
        // Get All Items
        XmlNodeList rootNodes = XMLRoot.GetElementsByTagName("Item");
        foreach (XmlNode itemNode in rootNodes) {
            XmlNodeList itemNodes = itemNode.ChildNodes;
            foreach (XmlNode node in itemNodes) {
                // Get Item By Name
                if (node.Name.Equals("Name") &&
                    node.InnerText.Equals(itemName)) {
                    return GetItem(itemNode);
                }
            }
        }
        return null;
    }
    private static BaseItem GetItem(XmlNode itemNode) {
        XmlAttribute xmlAttribute = itemNode.Attributes[0];
        BaseItem.ItemType type = GetItemType(xmlAttribute.InnerText);
        switch (type) {
            case BaseItem.ItemType.ARMOR:
            return CreateArmorItem(itemNode);
            case BaseItem.ItemType.QUEST:
            return CreateQuestItem(itemNode);
            case BaseItem.ItemType.RESOURCES:
            return CreateResourcesItem(itemNode);
            case BaseItem.ItemType.TOOL:
            return CreateToolItem(itemNode);
            case BaseItem.ItemType.RING:
            return CreateRingItem(itemNode);
            case BaseItem.ItemType.AMULET:
            return CreateAmuletItem(itemNode);
            case BaseItem.ItemType.SHIELD:
            return CreateShieldItem(itemNode);
            case BaseItem.ItemType.HELMET:
            return CreateHelmetItem(itemNode);
            case BaseItem.ItemType.BELT:
            return CreateBeltItem(itemNode);
            case BaseItem.ItemType.GLOVES:
            return CreateGlovesItem(itemNode);
            case BaseItem.ItemType.PANTS:
            return CreatePantsItem(itemNode);
            case BaseItem.ItemType.BOOTS:
            return CreateBootsItem(itemNode);
            case BaseItem.ItemType.CLOAK:
            return CreateCloakItem(itemNode);
            case BaseItem.ItemType.TOW_HAND_WEAPON:
            return CreateTowHandWeaponItem(itemNode);
            case BaseItem.ItemType.WEAPON:
            return CreateWeaponItem(itemNode);
            case BaseItem.ItemType.PET:
            return CreatePetItem(itemNode);
        }
        return null;
    }
    // Public
    // Private
    private static ArmorItem CreateArmorItem(XmlNode armorNode) {
        ArmorItem armorItem = new ArmorItem();
        armorItem.SetBase(GetBaseItem(armorNode));
        armorItem.itemType = BaseItem.ItemType.ARMOR;
        return armorItem;
    }
    private static QuestItem CreateQuestItem(XmlNode questNode) {
        QuestItem questItem = new QuestItem();
        questItem.SetBase(GetBaseItem(questNode));
        questItem.itemType = BaseItem.ItemType.QUEST;
        return questItem;
    }
    private static ResourcesItem CreateResourcesItem(XmlNode resourcesNode) {
        ResourcesItem resourcesItem = new ResourcesItem();
        resourcesItem.SetBase(GetBaseItem(resourcesNode));
        resourcesItem.itemType = BaseItem.ItemType.RESOURCES;
        return resourcesItem;
    }
    private static ToolItem CreateToolItem(XmlNode toolNode) {
        ToolItem toolItem = new ToolItem();
        toolItem.SetBase(GetBaseItem(toolNode));
        toolItem.itemType = BaseItem.ItemType.TOOL;
        return toolItem;
    }
    private static AmuletItem CreateAmuletItem(XmlNode amuletNode) {
        AmuletItem amuletItem = new AmuletItem();
        amuletItem.SetBase(GetBaseItem(amuletNode));
        amuletItem.itemType = BaseItem.ItemType.AMULET;
        return amuletItem;
    }
    private static RingItem CreateRingItem(XmlNode ringNode) {
        RingItem ringItem = new RingItem();
        ringItem.SetBase(GetBaseItem(ringNode));
        ringItem.itemType = BaseItem.ItemType.RING;
        return ringItem;
    }
    private static PetItem CreatePetItem(XmlNode petNode) {
        PetItem petItem = new PetItem();
        petItem.SetBase(GetBaseItem(petNode));
        petItem.itemType = BaseItem.ItemType.PET;
        return petItem;
    }
    private static WeaponItem CreateWeaponItem(XmlNode weaponNode) {
        WeaponItem weaponItem = new WeaponItem();
        weaponItem.SetBase(GetBaseItem(weaponNode));
        weaponItem.itemType = BaseItem.ItemType.WEAPON;
        return weaponItem;
    }
    private static TowHandWeapon CreateTowHandWeaponItem(XmlNode towHandWeaponNode) {
        TowHandWeapon towHandWeapon = new TowHandWeapon();
        towHandWeapon.SetBase(GetBaseItem(towHandWeaponNode));
        towHandWeapon.itemType = BaseItem.ItemType.TOW_HAND_WEAPON;
        return towHandWeapon;
    }
    private static CloakItem CreateCloakItem(XmlNode cloakNode) {
        CloakItem cloakItem = new CloakItem();
        cloakItem.SetBase(GetBaseItem(cloakNode));
        cloakItem.itemType = BaseItem.ItemType.CLOAK;
        return cloakItem;
    }
    private static BootsItem CreateBootsItem(XmlNode bootsNode) {
        BootsItem bootsItem = new BootsItem();
        bootsItem.SetBase(GetBaseItem(bootsNode));
        bootsItem.itemType = BaseItem.ItemType.BOOTS;
        return bootsItem;
    }
    private static PantsItem CreatePantsItem(XmlNode pantsNode) {
        PantsItem pantsItem = new PantsItem();
        pantsItem.SetBase(GetBaseItem(pantsNode));
        pantsItem.itemType = BaseItem.ItemType.PANTS;
        return pantsItem;
    }
    private static BeltItem CreateBeltItem(XmlNode beltNode) {
        BeltItem beltItem = new BeltItem();
        beltItem.SetBase(GetBaseItem(beltNode));
        beltItem.itemType = BaseItem.ItemType.BELT;
        return beltItem;
    }
    private static GlovesItem CreateGlovesItem(XmlNode glovesNode) {
        GlovesItem glovesItem = new GlovesItem();
        glovesItem.SetBase(GetBaseItem(glovesNode));
        glovesItem.itemType = BaseItem.ItemType.GLOVES;
        return glovesItem;
    }
    private static HelmetItem CreateHelmetItem(XmlNode helmetNode) {
        HelmetItem helmetItem = new HelmetItem();
        helmetItem.SetBase(GetBaseItem(helmetNode));
        helmetItem.itemType = BaseItem.ItemType.HELMET;
        return helmetItem;
    }
    private static ShieldItem CreateShieldItem(XmlNode shieldNode) {
        ShieldItem shieldItem = new ShieldItem();
        shieldItem.SetBase(GetBaseItem(shieldNode));
        shieldItem.itemType = BaseItem.ItemType.SHIELD;
        return shieldItem;
    }
    static private BaseItem GetBaseItem(XmlNode armorNode) {
        BaseItem baseItem = new BaseItem();
        foreach (XmlNode node in armorNode.ChildNodes) {
            switch (node.Name) {
                case "Name":
                baseItem.name = node.InnerText;
                break;
                case "GameName":
                baseItem.gameName = node.InnerText;
                break;
                case "Description":
                baseItem.description = node.InnerText;
                break;
                case "Quality":
                float.TryParse(node.InnerText, out baseItem.quality);
                break;
                case "MinQuality":
                float.TryParse(node.InnerText, out baseItem.minQuality);
                break;
                case "Durability":
                float.TryParse(node.InnerText, out baseItem.quality);
                break;
                case "MaxDurability":
                float.TryParse(node.InnerText, out baseItem.minQuality);
                break;
                case "IconName":
                baseItem.iconName = node.InnerText;
                break;
                case "ModelName":
                baseItem.modelName = node.InnerText;
                break;
                case "MaxStuck":
                float.TryParse(node.InnerText, out baseItem.maxStuck);
                break;
                case "Stuck":
                bool.TryParse(node.InnerText, out baseItem.stuck);
                break;
                case "Volume":
                float.TryParse(node.InnerText, out baseItem.volume);
                break;
                case "Mass":
                float.TryParse(node.InnerText, out baseItem.mass);
                break;
                case "MinPrice":
                float.TryParse(node.InnerText, out baseItem.minPrice);
                break;
                case "Use":
                bool.TryParse(node.InnerText, out baseItem.use);
                break;
            }
        }
        return baseItem;
    }
    static private BaseItem.ItemType GetItemType(string innerText) {
        switch (innerText) {
            case "AMULET":
            return BaseItem.ItemType.AMULET;
            case "ARMOR":
            return BaseItem.ItemType.ARMOR;
            case "BELT":
            return BaseItem.ItemType.BELT;
            case "BOOTS":
            return BaseItem.ItemType.BOOTS;
            case "CLOAK":
            return BaseItem.ItemType.CLOAK;
            case "GLOVES":
            return BaseItem.ItemType.GLOVES;
            case "HELMET":
            return BaseItem.ItemType.HELMET;
            case "PANTS":
            return BaseItem.ItemType.PANTS;
            case "PET":
            return BaseItem.ItemType.PET;
            case "QUEST":
            return BaseItem.ItemType.QUEST;
            case "RESOURCES":
            return BaseItem.ItemType.RESOURCES;
            case "RING":
            return BaseItem.ItemType.RING;
            case "SHIELD":
            return BaseItem.ItemType.SHIELD;
            case "TOOL":
            return BaseItem.ItemType.TOOL;
            case "TOW_HAND_WEAPON":
            return BaseItem.ItemType.TOW_HAND_WEAPON;
            case "WEAPON":
            return BaseItem.ItemType.WEAPON;
        }
        return BaseItem.ItemType.ERROR;
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