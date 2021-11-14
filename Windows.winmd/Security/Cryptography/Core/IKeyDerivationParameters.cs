// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  [Guid(2079349095, 1147, 19084, 150, 74, 70, 159, 253, 85, 34, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyDerivationParameters
  {
    IBuffer KdfGenericBinary { get; set; }

    uint IterationCount { get; }
  }
}
