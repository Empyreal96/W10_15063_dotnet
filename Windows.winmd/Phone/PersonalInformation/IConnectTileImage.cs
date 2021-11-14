// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IConnectTileImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ConnectTileImage))]
  [Guid(2460479418, 18882, 18882, 148, 79, 126, 115, 119, 91, 224, 124)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IConnectTileImage
  {
    string ImageUrl { get; set; }

    IAsyncOperation<IRandomAccessStream> GetImageAsync();

    IAsyncAction SetImageAsync(IInputStream stream);

    IRandomAccessStreamReference Image { get; }
  }
}
