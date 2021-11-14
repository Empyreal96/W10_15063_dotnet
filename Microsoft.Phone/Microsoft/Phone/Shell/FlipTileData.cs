// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.FlipTileData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Shell
{
  public class FlipTileData : StandardTileData
  {
    private readonly TILE_PROPERTY_TYPE[] TILE_TEMPLATE_FLIP_PROPERTIES = new TILE_PROPERTY_TYPE[12]
    {
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_TITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKBACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKTITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_BACKCONTENT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKCONTENT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKBACKGROUNDIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SHOWONCREATE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_HASLARGE
    };
    private short TILE_TEMPLATE_FLIP = 5;

    public FlipTileData() => this.isFlip = true;

    [SecuritySafeCritical]
    public FlipTileData(string xmlContent)
    {
      this.isFlip = true;
      this.Parse(xmlContent);
    }

    internal override void AssignProperties(TokenPropertiesForTile tokenProperties)
    {
      base.AssignProperties(tokenProperties);
      PrimaryTokenProperties primary = tokenProperties.flip.primary;
      ExtendedTokenProperties extended = tokenProperties.flip.extended;
      if (primary.fClearSmallImg)
        this.SmallBackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(primary.wstrSmallImg))
      {
        this.SmallBackgroundImage = new Uri(primary.wstrSmallImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.SmallBackgroundImage);
      }
      if (primary.fClearWideImg)
        this.WideBackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(primary.wstrWideImg))
      {
        this.WideBackgroundImage = new Uri(primary.wstrWideImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.WideBackgroundImage);
      }
      if (extended.fClearWideImg)
        this.WideBackBackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(extended.wstrWideImg))
      {
        this.WideBackBackgroundImage = new Uri(extended.wstrWideImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.WideBackBackgroundImage);
      }
      if (extended.fClearWideBackgroundContent)
      {
        this.WideBackContent = string.Empty;
      }
      else
      {
        if (string.IsNullOrEmpty(extended.wstrWideBackContent))
          return;
        this.WideBackContent = extended.wstrWideBackContent;
      }
    }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri SmallBackgroundImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKGROUNDIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri WideBackgroundImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKCONTENT, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string WideBackContent { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_LARGEBACKBACKGROUNDIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri WideBackBackgroundImage { get; set; }

    internal override TILE_PROPERTY_TYPE[] TemplateTypeProperties => this.TILE_TEMPLATE_FLIP_PROPERTIES;

    internal override short TemplateType => this.TILE_TEMPLATE_FLIP;
  }
}
