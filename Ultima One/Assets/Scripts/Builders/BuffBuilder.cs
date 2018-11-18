using System;
using System.Xml;
using UnityEngine;

public class BuffBuilder {
    #region Fields
    // Private
    static private XmlDocument XMLDoc = new XmlDocument();
    static private XmlElement XMLRoot;
    #endregion
    #region Function
    // Public
    // Atatic
    static public Buff GetBuffByName(string buffName) {
        if (XMLRoot == null) {
            XMLDoc.Load("Assets/XML/Buffs.xml");
            XMLRoot = XMLDoc.DocumentElement;
        }
        // Get All Buffs
        XmlNodeList rootNodes = XMLRoot.GetElementsByTagName("Buff");
        foreach (XmlNode buffNode in rootNodes) {
            XmlNodeList buffNodes = buffNode.ChildNodes;
            foreach (XmlNode node in buffNodes) {
                // Get Recope By Name
                if (node.Name.Equals("Name") &&
                    node.InnerText.Equals(buffName)) {
                    return GetBuff(buffNode);
                }
            }
        }
        return null;
    }
    // Private
    static private Buff GetBuff(XmlNode buffNode) {
        Buff buff = new Buff();
        foreach (XmlNode node in buffNode.ChildNodes) {
            switch (node.Name) {
                case "Name":
                buff.name = node.InnerText;
                break;
                case "GameName":
                buff.gameName = node.InnerText;
                break;
                case "Description":
                buff.description = node.InnerText;
                break;
                case "IconName":
                buff.iconName = node.InnerText;
                break;
                case "LiveTime":
                float.TryParse(node.InnerText, out buff.liveTime);
                break;

            }
        }

        return buff;
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