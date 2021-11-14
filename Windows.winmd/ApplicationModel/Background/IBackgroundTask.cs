// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2098451764, 64786, 17358, 140, 34, 234, 31, 241, 60, 6, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IBackgroundTask
  {
    void Run(IBackgroundTaskInstance taskInstance);
  }
}
