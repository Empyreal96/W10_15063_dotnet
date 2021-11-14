// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITransformProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2036797405, 63145, 19045, 175, 23, 134, 29, 183, 153, 162, 218)]
  public interface ITransformProvider
  {
    bool CanMove { get; }

    bool CanResize { get; }

    bool CanRotate { get; }

    void Move(double x, double y);

    void Resize(double width, double height);

    void Rotate(double degrees);
  }
}
