// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class WebViewSettings : IWebViewSettings
  {
    public extern bool IsJavaScriptEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsIndexedDBEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
