using System;
using System.Xml;
using UnityEngine;

public class SceneObjectBuilder : BaseBuilder {
    #region Fields
    // Private
    static private XmlDocument XMLDoc = new XmlDocument();
    static private XmlElement XMLRoot;
    #endregion
    #region Function
    // Public
    static public void GetObjectByName(BaseSceneObject baseSceneObject) {
        if (XMLRoot == null) {
            XMLDoc.Load("Assets/XML/SceneObjects.xml");
            XMLRoot = XMLDoc.DocumentElement;
        }
        // Get All SceneObjects
        XmlNodeList rootNodes = XMLRoot.GetElementsByTagName("SceneObject");
        foreach (XmlNode sceneObjectNode in rootNodes) {
            XmlNodeList sceneObjectNodes = sceneObjectNode.ChildNodes;
            foreach (XmlNode node in sceneObjectNodes) {
                // Get SceneObject By Name
                if (node.Name.Equals("Name") &&
                    node.InnerText.Equals(baseSceneObject.sceneObjectName)) {
                    GetSceneObject(sceneObjectNode, baseSceneObject);
                }
            }
        }
    }
    // Private
    private static void GetSceneObject(XmlNode sceneObjectNode, 
        BaseSceneObject baseSceneObject) {
        // Tree Object
        if (baseSceneObject is TreeObject)
            CreateTreeObject(sceneObjectNode, baseSceneObject as TreeObject);
        // Barrel Object
        if (baseSceneObject is BarrelObject)
            CreateBarrelObject(sceneObjectNode, baseSceneObject as BarrelObject);
    }
    private static void CreateBarrelObject(XmlNode sceneObjectNode, 
        BarrelObject barrelObject) {
        GetBaseSceneObject(sceneObjectNode, barrelObject);
        foreach (XmlNode node in sceneObjectNode.ChildNodes) {
            switch (node.Name) {
                case "DropInventory":
                barrelObject.dropInventory = GetItemInventory(sceneObjectNode);
                break;
                case "ItemInventory":
                barrelObject.itemInventory = GetItemInventory(node);
                break;
            }
        }
    }
    static private void CreateTreeObject(XmlNode sceneObjectNode, 
        TreeObject treeObject) {
        GetBaseSceneObject(sceneObjectNode, treeObject);
        




    }
    static private void GetBaseSceneObject(XmlNode sceneObjectNode, 
        BaseSceneObject baseSceneObject) {
        foreach (XmlNode node in sceneObjectNode.ChildNodes) {
            switch (node.Name) {
                case "GameName":
                baseSceneObject.sceneObjectGameName = sceneObjectNode.InnerText;
                break;
                case "Description":
                baseSceneObject.description = sceneObjectNode.InnerText;
                break;
                case "IconName":
                baseSceneObject.iconName = sceneObjectNode.InnerText;
                break;
                case "Quality":
                uint.TryParse(sceneObjectNode.InnerText, out baseSceneObject.quality);
                break;
                case "HP":
                uint.TryParse(sceneObjectNode.InnerText, out baseSceneObject.HP);
                break;
            }
        }
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