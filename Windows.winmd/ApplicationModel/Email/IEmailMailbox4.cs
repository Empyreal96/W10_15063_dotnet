// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailbox4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1562325019, 61986, 18599, 183, 182, 113, 99, 86, 205, 38, 161)]
  [ExclusiveTo(typeof (EmailMailbox))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailbox4
  {
    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();
  }
}
