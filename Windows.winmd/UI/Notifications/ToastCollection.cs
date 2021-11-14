// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Activatable(typeof (IToastCollectionFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class ToastCollection : IToastCollection
  {
    [MethodImpl]
    public extern ToastCollection(
      string collectionId,
      string displayName,
      string launchArgs,
      Uri iconUri);

    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string LaunchArgs { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Icon { [MethodImpl] get; [MethodImpl] set; }
  }
}
