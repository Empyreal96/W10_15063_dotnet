// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationPeer))]
  [Guid(1981605714, 29633, 20292, 190, 117, 67, 196, 158, 192, 212, 213)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IAutomationPeer4
  {
    AutomationLandmarkType GetLandmarkType();

    string GetLocalizedLandmarkType();
  }
}
