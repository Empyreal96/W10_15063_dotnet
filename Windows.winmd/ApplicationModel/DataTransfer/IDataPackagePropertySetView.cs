// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackagePropertySetView))]
  [Guid(3108826113, 3098, 19543, 190, 85, 117, 208, 18, 137, 115, 93)]
  [HasVariant]
  internal interface IDataPackagePropertySetView : 
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    string Title { get; }

    string Description { get; }

    RandomAccessStreamReference Thumbnail { get; }

    IVectorView<string> FileTypes { get; }

    string ApplicationName { get; }

    Uri ApplicationListingUri { get; }
  }
}
