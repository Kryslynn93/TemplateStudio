﻿//{[{
using Param_RootNamespace.Core.Services;
//}]}

namespace Param_RootNamespace.Core.Tests.xUnit
{
    public class Tests
    {
        //^^
        //{[{

        // TODO WTS: Remove or update this once your app is using real data and not the SampleDataService
        // This test serves only as a demonstration of testing functionality in the Core library
        [Fact]
        public void EnsureSampleDataServiceReturnsChartData()
        {
            var actual = SampleDataService.GetChartSampleData();

            Assert.NotEmpty(actual);
        }
        //}]}
    }
}
