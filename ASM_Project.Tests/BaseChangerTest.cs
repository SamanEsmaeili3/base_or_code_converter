// <copyright file="BaseChangerTest.cs">Copyright ©  2024</copyright>
using System;
using ASM_Project;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASM_Project.Tests
{
    /// <summary>This class contains parameterized unit tests for BaseChanger</summary>
    [PexClass(typeof(BaseChanger))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BaseChangerTest
    {
        /// <summary>Test stub for convertToTargetBase(Int32, Int32)</summary>
        [PexMethod]
        internal string convertToTargetBaseTest(
            [PexAssumeUnderTest]BaseChanger target,
            int input,
            int targetBase
        )
        {
            string result = target.convertDecimalToTargetBase(input, targetBase);
            return result;
            // TODO: add assertions to method BaseChangerTest.convertToTargetBaseTest(BaseChanger, Int32, Int32)
        }
    }
}
