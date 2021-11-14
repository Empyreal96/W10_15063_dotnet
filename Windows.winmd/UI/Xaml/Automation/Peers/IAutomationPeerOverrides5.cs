// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AutomationPeer))]
  [Guid(746880133, 30750, 18935, 159, 239, 185, 225, 77, 1, 71, 7)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAutomationPeerOverrides5
  {
    bool IsPeripheralCore();

    bool IsDataValidForFormCore();

    string GetFullDescriptionCore();

    IIterable<AutomationPeer> GetDescribedByCore();

    IIterable<AutomationPeer> GetFlowsToCore();

    IIterable<AutomationPeer> GetFlowsFromCore();
  }
}
