// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.CreateSnapshotCompletedEventArgs
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Maps.Controls
{
  internal sealed class CreateSnapshotCompletedEventArgs : AsyncCompletedEventArgs
  {
    private WriteableBitmap bitmap;

    internal CreateSnapshotCompletedEventArgs(Exception error, bool cancelled, object userState)
      : base(error, cancelled, userState)
    {
    }

    internal CreateSnapshotCompletedEventArgs(WriteableBitmap bitmap, object userState)
      : base((Exception) null, false, userState)
    {
      this.Bitmap = bitmap;
    }

    public WriteableBitmap Bitmap
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return this.bitmap;
      }
      private set => this.bitmap = value;
    }
  }
}
