// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IEncryptedAndAuthenticatedData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (EncryptedAndAuthenticatedData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1873031143, 7883, 19200, 190, 165, 96, 184, 63, 134, 47, 23)]
  internal interface IEncryptedAndAuthenticatedData
  {
    IBuffer EncryptedData { get; }

    IBuffer AuthenticationTag { get; }
  }
}
