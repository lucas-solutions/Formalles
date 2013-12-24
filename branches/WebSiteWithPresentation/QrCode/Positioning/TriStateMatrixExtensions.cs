﻿using System.Collections.Generic;

namespace Custom.Algebra
{
    internal static class TriStateMatrixExtensions
    {
        internal static TriStateMatrix Embed(this TriStateMatrix matrix, BitMatrix stencil, MatrixPoint location)
        {
            stencil.CopyTo(matrix, location, MatrixStatus.NoMask);
            return matrix;
        }

        internal static TriStateMatrix Embed(this TriStateMatrix matrix, BitMatrix stencil, IEnumerable<MatrixPoint> locations)
        {
            foreach (MatrixPoint location in locations)
            {
                Embed(matrix, stencil, location);
            }
            return matrix;
        }
    }
}
