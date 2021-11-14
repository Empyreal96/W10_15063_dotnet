// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IconicTileData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Globalization;
using System.Security;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  public class IconicTileData : ShellTileData
  {
    private readonly TILE_PROPERTY_TYPE[] TILE_TEMPLATE_METROCOUNT_PROPERTIES = new TILE_PROPERTY_TYPE[10]
    {
      TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_TITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKGROUNDCOLOR,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_ICONIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT1,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT2,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT3,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SHOWONCREATE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_HASLARGE
    };
    private short TILE_TEMPLATE_METROCOUNT = 1;

    public IconicTileData()
    {
    }

    [SecuritySafeCritical]
    public IconicTileData(string xmlContent)
      : base(xmlContent)
    {
    }

    internal override void AssignProperties(TokenPropertiesForTile tokenProperties)
    {
      IconicTokenProperties icon = tokenProperties.icon;
      if (icon.fClearCount)
        this.Count = new int?(0);
      else if (!string.IsNullOrEmpty(icon.wstrCount))
        this.Count = new int?(Convert.ToInt32(icon.wstrCount));
      if (icon.fClearTitle)
        this.Title = string.Empty;
      else if (!string.IsNullOrEmpty(icon.wstrTitle))
        this.Title = icon.wstrTitle;
      if (icon.fClearSmallImg)
        this.SmallIconImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(icon.wstrSmallImg))
      {
        this.SmallIconImage = new Uri(icon.wstrSmallImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.SmallIconImage);
      }
      if (icon.fClearImg)
        this.IconImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(icon.wstrImg))
      {
        this.IconImage = new Uri(icon.wstrImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.IconImage);
      }
      if (icon.fClearContent1)
        this.WideContent1 = string.Empty;
      else if (!string.IsNullOrEmpty(icon.wstrContent1))
        this.WideContent1 = icon.wstrContent1;
      if (icon.fClearContent2)
        this.WideContent2 = string.Empty;
      else if (!string.IsNullOrEmpty(icon.wstrContent2))
        this.WideContent2 = icon.wstrContent2;
      if (icon.fClearContent3)
        this.WideContent3 = string.Empty;
      else if (!string.IsNullOrEmpty(icon.wstrContent3))
        this.WideContent3 = icon.wstrContent3;
      if (icon.fClearColor)
      {
        this.BackgroundColor = new Color() { A = (byte) 0 };
      }
      else
      {
        if (string.IsNullOrEmpty(icon.wstrColor))
          return;
        this.BackgroundColor = this.ConvertStringToColor(icon.wstrColor);
      }
    }

    private Color ConvertStringToColor(string stringColor)
    {
      if (stringColor.Length != 9 || !stringColor.StartsWith("#"))
        throw new ArgumentException("Wrong format for Color string. Color string has to have format #ARGB (ex.: #FF0ABB10)");
      Color color = new Color();
      color.A = byte.Parse(stringColor.Substring(1, 2), NumberStyles.HexNumber);
      if (color.A != byte.MaxValue)
        return color;
      color.R = byte.Parse(stringColor.Substring(3, 2), NumberStyles.HexNumber);
      color.G = byte.Parse(stringColor.Substring(5, 2), NumberStyles.HexNumber);
      color.B = byte.Parse(stringColor.Substring(7, 2), NumberStyles.HexNumber);
      return color;
    }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri SmallIconImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT, ValueConverter = "Microsoft.Phone.Shell.CountConverter")]
    public int? Count { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_ICONIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri IconImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKGROUNDCOLOR, ValueConverter = "Microsoft.Phone.Shell.ColorConverter")]
    public Color BackgroundColor { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT1, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string WideContent1 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT2, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string WideContent2 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGECONTENT3, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string WideContent3 { get; set; }

    internal override TILE_PROPERTY_TYPE[] TemplateTypeProperties => this.TILE_TEMPLATE_METROCOUNT_PROPERTIES;

    internal override short TemplateType => this.TILE_TEMPLATE_METROCOUNT;
  }
}
