// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomComboBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnCustomComboBox : IVpnCustomComboBox, IVpnCustomPrompt
  {
    [MethodImpl]
    public extern VpnCustomComboBox();

    public extern IVectorView<string> OptionsText { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Selected { [MethodImpl] get; }

    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Bordered { [MethodImpl] set; [MethodImpl] get; }
  }
}
