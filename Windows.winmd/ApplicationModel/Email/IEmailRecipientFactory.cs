// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailRecipient))]
  [Guid(1426110541, 51098, 20216, 185, 9, 114, 46, 24, 227, 147, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailRecipientFactory
  {
    EmailRecipient Create(string address);

    EmailRecipient CreateWithName(string address, string name);
  }
}
