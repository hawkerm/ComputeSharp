#if WINDOWS_UWP
using Windows.UI.Xaml.Media;
#else
using Microsoft.UI.Xaml.Media;
#endif
using Windows.UI;

namespace ComputeSharp.SwapChain.Core.Converters;

/// <summary>
/// A class with some static converters for colors.
/// </summary>
public static class ColorConverter
{
    /// <summary>
    /// Converts a <see cref="Color"/> to a <see cref="SolidColorBrush"/>.
    /// </summary>
    /// <param name="value">The input color.</param>
    /// <returns>A brush representing the input color.</returns>
    public static SolidColorBrush ConvertColorToBrush(Color value)
    {
        return new SolidColorBrush(value);
    }

    /// <summary>
    /// Converts a <see cref="Color"/> to a <see cref="float3"/> value for usage in ComputeSharp.
    /// </summary>
    /// <param name="value">The input color.</param>
    /// <returns>The normalized color vector.</returns>
    public static float3 ToFloat3(this Color value)
    {
        return new(value.R / 255f, value.G / 255f, value.B / 255f);
    }
}
