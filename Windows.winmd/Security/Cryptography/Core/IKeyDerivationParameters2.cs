// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParameters2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3443615441, 16766, 20300, 182, 102, 192, 216, 121, 243, 248, 224)]
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyDerivationParameters2
  {
    Capi1KdfTargetAlgorithm Capi1KdfTargetAlgorithm { get; set; }
  }
}
