// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (INotificationDataFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class NotificationData : INotificationData
  {
    [MethodImpl]
    public extern NotificationData();

    [MethodImpl]
    public extern NotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues,
      uint sequenceNumber);

    [MethodImpl]
    public extern NotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues);

    public extern IMap<string, string> Values { [MethodImpl] get; }

    public extern uint SequenceNumber { [MethodImpl] get; [MethodImpl] set; }
  }
}
