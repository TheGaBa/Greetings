﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.0.1+g8c3a3a945e
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile heart.json
//       
//       Input file:
//           heart.json (15611 bytes created 23:11+03:00 Apr 3 2021)
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
// | All CompositionObjects   |   122 |
// |--------------------------+-------|
// | Expression animators     |    20 |
// | KeyFrame animators       |    14 |
// | Reference parameters     |    21 |
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
// | ContainerShapes          |    12 |
// | CompositionSpriteShapes  |    10 |
// |--------------------------+-------|
// | Brushes                  |     3 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace AnimatedVisuals
{
    // Name:        Heart animation
    // Frame rate:  30 fps
    // Frame count: 50
    // Duration:    1666.7 mS
    sealed class Heart
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 1.667 seconds.
        internal const long c_durationTicks = 16666666;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Heart_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Heart_AnimatedVisual(
                        compositor
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 50d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 30d;

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
            return frameNumber / 50d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
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

        sealed class Heart_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 16666666;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorBrush _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A;
            CompositionPathGeometry _pathGeometry;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

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

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
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

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            CanvasGeometry Geometry()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(606.625F, -489.924988F));
                    builder.AddCubicBezier(new Vector2(444.846985F, -651.702026F), new Vector2(186.087997F, -657.333984F), new Vector2(17.5230007F, -506.875F));
                    builder.AddCubicBezier(new Vector2(10.0450001F, -500.199005F), new Vector2(-1.28699994F, -500.161987F), new Vector2(-8.76500034F, -506.838989F));
                    builder.AddCubicBezier(new Vector2(-170.072998F, -650.857971F), new Vector2(-414.005005F, -651.909973F), new Vector2(-576.491028F, -509.946991F));
                    builder.AddCubicBezier(new Vector2(-766.776001F, -343.696014F), new Vector2(-774.267029F, -59.1990013F), new Vector2(-595.593994F, 119.473F));
                    builder.AddLine(new Vector2(-134.330994F, 580.737F));
                    builder.AddCubicBezier(new Vector2(-57.7340012F, 657.333984F), new Vector2(66.4530029F, 657.333984F), new Vector2(143.050003F, 580.737F));
                    builder.AddLine(new Vector2(606.625F, 117.162003F));
                    builder.AddCubicBezier(new Vector2(774.267029F, -50.4799995F), new Vector2(774.267029F, -322.282013F), new Vector2(606.625F, -489.924988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Color
            ColorKeyFrameAnimation ColorAnimation_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0xFF, 0xFF, 0x49, 0x5A), _stepThenHoldEasingFunction);
                // Frame 25.
                // AlmostTomato_FFFF495A
                result.InsertKeyFrame(0.5F, Color.FromArgb(0xFF, 0xFF, 0x49, 0x5A), _holdThenStepEasingFunction);
                // Frame 35.
                // TransparentAlmostTomato_00FF495A
                result.InsertKeyFrame(0.699999988F, Color.FromArgb(0x00, 0xFF, 0x49, 0x5A), _cubicBezierEasingFunction_0);
                return result;
            }

            CompositionColorBrush AnimatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A()
            {
                var result = _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A(), _rootProgress);
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: grey 2
            // ShapeGroup: Group 1 Offset:<894.579, 919.664>
            CompositionColorBrush ColorBrush_AlmostTomato_FFFF495A()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xFF, 0x49, 0x5A));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 1 Offset:<894.579, 919.664>
            CompositionColorBrush ColorBrush_AlmostWhiteSmoke_FFF2F2F2()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xF2, 0xF2, 0xF2));
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_00()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 930.935974F);
                result.Offset = new Vector2(-358.466003F, -390.935974F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_0());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_0(), RootProgress());
                return result;
            }

            // Layer aggregator
            // Layer: grey 2
            CompositionContainerShape ContainerShape_01()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                result.Shapes.Add(ContainerShape_02());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_0(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 2
            CompositionContainerShape ContainerShape_02()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 930.935974F);
                result.Offset = new Vector2(-358.466003F, -390.935974F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_1());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_1(), _rootProgress);
                return result;
            }

            // Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_03()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                shapes.Add(ContainerShape_04());
                shapes.Add(ContainerShape_05());
                shapes.Add(ContainerShape_06());
                shapes.Add(ContainerShape_07());
                shapes.Add(ContainerShape_08());
                shapes.Add(ContainerShape_09());
                shapes.Add(ContainerShape_10());
                shapes.Add(ContainerShape_11());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_1(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_04()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = -125.5F;
                result.Scale = new Vector2(0.0211299993F, 0.0211299993F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_2());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_0(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_05()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = 147.766006F;
                result.Scale = new Vector2(0.0193000007F, 0.0193000007F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_3());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_1(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_06()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.Scale = new Vector2(0.0291799996F, 0.0291799996F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_4());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_2(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_07()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = -174.475998F;
                result.Scale = new Vector2(0.0322499983F, 0.0322499983F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_5());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_3(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_08()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = -293.278992F;
                result.Scale = new Vector2(0.0339699984F, 0.0339699984F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_6());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_4(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_09()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = -68.3840027F;
                result.Scale = new Vector2(0.0387500003F, 0.0387500003F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_7());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_5(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_10()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = -29.5160007F;
                result.Scale = new Vector2(0.0193700008F, 0.0193700008F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_8());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_6(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            CompositionContainerShape ContainerShape_11()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(898.466003F, 1557.849F);
                result.RotationAngleInDegrees = 24.6189995F;
                result.Scale = new Vector2(0.0196000002F, 0.0196000002F);
                // ShapeGroup: Group 1 Offset:<894.579, 919.664>
                result.Shapes.Add(SpriteShape_9());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_7(), _rootProgress);
                return result;
            }

            CompositionPathGeometry PathGeometry()
            {
                return _pathGeometry = _c.CreatePathGeometry(new CompositionPath(Geometry()));
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(PathGeometry(), new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), ColorBrush_AlmostWhiteSmoke_FFF2F2F2());
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 2
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), ColorBrush_AlmostTomato_FFFF495A());
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), AnimatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A());
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_3()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_4()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_5()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_6()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_7()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_8()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Path 1
            CompositionSpriteShape SpriteShape_9()
            {
                // Offset:<894.579, 919.664>
                var result = CreateSpriteShape(_pathGeometry, new Matrix3x2(1F, 0F, 0F, 1F, 894.578979F, 919.664001F), _animatedColorBrush_AlmostTomato_FFFF495A_to_TransparentAlmostTomato_00FF495A);
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                propertySet.InsertScalar("t0", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                StartProgressBoundAnimation(propertySet, "t0", t0ScalarAnimation_0_to_1(), _rootProgress);
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

            ScalarKeyFrameAnimation t0ScalarAnimation_0_to_1()
            {
                // Frame 25.
                var result = CreateScalarKeyFrameAnimation(0.50000006F, 0F, _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 30.
                result.InsertKeyFrame(0.599999964F, 1F, _cubicBezierEasingFunction_0);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                var shapes = result.Shapes;
                shapes.Add(ContainerShape_00());
                // Layer: grey 2
                shapes.Add(ContainerShape_01());
                // Layer: grey 3
                shapes.Add(ContainerShape_03());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-508.846008F, -843.257019F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-508.846008F, -843.257019F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-508.846,-843.257)+(3*Square(1-_.t0)*_.t0*Vector2(-527.513,-829.59))+(3*(1-_.t0)*Square(_.t0)*Vector2(-602.179,-774.924))+(Pow(_.t0,3)*Vector2(-620.846,-761.257))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-620.846008F, -761.257019F), _stepThenHoldEasingFunction);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-220.121994F, -839.02002F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-220.121994F, -839.02002F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-220.122,-839.02)+(3*Square(1-_.t0)*_.t0*Vector2(-212.789,-829.02))+(3*(1-_.t0)*Square(_.t0)*Vector2(-183.455,-789.02))+(Pow(_.t0,3)*Vector2(-176.122,-779.02))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-176.121994F, -779.02002F), _stepThenHoldEasingFunction);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-360.466003F, -1219.41296F), _stepThenHoldEasingFunction);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-360.466003F, -1219.41296F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-360.466003F, -1287.41296F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_3()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-348.114014F, -768.171997F), _stepThenHoldEasingFunction);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-348.114014F, -768.171997F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-348.114014F, -672.171997F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_4()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-52.1139984F, -1052.172F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-52.1139984F, -1052.172F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-52.114,-1052.172)+(3*Square(1-_.t0)*_.t0*Vector2(-41.447,-1048.172))+(3*(1-_.t0)*Square(_.t0)*Vector2(1.219,-1032.172))+(Pow(_.t0,3)*Vector2(11.886,-1028.172))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(11.8859997F, -1028.172F), _stepThenHoldEasingFunction);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_5()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-624.114014F, -992.171997F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-624.114014F, -992.171997F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-624.114,-992.172)+(3*Square(1-_.t0)*_.t0*Vector2(-645.447,-997.505))+(3*(1-_.t0)*Square(_.t0)*Vector2(-730.781,-1018.839))+(Pow(_.t0,3)*Vector2(-752.114,-1024.172))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-752.114014F, -1024.172F), _stepThenHoldEasingFunction);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_6()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-619.047974F, -1232.31702F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-619.047974F, -1232.31702F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-619.048,-1232.317)+(3*Square(1-_.t0)*_.t0*Vector2(-627.048,-1242.984))+(3*(1-_.t0)*Square(_.t0)*Vector2(-659.048,-1285.65))+(Pow(_.t0,3)*Vector2(-667.048,-1296.317))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-667.047974F, -1296.31702F), _stepThenHoldEasingFunction);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_7()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-94.0400009F, -1201.86304F), _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 25.
                result.InsertKeyFrame(0.5F, new Vector2(-94.0400009F, -1201.86304F), _holdThenStepEasingFunction);
                // Frame 30.
                result.InsertExpressionKeyFrame(0.599999964F, "Pow(1-_.t0,3)*Vector2(-94.04,-1201.863)+(3*Square(1-_.t0)*_.t0*Vector2(-82.707,-1211.863))+(3*(1-_.t0)*Square(_.t0)*Vector2(-37.373,-1251.863))+(Pow(_.t0,3)*Vector2(-26.04,-1261.863))", _stepThenHoldEasingFunction);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(-26.0400009F, -1261.86304F), _stepThenHoldEasingFunction);
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0.42306F, 0.42306F), HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.200000003F, new Vector2(0.582300007F, 0.582300007F), CubicBezierEasingFunction_0());
                // Frame 15.
                result.InsertKeyFrame(0.300000012F, new Vector2(0.42306F, 0.42306F), _cubicBezierEasingFunction_0);
                // Frame 18.
                result.InsertKeyFrame(0.360000014F, new Vector2(0F, 0F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: grey 2
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.300000012F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 20.
                result.InsertKeyFrame(0.400000006F, new Vector2(0.670000017F, 0.670000017F), _cubicBezierEasingFunction_0);
                // Frame 30.
                result.InsertKeyFrame(0.600000024F, new Vector2(0.241860002F, 0.241860002F), _cubicBezierEasingFunction_0);
                // Frame 37.
                result.InsertKeyFrame(0.74000001F, new Vector2(0.42306F, 0.42306F), _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0F), new Vector2(0.833000004F, 1F)));
                return result;
            }

            // - Layer aggregator
            // Layer: grey 2
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_0()
            {
                // Frame 15.
                var result = CreateVector2KeyFrameAnimation(0.300000012F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            // - Layer aggregator
            // Layer: grey 3
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_1()
            {
                // Frame 25.
                var result = CreateVector2KeyFrameAnimation(0.5F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 40.
                result.InsertKeyFrame(0.800000012F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                return result;
            }

            internal Heart_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(1080F, 1080F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}