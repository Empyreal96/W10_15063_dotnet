// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (AsymmetricKeyAlgorithmProvider))]
  [Guid(1113316888, 42995, 18342, 168, 210, 196, 141, 96, 51, 166, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAsymmetricKeyAlgorithmProviderStatics
  {
    AsymmetricKeyAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
