// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IAnnotationProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(2512000023, 17463, 17691, 148, 97, 5, 10, 73, 181, 157, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAnnotationProvider
  {
    int AnnotationTypeId { get; }

    string AnnotationTypeName { get; }

    string Author { get; }

    string DateTime { get; }

    IRawElementProviderSimple Target { get; }
  }
}
