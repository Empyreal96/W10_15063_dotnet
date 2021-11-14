// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (WebAccountProvider))]
  [Guid(1241639685, 20034, 16852, 181, 24, 224, 8, 165, 22, 54, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProvider2 : IWebAccountProvider
  {
    string DisplayPurpose { get; }

    string Authority { get; }
  }
}
