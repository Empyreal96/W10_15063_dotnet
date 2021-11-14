// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(243543508, 55724, 17901, 154, 30, 116, 206, 5, 107, 38, 53)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage5
  {
    [RemoteAsync]
    IAsyncOperation<IVector<PackageContentGroup>> GetContentGroupsAsync();

    [RemoteAsync]
    IAsyncOperation<PackageContentGroup> GetContentGroupAsync(
      string name);

    [Overload("StageContentGroupsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names);

    [RemoteAsync]
    [Overload("StageContentGroupsWithPriorityAsync")]
    IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names,
      bool moveToHeadOfQueue);

    [RemoteAsync]
    IAsyncOperation<bool> SetInUseAsync(bool inUse);
  }
}
