// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(170002810, 2588, 17467, 148, 24, 185, 73, 138, 235, 22, 3)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmProvider))]
  internal interface IKeyDerivationAlgorithmProviderStatics
  {
    KeyDerivationAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
