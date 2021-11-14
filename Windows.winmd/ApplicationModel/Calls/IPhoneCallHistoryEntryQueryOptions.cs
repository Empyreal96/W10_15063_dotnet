// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(2623529308, 35821, 16586, 176, 110, 196, 202, 142, 174, 92, 135)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryQueryOptions))]
  internal interface IPhoneCallHistoryEntryQueryOptions
  {
    PhoneCallHistoryEntryQueryDesiredMedia DesiredMedia { get; set; }

    IVector<string> SourceIds { get; }
  }
}
