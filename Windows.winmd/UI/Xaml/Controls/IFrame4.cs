// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2602025498, 48427, 18944, 153, 235, 148, 107, 233, 97, 128, 132)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Frame))]
  internal interface IFrame4
  {
    [Overload("SetNavigationStateWithNavigationControl")]
    void SetNavigationState(string navigationState, bool suppressNavigate);
  }
}
