// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialRecognitionEndedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(238417355, 16245, 17395, 172, 129, 209, 220, 45, 249, 177, 251)]
  [ExclusiveTo(typeof (SpatialRecognitionEndedEventArgs))]
  internal interface ISpatialRecognitionEndedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
