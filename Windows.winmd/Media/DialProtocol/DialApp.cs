// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DialApp : IDialApp
  {
    public extern string AppName { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppLaunchResult> RequestLaunchAsync(
      string appArgument);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppStopResult> StopAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppStateDetails> GetAppStateAsync();
  }
}
