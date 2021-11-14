// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerVisualizationSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (PointerVisualizationSettings))]
  [Guid(1753681627, 5723, 16916, 180, 243, 88, 78, 202, 140, 138, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerVisualizationSettingsStatics
  {
    PointerVisualizationSettings GetForCurrentView();
  }
}
