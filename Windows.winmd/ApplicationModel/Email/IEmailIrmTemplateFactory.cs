// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmTemplateFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1034098806, 34616, 17432, 185, 203, 71, 27, 147, 111, 231, 30)]
  [ExclusiveTo(typeof (EmailIrmTemplate))]
  internal interface IEmailIrmTemplateFactory
  {
    EmailIrmTemplate Create(string id, string name, string description);
  }
}
