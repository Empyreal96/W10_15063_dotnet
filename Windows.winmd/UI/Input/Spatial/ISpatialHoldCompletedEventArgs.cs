// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialHoldCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(1063536395, 19709, 17370, 141, 196, 230, 69, 82, 23, 57, 113)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialHoldCompletedEventArgs))]
  internal interface ISpatialHoldCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
