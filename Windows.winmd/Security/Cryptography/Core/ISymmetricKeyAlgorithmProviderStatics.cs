// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2369463078, 7991, 18719, 182, 14, 245, 67, 27, 38, 180, 131)]
  [ExclusiveTo(typeof (SymmetricKeyAlgorithmProvider))]
  internal interface ISymmetricKeyAlgorithmProviderStatics
  {
    SymmetricKeyAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
