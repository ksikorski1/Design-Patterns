from  meal.meal import Meal
from  meal.meal_factory import MealFactory
from  dish.burger.burger_factory import BurgerFactory


class SchoolTripFactory(MealFactory):
    def prepare_meal(self) -> Meal:
        return Meal([BurgerFactory().prepare(30)])