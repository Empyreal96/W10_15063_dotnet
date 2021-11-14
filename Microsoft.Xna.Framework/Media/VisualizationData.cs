// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.VisualizationData
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Media
{
  public class VisualizationData
  {
    internal float[] frequencies;
    internal float[] samples;
    private ReadOnlyCollection<float> frequenciesCollection;
    private ReadOnlyCollection<float> samplesCollection;

    public VisualizationData()
    {
      this.frequencies = new float[256];
      this.samples = new float[256];
      this.frequenciesCollection = new ReadOnlyCollection<float>((IList<float>) this.frequencies);
      this.samplesCollection = new ReadOnlyCollection<float>((IList<float>) this.samples);
    }

    public ReadOnlyCollection<float> Frequencies => this.frequenciesCollection;

    public ReadOnlyCollection<float> Samples => this.samplesCollection;
  }
}
