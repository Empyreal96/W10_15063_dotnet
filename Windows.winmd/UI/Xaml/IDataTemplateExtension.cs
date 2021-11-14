// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateExtension
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1499370823, 52735, 19346, 183, 115, 171, 57, 104, 120, 243, 83)]
  public interface IDataTemplateExtension
  {
    void ResetTemplate();

    bool ProcessBinding(uint phase);

    int ProcessBindings(ContainerContentChangingEventArgs arg);
  }
}
