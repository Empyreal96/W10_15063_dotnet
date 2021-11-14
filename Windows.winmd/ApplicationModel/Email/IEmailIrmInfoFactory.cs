// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailIrmInfo))]
  [Guid(827044236, 58342, 19835, 190, 141, 145, 169, 99, 17, 176, 27)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailIrmInfoFactory
  {
    EmailIrmInfo Create(DateTime expiration, EmailIrmTemplate irmTemplate);
  }
}
