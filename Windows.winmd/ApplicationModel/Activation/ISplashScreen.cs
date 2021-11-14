// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ISplashScreen
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3394082652, 54486, 17392, 151, 192, 8, 51, 198, 57, 28, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplashScreen))]
  internal interface ISplashScreen
  {
    Rect ImageLocation { get; }

    event TypedEventHandler<SplashScreen, object> Dismissed;
  }
}
