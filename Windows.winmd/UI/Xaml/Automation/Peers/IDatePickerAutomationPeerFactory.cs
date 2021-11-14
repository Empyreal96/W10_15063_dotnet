// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IDatePickerAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatePickerAutomationPeer))]
  [WebHostHidden]
  [Guid(3848699161, 37207, 17462, 159, 77, 127, 185, 145, 116, 180, 142)]
  internal interface IDatePickerAutomationPeerFactory
  {
    DatePickerAutomationPeer CreateInstanceWithOwner(
      DatePicker owner,
      object outer,
      out object inner);
  }
}
