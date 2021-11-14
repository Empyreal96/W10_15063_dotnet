// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptOptionSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnCustomPromptOptionSelector : 
    IVpnCustomPromptOptionSelector,
    IVpnCustomPromptElement
  {
    [MethodImpl]
    public extern VpnCustomPromptOptionSelector();

    public extern IVector<string> Options { [MethodImpl] get; }

    public extern uint SelectedIndex { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
