﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ComputeSharp.Tests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputeSharp.Tests.Attributes;

/// <summary>
/// A custom <see cref="TestMethodAttribute"/> implementation that also acts as a combinatorial <see cref="ITestDataSource"/>
/// instance. It has dedicated paths for target devices and resource types, and arbitrary inputs for the test methods.
/// </summary>
/// <remarks>
/// Use this attribute in combination with <see cref="DeviceAttribute"/>, <see cref="AllDevicesAttribute"/>,
/// <see cref="ResourceAttribute"/> or <see cref="DataAttribute"/>, not other existing MSTest attributes.
/// </remarks>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public sealed class CombinatorialTestMethodAttribute : TestMethodAttribute, ITestDataSource
{
    /// <inheritdoc/>
    IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
    {
        Device[] devices;

        if (methodInfo.GetCustomAttribute<AllDevicesAttribute>() is not null)
        {
            devices = (Device[])Enum.GetValues(typeof(Device));
        }
        else if (methodInfo.GetCustomAttributes<DeviceAttribute>().ToArray() is { Length: > 0 } values)
        {
            devices = values.Select(static value => value.Device).ToArray();
        }
        else
        {
            devices = Array.Empty<Device>();
        }

        Type[] resources = methodInfo.GetCustomAttributes<ResourceAttribute>().Select(static value => value.Type).ToArray();
        object[][] data = methodInfo.GetCustomAttributes<DataAttribute>().Select(static value => value.Data).ToArray();

        if (devices.Length > 0)
        {
            foreach (Device device in devices)
            {
                if (resources.Length > 0)
                {
                    foreach (Type type in resources)
                    {
                        if (data.Length == 0)
                        {
                            yield return new object[] { device, type };
                        }
                        else
                        {
                            foreach (object[] items in data)
                            {
                                yield return new object[] { device, type }.Concat(items).ToArray();
                            }
                        }
                    }
                }
                else
                {
                    if (data.Length == 0)
                    {
                        yield return new object[] { device };
                    }
                    else
                    {
                        foreach (object[] items in data)
                        {
                            yield return new object[] { device }.Concat(items).ToArray();
                        }
                    }
                }
            }
        }
        else if (resources.Length > 0)
        {
            foreach (Type type in resources)
            {
                if (data.Length == 0)
                {
                    yield return new object[] { type };
                }
                else
                {
                    foreach (object[] items in data)
                    {
                        yield return new object[] { type }.Concat(items).ToArray();
                    }
                }
            }
        }
        else
        {
            if (data.Length == 0)
            {
                yield return Array.Empty<object>();
            }
            else
            {
                foreach (object[] items in data)
                {
                    yield return items;
                }
            }
        }
    }

    /// <inheritdoc/>
    string ITestDataSource.GetDisplayName(MethodInfo methodInfo, object[] data)
    {
        return $"{methodInfo.Name} ({string.Join(", ", data)})";
    }
}
