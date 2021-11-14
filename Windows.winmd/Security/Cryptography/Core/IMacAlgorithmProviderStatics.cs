// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (MacAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3384656199, 52343, 19952, 158, 78, 185, 33, 224, 128, 100, 76)]
  internal interface IMacAlgorithmProviderStatics
  {
    MacAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
