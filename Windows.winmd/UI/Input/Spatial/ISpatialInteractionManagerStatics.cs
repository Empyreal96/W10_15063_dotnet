// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(14884774, 36002, 12479, 145, 254, 217, 203, 74, 0, 137, 144)]
  [ExclusiveTo(typeof (SpatialInteractionManager))]
  internal interface ISpatialInteractionManagerStatics
  {
    SpatialInteractionManager GetForCurrentView();
  }
}
