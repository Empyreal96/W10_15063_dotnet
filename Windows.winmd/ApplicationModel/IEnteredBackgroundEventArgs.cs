// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IEnteredBackgroundEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(4146257090, 38951, 16445, 170, 237, 236, 202, 154, 193, 115, 152)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IEnteredBackgroundEventArgs
  {
    Deferral GetDeferral();
  }
}
