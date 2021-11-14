// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IAppListEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppListEntry))]
  [Guid(4009816191, 8456, 18698, 135, 122, 138, 159, 23, 194, 95, 173)]
  internal interface IAppListEntry
  {
    AppDisplayInfo DisplayInfo { get; }

    [RemoteAsync]
    IAsyncOperation<bool> LaunchAsync();
  }
}
