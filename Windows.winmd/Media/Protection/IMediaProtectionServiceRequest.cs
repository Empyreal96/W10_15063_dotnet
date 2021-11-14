// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2984119974, 8340, 18317, 135, 164, 139, 149, 32, 15, 133, 198)]
  public interface IMediaProtectionServiceRequest
  {
    Guid ProtectionSystem { get; }

    Guid Type { get; }
  }
}
