// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Package))]
  [Guid(1705955758, 47451, 17676, 136, 43, 98, 85, 24, 127, 57, 126)]
  internal interface IPackage4
  {
    PackageSignatureKind SignatureKind { get; }

    bool IsOptional { get; }

    [RemoteAsync]
    IAsyncOperation<bool> VerifyContentIntegrityAsync();
  }
}
