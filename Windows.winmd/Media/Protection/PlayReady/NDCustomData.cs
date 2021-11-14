// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCustomData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("NDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (INDCustomDataFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDCustomData : INDCustomData
  {
    [Deprecated("INDCustomDataFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDCustomData(byte[] customDataTypeIDBytes, byte[] customDataBytes);

    public extern byte[] CustomDataTypeID { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern byte[] CustomData { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
