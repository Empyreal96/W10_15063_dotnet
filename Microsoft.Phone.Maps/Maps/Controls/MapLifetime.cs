// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapLifetime
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows.Controls;

namespace Microsoft.Phone.Maps.Controls
{
  internal abstract class MapLifetime
  {
    private bool isInVisualTree;

    public IMapModel MapModel { get; protected set; }

    public void OnApplyTemplate(Border presentationContainer) => this.OnLoaded(presentationContainer);

    public void OnLoaded(Border presentationContainer)
    {
      if (this.isInVisualTree)
        return;
      this.isInVisualTree = true;
      this.OnEnterVisualTree(presentationContainer);
    }

    public void OnUnloaded()
    {
      if (!this.isInVisualTree)
        return;
      this.isInVisualTree = false;
      this.OnExitVisualTree();
    }

    public virtual void OnAfterLoaded()
    {
    }

    protected abstract void OnEnterVisualTree(Border presentationContainer);

    protected abstract void OnExitVisualTree();
  }
}
