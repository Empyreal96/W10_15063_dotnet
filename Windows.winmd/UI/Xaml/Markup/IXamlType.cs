// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2032200369, 41701, 18330, 189, 80, 108, 239, 60, 11, 73, 112)]
  [WebHostHidden]
  public interface IXamlType
  {
    IXamlType BaseType { get; }

    IXamlMember ContentProperty { get; }

    string FullName { get; }

    bool IsArray { get; }

    bool IsCollection { get; }

    bool IsConstructible { get; }

    bool IsDictionary { get; }

    bool IsMarkupExtension { get; }

    bool IsBindable { get; }

    IXamlType ItemType { get; }

    IXamlType KeyType { get; }

    TypeName UnderlyingType { get; }

    object ActivateInstance();

    object CreateFromString(string value);

    IXamlMember GetMember(string name);

    void AddToVector(object instance, object value);

    void AddToMap(object instance, object key, object value);

    void RunInitializer();
  }
}
