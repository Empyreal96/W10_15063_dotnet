// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FocusSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FocusSettings : IFocusSettings
  {
    [MethodImpl]
    public extern FocusSettings();

    public extern FocusMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern AutoFocusRange AutoFocusRange { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> Value { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<ManualFocusDistance> Distance { [MethodImpl] get; [MethodImpl] set; }

    public extern bool WaitForFocus { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DisableDriverFallback { [MethodImpl] get; [MethodImpl] set; }
  }
}
