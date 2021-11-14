// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.CycleTileData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Microsoft.Phone.Shell
{
  public class CycleTileData : ShellTileData
  {
    private readonly TILE_PROPERTY_TYPE[] TILE_TEMPLATE_CYCLE_PROPERTIES = new TILE_PROPERTY_TYPE[14]
    {
      TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_TITLE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO01IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO02IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO03IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO04IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO05IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO06IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO07IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO08IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO09IMAGEURI,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_SHOWONCREATE,
      TILE_PROPERTY_TYPE.TILE_PROPERTY_HASLARGE
    };
    private short TILE_TEMPLATE_CYCLE = 14;
    private IEnumerable<Uri> cycleImages = (IEnumerable<Uri>) new Uri[9];

    public CycleTileData()
    {
    }

    [SecuritySafeCritical]
    public CycleTileData(string xmlContent)
      : base(xmlContent)
    {
    }

    internal override void AssignProperties(TokenPropertiesForTile tokenProperties)
    {
      CycleTokenProperties cycle = tokenProperties.cycle;
      if (cycle.fClearCount)
        this.Count = new int?(0);
      else if (!string.IsNullOrEmpty(cycle.wstrCount))
        this.Count = new int?(Convert.ToInt32(cycle.wstrCount));
      if (cycle.fClearTitle)
        this.Title = string.Empty;
      else if (!string.IsNullOrEmpty(cycle.wstrTitle))
        this.Title = cycle.wstrTitle;
      if (cycle.fClearSmallImg)
        this.SmallBackgroundImage = new Uri(string.Empty, UriKind.Relative);
      else if (!string.IsNullOrEmpty(cycle.wstrSmallImg))
      {
        this.SmallBackgroundImage = new Uri(cycle.wstrSmallImg, UriKind.RelativeOrAbsolute);
        this.CheckForInvalidPath(this.SmallBackgroundImage);
      }
      if (cycle.ClearImg == null && cycle.wstrImages == null)
        return;
      Uri[] uriArray = new Uri[9];
      for (int index = 0; index < 9; ++index)
      {
        if (cycle.ClearImg[index])
          uriArray[index] = new Uri(string.Empty, UriKind.Relative);
        else if (!string.IsNullOrEmpty(cycle.wstrImages[index]))
        {
          uriArray[index] = new Uri(cycle.wstrImages[index], UriKind.RelativeOrAbsolute);
          this.CheckForInvalidPath(uriArray[index]);
        }
      }
      this.CycleImages = (IEnumerable<Uri>) uriArray;
    }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_SMALLIMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    public Uri SmallBackgroundImage { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_COUNT, ValueConverter = "Microsoft.Phone.Shell.CountConverter")]
    public int? Count { get; set; }

    public IEnumerable<Uri> CycleImages
    {
      get => this.cycleImages;
      set
      {
        this.cycleImages = value;
        if (this.cycleImages == null)
          return;
        int count = this.cycleImages.Count<Uri>();
        if (count < 1)
          return;
        if (count > 9)
          throw new ArgumentException("Number of CycleImages cannot be more than " + (object) 9);
        this.AssignImages(count);
      }
    }

    private void CheckRemote(Uri uri)
    {
      if (uri != (Uri) null && TileUtils.GetURIScheme(uri) == URIType.http)
        throw new ArgumentException("Cycle images can only have local URIs");
    }

    private void AssignImages(int count)
    {
      if (count > 0 && this.cycleImages.ElementAt<Uri>(0) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(0);
        this.CheckRemote(uri);
        this.CycleImage01 = uri;
      }
      if (count > 1 && this.cycleImages.ElementAt<Uri>(1) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(1);
        this.CheckRemote(uri);
        this.CycleImage02 = uri;
      }
      if (count > 2 && this.cycleImages.ElementAt<Uri>(2) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(2);
        this.CheckRemote(uri);
        this.CycleImage03 = uri;
      }
      if (count > 3 && this.cycleImages.ElementAt<Uri>(3) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(3);
        this.CheckRemote(uri);
        this.CycleImage04 = uri;
      }
      if (count > 4 && this.cycleImages.ElementAt<Uri>(4) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(4);
        this.CheckRemote(uri);
        this.CycleImage05 = uri;
      }
      if (count > 5 && this.cycleImages.ElementAt<Uri>(5) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(5);
        this.CheckRemote(uri);
        this.CycleImage06 = uri;
      }
      if (count > 6 && this.cycleImages.ElementAt<Uri>(6) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(6);
        this.CheckRemote(uri);
        this.CycleImage07 = uri;
      }
      if (count > 7 && this.cycleImages.ElementAt<Uri>(7) != (Uri) null)
      {
        Uri uri = this.cycleImages.ElementAt<Uri>(7);
        this.CheckRemote(uri);
        this.CycleImage08 = uri;
      }
      if (count <= 8 || !(this.cycleImages.ElementAt<Uri>(8) != (Uri) null))
        return;
      Uri uri1 = this.cycleImages.ElementAt<Uri>(8);
      this.CheckRemote(uri1);
      this.CycleImage09 = uri1;
    }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO01IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage01 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO02IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage02 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO03IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage03 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO04IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage04 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO05IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage05 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO06IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage06 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO07IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage07 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO08IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage08 { get; set; }

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_PHOTO09IMAGEURI, ValueConverter = "Microsoft.Phone.Shell.UriToLocalStoreConverter")]
    internal Uri CycleImage09 { get; set; }

    internal override TILE_PROPERTY_TYPE[] TemplateTypeProperties => this.TILE_TEMPLATE_CYCLE_PROPERTIES;

    internal override short TemplateType => this.TILE_TEMPLATE_CYCLE;
  }
}
