// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChangedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxChangedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2006611137, 38853, 19284, 179, 13, 48, 98, 50, 98, 62, 109)]
  internal interface IEmailMailboxChangedDeferral
  {
    void Complete();
  }
}
