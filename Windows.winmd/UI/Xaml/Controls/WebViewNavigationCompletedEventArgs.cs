// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class WebViewNavigationCompletedEventArgs : IWebViewNavigationCompletedEventArgs
  {
    public extern Uri Uri { [MethodImpl] get; }

    public extern bool IsSuccess { [MethodImpl] get; }

    public extern WebErrorStatus WebErrorStatus { [MethodImpl] get; }
  }
}
