// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalLocationFinderStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [WebHostHidden]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  public enum LocalLocationFinderStatus
  {
    Success,
    UnknownError,
    InvalidCredentials,
    InvalidCategory,
    InvalidSearchTerm,
    InvalidSearchArea,
    NetworkFailure,
    NotSupported,
  }
}
