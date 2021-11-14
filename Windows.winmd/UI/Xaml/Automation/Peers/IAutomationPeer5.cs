// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4130529734, 2623, 17780, 159, 239, 205, 193, 81, 118, 86, 116)]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeer5
  {
    bool IsPeripheral();

    bool IsDataValidForForm();

    string GetFullDescription();
  }
}
