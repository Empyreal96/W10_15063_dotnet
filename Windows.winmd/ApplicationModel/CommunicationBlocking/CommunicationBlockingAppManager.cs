// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAppManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.CommunicationBlocking
{
  [Static(typeof (ICommunicationBlockingAppManagerStatics), 65536, "Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICommunicationBlockingAppManagerStatics2), 131072, "Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  public static class CommunicationBlockingAppManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestSetAsActiveBlockingAppAsync();

    public static extern bool IsCurrentAppActiveBlockingApp { [MethodImpl] get; }

    [MethodImpl]
    public static extern void ShowCommunicationBlockingSettingsUI();
  }
}
