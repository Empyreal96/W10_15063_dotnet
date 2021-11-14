// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailIrmTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailIrmTemplate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4079449485, 21613, 19434, 169, 99, 84, 163, 139, 44, 192, 22)]
  internal interface IEmailIrmTemplate
  {
    string Id { get; set; }

    string Description { get; set; }

    string Name { get; set; }
  }
}
