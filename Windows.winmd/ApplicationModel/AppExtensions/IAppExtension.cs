// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtension
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.AppExtensions
{
  [Guid(2219872300, 5613, 20399, 147, 234, 34, 55, 187, 248, 203, 214)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppExtension))]
  internal interface IAppExtension
  {
    string Id { get; }

    string DisplayName { get; }

    string Description { get; }

    Package Package { get; }

    AppInfo AppInfo { get; }

    [RemoteAsync]
    IAsyncOperation<IPropertySet> GetExtensionPropertiesAsync();

    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetPublicFolderAsync();
  }
}
