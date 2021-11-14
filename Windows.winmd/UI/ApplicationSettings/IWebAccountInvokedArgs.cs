// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountInvokedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountInvokedArgs))]
  [Guid(3886795840, 41432, 19549, 154, 127, 29, 52, 178, 249, 10, 210)]
  internal interface IWebAccountInvokedArgs
  {
    WebAccountAction Action { get; }
  }
}
