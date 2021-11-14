// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Calls
{
  [Guid(4023678192, 41691, 16776, 158, 146, 188, 60, 250, 104, 19, 207)]
  [ExclusiveTo(typeof (PhoneCallHistoryManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneCallHistoryManagerStatics2
  {
    PhoneCallHistoryManagerForUser GetForUser(User user);
  }
}
