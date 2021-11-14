// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IStylesProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(442202647, 31745, 19436, 156, 212, 45, 250, 125, 194, 70, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStylesProvider
  {
    string ExtendedProperties { get; }

    Color FillColor { get; }

    Color FillPatternColor { get; }

    string FillPatternStyle { get; }

    string Shape { get; }

    int StyleId { get; }

    string StyleName { get; }
  }
}
