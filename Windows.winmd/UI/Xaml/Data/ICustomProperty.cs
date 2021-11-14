// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICustomProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  [Guid(819630784, 9192, 17056, 174, 124, 115, 74, 14, 93, 39, 130)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICustomProperty
  {
    TypeName Type { get; }

    string Name { get; }

    object GetValue(object target);

    void SetValue(object target, object value);

    object GetIndexedValue(object target, object index);

    void SetIndexedValue(object target, object value, object index);

    bool CanWrite { get; }

    bool CanRead { get; }
  }
}
