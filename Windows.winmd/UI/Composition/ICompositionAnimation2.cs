// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionAnimation))]
  [Guid(916152382, 43023, 18760, 147, 227, 237, 35, 251, 56, 198, 203)]
  [WebHostHidden]
  internal interface ICompositionAnimation2
  {
    void SetBooleanParameter(string key, bool value);

    string Target { get; set; }
  }
}
