// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccount2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [Guid(2069288696, 39179, 20149, 148, 167, 86, 33, 243, 168, 184, 36)]
  [ExclusiveTo(typeof (WebAccount))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccount2 : IWebAccount
  {
    string Id { get; }

    IMapView<string, string> Properties { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetPictureAsync(
      WebAccountPictureSize desizedSize);

    [Overload("SignOutAsync")]
    [RemoteAsync]
    IAsyncAction SignOutAsync();

    [Overload("SignOutWithClientIdAsync")]
    [RemoteAsync]
    IAsyncAction SignOutAsync(string clientId);
  }
}
