// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionPMPServerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ExclusiveTo(typeof (MediaProtectionPMPServer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1613532766, 63442, 18558, 175, 145, 219, 196, 37, 43, 33, 130)]
  internal interface IMediaProtectionPMPServerFactory
  {
    MediaProtectionPMPServer CreatePMPServer(IPropertySet pProperties);
  }
}
