// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailRecipient))]
  [Guid(3404211635, 17528, 18452, 185, 0, 201, 2, 181, 225, 155, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailRecipient
  {
    string Name { get; set; }

    string Address { get; set; }
  }
}
