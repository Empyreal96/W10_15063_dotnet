// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteraction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialInteraction))]
  [Guid(4237719097, 35046, 17990, 145, 18, 67, 68, 170, 236, 157, 250)]
  internal interface ISpatialInteraction
  {
    SpatialInteractionSourceState SourceState { get; }
  }
}
