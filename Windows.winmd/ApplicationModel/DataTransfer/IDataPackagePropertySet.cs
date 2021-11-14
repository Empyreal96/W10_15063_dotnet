// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet
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
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  [Guid(3441202155, 19532, 17466, 168, 211, 245, 194, 65, 233, 22, 137)]
  [HasVariant]
  internal interface IDataPackagePropertySet : 
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    string Title { get; set; }

    string Description { get; set; }

    IRandomAccessStreamReference Thumbnail { get; set; }

    IVector<string> FileTypes { get; }

    string ApplicationName { get; set; }

    Uri ApplicationListingUri { get; set; }
  }
}
