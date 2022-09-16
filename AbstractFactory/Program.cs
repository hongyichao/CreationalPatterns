using AbstractFactory;

var homePage = new HomePage();
homePage.setGoal(new WeightLossPlanFactory());

homePage.setGoal(new BuildMusclePlanFactory());