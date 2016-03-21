using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{


    public delegate void VoidMethod();

    /// <summary>
    /// There are the type of algorithms for which test case
    /// support is given.
    /// </summary>
    public enum AlgorithemType
    {
        /// <summary>
        /// The unknown
        /// </summary>
        Unknown,

        /// <summary>
        /// The simple recursive
        /// </summary>
        SimpleRecursive,

        /// <summary>
        /// The dynamic programming bottom up
        /// </summary>
        DynamicProgrammingBottomUp,

        /// <summary>
        /// The dynamic programming top down
        /// </summary>
        DynamicProgrammingTopDown,

        /// <summary>
        /// The normal
        /// </summary>
        NormalSolution,
    }

    /// <summary>
    /// AlgorithemType extension methods
    /// </summary>
    public static class AlgorithemTypeExtensionMethods
    {
        public static VoidMethod Calculate(this AlgorithemType type, Problem problem)
        {
            VoidMethod result = null;
            switch (type)
            {
                case AlgorithemType.DynamicProgrammingBottomUp:
                    IDynamicProgrammingBottomUp DpBottomUp = problem as IDynamicProgrammingBottomUp;
                    if (DpBottomUp != null)
                    {
                        result = DpBottomUp.CalculateSolutionByBottomUp;
                    }
                    break;
                case AlgorithemType.DynamicProgrammingTopDown:
                    IDynamicProgrammingTopDown DpTopDown = problem as IDynamicProgrammingTopDown;
                    if (DpTopDown != null)
                    {
                        result = DpTopDown.CalculateSolutionByTopDown;
                    }
                    break;
                case AlgorithemType.NormalSolution:
                    INormalSolution normalSolution = problem as INormalSolution;
                    if (normalSolution != null)
                    {
                        result = normalSolution.CalculateSolution;
                    }
                    break;
                case AlgorithemType.SimpleRecursive:
                    ISimpleRecursive simpleRecursive = problem as ISimpleRecursive;
                    if (simpleRecursive != null)
                    {
                        result = simpleRecursive.CalculateSolutionBySimpleRecursive;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
