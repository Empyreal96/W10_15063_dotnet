// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailManagerForUser : IEmailManagerForUser
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    public extern User User { [MethodImpl] get; }
  }
}
