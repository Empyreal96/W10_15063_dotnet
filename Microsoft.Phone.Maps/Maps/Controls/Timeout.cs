// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.Timeout
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class Timeout
  {
    private readonly Action action;
    private readonly DispatcherTimer timer = new DispatcherTimer();

    public Timeout(Action action, long timeout)
    {
      this.action = action;
      this.timer.Tick += new EventHandler(this.OnTimeout);
      this.timer.Interval = TimeSpan.FromTicks(timeout);
      this.timer.Start();
    }

    public void DoItNow()
    {
      if (!this.timer.IsEnabled)
        return;
      this.OnTimeout((object) this, (EventArgs) null);
    }

    public void Cancel()
    {
      this.timer.Tick -= new EventHandler(this.OnTimeout);
      if (!this.timer.IsEnabled)
        return;
      this.timer.Stop();
    }

    private void OnTimeout(object sender, EventArgs e)
    {
      this.action();
      this.timer.Tick -= new EventHandler(this.OnTimeout);
      this.timer.Stop();
    }
  }
}
