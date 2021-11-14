// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashComputation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (CryptographicHash))]
  [Guid(1493488054, 44337, 17923, 163, 164, 177, 189, 169, 142, 37, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHashComputation
  {
    void Append(IBuffer data);

    IBuffer GetValueAndReset();
  }
}
