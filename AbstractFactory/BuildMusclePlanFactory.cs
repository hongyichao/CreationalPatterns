﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BuildMusclePlanFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {   
            return new BuildMuscleMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new BuildMuscleWorkout();
        }
    }
}
