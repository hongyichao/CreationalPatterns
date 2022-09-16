using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class BuildMuscleWorkout : IWorkoutPlan
    {
        public string GetWorkoutPlan()
        {
            return "here is your build muscle workout plan";
        }
    }
}
