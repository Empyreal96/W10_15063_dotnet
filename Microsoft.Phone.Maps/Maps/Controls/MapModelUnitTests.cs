// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapModelUnitTests
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapModelUnitTests : IMapModel
  {
    private static int idSeed;
    private FakeTileHost tileHost;
    private Dispatcher dispatcher;

    public MapModelUnitTests(MapCallbacks mapCallbacks, Dispatcher dispatcher)
    {
      this.MapCallbacks = mapCallbacks;
      this.dispatcher = dispatcher;
      this.UniqueId = Interlocked.Add(ref MapModelUnitTests.idSeed, 1);
      this.tileHost = new FakeTileHost();
      SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Brown);
      Rectangle rectangle = new Rectangle();
      rectangle.Fill = (Brush) solidColorBrush;
      this.tileHost.Content = (UIElement) rectangle;
      this.UniqueId = this.tileHost.Id;
      this.Presentation = new MapPresentationContainer((FrameworkElement) this.tileHost);
      MapReverseCallbacksThunk.MapInstanceRegistry.Insert(this.UniqueId, (IMapModel) this);
      this.IsInRegistry = true;
      this.MapOverlayModels = new List<IMapOverlayModel>();
    }

    ~MapModelUnitTests()
    {
      if (!this.IsInRegistry)
        return;
      MapReverseCallbacksThunk.MapInstanceRegistry.Remove(this.UniqueId);
      this.IsInRegistry = false;
    }

    public event EventHandler<UnitTestEventArgs> UnitTestFunctionCalled;

    public List<IMapOverlayModel> MapOverlayModels { get; private set; }

    public int UniqueId { get; internal set; }

    public Size ViewPortSize { get; set; }

    public GeoCoordinate Center { get; set; }

    public Point TransformCenter { get; set; }

    public double ZoomLevel { get; set; }

    public double Heading { get; set; }

    public double Pitch { get; set; }

    public double ActualPitch => 0.0;

    public MapCartographicMode CartographicMode { get; set; }

    public MapColorMode ColorMode { get; set; }

    public bool LandmarksEnabled { get; set; }

    public bool PedestrianFeaturesEnabled { get; set; }

    public bool WatermarkEnabled { get; set; }

    public MapPresentationContainer Presentation { get; set; }

    public MapCallbacks MapCallbacks { get; set; }

    public bool IsInRegistry { get; private set; }

    public void InvokeProcessDispatchQueue()
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name
      });
    }

    public GeoCoordinate ConvertViewportPointToGeoCoordinate(Point viewportPoint)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (viewportPoint),
              (object) viewportPoint
            }
          }
        });
      return new GeoCoordinate(0.0, 0.0);
    }

    public Point ConvertGeoCoordinateToViewportPoint(GeoCoordinate geocoordinate)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (geocoordinate),
              (object) geocoordinate
            }
          }
        });
      return new Point();
    }

    public void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (boundingRectangle),
            (object) boundingRectangle
          },
          {
            nameof (animationKind),
            (object) animationKind
          }
        }
      });
    }

    public void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMargins,
      MapAnimationKind animationKind)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (boundingRectangle),
            (object) boundingRectangle
          },
          {
            nameof (desiredMargins),
            (object) desiredMargins
          },
          {
            nameof (animationKind),
            (object) animationKind
          }
        }
      });
    }

    public void SetView(GeoCoordinate center, double zoomLevel, MapAnimationKind animationKind)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (center),
            (object) center
          },
          {
            nameof (zoomLevel),
            (object) zoomLevel
          },
          {
            nameof (animationKind),
            (object) animationKind
          }
        }
      });
    }

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      MapAnimationKind animationKind)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (center),
            (object) center
          },
          {
            nameof (zoomLevel),
            (object) zoomLevel
          },
          {
            nameof (heading),
            (object) heading
          },
          {
            nameof (animationKind),
            (object) animationKind
          }
        }
      });
    }

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      double pitch,
      MapAnimationKind animationKind)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (center),
            (object) center
          },
          {
            nameof (zoomLevel),
            (object) zoomLevel
          },
          {
            nameof (heading),
            (object) heading
          },
          {
            nameof (pitch),
            (object) pitch
          },
          {
            nameof (animationKind),
            (object) animationKind
          }
        }
      });
    }

    public void CreateSnapshotAsync()
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name
      });
    }

    public void Invalidate()
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name
      });
    }

    public void OnLoaded()
    {
    }

    public void OnUnloaded()
    {
    }

    public void AddRoute(MapRoute mapRoute)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (mapRoute),
            (object) mapRoute
          }
        }
      });
    }

    public bool RemoveRoute(MapRoute mapRoute)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (mapRoute),
              (object) mapRoute
            }
          }
        });
      return true;
    }

    public void AddMapElement(MapElement mapObject)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (mapObject),
            (object) mapObject
          }
        }
      });
    }

    public void RemoveMapElement(MapElement mapObject)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (mapObject),
            (object) mapObject
          }
        }
      });
    }

    public IList<MapElement> GetMapElementsAt(Point viewportPoint)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (viewportPoint),
              (object) viewportPoint
            }
          }
        });
      return (IList<MapElement>) new List<MapElement>();
    }

    public void AddTileSource(ITileSourceModel tileSource)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (tileSource),
            (object) tileSource
          }
        }
      });
    }

    public void RemoveTileSource(ITileSourceModel tileSource)
    {
      if (this.UnitTestFunctionCalled == null)
        return;
      this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
      {
        FunctionName = MethodBase.GetCurrentMethod().Name,
        Parameters = {
          {
            nameof (tileSource),
            (object) tileSource
          }
        }
      });
    }

    public void AddMapOverlay(IMapOverlayModel overlayAnimationModel)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (overlayAnimationModel),
              (object) overlayAnimationModel
            }
          }
        });
      this.MapOverlayModels.Add(overlayAnimationModel);
    }

    public void RemoveMapOverlay(IMapOverlayModel overlayAnimationModel)
    {
      if (this.UnitTestFunctionCalled != null)
        this.UnitTestFunctionCalled((object) this, new UnitTestEventArgs()
        {
          FunctionName = MethodBase.GetCurrentMethod().Name,
          Parameters = {
            {
              nameof (overlayAnimationModel),
              (object) overlayAnimationModel
            }
          }
        });
      this.MapOverlayModels.Remove(overlayAnimationModel);
    }
  }
}
