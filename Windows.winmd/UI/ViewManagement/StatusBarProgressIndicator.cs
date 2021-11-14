// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.StatusBarProgressIndicator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StatusBarProgressIndicator : IStatusBarProgressIndicator
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction HideAsync();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> ProgressValue { [MethodImpl] get; [MethodImpl] set; }
  }
}
