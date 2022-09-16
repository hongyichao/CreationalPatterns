using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WeightLossWorkout : IWorkoutPlan
    {
        public string GetWorkoutPlan()
        {
            return "here is your weight loss workout plan";
        }
    }
}