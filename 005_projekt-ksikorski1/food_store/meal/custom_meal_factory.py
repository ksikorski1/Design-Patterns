from  meal.meal import Meal
from  meal.meal_factory import MealFactory


class CustomMealFactory(MealFactory):
    def prepare_meal(self, dishes) -> Meal:
        return Meal(dishes)