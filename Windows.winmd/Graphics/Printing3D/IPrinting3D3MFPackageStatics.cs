// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3D3MFPackageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3D3MFPackage))]
  [Guid(1884871087, 31386, 18311, 184, 23, 246, 244, 89, 33, 72, 35)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3D3MFPackageStatics
  {
    [RemoteAsync]
    IAsyncOperation<Printing3D3MFPackage> LoadAsync(
      IRandomAccessStream value);
  }
}
