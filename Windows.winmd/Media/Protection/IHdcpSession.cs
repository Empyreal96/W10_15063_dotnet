// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IHdcpSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(1904756201, 25815, 17005, 128, 155, 27, 228, 97, 148, 26, 42)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (HdcpSession))]
  internal interface IHdcpSession : IClosable
  {
    bool IsEffectiveProtectionAtLeast(HdcpProtection protection);

    IReference<HdcpProtection> GetEffectiveProtection();

    [RemoteAsync]
    IAsyncOperation<HdcpSetProtectionResult> SetDesiredMinProtectionAsync(
      HdcpProtection protection);

    event TypedEventHandler<HdcpSession, object> ProtectionChanged;
  }
}
