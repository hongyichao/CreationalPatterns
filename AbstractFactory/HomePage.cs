using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HomePage
    {
        private IWorkoutPlan workoutPlan;
        private IMealPlan mealPlan;

        public void setGoal(IPlanFactory planFactory)
        {
            workoutPlan = planFactory.CreateWorkoutPlan();
            mealPlan = planFactory.CreateMealPlan();

            Console.WriteLine(workoutPlan.GetWorkoutPlan());
            Console.WriteLine(mealPlan.GetMealPlan());
        }
    }
}
