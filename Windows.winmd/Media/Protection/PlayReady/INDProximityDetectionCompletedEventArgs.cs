// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDProximityDetectionCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDProximityDetectionCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(712008488, 55845, 20364, 158, 183, 93, 15, 195, 101, 139, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDProximityDetectionCompletedEventArgs
  {
    uint ProximityDetectionRetryCount { [Deprecated("INDProximityDetectionCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
