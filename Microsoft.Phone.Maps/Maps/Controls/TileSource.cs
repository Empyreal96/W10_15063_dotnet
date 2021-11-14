// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.TileSource
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Microsoft.Phone.Maps.Controls
{
  public class TileSource
  {
    public const string UriSchemeUriFragment = "{UriScheme}";
    public const string QuadKeyUriFragment = "{quadkey}";
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Subdomain is correct")]
    public const string SubdomainUriFragment = "{subdomain}";
    public const string XUriFragment = "{x}";
    public const string YUriFragment = "{y}";
    public const string ZoomLevelUriFragment = "{zoomlevel}";
    private const string InternalQuadKeyUriFragment = "{QUADKEY}";
    private const string InternalSubdomainUriFragment = "{SUBDOMAIN}";
    private const string InternalXUriFragment = "{X}";
    private const string InternalYUriFragment = "{Y}";
    private const string InternalZoomLevelUriFragment = "{ZOOMLEVEL}";
    private volatile string convertedUriFormat;
    private string[][] subdomainsList;
    private int maxX;
    private int maxY;
    private string uriFormat;
    private Lazy<ITileSourceModel> lazyTileSourceModel;

    public TileSource()
    {
      this.subdomainsList = new string[2][]
      {
        new string[4]{ "0", "2", "4", "6" },
        new string[4]{ "1", "3", "5", "7" }
      };
      this.maxX = 2;
      this.maxY = 4;
      this.lazyTileSourceModel = new Lazy<ITileSourceModel>(new Func<ITileSourceModel>(this.CreateTileSourceModelInstance));
    }

    [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Justification = "UriFormats are not URIs, they're strings")]
    public TileSource(string uriFormat)
      : this()
    {
      this.UriFormat = uriFormat;
    }

    [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Justification = "UriFormats are not URIs, they're strings")]
    public TileSource(string uriFormat, LocationRectangle boundingRectangle)
      : this(uriFormat)
    {
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      this.BoundingRectangle = boundingRectangle.IsValid ? boundingRectangle : throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
    }

    [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Justification = "UriFormats are not URIs, they're strings")]
    public TileSource(string uriFormat, int minZoomLevel, int maxZoomLevel)
      : this(uriFormat)
    {
      this.ZoomRange = minZoomLevel <= maxZoomLevel ? new Range<int>(minZoomLevel, maxZoomLevel) : throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LessThanExceptionFormat, (object) minZoomLevel, (object) maxZoomLevel));
    }

    [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Justification = "UriFormats are not URIs, they're strings")]
    public TileSource(
      string uriFormat,
      LocationRectangle boundingRectangle,
      int minZoomLevel,
      int maxZoomLevel)
      : this(uriFormat)
    {
      if (minZoomLevel > maxZoomLevel)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LessThanExceptionFormat, (object) minZoomLevel, (object) maxZoomLevel));
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      this.BoundingRectangle = boundingRectangle.IsValid ? boundingRectangle : throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
      this.ZoomRange = new Range<int>(minZoomLevel, maxZoomLevel);
    }

    [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = "UriFormats are not URIs, they're strings")]
    public string UriFormat
    {
      get => this.uriFormat;
      set
      {
        if (!(this.uriFormat != value))
          return;
        this.uriFormat = value;
        this.convertedUriFormat = TileSource.ReplaceString(TileSource.ReplaceString(TileSource.ReplaceString(TileSource.ReplaceString(TileSource.ReplaceString(TileSource.ReplaceString(value, "{UriScheme}", Uri.UriSchemeHttp), "{quadkey}", "{QUADKEY}"), "{subdomain}", "{SUBDOMAIN}"), "{x}", "{X}"), "{y}", "{Y}"), "{zoomlevel}", "{ZOOMLEVEL}");
      }
    }

    internal ITileSourceModel TileSourceModel => this.lazyTileSourceModel.Value;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Property is being set; we want to leave the getter in")]
    private LocationRectangle BoundingRectangle
    {
      get => this.TileSourceModel.BoundingRectangle;
      set => this.TileSourceModel.BoundingRectangle = value;
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Property is being set; we want to leave the getter in")]
    private Range<int> ZoomRange
    {
      get => this.TileSourceModel.ZoomRange;
      set => this.TileSourceModel.ZoomRange = value;
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "x, y are correct")]
    public virtual Uri GetUri(int x, int y, int zoomLevel)
    {
      if (string.IsNullOrEmpty(this.convertedUriFormat))
        return (Uri) null;
      return new Uri(this.convertedUriFormat.Replace("{QUADKEY}", new QuadKey(x, y, zoomLevel).Key).Replace("{SUBDOMAIN}", this.GetSubdomain(x, y)).Replace("{X}", x.ToString((IFormatProvider) CultureInfo.InvariantCulture)).Replace("{Y}", y.ToString((IFormatProvider) CultureInfo.InvariantCulture)).Replace("{ZOOMLEVEL}", zoomLevel.ToString((IFormatProvider) CultureInfo.InvariantCulture)));
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Subdomain is correct")]
    public virtual string GetSubdomain(QuadKey quadKey) => this.GetSubdomain(quadKey.X, quadKey.Y);

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "subdomains is correct")]
    public void SetSubdomains(string[][] subdomains)
    {
      if (subdomains != null)
      {
        int num = subdomains.Length != 0 && subdomains[0].Length != 0 ? subdomains[0].Length : throw new ArgumentException(Resources.SubdomainsEmptyException, nameof (subdomains));
        foreach (string[] subdomain in subdomains)
        {
          if (subdomain.Length != num)
            throw new ArgumentException(Resources.SubdomainsVariedLengthException, nameof (subdomains));
          foreach (string str in subdomain)
          {
            if (str == null)
              throw new ArgumentException(Resources.SubdomainNullException, nameof (subdomains));
          }
        }
        this.subdomainsList = subdomains;
        this.maxX = subdomains.Length;
        this.maxY = num;
      }
      else
        this.subdomainsList = (string[][]) null;
    }

    private static string ReplaceString(string input, string pattern, string replacement) => Regex.Replace(input, pattern, replacement, RegexOptions.IgnoreCase);

    private ITileSourceModel CreateTileSourceModelInstance() => (ITileSourceModel) new MOSTileSource(new TileSourceCallbacks()
    {
      GetUriCallbackEventHandler = new TileSourceCallbackDelegates.GetUriCallback(this.GetUri)
    });

    private string GetSubdomain(int x, int y) => this.subdomainsList == null ? string.Empty : this.subdomainsList[x % this.maxX][y % this.maxY];
  }
}
