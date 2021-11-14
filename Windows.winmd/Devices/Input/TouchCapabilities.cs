// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.TouchCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TouchCapabilities : ITouchCapabilities
  {
    [MethodImpl]
    public extern TouchCapabilities();

    public extern int TouchPresent { [MethodImpl] get; }

    public extern uint Contacts { [MethodImpl] get; }
  }
}
