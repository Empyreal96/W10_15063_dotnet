// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialGestureRecognizerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialGestureRecognizer))]
  [Guid(1998668166, 22457, 12624, 131, 130, 105, 139, 36, 226, 100, 208)]
  internal interface ISpatialGestureRecognizerFactory
  {
    SpatialGestureRecognizer Create(SpatialGestureSettings settings);
  }
}
