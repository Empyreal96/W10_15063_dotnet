// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomEditBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class VpnCustomEditBox : IVpnCustomEditBox, IVpnCustomPrompt
  {
    [MethodImpl]
    public extern VpnCustomEditBox();

    public extern string DefaultText { [MethodImpl] set; [MethodImpl] get; }

    public extern bool NoEcho { [MethodImpl] set; [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }

    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Bordered { [MethodImpl] set; [MethodImpl] get; }
  }
}
