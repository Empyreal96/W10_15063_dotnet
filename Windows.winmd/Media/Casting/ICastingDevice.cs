// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingDevice))]
  [Guid(3732020355, 19011, 19153, 166, 210, 36, 146, 167, 150, 195, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICastingDevice
  {
    string Id { get; }

    string FriendlyName { get; }

    IRandomAccessStreamWithContentType Icon { get; }

    [RemoteAsync]
    IAsyncOperation<CastingPlaybackTypes> GetSupportedCastingPlaybackTypesAsync();

    CastingConnection CreateCastingConnection();
  }
}
