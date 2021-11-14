// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.ImageProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ImageProperties : IImageProperties, IStorageItemExtraProperties
  {
    public extern uint Rating { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Keywords { [MethodImpl] get; }

    public extern DateTime DateTaken { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> Latitude { [MethodImpl] get; }

    public extern IReference<double> Longitude { [MethodImpl] get; }

    public extern string CameraManufacturer { [MethodImpl] get; [MethodImpl] set; }

    public extern string CameraModel { [MethodImpl] get; [MethodImpl] set; }

    public extern PhotoOrientation Orientation { [MethodImpl] get; }

    public extern IVectorView<string> PeopleNames { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    [RemoteAsync]
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
