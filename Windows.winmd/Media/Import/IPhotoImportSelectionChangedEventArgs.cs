// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSelectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(273028994, 64157, 19504, 139, 201, 77, 100, 145, 21, 114, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportSelectionChangedEventArgs))]
  internal interface IPhotoImportSelectionChangedEventArgs
  {
    bool IsSelectionEmpty { get; }
  }
}
