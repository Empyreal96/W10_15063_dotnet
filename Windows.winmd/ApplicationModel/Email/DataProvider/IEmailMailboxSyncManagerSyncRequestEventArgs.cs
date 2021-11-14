// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxSyncManagerSyncRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxSyncManagerSyncRequestEventArgs))]
  [Guid(1134166810, 36812, 19173, 185, 181, 212, 52, 224, 166, 90, 168)]
  internal interface IEmailMailboxSyncManagerSyncRequestEventArgs
  {
    EmailMailboxSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
