// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.CameraOperationCompletedEventArgs
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

using System;

namespace Microsoft.Devices
{
  public class CameraOperationCompletedEventArgs : EventArgs
  {
    public CameraOperationCompletedEventArgs(bool succeeded, Exception exception)
    {
      this.Exception = exception;
      this.Succeeded = succeeded;
    }

    public Exception Exception { get; private set; }

    public bool Succeeded { get; private set; }
  }
}
