// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionPMPServer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaProtectionPMPServer))]
  [Guid(202445350, 31526, 19761, 149, 187, 156, 27, 8, 239, 127, 192)]
  internal interface IMediaProtectionPMPServer
  {
    IPropertySet Properties { get; }
  }
}
