// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplication2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2575729147, 6838, 19327, 190, 74, 154, 6, 69, 34, 76, 4)]
  [ExclusiveTo(typeof (CoreApplication))]
  internal interface ICoreApplication2
  {
    event EventHandler<BackgroundActivatedEventArgs> BackgroundActivated;

    event EventHandler<LeavingBackgroundEventArgs> LeavingBackground;

    event EventHandler<EnteredBackgroundEventArgs> EnteredBackground;

    void EnablePrelaunch(bool value);
  }
}
