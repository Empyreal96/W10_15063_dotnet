// Decompiled with JetBrains decompiler
// Type: Windows.System.Display.DisplayRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Display
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [Threading(ThreadingModel.STA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DisplayRequest : IDisplayRequest
  {
    [MethodImpl]
    public extern DisplayRequest();

    [MethodImpl]
    public extern void RequestActive();

    [MethodImpl]
    public extern void RequestRelease();
  }
}
