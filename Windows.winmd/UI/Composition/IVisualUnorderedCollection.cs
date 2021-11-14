// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisualUnorderedCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualUnorderedCollection))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(865053296, 21704, 16551, 128, 41, 201, 206, 235, 10, 162, 80)]
  internal interface IVisualUnorderedCollection : IIterable<Visual>
  {
    int Count { get; }

    void Add(Visual newVisual);

    void Remove(Visual visual);

    void RemoveAll();
  }
}
