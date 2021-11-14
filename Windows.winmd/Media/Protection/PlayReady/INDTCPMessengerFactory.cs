// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDTCPMessengerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2111331582, 7065, 20328, 143, 130, 129, 119, 247, 206, 223, 43)]
  [ExclusiveTo(typeof (NDTCPMessenger))]
  [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface INDTCPMessengerFactory
  {
    [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDTCPMessenger CreateInstance(string remoteHostName, uint remoteHostPort);
  }
}
