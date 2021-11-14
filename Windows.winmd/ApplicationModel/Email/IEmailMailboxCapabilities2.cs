// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCapabilities2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1769094884, 12065, 19644, 136, 171, 46, 118, 2, 164, 128, 107)]
  [ExclusiveTo(typeof (EmailMailboxCapabilities))]
  internal interface IEmailMailboxCapabilities2
  {
    bool CanResolveRecipients { get; }

    bool CanValidateCertificates { get; }

    bool CanEmptyFolder { get; }

    bool CanCreateFolder { get; }

    bool CanDeleteFolder { get; }

    bool CanMoveFolder { get; }
  }
}
