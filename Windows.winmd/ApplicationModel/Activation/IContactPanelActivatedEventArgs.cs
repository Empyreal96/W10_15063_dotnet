// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(1388012516, 54228, 19299, 128, 81, 74, 242, 8, 44, 171, 128)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IContactPanelActivatedEventArgs
  {
    ContactPanel ContactPanel { get; }

    Contact Contact { get; }
  }
}
