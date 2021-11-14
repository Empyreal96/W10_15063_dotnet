// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionTarget
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(2713626810, 55078, 18019, 129, 41, 107, 94, 121, 39, 255, 166)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionTarget))]
  [WebHostHidden]
  internal interface ICompositionTarget
  {
    Visual Root { get; set; }
  }
}
