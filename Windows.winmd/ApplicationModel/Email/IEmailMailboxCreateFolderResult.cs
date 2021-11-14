// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxCreateFolderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2988987775, 10373, 18840, 181, 149, 138, 45, 55, 76, 233, 80)]
  [ExclusiveTo(typeof (EmailMailboxCreateFolderResult))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IEmailMailboxCreateFolderResult
  {
    EmailMailboxCreateFolderStatus Status { get; }

    EmailFolder Folder { get; }
  }
}
