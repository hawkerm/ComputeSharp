﻿using System.Linq;
using Microsoft.CodeAnalysis;

namespace ComputeSharp.SourceGenerators.Diagnostics;

/// <summary>
/// Extension methods for <see cref="GeneratorExecutionContext"/>, specifically for reporting diagnostics.
/// </summary>
internal static class DiagnosticsExtensions
{
    /// <summary>
    /// Adds a new diagnostics to the current compilation.
    /// </summary>
    /// <param name="context">The <see cref="GeneratorEditContext"/> instance currently in use.</param>
    /// <param name="descriptor">The input <see cref="DiagnosticDescriptor"/> for the diagnostics to create.</param>
    /// <param name="symbol">The source <see cref="ISymbol"/> to attach the diagnostics to.</param>
    /// <param name="args">The optional arguments for the formatted message to include.</param>
    public static void ReportDiagnostic(
        this GeneratorExecutionContext context,
        DiagnosticDescriptor descriptor,
        ISymbol symbol,
        params object[] args)
    {
        context.ReportDiagnostic(Diagnostic.Create(descriptor, symbol.Locations.FirstOrDefault(), args));
    }

    /// <summary>
    /// Adds a new diagnostics to the current compilation.
    /// </summary>
    /// <param name="context">The <see cref="GeneratorEditContext"/> instance currently in use.</param>
    /// <param name="descriptor">The input <see cref="DiagnosticDescriptor"/> for the diagnostics to create.</param>
    /// <param name="node">The source <see cref="SyntaxNode"/> to attach the diagnostics to.</param>
    /// <param name="args">The optional arguments for the formatted message to include.</param>
    public static void ReportDiagnostic(
        this GeneratorExecutionContext context,
        DiagnosticDescriptor descriptor,
        SyntaxNode node,
        params object[] args)
    {
        context.ReportDiagnostic(Diagnostic.Create(descriptor, node.GetLocation(), args));
    }
}
