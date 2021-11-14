// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ICortanaTileNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3691971029, 5257, 18107, 183, 59, 127, 144, 6, 126, 207, 39)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (CortanaTileNotificationTriggerDetails))]
  internal interface ICortanaTileNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    string TileId { get; }

    string Content { get; }

    string LargeContent1 { get; }

    string LargeContent2 { get; }

    string EmphasizedText { get; }

    string NonWrappedSmallContent1 { get; }

    string NonWrappedSmallContent2 { get; }

    string NonWrappedSmallContent3 { get; }

    string NonWrappedSmallContent4 { get; }

    string Source { get; }
  }
}
