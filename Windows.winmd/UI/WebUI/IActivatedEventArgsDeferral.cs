// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IActivatedEventArgsDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [Guid(3396165492, 25538, 17574, 185, 123, 217, 160, 60, 32, 188, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IActivatedEventArgsDeferral
  {
    ActivatedOperation ActivatedOperation { get; }
  }
}
