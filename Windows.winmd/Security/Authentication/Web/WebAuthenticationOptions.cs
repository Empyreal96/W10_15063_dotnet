// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAuthenticationOptions : uint
  {
    None = 0,
    SilentMode = 1,
    UseTitle = 2,
    UseHttpPost = 4,
    UseCorporateNetwork = 8,
  }
}
