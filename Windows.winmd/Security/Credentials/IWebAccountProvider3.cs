// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (WebAccountProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3659288971, 38669, 19785, 130, 92, 242, 112, 111, 140, 167, 254)]
  internal interface IWebAccountProvider3 : IWebAccountProvider2, IWebAccountProvider
  {
    User User { get; }
  }
}
