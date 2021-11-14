// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackagePropertySetView))]
  [Guid(1616138395, 36542, 20459, 156, 30, 117, 230, 157, 229, 75, 132)]
  internal interface IDataPackagePropertySetView2
  {
    string PackageFamilyName { get; }

    Uri ContentSourceWebLink { get; }

    Uri ContentSourceApplicationLink { get; }

    IRandomAccessStreamReference Square30x30Logo { get; }

    Color LogoBackgroundColor { get; }
  }
}
