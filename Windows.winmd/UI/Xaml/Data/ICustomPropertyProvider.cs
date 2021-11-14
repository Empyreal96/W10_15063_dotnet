// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICustomPropertyProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2089965397, 15944, 17076, 134, 119, 118, 55, 34, 103, 3, 63)]
  public interface ICustomPropertyProvider
  {
    ICustomProperty GetCustomProperty(string name);

    ICustomProperty GetIndexedProperty(string name, TypeName type);

    string GetStringRepresentation();

    TypeName Type { get; }
  }
}
