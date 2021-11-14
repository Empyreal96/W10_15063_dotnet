// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSidecar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSidecar))]
  [Guid(1188550487, 63490, 17607, 156, 152, 122, 113, 244, 188, 20, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportSidecar
  {
    string Name { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }
  }
}
