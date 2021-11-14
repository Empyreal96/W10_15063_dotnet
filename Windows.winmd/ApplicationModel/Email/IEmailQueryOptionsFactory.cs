// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailQueryOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailQueryOptions))]
  [Guid(2297536952, 30891, 20200, 180, 227, 4, 109, 110, 47, 229, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailQueryOptionsFactory
  {
    EmailQueryOptions CreateWithText(string text);

    EmailQueryOptions CreateWithTextAndFields(
      string text,
      EmailQuerySearchFields fields);
  }
}
