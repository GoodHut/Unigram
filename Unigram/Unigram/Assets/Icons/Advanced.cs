﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile Advanced.json
//       
//       Input file:
//           Advanced.json (3812 bytes created 17:41+01:00 Dec 21 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    36 |
// |--------------------------+-------|
// | Expression animators     |     4 |
// | KeyFrame animators       |     4 |
// | Reference parameters     |     4 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     1 |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     1 |
// |--------------------------+-------|
// | Brushes                  |     1 |
// | Gradient stops           |     2 |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        u_settings
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    sealed class Advanced
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.500 seconds.
        internal const long c_durationTicks = 5000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Advanced_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Advanced_AnimatedVisual(
                        compositor
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 30d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 30d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
                { "NormalToPointerOver_Start", 0.0 },
                { "NormalToPointerOver_End", 1 },
                { "PointerOverToNormal_Start", 0 },
                { "PointerOverToNormal_End", 0 },
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class Advanced_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 2
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_0()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_1(), Geometry_2() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-19.9650002F, 0F));
                    builder.AddCubicBezier(new Vector2(-19.9650002F, 11.0459995F), new Vector2(-11.0109997F, 20F), new Vector2(0.0350000001F, 20F));
                    builder.AddCubicBezier(new Vector2(11.0810003F, 20F), new Vector2(20.0349998F, 11.0459995F), new Vector2(20.0349998F, 0F));
                    builder.AddCubicBezier(new Vector2(20.0349998F, -11.0459995F), new Vector2(11.0810003F, -20F), new Vector2(0.0350000001F, -20F));
                    builder.AddCubicBezier(new Vector2(-11.0109997F, -20F), new Vector2(-19.9650002F, -11.0459995F), new Vector2(-19.9650002F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-80.8570023F, -26.1730003F));
                    builder.AddCubicBezier(new Vector2(-77.1640015F, -37.5940018F), new Vector2(-71.0810013F, -48.0789986F), new Vector2(-63.0540009F, -56.9640007F));
                    builder.AddCubicBezier(new Vector2(-61.6969986F, -58.4669991F), new Vector2(-59.5670013F, -59.0019989F), new Vector2(-57.6599998F, -58.3199997F));
                    builder.AddLine(new Vector2(-38.4770012F, -51.4609985F));
                    builder.AddCubicBezier(new Vector2(-33.276001F, -49.6020012F), new Vector2(-27.5550003F, -52.3110008F), new Vector2(-25.6959991F, -57.512001F));
                    builder.AddCubicBezier(new Vector2(-25.5130005F, -58.0229988F), new Vector2(-25.3719997F, -58.5499992F), new Vector2(-25.2749996F, -59.0830002F));
                    builder.AddLine(new Vector2(-21.6200008F, -79.1429977F));
                    builder.AddCubicBezier(new Vector2(-21.257F, -81.1380005F), new Vector2(-19.7250004F, -82.7149963F), new Vector2(-17.7420006F, -83.137001F));
                    builder.AddCubicBezier(new Vector2(-11.9399996F, -84.3720016F), new Vector2(-5.9920001F, -85F), new Vector2(0.0350000001F, -85F));
                    builder.AddCubicBezier(new Vector2(6.05800009F, -85F), new Vector2(12.0030003F, -84.3720016F), new Vector2(17.802F, -83.1389999F));
                    builder.AddCubicBezier(new Vector2(19.7840004F, -82.7170029F), new Vector2(21.316F, -81.1409988F), new Vector2(21.6800003F, -79.1470032F));
                    builder.AddLine(new Vector2(25.3449993F, -59.0830002F));
                    builder.AddCubicBezier(new Vector2(26.3360004F, -53.6500015F), new Vector2(31.5440006F, -50.0489998F), new Vector2(36.9770012F, -51.0400009F));
                    builder.AddCubicBezier(new Vector2(37.5110016F, -51.137001F), new Vector2(38.0369987F, -51.2779999F), new Vector2(38.5470009F, -51.4599991F));
                    builder.AddLine(new Vector2(57.730999F, -58.3199997F));
                    builder.AddCubicBezier(new Vector2(59.637001F, -59.0019989F), new Vector2(61.7669983F, -58.4669991F), new Vector2(63.1240005F, -56.9640007F));
                    builder.AddCubicBezier(new Vector2(71.151001F, -48.0789986F), new Vector2(77.2350006F, -37.5940018F), new Vector2(80.9280014F, -26.1730003F));
                    builder.AddCubicBezier(new Vector2(81.5510025F, -24.2460003F), new Vector2(80.9499969F, -22.1350002F), new Vector2(79.4059982F, -20.8239994F));
                    builder.AddLine(new Vector2(63.8580017F, -7.62300014F));
                    builder.AddCubicBezier(new Vector2(59.6479988F, -4.04799986F), new Vector2(59.1329994F, 2.26300001F), new Vector2(62.7080002F, 6.47300005F));
                    builder.AddCubicBezier(new Vector2(63.0589981F, 6.88700008F), new Vector2(63.4440002F, 7.27099991F), new Vector2(63.8580017F, 7.62300014F));
                    builder.AddLine(new Vector2(79.4059982F, 20.8239994F));
                    builder.AddCubicBezier(new Vector2(80.9499969F, 22.1340008F), new Vector2(81.5510025F, 24.2469997F), new Vector2(80.9280014F, 26.1730003F));
                    builder.AddCubicBezier(new Vector2(77.2350006F, 37.5950012F), new Vector2(71.151001F, 48.0789986F), new Vector2(63.1240005F, 56.9640007F));
                    builder.AddCubicBezier(new Vector2(61.7669983F, 58.4659996F), new Vector2(59.637001F, 59.0019989F), new Vector2(57.730999F, 58.3199997F));
                    builder.AddLine(new Vector2(38.5480003F, 51.4609985F));
                    builder.AddCubicBezier(new Vector2(33.3470001F, 49.6020012F), new Vector2(27.625F, 52.3120003F), new Vector2(25.7660007F, 57.512001F));
                    builder.AddCubicBezier(new Vector2(25.5830002F, 58.0239983F), new Vector2(25.4430008F, 58.5489998F), new Vector2(25.3449993F, 59.0849991F));
                    builder.AddLine(new Vector2(21.6800003F, 79.1470032F));
                    builder.AddCubicBezier(new Vector2(21.316F, 81.1409988F), new Vector2(19.7840004F, 82.7180023F), new Vector2(17.802F, 83.1389999F));
                    builder.AddCubicBezier(new Vector2(12.0030003F, 84.3730011F), new Vector2(6.05800009F, 85F), new Vector2(0.0350000001F, 85F));
                    builder.AddCubicBezier(new Vector2(-5.9920001F, 85F), new Vector2(-11.9399996F, 84.3720016F), new Vector2(-17.7420006F, 83.137001F));
                    builder.AddCubicBezier(new Vector2(-19.7250004F, 82.7149963F), new Vector2(-21.257F, 81.137001F), new Vector2(-21.6200008F, 79.1429977F));
                    builder.AddLine(new Vector2(-25.2749996F, 59.0839996F));
                    builder.AddCubicBezier(new Vector2(-26.2660007F, 53.6500015F), new Vector2(-31.4729996F, 50.0489998F), new Vector2(-36.9059982F, 51.0400009F));
                    builder.AddCubicBezier(new Vector2(-37.4399986F, 51.137001F), new Vector2(-37.9659996F, 51.2779999F), new Vector2(-38.4770012F, 51.4609985F));
                    builder.AddLine(new Vector2(-57.6599998F, 58.3199997F));
                    builder.AddCubicBezier(new Vector2(-59.5670013F, 59.0019989F), new Vector2(-61.6969986F, 58.4659996F), new Vector2(-63.0540009F, 56.9640007F));
                    builder.AddCubicBezier(new Vector2(-71.0810013F, 48.0789986F), new Vector2(-77.1640015F, 37.5950012F), new Vector2(-80.8570023F, 26.1730003F));
                    builder.AddCubicBezier(new Vector2(-81.4800034F, 24.2469997F), new Vector2(-80.8799973F, 22.1340008F), new Vector2(-79.3359985F, 20.8239994F));
                    builder.AddLine(new Vector2(-63.7869987F, 7.62300014F));
                    builder.AddCubicBezier(new Vector2(-59.5769997F, 4.04799986F), new Vector2(-59.0620003F, -2.26300001F), new Vector2(-62.637001F, -6.47300005F));
                    builder.AddCubicBezier(new Vector2(-62.9889984F, -6.88700008F), new Vector2(-63.3730011F, -7.27099991F), new Vector2(-63.7869987F, -7.62200022F));
                    builder.AddLine(new Vector2(-79.3359985F, -20.8239994F));
                    builder.AddCubicBezier(new Vector2(-80.8799973F, -22.1350002F), new Vector2(-81.4800034F, -24.2460003F), new Vector2(-80.8570023F, -26.1730003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostLightGray_FFCCD2D6()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0xCC, 0xD2, 0xD6));
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostLightSlateGray_FF868B93()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x86, 0x8B, 0x93));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionLinearGradientBrush LinearGradientBrush()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostLightGray_FFCCD2D6());
                colorStops.Add(GradientStop_1_AlmostLightSlateGray_FF868B93());
                result.MappingMode = CompositionMappingMode.Absolute;
                StartProgressBoundAnimation(result, "StartPoint", StartPointVector2Animation(), RootProgress());
                StartProgressBoundAnimation(result, "EndPoint", EndPointVector2Animation(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // Shape tree root for layer: icon
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape()
            {
                var result = _c.CreateSpriteShape(PathGeometry());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = LinearGradientBrush();
                StartProgressBoundAnimation(result, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_60(), _rootProgress);
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation(), _rootProgress);
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_60()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, _holdThenStepEasingFunction);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, 60F, _cubicBezierEasingFunction_0);
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                // ShapeGroup: Group 2
                result.Shapes.Add(SpriteShape());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // EndPoint
            Vector2KeyFrameAnimation EndPointVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 85F), _holdThenStepEasingFunction);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(73.4820023F, 41.5349998F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 10.
                result.InsertKeyFrame(0.333333343F, new Vector2(1.12F, 1.12F), _cubicBezierEasingFunction_0);
                // Frame 20.
                result.InsertKeyFrame(0.666666687F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // StartPoint
            Vector2KeyFrameAnimation StartPointVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, -85F), HoldThenStepEasingFunction());
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(-73.4540024F, -41.8120003F), CubicBezierEasingFunction_0());
                return result;
            }

            internal Advanced_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
