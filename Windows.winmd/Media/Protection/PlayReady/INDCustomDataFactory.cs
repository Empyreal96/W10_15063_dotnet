// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDCustomDataFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (NDCustomData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3595830699, 13348, 18483, 140, 154, 175, 95, 222, 178, 40, 114)]
  [Deprecated("INDCustomDataFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface INDCustomDataFactory
  {
    [Deprecated("INDCustomDataFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDCustomData CreateInstance(byte[] customDataTypeIDBytes, byte[] customDataBytes);
  }
}
