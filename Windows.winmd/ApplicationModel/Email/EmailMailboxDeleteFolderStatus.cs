// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxDeleteFolderStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum EmailMailboxDeleteFolderStatus
  {
    Success,
    NetworkError,
    PermissionsError,
    ServerError,
    UnknownFailure,
    CouldNotDeleteEverything,
  }
}
