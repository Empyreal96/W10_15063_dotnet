// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialApp))]
  [Guid(1432353747, 17847, 18931, 187, 215, 48, 45, 182, 8, 70, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDialApp
  {
    string AppName { get; }

    [RemoteAsync]
    IAsyncOperation<DialAppLaunchResult> RequestLaunchAsync(
      string appArgument);

    [RemoteAsync]
    IAsyncOperation<DialAppStopResult> StopAsync();

    [RemoteAsync]
    IAsyncOperation<DialAppStateDetails> GetAppStateAsync();
  }
}
