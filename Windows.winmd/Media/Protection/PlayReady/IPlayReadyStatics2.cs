// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(529361554, 24474, 16958, 148, 102, 179, 57, 105, 175, 122, 61)]
  internal interface IPlayReadyStatics2 : IPlayReadyStatics
  {
    uint PlayReadyCertificateSecurityLevel { get; }
  }
}
