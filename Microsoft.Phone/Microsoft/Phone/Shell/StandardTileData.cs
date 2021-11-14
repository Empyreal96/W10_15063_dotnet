// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.StandardTileData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Shell
{
  public class StandardTileData : ShellTileData
  {
    private short TILE_TEMPLATE_FLIP = 5;
    private readonly TILE_PROPERTY_TYPE[] TILE_TEMPLATE_TEMPLATE5_PROPERTIES = new TILE_PROPERTY_TYPE[7]
    {
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_TITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SHOWONCREATE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKBACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKTITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKCONTENT
    };
    internal bool isFlip;

    public StandardTileData()
    {
    }

    [SecuritySafeCritical]
    public StandardTileData(string xmlContent)
      : base(xmlContent)
    {
    }

    internal override void AssignProperties(TokenPropertiesForTile tokenProperties)
    {
      PrimaryTokenProperties primary = tokenProperties.flip.primary;
      ExtendedTokenProperties extended = tokenProperties.flip.extended;
      if (primary.fClearCount)
        this.Count = new int?(0);
      else if (!string.IsNullOrEmpty(primary.wstrCount))
        this.Count = new int?(Convert.ToInt32(primary.wstrCount));
      if (primary.fClearTitle)
        this.Title = string.Empty;
      else if (!string.IsNullOrEmpty(primary.wstrTitle))
        this.Title = primary.wstrTitle;
      if (primary.fClearImg)
        this.BackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(primary.wstrImg))
      {
        this.BackgroundImage = new Uri(primary.wstrImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.BackgroundImage);
      }
      if (extended.fClearImg)
        this.BackBackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(extended.wstrImg))
      {
        this.BackBackgroundImage = new Uri(extended.wstrImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.BackBackgroundImage);
      }
      if (extended.fClearBackgroundContent)
        this.BackContent = string.Empty;
      else if (!string.IsNullOrEmpty(extended.wstrBackContent))
        this.BackContent = extended.wstrBackContent;
      if (extended.fClearTitle)
      {
        this.BackTitle = string.Empty;
      }
      else
      {
        if (string.IsNullOrEmpty(extended.wstrTitle))
          return;
        this.BackTitle = extended.wstrTitle;
      }
    }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT, ValueConverter = "Microsoft.Phone.Shell.CountConverter")]
    public int? Count { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKGROUNDIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri BackgroundImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKCONTENT, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string BackContent { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKTITLE, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string BackTitle { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKBACKGROUNDIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri BackBackgroundImage { get; set; }

    internal override short TemplateType => this.TILE_TEMPLATE_FLIP;

    internal override TILE_PROPERTY_TYPE[] TemplateTypeProperties => this.TILE_TEMPLATE_TEMPLATE5_PROPERTIES;
  }
}
