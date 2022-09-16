using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WeightLossPlanFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {   
            return new WeighLossMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkout();
        }
    }
}
