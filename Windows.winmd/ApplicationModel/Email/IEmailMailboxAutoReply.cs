// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxAutoReply
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxAutoReply))]
  [Guid(3793954124, 35508, 18523, 179, 31, 4, 209, 84, 118, 189, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxAutoReply
  {
    bool IsEnabled { get; set; }

    string Response { get; set; }
  }
}
