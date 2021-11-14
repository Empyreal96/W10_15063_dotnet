// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.TileUtils
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Text;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  internal class TileUtils
  {
    public const int MAX_CYCLE_IMAGE_NUM = 9;
    public const int MAX_XML_BYTE_SIZE = 3072;

    public static byte[] HardConvertUnicodeToASCIIByte(string unicode)
    {
      UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
      return Encoding.Convert((Encoding) unicodeEncoding, (Encoding) new UTF8Encoding(), unicodeEncoding.GetBytes(unicode));
    }

    public static DataType GetDataType(ShellTileData shellTileData)
    {
      switch ((TILE_TEMPLATE_TYPE) shellTileData.TemplateType)
      {
        case TILE_TEMPLATE_TYPE.TILE_TEMPLATE_METROCOUNT:
          return DataType.IconicData;
        case TILE_TEMPLATE_TYPE.TILE_TEMPLATE_FLIP:
          return ((StandardTileData) shellTileData).isFlip ? DataType.FlipData : DataType.StandardData;
        case TILE_TEMPLATE_TYPE.TILE_TEMPLATE_CYCLE:
          return DataType.CycleData;
        default:
          throw new ArgumentException("Invalid ShellTileData type");
      }
    }

    public static bool IsTileContainsRemoteUri(DataType? dataType, ShellTileData data)
    {
      DataType? nullable = dataType;
      if (nullable.HasValue)
      {
        switch (nullable.GetValueOrDefault())
        {
          case DataType.StandardData:
            return TileUtils.IsAnyRemoteUriStandard((StandardTileData) data);
          case DataType.FlipData:
            return TileUtils.IsAnyRemoteUriFlip((FlipTileData) data);
          case DataType.IconicData:
            return TileUtils.IsAnyRemoteUriIconic((IconicTileData) data);
          case DataType.CycleData:
            return TileUtils.IsAnyRemoteUriCycle((CycleTileData) data);
        }
      }
      throw new ArgumentException("Invalid ShellTileData type");
    }

    private static bool IsAnyRemoteUriStandard(StandardTileData data) => data.BackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.BackgroundImage) == URIType.http || data.BackBackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.BackBackgroundImage) == URIType.http;

    private static bool IsAnyRemoteUriFlip(FlipTileData data) => TileUtils.IsAnyRemoteUriStandard((StandardTileData) data) || data.SmallBackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.SmallBackgroundImage) == URIType.http || (data.WideBackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.WideBackgroundImage) == URIType.http || data.WideBackBackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.WideBackBackgroundImage) == URIType.http);

    private static bool IsAnyRemoteUriIconic(IconicTileData data) => data.SmallIconImage != (Uri) null && TileUtils.GetURIScheme(data.SmallIconImage) == URIType.http || data.IconImage != (Uri) null && TileUtils.GetURIScheme(data.IconImage) == URIType.http;

    private static bool IsAnyRemoteUriCycle(CycleTileData data) => data.SmallBackgroundImage != (Uri) null && TileUtils.GetURIScheme(data.SmallBackgroundImage) == URIType.http;

    public static URIType GetURIScheme(Uri uriTobeExamined)
    {
      if (!uriTobeExamined.IsAbsoluteUri)
        return URIType.relative;
      if (uriTobeExamined.Scheme == "http")
        return URIType.http;
      if (uriTobeExamined.Scheme == "res")
        return URIType.res;
      return uriTobeExamined.Scheme == "file" ? URIType.file : URIType.unknown;
    }

    public static void ConstructXMLCreate(
      DataType? dataType,
      ShellTileData data,
      string id,
      bool hasLarge,
      ref string xmlTemplateBuilderString,
      ref string xmlUriBuilderString)
    {
      TileUtils.ConstructXML(dataType, data, id, (Uri) null, true, hasLarge, ref xmlTemplateBuilderString, ref xmlUriBuilderString);
    }

    public static void ConstructXMLUpdate(
      DataType? dataType,
      ShellTileData data,
      string id,
      Uri remoteUri,
      ref string xmlTemplateBuilderString,
      ref string xmlUriBuilderString)
    {
      TileUtils.ConstructXML(dataType, data, id, remoteUri, false, false, ref xmlTemplateBuilderString, ref xmlUriBuilderString);
    }

    private static void ConstructXML(
      DataType? dataType,
      ShellTileData data,
      string id,
      Uri remoteUri,
      bool isCreate,
      bool hasLarge,
      ref string xmlTemplateBuilderString,
      ref string xmlUriBuilderString)
    {
      StringBuilder tokenBuilder = new StringBuilder();
      StringBuilder xmlUriBuilder = new StringBuilder();
      if (!dataType.HasValue)
      {
        TileUtils.ConstructMangoXmlTemplateString(id, remoteUri, tokenBuilder, xmlUriBuilder);
      }
      else
      {
        DataType? nullable = dataType;
        if (nullable.HasValue)
        {
          switch (nullable.GetValueOrDefault())
          {
            case DataType.FlipData:
              TileUtils.ConstructFlipXmlTemplateString(id, (FlipTileData) data, isCreate, hasLarge, tokenBuilder, xmlUriBuilder);
              goto label_8;
            case DataType.IconicData:
              TileUtils.ConstructIconicXmlTemplateString(id, (IconicTileData) data, isCreate, hasLarge, tokenBuilder, xmlUriBuilder);
              goto label_8;
            case DataType.CycleData:
              TileUtils.ConstructCycleXmlTemplateString(id, (CycleTileData) data, isCreate, hasLarge, tokenBuilder, xmlUriBuilder);
              goto label_8;
          }
        }
        TileUtils.ConstructTemplate5XmlTemplateString(id, (StandardTileData) data, tokenBuilder, xmlUriBuilder);
      }
label_8:
      xmlTemplateBuilderString = tokenBuilder.ToString();
      xmlUriBuilderString = xmlUriBuilder.ToString();
    }

    private static void BuildXMLStart(
      StringBuilder tokenBuilder,
      string tokenId,
      string templateType,
      StringBuilder xmlUriBuilder)
    {
      tokenBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
      tokenBuilder.AppendLine("<PushNotification xmlns=\"http://Yamanote\">");
      if (!string.IsNullOrEmpty(tokenId))
        tokenBuilder.AppendLine(string.Format("<Token xmlns=\"\" TokenID=\"{0}\">", (object) ShellTile.ConvertToXMLFormat(tokenId)));
      else
        tokenBuilder.AppendLine("<Token xmlns=\"\" TokenID=\"\">");
      tokenBuilder.AppendLine(string.Format("<{0}>", (object) templateType));
      xmlUriBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
      xmlUriBuilder.AppendLine(string.Format("<TemplateType Name=\"{0}\">", (object) templateType));
    }

    private static void BuildXMLEnd(
      StringBuilder tokenBuilder,
      string templateType,
      StringBuilder xmlUriBuilder,
      bool fRemoteUri)
    {
      if (!fRemoteUri)
      {
        tokenBuilder.AppendLine(string.Format("</{0}>", (object) templateType));
        tokenBuilder.AppendLine("</Token>");
        tokenBuilder.AppendLine("</PushNotification>");
      }
      xmlUriBuilder.AppendLine("</TemplateType>");
    }

    private static bool AddImageURIXml(
      string uriXmlTag,
      Uri uri,
      StringBuilder xmlTemplateBuilder,
      StringBuilder xmlUriBuilder,
      bool canClear)
    {
      bool flag = false;
      if (uri == (Uri) null)
        return flag;
      URIType uriScheme = TileUtils.GetURIScheme(uri);
      string xmlFormat = ShellTile.ConvertToXMLFormat(uri.OriginalString);
      if (uriScheme == URIType.http)
      {
        flag = true;
        xmlUriBuilder.AppendLine(string.Format("<{0}>{1}</{0}>", (object) uriXmlTag, (object) xmlFormat));
      }
      else
      {
        string localFilePath = ShellTileData.GetLocalFilePath(uri);
        if (string.Compare(localFilePath, string.Empty) == 0)
        {
          if (canClear)
            xmlTemplateBuilder.AppendLine(string.Format("<{0}></{0}>", (object) uriXmlTag));
        }
        else
          xmlTemplateBuilder.AppendLine(string.Format("<{0} IsRelative=\"false\" IsResource=\"false\">{1}</{0}>", (object) uriXmlTag, (object) localFilePath));
      }
      return flag;
    }

    private static void AddNullableInt(string xmlTag, int? number, StringBuilder stringBuilder)
    {
      if (!number.HasValue)
        return;
      int? nullable = number;
      int num1 = 99;
      if ((nullable.GetValueOrDefault() > num1 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
      {
        stringBuilder.AppendLine(string.Format("<{0}>99</{0}>", (object) xmlTag));
      }
      else
      {
        nullable = number;
        int num2 = 0;
        if ((nullable.GetValueOrDefault() > num2 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
        {
          stringBuilder.AppendLine(string.Format("<{0}>{1}</{0}>", (object) xmlTag, (object) number.ToString()));
        }
        else
        {
          nullable = number;
          int num3 = 0;
          if ((nullable.GetValueOrDefault() == num3 ? (nullable.HasValue ? 1 : 0) : 0) == 0)
            return;
          stringBuilder.AppendLine(string.Format("<{0}></{0}>", (object) xmlTag));
        }
      }
    }

    private static void AddString(string xmlTag, string value, StringBuilder stringBuilder)
    {
      if (!string.IsNullOrEmpty(value))
      {
        stringBuilder.AppendLine(string.Format("<{0}>{1}</{0}>", (object) xmlTag, (object) ShellTile.ConvertToXMLFormat(value)));
      }
      else
      {
        if (string.Compare(value, string.Empty) != 0)
          return;
        stringBuilder.AppendLine(string.Format("<{0}></{0}>", (object) xmlTag));
      }
    }

    private static void AddColor(string xmlTag, Color color, StringBuilder stringBuilder)
    {
      if (color.A != byte.MaxValue)
      {
        stringBuilder.AppendLine(string.Format("<{0}></{0}>", (object) xmlTag));
      }
      else
      {
        StringBuilder stringBuilder1 = stringBuilder;
        object[] objArray = new object[4]
        {
          (object) xmlTag,
          null,
          null,
          null
        };
        byte num = color.R;
        objArray[1] = (object) num.ToString("X2");
        num = color.G;
        objArray[2] = (object) num.ToString("X2");
        num = color.B;
        objArray[3] = (object) num.ToString("X2");
        string str = string.Format("<{0}>#{1}{2}{3}</{0}>", objArray);
        stringBuilder1.AppendLine(str);
      }
    }

    private static void AddBool(string xmlTag, bool value, StringBuilder stringBuilder) => stringBuilder.AppendLine(string.Format("<{0}>{1}</{0}>", (object) xmlTag, (object) value));

    private static void ConstructMangoXmlTemplateString(
      string tokenId,
      Uri uri,
      StringBuilder tokenBuilder,
      StringBuilder xmlUriBuilder)
    {
      string templateType = "TemplateType5";
      TileUtils.BuildXMLStart(tokenBuilder, tokenId, templateType, xmlUriBuilder);
      bool fRemoteUri = TileUtils.AddImageURIXml("BackgroundImageURI", uri, tokenBuilder, xmlUriBuilder, false);
      TileUtils.BuildXMLEnd(tokenBuilder, templateType, xmlUriBuilder, fRemoteUri);
    }

    private static void ConstructTemplate5XmlTemplateString(
      string tokenId,
      StandardTileData data,
      StringBuilder tokenBuilder,
      StringBuilder xmlUriBuilder)
    {
      string templateType = "TemplateType5";
      bool fRemoteUri = false;
      TileUtils.BuildXMLStart(tokenBuilder, tokenId, templateType, xmlUriBuilder);
      TileUtils.AddNullableInt("Count", data.Count, tokenBuilder);
      if (TileUtils.AddImageURIXml("BackgroundImageURI", data.BackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("Title", data.Title, tokenBuilder);
      TileUtils.AddString("BackContent", data.BackContent, tokenBuilder);
      if (TileUtils.AddImageURIXml("BackBackgroundImageURI", data.BackBackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("BackTitle", data.BackTitle, tokenBuilder);
      TileUtils.BuildXMLEnd(tokenBuilder, templateType, xmlUriBuilder, fRemoteUri);
    }

    private static void ConstructFlipXmlTemplateString(
      string tokenId,
      FlipTileData data,
      bool isCreate,
      bool hasLarge,
      StringBuilder tokenBuilder,
      StringBuilder xmlUriBuilder)
    {
      string templateType = "TemplateFlip";
      bool fRemoteUri = false;
      TileUtils.BuildXMLStart(tokenBuilder, tokenId, templateType, xmlUriBuilder);
      if (TileUtils.AddImageURIXml("SmallImageURI", data.SmallBackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddNullableInt("Count", data.Count, tokenBuilder);
      if (TileUtils.AddImageURIXml("BackgroundImageURI", data.BackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("Title", data.Title, tokenBuilder);
      TileUtils.AddString("BackContent", data.BackContent, tokenBuilder);
      if (TileUtils.AddImageURIXml("BackBackgroundImageURI", data.BackBackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("BackTitle", data.BackTitle, tokenBuilder);
      if (isCreate)
        TileUtils.AddBool("HasLarge", hasLarge, tokenBuilder);
      if (TileUtils.AddImageURIXml("LargeBackgroundImageURI", data.WideBackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("LargeBackContent", data.WideBackContent, tokenBuilder);
      if (TileUtils.AddImageURIXml("LargeBackBackgroundImageURI", data.WideBackBackgroundImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.BuildXMLEnd(tokenBuilder, templateType, xmlUriBuilder, fRemoteUri);
    }

    private static void ConstructIconicXmlTemplateString(
      string tokenId,
      IconicTileData data,
      bool isCreate,
      bool hasLarge,
      StringBuilder tokenBuilder,
      StringBuilder xmlUriBuilder)
    {
      string templateType = "TemplateMetroCount";
      bool fRemoteUri = false;
      TileUtils.BuildXMLStart(tokenBuilder, tokenId, templateType, xmlUriBuilder);
      if (TileUtils.AddImageURIXml("SmallImageURI", data.SmallIconImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddNullableInt("Count", data.Count, tokenBuilder);
      if (TileUtils.AddImageURIXml("IconImageURI", data.IconImage, tokenBuilder, xmlUriBuilder, true))
        fRemoteUri = true;
      TileUtils.AddString("Title", data.Title, tokenBuilder);
      TileUtils.AddColor("BackgroundColor", data.BackgroundColor, tokenBuilder);
      if (isCreate)
        TileUtils.AddBool("HasLarge", hasLarge, tokenBuilder);
      TileUtils.AddString("LargeContent1", data.WideContent1, tokenBuilder);
      TileUtils.AddString("LargeContent2", data.WideContent2, tokenBuilder);
      TileUtils.AddString("LargeContent3", data.WideContent3, tokenBuilder);
      TileUtils.BuildXMLEnd(tokenBuilder, templateType, xmlUriBuilder, fRemoteUri);
    }

    private static void ConstructCycleXmlTemplateString(
      string tokenId,
      CycleTileData data,
      bool isCreate,
      bool hasLarge,
      StringBuilder tokenBuilder,
      StringBuilder xmlUriBuilder)
    {
      string templateType = "TemplateCycle";
      TileUtils.BuildXMLStart(tokenBuilder, tokenId, templateType, xmlUriBuilder);
      bool fRemoteUri = TileUtils.AddImageURIXml("SmallImageURI", data.SmallBackgroundImage, tokenBuilder, xmlUriBuilder, true);
      TileUtils.AddNullableInt("Count", data.Count, tokenBuilder);
      TileUtils.AddString("Title", data.Title, tokenBuilder);
      if (isCreate)
        TileUtils.AddBool("HasLarge", hasLarge, tokenBuilder);
      if (data.CycleImages != null)
      {
        int num = 1;
        foreach (Uri cycleImage in data.CycleImages)
        {
          TileUtils.AddImageURIXml(string.Format("Photo0{0}ImageURI", (object) num), cycleImage, tokenBuilder, xmlUriBuilder, true);
          ++num;
        }
      }
      TileUtils.BuildXMLEnd(tokenBuilder, templateType, xmlUriBuilder, fRemoteUri);
    }
  }
}
