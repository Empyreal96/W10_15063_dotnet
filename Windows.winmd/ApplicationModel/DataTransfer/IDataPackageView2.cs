// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(1089256085, 9296, 19485, 182, 180, 237, 69, 70, 61, 238, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackageView))]
  internal interface IDataPackageView2
  {
    [RemoteAsync]
    IAsyncOperation<Uri> GetApplicationLinkAsync();

    [RemoteAsync]
    IAsyncOperation<Uri> GetWebLinkAsync();
  }
}
