using System.Xml;
using UnityEngine;

public class BaseBuilder {
    #region Fields

    #endregion
    #region Function
    // Public
    // Protected
    static protected ItemInventory GetItemInventory(XmlNode node) {
        
        // Get Inventory Attribute
        XmlAttributeCollection inventoryAttributes = node.Attributes;
        uint volume = uint.MaxValue;
        uint mass = uint.MaxValue;
        foreach (XmlAttribute attribut in inventoryAttributes) {
            switch (attribut.Name) {
                case "volume":
                uint.TryParse(attribut.InnerText, out volume);
                break;
                case "mass":
                uint.TryParse(attribut.InnerText, out mass);
                break;
            }
        }
        // Create Empty Inventory
        ItemInventory itemInventory = new ItemInventory(volume, mass);
        // Get Items
        foreach (XmlNode itemNode in node) {
            XmlAttributeCollection itemAttributes = itemNode.Attributes;
            string itemName = "";
            uint count = 0;
            foreach (XmlAttribute attribute in itemAttributes) {
                switch (attribute.Name) {
                    case "name":
                    itemName = attribute.InnerText;
                    break;
                    case "count":
                    uint.TryParse(attribute.InnerText, out count);
                    break;
                }
            }
            if (itemName == "" || count == 0)
                break;
            // Try Get Item
            BaseItem baseItem = ItemBuilder.GetItemByName(itemName);
            if (baseItem == null)
                break;
            for (int i = 0; i < count; i++)
                if (!itemInventory.AddItem(baseItem))
                    return itemInventory;
        }
        return itemInventory;
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