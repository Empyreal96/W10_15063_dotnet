// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStyle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [Guid(3299471909, 40375, 19069, 182, 209, 247, 78, 219, 146, 147, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Style))]
  [WebHostHidden]
  internal interface IStyle
  {
    bool IsSealed { get; }

    SetterBaseCollection Setters { get; }

    TypeName TargetType { get; set; }

    Style BasedOn { get; set; }

    void Seal();
  }
}
