// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.WebAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [Activatable(typeof (IWebAccountFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class WebAccount : IWebAccount, IWebAccount2
  {
    [MethodImpl]
    public extern WebAccount(
      WebAccountProvider webAccountProvider,
      string userName,
      WebAccountState state);

    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    public extern string UserName { [MethodImpl] get; }

    public extern WebAccountState State { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern IMapView<string, string> Properties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetPictureAsync(
      WebAccountPictureSize desizedSize);

    [Overload("SignOutAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SignOutAsync();

    [RemoteAsync]
    [Overload("SignOutWithClientIdAsync")]
    [MethodImpl]
    public extern IAsyncAction SignOutAsync(string clientId);
  }
}
