// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDispatcherTimer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3512782406, 52514, 20319, 140, 151, 64, 230, 29, 163, 226, 220)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DispatcherTimer))]
  internal interface IDispatcherTimer
  {
    TimeSpan Interval { get; set; }

    bool IsEnabled { get; }

    event EventHandler<object> Tick;

    void Start();

    void Stop();
  }
}
