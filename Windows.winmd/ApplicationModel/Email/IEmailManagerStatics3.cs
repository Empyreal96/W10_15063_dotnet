// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1248994197, 33854, 18757, 179, 170, 52, 158, 7, 163, 98, 197)]
  internal interface IEmailManagerStatics3
  {
    EmailManagerForUser GetForUser(User user);
  }
}
