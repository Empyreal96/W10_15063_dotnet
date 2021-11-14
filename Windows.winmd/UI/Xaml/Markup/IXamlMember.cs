// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlMember
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [Guid(3309434252, 17321, 16918, 183, 24, 224, 177, 27, 20, 233, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IXamlMember
  {
    bool IsAttachable { get; }

    bool IsDependencyProperty { get; }

    bool IsReadOnly { get; }

    string Name { get; }

    IXamlType TargetType { get; }

    IXamlType Type { get; }

    object GetValue(object instance);

    void SetValue(object instance, object value);
  }
}
