// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ConnectTileImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  public sealed class ConnectTileImage : IConnectTileImage
  {
    [MethodImpl]
    public extern ConnectTileImage();

    public extern string ImageUrl { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetImageAsync();

    [MethodImpl]
    public extern IAsyncAction SetImageAsync(IInputStream stream);

    public extern IRandomAccessStreamReference Image { [MethodImpl] get; }
  }
}
