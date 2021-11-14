// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationCanceledEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3461365468, 59557, 18160, 146, 212, 60, 18, 43, 53, 17, 42)]
  [ExclusiveTo(typeof (SpatialNavigationCanceledEventArgs))]
  internal interface ISpatialNavigationCanceledEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
