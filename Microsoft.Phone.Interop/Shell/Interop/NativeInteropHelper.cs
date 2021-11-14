// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeInteropHelper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Windows.Media;

namespace Microsoft.Phone.Shell.Interop
{
  internal class NativeInteropHelper
  {
    public const string AppChromeDll = "AppChromeAPI.dll";
    public const string PlatformInteropDll = "PlatformInterop.dll";

    public static uint ConvertToWin32Color(Color color)
    {
      int num1 = (int) color.A << 24;
      int num2 = (int) color.R << 16;
      int num3 = (int) color.G << 8;
      int b = (int) color.B;
      int num4 = num2;
      return (uint) (num1 + num4 + num3 + b);
    }

    public static Color ConvertToSilverlightColor(uint color) => new Color()
    {
      A = (byte) (color >> 24),
      R = (byte) (color >> 16),
      G = (byte) (color >> 8),
      B = (byte) color
    };
  }
}
