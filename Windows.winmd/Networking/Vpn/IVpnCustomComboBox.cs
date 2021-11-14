// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomComboBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2586056078, 56225, 19567, 130, 112, 220, 243, 201, 118, 28, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnCustomComboBox))]
  internal interface IVpnCustomComboBox : IVpnCustomPrompt
  {
    IVectorView<string> OptionsText { set; get; }

    uint Selected { get; }
  }
}
