// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [Static(typeof (IEmailManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IEmailManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IEmailManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class EmailManager
  {
    [MethodImpl]
    public static extern EmailManagerForUser GetForUser(User user);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);
  }
}
