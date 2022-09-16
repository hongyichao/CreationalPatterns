using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WeighLossMealPlan : IMealPlan
    {
        public string GetMealPlan()
        {
            return "here is your weight loss meal plan";
        }
    }
}
