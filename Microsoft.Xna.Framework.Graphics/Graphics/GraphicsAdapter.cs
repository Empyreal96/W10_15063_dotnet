// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsAdapter
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class GraphicsAdapter
  {
    internal static uint pComHandle = UnsafeNativeMethods.Adapter.CreateHandle(out GraphicsAdapter._desc);
    private static ReadOnlyCollection<GraphicsAdapter> _adapters;
    private static DisplayModeCollection _supportedDisplayModes;
    private static DisplayMode _currentDisplayMode;
    private static bool _isWidescreen;
    private static GraphicsAdapter.CleanupHelper _cleanupHelper = new GraphicsAdapter.CleanupHelper();
    private static UnsafeNativeStructures.ADAPTER_DESC _desc;

    [SecuritySafeCritical]
    static GraphicsAdapter()
    {
      GraphicsAdapter._adapters = new ReadOnlyCollection<GraphicsAdapter>((IList<GraphicsAdapter>) new List<GraphicsAdapter>(1)
      {
        new GraphicsAdapter()
      });
      UnsafeNativeStructures.DISPLAY_MODE_INFO mode;
      uint widescreen;
      int currentDisplayMode = (int) UnsafeNativeMethods.Adapter.GetCurrentDisplayMode(GraphicsAdapter.pComHandle, out mode, out widescreen);
      GraphicsAdapter._currentDisplayMode = !Helpers.ShouldCurrentDisplaySizeReturnMangoSize ? new DisplayMode(mode.Width, mode.Height, mode.Format) : new DisplayMode(480, 800, mode.Format);
      GraphicsAdapter._isWidescreen = widescreen > 0U;
    }

    private GraphicsAdapter()
    {
    }

    public static ReadOnlyCollection<GraphicsAdapter> Adapters => GraphicsAdapter._adapters;

    public static GraphicsAdapter DefaultAdapter => GraphicsAdapter._adapters[0];

    public DisplayMode CurrentDisplayMode => GraphicsAdapter._currentDisplayMode;

    public bool IsWideScreen => GraphicsAdapter._isWidescreen;

    public DisplayModeCollection SupportedDisplayModes
    {
      [SecuritySafeCritical] get
      {
        if (GraphicsAdapter._supportedDisplayModes == null)
        {
          List<DisplayMode> displayModes = new List<DisplayMode>();
          if (Helpers.ShouldSupportedDisplayModesReturnOnlyCurrentDisplayMode)
          {
            displayModes.Add(new DisplayMode(GraphicsAdapter._currentDisplayMode.Width, GraphicsAdapter._currentDisplayMode.Height, GraphicsAdapter._currentDisplayMode.Format));
            displayModes.Add(new DisplayMode(GraphicsAdapter._currentDisplayMode.Height, GraphicsAdapter._currentDisplayMode.Width, GraphicsAdapter._currentDisplayMode.Format));
          }
          else
          {
            UnsafeNativeStructures.DISPLAY_MODE_INFO mode;
            for (uint index = 0; UnsafeNativeMethods.Adapter.GetSupportedDisplayMode(GraphicsAdapter.pComHandle, index, out mode) == 0U; ++index)
              displayModes.Add(new DisplayMode(mode.Width, mode.Height, mode.Format));
          }
          GraphicsAdapter._supportedDisplayModes = new DisplayModeCollection(displayModes);
        }
        return GraphicsAdapter._supportedDisplayModes;
      }
    }

    public string Description => "XNA";

    public string DeviceName => "\\\\.\\DISPLAY1";

    public bool IsDefaultAdapter => true;

    public IntPtr MonitorHandle => IntPtr.Zero;

    public int VendorId => GraphicsAdapter._desc.VendorId;

    public int DeviceId => GraphicsAdapter._desc.DeviceId;

    public int SubSystemId => GraphicsAdapter._desc.SubSystemId;

    public int Revision => GraphicsAdapter._desc.Revision;

    public static bool UseNullDevice { get; set; }

    public static bool UseReferenceDevice { get; set; }

    [SecuritySafeCritical]
    public bool IsProfileSupported(GraphicsProfile graphicsProfile) => UnsafeNativeMethods.Adapter.IsProfileSupported(GraphicsAdapter.pComHandle, graphicsProfile) == 0U;

    public bool QueryBackBufferFormat(
      GraphicsProfile graphicsProfile,
      SurfaceFormat format,
      DepthFormat depthFormat,
      int multiSampleCount,
      out SurfaceFormat selectedFormat,
      out DepthFormat selectedDepthFormat,
      out int selectedMultiSampleCount)
    {
      return GraphicsAdapter.QueryFormat(true, graphicsProfile, format, depthFormat, multiSampleCount, out selectedFormat, out selectedDepthFormat, out selectedMultiSampleCount);
    }

    public bool QueryRenderTargetFormat(
      GraphicsProfile graphicsProfile,
      SurfaceFormat format,
      DepthFormat depthFormat,
      int multiSampleCount,
      out SurfaceFormat selectedFormat,
      out DepthFormat selectedDepthFormat,
      out int selectedMultiSampleCount)
    {
      return GraphicsAdapter.QueryFormat(false, graphicsProfile, format, depthFormat, multiSampleCount, out selectedFormat, out selectedDepthFormat, out selectedMultiSampleCount);
    }

    [SecuritySafeCritical]
    private static bool QueryFormat(
      bool isBackBuffer,
      GraphicsProfile graphicsProfile,
      SurfaceFormat format,
      DepthFormat depthFormat,
      int multiSampleCount,
      out SurfaceFormat selectedFormat,
      out DepthFormat selectedDepthFormat,
      out int selectedMultiSampleCount)
    {
      UnsafeNativeStructures.QUERY_FORMAT_INFO info = new UnsafeNativeStructures.QUERY_FORMAT_INFO()
      {
        Format = format,
        DepthFormat = depthFormat,
        MultiSampleCount = multiSampleCount
      };
      ProfileCapabilities instance = ProfileCapabilities.GetInstance(graphicsProfile);
      if (!instance.ValidTextureFormats.Contains(info.Format))
        info.Format = SurfaceFormat.Color;
      if (info.DepthFormat != DepthFormat.None && !instance.ValidDepthFormats.Contains(info.DepthFormat))
        info.DepthFormat = DepthFormat.Depth24;
      int num = (int) UnsafeNativeMethods.Adapter.QueryFormat(GraphicsAdapter.pComHandle, isBackBuffer, graphicsProfile, ref info);
      selectedFormat = info.Format;
      selectedDepthFormat = info.DepthFormat;
      selectedMultiSampleCount = info.MultiSampleCount;
      return selectedFormat == format && selectedDepthFormat == depthFormat && selectedMultiSampleCount == multiSampleCount;
    }

    private class CleanupHelper
    {
      [SecuritySafeCritical]
      ~CleanupHelper()
      {
        if (GraphicsAdapter.pComHandle == uint.MaxValue)
          return;
        UnsafeNativeMethods.Adapter.ReleaseHandle(GraphicsAdapter.pComHandle);
      }
    }
  }
}
