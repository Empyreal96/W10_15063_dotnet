// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.XmlReaderHelper
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Xml;

namespace GamerServices.Platforms.Web
{
  internal static class XmlReaderHelper
  {
    public static bool ReadUntil(XmlReader reader, string elementName)
    {
      while (!XmlReaderHelper.IsElement(reader, elementName))
      {
        if (!reader.Read())
          return false;
      }
      return true;
    }

    public static bool IsElement(XmlReader reader, string elementName) => reader.NodeType == XmlNodeType.Element && string.Compare(reader.LocalName, elementName, StringComparison.InvariantCultureIgnoreCase) == 0;

    public static bool IsEndElement(XmlReader reader, string elementName) => reader.NodeType == XmlNodeType.EndElement && string.Compare(reader.LocalName, elementName, StringComparison.InvariantCultureIgnoreCase) == 0;
  }
}
