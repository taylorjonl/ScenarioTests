﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ScenarioTests.Tests
{
    public class IntegrationTests
    {
        [Internal.ScenarioFact(DisplayName = nameof(SimpleFact), FactName = "X")]
        public void SimpleFact(ScenarioContext scenarioContext)
        {
            scenarioContext.Fact("X", () =>
            {
                Assert.Equal("X", scenarioContext.TargetName);
            });
        }


        [Internal.ScenarioFact(DisplayName = nameof(SimpleTheory), FactName = "X")]
        public void SimpleTheory(ScenarioContext scenarioContext)
        {
            var invocations = 0;

            for (var repeat = 0; repeat < 5; repeat++)
            {
                scenarioContext.Theory("X", repeat, () =>
                {
                    Assert.Equal(0, invocations++);
                });
            }

            Assert.Equal(1, invocations);
        }

        [Internal.ScenarioFact(DisplayName = nameof(SimpleTheory2), FactName = "X")]
        public void SimpleTheory2(ScenarioContext scenarioContext)
        {
            var invocations = 0;

            for (var repeat = 0; repeat < 5; repeat++)
            {
                scenarioContext.Theory("X", repeat, () =>
                {
                    Assert.Equal(0, invocations++);
                });
            }

            Assert.Equal(1, invocations);
        }
    }
}
