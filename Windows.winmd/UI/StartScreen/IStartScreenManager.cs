// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IStartScreenManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.StartScreen
{
  [Guid(1243466699, 9961, 20148, 137, 51, 133, 158, 182, 236, 219, 41)]
  [ExclusiveTo(typeof (StartScreenManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IStartScreenManager
  {
    User User { get; }

    bool SupportsAppListEntry(AppListEntry appListEntry);

    [RemoteAsync]
    IAsyncOperation<bool> ContainsAppListEntryAsync(AppListEntry appListEntry);

    IAsyncOperation<bool> RequestAddAppListEntryAsync(AppListEntry appListEntry);
  }
}
