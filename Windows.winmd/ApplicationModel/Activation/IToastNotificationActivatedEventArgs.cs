// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(2460512130, 21136, 17181, 190, 133, 196, 170, 238, 184, 104, 95)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IToastNotificationActivatedEventArgs : IActivatedEventArgs
  {
    string Argument { get; }

    ValueSet UserInput { get; }
  }
}
