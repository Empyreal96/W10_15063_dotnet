// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ILeavingBackgroundEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(969338010, 44654, 18169, 160, 122, 207, 194, 63, 136, 115, 62)]
  public interface ILeavingBackgroundEventArgs
  {
    Deferral GetDeferral();
  }
}
