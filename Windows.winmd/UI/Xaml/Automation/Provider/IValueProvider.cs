// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IValueProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(545699751, 44046, 18385, 171, 155, 42, 100, 41, 42, 253, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IValueProvider
  {
    bool IsReadOnly { get; }

    string Value { get; }

    void SetValue(string value);
  }
}
