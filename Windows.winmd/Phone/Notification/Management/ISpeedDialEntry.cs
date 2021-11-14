// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ISpeedDialEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(2453714651, 34604, 18140, 182, 42, 190, 69, 65, 177, 102, 248)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (SpeedDialEntry))]
  internal interface ISpeedDialEntry
  {
    string PhoneNumber { get; }

    string NumberType { get; }

    string ContactName { get; }
  }
}
