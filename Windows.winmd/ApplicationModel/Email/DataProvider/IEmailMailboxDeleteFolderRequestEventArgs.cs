// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDeleteFolderRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(3033738502, 9010, 18040, 131, 120, 40, 181, 121, 51, 104, 70)]
  [ExclusiveTo(typeof (EmailMailboxDeleteFolderRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxDeleteFolderRequestEventArgs
  {
    EmailMailboxDeleteFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
