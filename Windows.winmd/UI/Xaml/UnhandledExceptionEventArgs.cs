// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UnhandledExceptionEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class UnhandledExceptionEventArgs : IUnhandledExceptionEventArgs
  {
    public extern HResult Exception { [MethodImpl] get; }

    public extern string Message { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
