﻿// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IPhoneLineDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3003963261, 327, 18828, 130, 65, 191, 12, 171, 198, 10, 37)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (PhoneLineDetails))]
  internal interface IPhoneLineDetails2
  {
    uint MissedCallCount { get; }
  }
}
