// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class AccessKeyInvokedEventArgs : IAccessKeyInvokedEventArgs
  {
    [MethodImpl]
    public extern AccessKeyInvokedEventArgs();

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
