// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3947912522, 38912, 18090, 177, 129, 123, 111, 15, 43, 145, 154)]
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataPackagePropertySet2
  {
    Uri ContentSourceWebLink { get; set; }

    Uri ContentSourceApplicationLink { get; set; }

    string PackageFamilyName { get; set; }

    IRandomAccessStreamReference Square30x30Logo { get; set; }

    Color LogoBackgroundColor { get; set; }
  }
}
