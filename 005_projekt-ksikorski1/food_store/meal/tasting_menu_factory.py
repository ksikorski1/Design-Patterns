from  meal.meal import Meal
from  meal.meal_factory import MealFactory
from  dish.spaghetti.spaghetti_factory import SpaghettiFactory
from  dish.dumpling.dumpling_factory import DumplingFactory
from  dish.burger.burger_factory import BurgerFactory


class TastingMenuFactory(MealFactory):
    def prepare_meal(self) -> Meal:
        return Meal   ([BurgerFactory().prepare(2),
                        SpaghettiFactory().prepare(2),
                        DumplingFactory().prepare(2)])