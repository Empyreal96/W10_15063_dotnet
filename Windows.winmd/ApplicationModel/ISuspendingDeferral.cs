// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(1494484233, 35785, 20148, 182, 54, 218, 189, 196, 244, 111, 102)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISuspendingDeferral
  {
    void Complete();
  }
}
