// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnCustomPromptText : IVpnCustomPromptText, IVpnCustomPromptElement
  {
    [MethodImpl]
    public extern VpnCustomPromptText();

    public extern string Text { [MethodImpl] set; [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
