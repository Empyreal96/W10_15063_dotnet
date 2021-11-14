// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxEmptyFolderRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxEmptyFolderRequestEventArgs))]
  [Guid(1904473220, 39002, 19136, 179, 63, 238, 14, 38, 39, 163, 192)]
  internal interface IEmailMailboxEmptyFolderRequestEventArgs
  {
    EmailMailboxEmptyFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
