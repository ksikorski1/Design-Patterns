from  dish.dish_factory import DishFactory
from  dish.burger.burger import Burger
from  singleton_meta import SingletonMeta


class BurgerFactory(DishFactory, metaclass=SingletonMeta):

    def prepare(self, count: int = 1, vegetarian: bool = False) -> Burger:
        return Burger(count, vegetarian)