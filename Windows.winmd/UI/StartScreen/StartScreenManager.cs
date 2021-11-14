// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.StartScreenManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.StartScreen
{
  [Static(typeof (IStartScreenManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class StartScreenManager : IStartScreenManager
  {
    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern bool SupportsAppListEntry(AppListEntry appListEntry);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ContainsAppListEntryAsync(
      AppListEntry appListEntry);

    [MethodImpl]
    public extern IAsyncOperation<bool> RequestAddAppListEntryAsync(
      AppListEntry appListEntry);

    [MethodImpl]
    public static extern StartScreenManager GetDefault();

    [MethodImpl]
    public static extern StartScreenManager GetForUser(User user);
  }
}
