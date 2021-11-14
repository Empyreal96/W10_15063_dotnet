// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IWebAccountProviderActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Provider;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1924601716, 39146, 19663, 151, 82, 70, 217, 5, 16, 4, 241)]
  public interface IWebAccountProviderActivatedEventArgs : IActivatedEventArgs
  {
    IWebAccountProviderOperation Operation { get; }
  }
}
