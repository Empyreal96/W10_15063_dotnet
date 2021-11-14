// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationDataFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (NotificationData))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(599909178, 7184, 18171, 128, 64, 222, 195, 132, 98, 28, 248)]
  internal interface INotificationDataFactory
  {
    [Overload("CreateNotificationDataWithValuesAndSequenceNumber")]
    NotificationData CreateNotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues,
      uint sequenceNumber);

    [Overload("CreateNotificationDataWithValues")]
    NotificationData CreateNotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues);
  }
}
