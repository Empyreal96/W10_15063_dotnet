// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxMoveFolderRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailMailboxMoveFolderRequestEventArgs))]
  [Guid(945958944, 5306, 19592, 134, 152, 114, 57, 227, 200, 170, 167)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxMoveFolderRequestEventArgs
  {
    EmailMailboxMoveFolderRequest Request { get; }

    Deferral GetDeferral();
  }
}
