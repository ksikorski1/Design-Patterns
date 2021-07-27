import copy

from  price_list.price_list import PriceList


class Meal:
    def __init__(self, dishes) -> None:
        self.dishes = dishes

    def __repr__(self):
        dish_names = []
        for dish in self.dishes:
            dish_names.append(f"{dish.name} x{dish.count}")
        return f"{self.__class__.__name__} <{','.join(dish_names)}>"

    def add(self, dish) -> None:
        self.dishes.append(dish)

    def get_cost(self, PriceBuilder) -> float:  # Facade
        sum = 0
        for dish in self.dishes:
            sum += PriceList().get_price(dish, PriceBuilder).gross * dish.count
        return sum
