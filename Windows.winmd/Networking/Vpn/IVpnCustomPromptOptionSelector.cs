// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptOptionSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnCustomPromptOptionSelector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(999240921, 36545, 20117, 154, 78, 123, 166, 77, 56, 243, 48)]
  internal interface IVpnCustomPromptOptionSelector : IVpnCustomPromptElement
  {
    IVector<string> Options { get; }

    uint SelectedIndex { get; }
  }
}
