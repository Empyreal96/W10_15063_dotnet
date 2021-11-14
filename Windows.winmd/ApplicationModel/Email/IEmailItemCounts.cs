// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailItemCounts
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1540436769, 65224, 19371, 131, 186, 11, 175, 60, 31, 108, 189)]
  [ExclusiveTo(typeof (EmailItemCounts))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailItemCounts
  {
    uint Flagged { get; }

    uint Important { get; }

    uint Total { get; }

    uint Unread { get; }
  }
}
