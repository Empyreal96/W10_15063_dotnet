// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.UriMapper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Markup;

namespace System.Windows.Navigation
{
  [ContentProperty("UriMappings")]
  public sealed class UriMapper : UriMapperBase
  {
    public UriMapper() => this.UriMappings = new Collection<UriMapping>();

    public Collection<UriMapping> UriMappings { get; private set; }

    public override Uri MapUri(Uri uri)
    {
      Collection<UriMapping> uriMappings = this.UriMappings;
      if (uriMappings == null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UriMapper_MustNotHaveANullUriMappingCollection, (object) nameof (UriMapper), (object) "UriMappings"));
      Guard.ArgumentNotNull((object) uri, nameof (uri));
      foreach (UriMapping uriMapping in uriMappings)
      {
        Uri uri1 = uriMapping.MapUri(uri);
        if (uri1 != (Uri) null)
          return uri1;
      }
      return uri;
    }
  }
}
