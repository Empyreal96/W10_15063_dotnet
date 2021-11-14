// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSession2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSession))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(710043408, 16070, 18077, 163, 117, 43, 159, 71, 133, 57, 30)]
  internal interface IPhotoImportSession2
  {
    PhotoImportSubfolderDateFormat SubfolderDateFormat { set; get; }

    bool RememberDeselectedItems { set; get; }
  }
}
