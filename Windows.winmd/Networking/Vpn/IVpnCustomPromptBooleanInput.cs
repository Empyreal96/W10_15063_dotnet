// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptBooleanInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3301549726, 65351, 17703, 159, 39, 164, 146, 146, 1, 153, 121)]
  [ExclusiveTo(typeof (VpnCustomPromptBooleanInput))]
  internal interface IVpnCustomPromptBooleanInput : IVpnCustomPromptElement
  {
    bool InitialValue { set; get; }

    bool Value { get; }
  }
}
